using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api
{
    public class Mock
    {
        public static List<Veiculo> Veiculos = GetVeiculo();
        private static List<Veiculo> GetVeiculo()
        {
            var veiculos = new List<Veiculo>();

            var v1 = new Carro("Fiesta", 2000);
            var v2 = new Carro("Brasília", 1965);
            var v3 = new Carro("Gol");
            var v4 = new Carro("Parati");
            var v5 = new Carro("Fusca");
            var v6 = new Moto("CG 150");
            var v7 = new Moto("Pop 100");
            var v8 = new Moto("Today");
            var v9 = new Moto("Biz");
            var v10 = new Moto("Rd 350");

            veiculos.Add(v1);
            veiculos.Add(v2);
            veiculos.Add(v3);
            veiculos.Add(v4);
            veiculos.Add(v5);
            veiculos.Add(v6);
            veiculos.Add(v7);
            veiculos.Add(v8);
            veiculos.Add(v9);
            veiculos.Add(v10);

            return veiculos;
        }

        public static int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
