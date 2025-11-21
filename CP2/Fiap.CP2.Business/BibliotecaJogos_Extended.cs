using System.Collections.Generic;
using FIAP.CP2.Model;

namespace Fiap.CP2.Business
{
    public static class BibliotecaJogos_Extended
    {
        public static List<ProfissaoModel> GetProfissoesSeed()
        {
            return new List<ProfissaoModel>
            {
                new ProfissaoModel { Id = "P1", Nome = "Datilógrafo", Status = "Extinta", Descricao = "Profissional responsável por datilografar textos em máquinas de escrever.", TecnologiasRelacionadas = "Máquinas de escrever, mecanização" },
                new ProfissaoModel { Id = "P2", Nome = "Operador de Telex", Status = "Extinta", Descricao = "Operava sistemas de transmissão telegráfica Telex.", TecnologiasRelacionadas = "Telex, Telecomunicações" },
                new ProfissaoModel { Id = "P3", Nome = "Analista de Dados", Status = "Atual", Descricao = "Analisa e interpreta dados para gerar insights.", TecnologiasRelacionadas = "SQL, Python, BI" },
                new ProfissaoModel { Id = "P4", Nome = "Engenheiro de Robótica Assistiva", Status = "Futura", Descricao = "Projeta robôs de assistência pessoal e saúde.", TecnologiasRelacionadas = "Robótica, IA, IoT" }
            };
        }

        public static List<JogoEducativoModel> GetJogosSeed()
        {
            return new List<JogoEducativoModel>
            {
                new JogoEducativoModel { Id = "J1", Titulo = "Quiz: Profissões do Passado", Descricao = "Teste seus conhecimentos sobre profissões extintas.", TemaProfissaoId = "P1" },
                new JogoEducativoModel { Id = "J2", Titulo = "Desafio: Tecnologias Emergentes", Descricao = "Associa tecnologias a profissões futuras.", TemaProfissaoId = "P4" }
            };
        }
    }
}
