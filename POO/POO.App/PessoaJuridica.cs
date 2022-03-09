using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.App
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public override void PagarImposto(string tipoImposto = "ICMS")
        {
            base.PagarImposto(tipoImposto);
        }
    }
}
