using System;
using System.Collections.Generic;
using System.Linq;
using FIAP.CP2.Model;

namespace FIAP.CP2.Business
{
    public class BibliotecaJogos
    {
        private List<JogoEducativo> jogos;

        public BibliotecaJogos()
        {
            jogos = new List<JogoEducativo>
            {
                new JogoEducativo("Human Resource Machine", "Tomorrow Corporation", "Lógica / Programação Visual"),
                new JogoEducativo("TIS-100", "Zachtronics", "Programação Assembly"),
                new JogoEducativo("SHENZHEN I/O", "Zachtronics", "Programação de Circuitos"),
                new JogoEducativo("7 Billion Humans", "Tomorrow Corporation", "Programação em grupo"),
                new JogoEducativo("while True: learn()", "Luden.io", "Aprendizado de Máquina"),
                new JogoEducativo("EXAPUNKS", "Zachtronics", "Linguagem EXA"),
                new JogoEducativo("Hacknet", "Team Fractal Alligator", "Simulação de Hacking"),
                new JogoEducativo("Robo Instructus", "Big AB Games", "Lógica e Automação em Pseudo-Código")
            };
        }

        public void ListarJogos()
        {
            Console.WriteLine("\n Lista de Jogos Educativos na Steam:\n");

            foreach (var jogo in jogos)
            {
                Console.WriteLine($" Jogos: {jogo.Nome}");
                Console.WriteLine($"   Desenvolvedor: {jogo.Desenvolvedor}");
                Console.WriteLine($"   Tema: {jogo.Linguagem}\n");
            }
        }

        public List<JogoEducativo> ListarTodos()
        {
            return jogos;
        }

        public void BuscarPorLinguagem(string termo)
        {
            var resultados = jogos
                .Where(j => j.Linguagem.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine($"\nNenhum jogo encontrado para a linguagem: {termo}");
                return;
            }

            Console.WriteLine($"\n🔎 Resultados para \"{termo}\":\n");

            foreach (var jogo in resultados)
            {
                Console.WriteLine($"🎮 {jogo.Nome}");
                Console.WriteLine($"   Desenvolvedor: {jogo.Desenvolvedor}");
                Console.WriteLine($"   Tema: {jogo.Linguagem}\n");
            }

        }
    }
}
