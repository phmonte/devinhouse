using System;

namespace POO.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var pf = new PessoaFisica();
            pf.PagarImposto();

            var pj = new PessoaJuridica();
            pj.PagarImposto();
        }
    }
}
