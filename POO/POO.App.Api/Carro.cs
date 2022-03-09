using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api
{
    public class Carro : Veiculo
    {

        public Carro(string nome) : base(nome)
        {
            
        }

        public Carro(string nome, int ano) : base(nome)
        {
            Ano = ano;
        }

        public override void Acelerar(int velocidade)
        {
            base.Acelerar(velocidade);
        }
    }
}
