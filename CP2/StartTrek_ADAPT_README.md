Start Trek adaptation notes:

Files added:
- FIAP.CP2.Model/ProfissaoModel.cs
- FIAP.CP2.Model/UsuarioModel.cs
- FIAP.CP2.Model/JogoEducativoModel.cs
- Fiap.CP2.Business/BibliotecaJogos_Extended.cs
- FIAP.CP2.UI/Controllers/ProfissoesController.cs
- Views/Profissoes (Index, Details, Create, Edit, Delete)

Notes:
- The project was updated with in-memory seed data. To persist properly, add EF Core DbContext,
  configure services in Startup/Program and create migrations with the dotnet-ef tools.
- To run: open solution in Visual Studio. The controllers use seed data from BibliotecaJogos_Extended.
