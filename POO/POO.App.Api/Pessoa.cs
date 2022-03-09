using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; }

        public virtual void PagarImposto(string tipoImposto)
        {
            Console.WriteLine($"O Imposto informado é: {tipoImposto}");
        }

        public Pessoa()
        {
            Random random = new Random();
            Id = random.Next(1, 1000);
        }

        public Pessoa(string nome)
        {
            Random random = new Random();
            Id = random.Next(1, 1000);
            Nome = $"{nome} todos os nomes terminam com H";
        }
    }
}
