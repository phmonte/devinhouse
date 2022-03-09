using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.App
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual void PagarImposto(string tipoImposto)
        {
            Console.WriteLine($"O Imposto informado é: {tipoImposto}");
        }

        public Pessoa()
        {
            Random random = new Random();
            Id = random.Next(1, 1000);
        }

        //public Pessoa(string nome)
        //{
        //    Random random = new Random();
        //    Id = random.Next(1, 1000);

        //    Nome = nome;
        //}

        //public Pessoa(int id, string nome)
        //{
        //    Id = id;
        //    Nome = nome;
        //}
    }
}
