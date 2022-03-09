using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api.Controllers
{
    [Route("api/veiculo")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpGet]
        public List<Veiculo> Get(){

            var listaVeiculo = new List<Veiculo>();
          
            Carro fiesta = new Carro("Fiesta", 97);
            Moto honda = new Moto("CG 150");

            honda.Acelerar(1);
            fiesta.Acelerar(2);

            listaVeiculo.Add(fiesta);
            listaVeiculo.Add(honda);

            return listaVeiculo;
        }
    }
}
