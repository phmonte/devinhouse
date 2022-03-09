using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome) : base(nome+ "eu sou PF")
        {
        }
        

        public override void PagarImposto(string tipoImposto = "IRPF")
        {
            base.PagarImposto(tipoImposto);
        }

    }
}
