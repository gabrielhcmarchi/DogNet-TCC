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

            if (ModelState.Keys.Contains("Cliente.Email"))
            {
                ModelState["Cliente.Email"].Errors.Clear();
                ModelState.Remove("Cliente.Email");
            }
            if (ModelState.Keys.Contains("Cliente.CPF"))
            {
                ModelState["Cliente.CPF"].Errors.Clear();
                ModelState.Remove("Cliente.CPF");
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
                if (!ClienteExists(Instituicoes.IdInstituicoes))
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

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.IdCliente == id);
        }
    }
}

