using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.App
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public override void PagarImposto(string tipoImposto = "IRPF")
        {
            base.PagarImposto(tipoImposto);
        }

    }
}
