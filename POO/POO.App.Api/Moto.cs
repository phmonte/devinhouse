using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api
{
    public class Moto : Veiculo
    {
        public Moto(string nome) : base(nome)
        {
        }

        public override void Acelerar(int velocidade)
        {
            base.Acelerar(velocidade);
        }
    }
}
