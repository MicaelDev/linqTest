using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //listar os gêneros rock
            var generos = new List<Genero>
            {
                new Genero { Id = 1, Nome = "Rock"},
                new Genero { Id = 2, Nome =  "Reggae"},
                new Genero { Id = 3, Nome =  "Rock Progressivo"},
                new Genero { Id = 4, Nome =  "Punk"},
                new Genero { Id = 5, Nome =  "Clássica"}
            };

            //listar músicas
            var musicas = new List<Musica>
            {
                new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
                new Musica { Id = 2, Nome = "I Shoot The Sheriff", GeneroId = 2},
                new Musica { Id = 3, Nome = "Danúbio Azul", GeneroId = 5},
            };

            //Query Linq
            var musicQuery = from m in musicas
                             join g in generos on m.GeneroId equals g.Id
                             select new { m, g };

            foreach (var musica in musicQuery)
            {
                Console.WriteLine("{0}\t{1}\t{2}", musica.m.Id, musica.m.Nome, musica.m.GeneroId);
            }

            Console.ReadLine();
        }
    }
}