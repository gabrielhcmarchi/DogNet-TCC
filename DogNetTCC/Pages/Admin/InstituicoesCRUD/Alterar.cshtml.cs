using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogNet.Data;
using DogNet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DogNet.Pages.Admin.InstuicoesCRUD
{
    [Authorize(Policy = "isAdmin")]
    public class AlterarModel : PageModel
    {
        private readonly DogNetMvcContext _context;

        public AlterarModel(DogNetMvcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Instituicoes Instituicoes { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instituicoes = await _context.Instituicoes.FirstOrDefaultAsync(m => m.IdInstituicoes == id);

            if (Instituicoes == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //para garantir que o CPF e o E-mail não serão atualizados
            var instituicoes = await _context.Instituicoes.Select(m => new { m.IdInstituicoes, m.Email, m.CNPJ }).FirstOrDefaultAsync(m => m.IdInstituicoes == Instituicoes.IdInstituicoes);
            Instituicoes.Email = instituicoes.Email;
            Instituicoes.Pix = instituicoes.CNPJ;

            //ModelState.ClearValidationState("Cliente.Email");
            //ModelState.ClearValidationState("Cliente.CPF");

            if (ModelState.Keys.Contains(" Institucoes.Email"))
            {
                ModelState["Institucoes.Email"].Errors.Clear();
                ModelState.Remove("Institucoes.Email");
            }
            if (ModelState.Keys.Contains("Institucoes.CPF"))
            {
                ModelState["Institucoes.CPF"].Errors.Clear();
                ModelState.Remove("Institucoes.CPF");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Instituicoes).State = EntityState.Modified;
            _context.Attach(Instituicoes.Endereco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstitucoesExists(Instituicoes.IdInstituicoes))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Listar");
        }

        private bool InstitucoesExists(int id)
        {
            return _context.Clientes.Any(e => e.IdCliente == id);
        }
    }
}

