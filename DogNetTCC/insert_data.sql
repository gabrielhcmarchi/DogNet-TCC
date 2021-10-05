INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES ('55a9eefa-338c-454f-928d-d09ece6bb2aa', 'cliente', 'CLIENTE', 'bc096141-1d7c-4392-8513-c0f0243433a0');
INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES ('e81caa96-9f0a-48df-9646-f57500a175ba', 'admin', 'ADMIN', 'f6619760-eb8a-4226-88d8-d3c7f15ead2d');


INSERT INTO AspNetUsers (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount, Nome) VALUES ('d89769ae-6a6e-4ae5-9181-37e9be5fb038', 'gabriel.imvu9@gmail.com', 'GABRIEL.IMVU9@GMAIL.COM', 'gabriel.imvu9@gmail.com', 'GABRIEL.IMVU9@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEEzLQXM6LJnc4Pjc6QPU+JjcQOThjl0SQh4wyC6E5c2a6qhaVLKf22UshGLK13HHmg==', '6WTTP2GLQ5Z3EAT7E6QATJAZ6DDHZDED', 'f2f3354e-4bf6-42eb-aae9-4a54adc76d1c', '47996349410', 0, 0, NULL, 1, 0, 'Gabriel Henrique da Costa Marchi');

INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('d89769ae-6a6e-4ae5-9181-37e9be5fb038', 'e81caa96-9f0a-48df-9646-f57500a175ba');

INSERT INTO Clientes (IdCliente, Nome, DataNascimento, CPF, Telefone, Email, Situacao, Endereco_Logradouro, Endereco_Numero, Endereco_Complemento, Endereco_Bairro, Endereco_Cidade, Endereco_Estado, Endereco_CEP, Endereco_Referencia) VALUES (6, 'Gabriel Henrique da Costa Marchi', '2001-07-24 00:00:00', '12345678912', '47996349410', 'gabriel.imvu9@gmail.com', 1, 'Rua Ignez de Andrade', '748', 'Casa', 'RH 44', 'Indail', 'SC', '89087491', NULL);

INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (1, 'Coleira Preta cachorro', 'Coleirade uso para cachorros para passeio.', 44.69, 20);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (2, 'Coleira Branca cachorro', 'Coleirade uso para cachorros para passeio.', 44.69, 20);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (3, 'Ração pedigree cachorro', 'Ração pedigree tamanho 15kg.', 132.0, 29);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (4, 'Ração Affinity Cachorro', 'Ração Affinity PetCare GranPlus Menu Frango e Arroz para Cães Adultos.', 170.0, 46);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (5, 'Ração Úmida Affinity Cachorro', 'Ração Úmida Affinity GranPlus Gourmet Sachê Ovelha para Cães Adultos 100g .', 3.95, 309);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (6, 'Ração Golden Special Cachorro', 'Ração Seca PremieR Pet Golden Special Cães Adultos Frango e Carne.', 119.95, 39);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (7, 'Ração Golden Gatos', 'Ração Seca PremieR Pet Golden Gatos Adultos Carne.', 20.75, 44);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (8, 'Ração Royal Canin Gatos', 'Ração Royal Canin Sterilised para Gatos Adultos Castrados.', 25.85, 65);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (9, 'Ração Seca Nestlé  Gatos', 'Ração Seca Nestlé Purina Pro Plan Trato Urinário Frango para Gatos Adultos.', 30.19, 0);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (10, 'Ração Seca Origens gatos', 'Ração Seca Origens Premium Especial Salmão Gatos Castrados.', 25.69, 325);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (11, 'Petisco Whiskas Gatos', 'Petisco Whiskas Temptations Antibola de Pelo para Gatos Adultos.', 8.99, 452);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (12, 'Snacks Hana Healthy gatos', 'Snacks Hana Healthy Life Dental Care para Gatos Adultos.', 8.49, 245);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (13, 'Petisco Dreamies gatos', 'Petisco Dreamies Carne Para Gatos Adultos.', 5.99, 485);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (14, 'Cerveja Cãolorado Cachorro', 'Cerveja Cãolorado Sabor Carne para Cães.', 12.55, 521);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (15, 'Cerveja Dog Beer cachorro', 'Cerveja Dog Beer sem Álcool Sabor Carne para Cães.', 11.29, 0);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (16, 'Chocolate para cachorro', 'Snack Bark Sobremesa Chocolate para Cães.', 6.79, 211);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (17, 'Molho XisDog Cachorro', 'Molho XisDog Churrasco para Cães - 250 mL.', 18.45, 230);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (18, 'Osso Nó Cachorro', 'Osso Nó 3/4 Petiscão.', 8.79, 86);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (19, 'Osso Snack Cachorro', 'Osso Snack Show Suíno Natural - 1 Unidade.', 10.19, 452);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (20, 'Osso Palito Fino Cachorro', 'Osso Deliciosso Baby Palito Fino Leite para Cães Filhotes.', 17.99, 412);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (21, 'Brinquedo Duraball cachorro', 'Brinquedo Duraball Solapa para Cães.', 11.79, 165);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (22, 'Brinquedo de Vinil Bola cachorro', 'Brinquedo de Vinil LCM Bola Cravinho Amarela.', 6.75, 421);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (23, 'Brinquedo Bola Holee cachorro', 'Brinquedo Bola Holee Roller Roxo para Cães- Tam. PP.', 44.59, 382);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (24, 'Casa Step cachorro', 'Casa Step Dog Comics Rock 2.', 341.98, 0);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (25, 'Casa de Madeira cachorro', 'Casa de Madeira Triangular com Amarelo para Cães e Gatos.', 495.99, 255);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (26, 'Brinquedo Furacão cachorro', 'Brinquedo Furacão Pet Dental Bone Algodão com Nó.', 10.99, 125);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (27, 'Areia Sanitária gatos', 'Areia Sanitária Me.Au Pet Grãos Finos para Gatos.', 10.29, 474);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (28, 'Granulado Ipet gatos', 'Granulado Ipet Woods de Madeira para Gatos.', 10.78, 280);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (29, 'Bandeja Higiênica gatos', 'Bandeja Higiênica Pet Injet Luxo Patas Sanicats Azul.', 20.59, 166);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (30, 'Bandeja Sanitária gatos', 'Bandeja Sanitária Furba Azul para Gatos.', 146.67, 311);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (31, 'Fonte Bebedouro gatos', 'Fonte Bebedouro Duracats Preto para Gatos.', 169.59, 123);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (32, 'Comedouro The Pets gatos', 'Comedouro The Pets Brasil Inox Patas Relevo para Gatos.', 12.19, 344);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (33, 'Comedouro Pidan gatos', 'Comedouro Pidan Inclinado para Gatos.', 139.19, 321);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (34, 'Brinquedo American gatos', 'Brinquedo American Pets Vinil Ratinho com Apito.', 4.59, 0);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (35, 'Spray Erva do Gato', 'Spray Erva do Gato CatMyPet Catnip.', 26.19, 225);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (36, 'Brinquedo Pet gatos', 'Brinquedo Pet Games Flying Cat.', 71.67, 441);
INSERT INTO Produtos (IdProduto, Nome, Descricao, Preco, Estoque) VALUES (37, 'Sistema de Terapia gatos', 'Sistema de Terapia Real H Homeo Pet Parafelis - 30 mL.', 77.49, 321);