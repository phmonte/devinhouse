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

            var listaVeiculos = Mock.GetVeiculo();

            return listaVeiculos;
        }

        [HttpPost("{ano}")]
        public List<Veiculo> Post(int ano)
        {
            var anoParametro = new List<Veiculo>();
            var listaVeiculos = Mock.GetVeiculo();

            foreach (var item in listaVeiculos)
            {
                if(item.Ano == ano)
                {
                    anoParametro.Add(item);
                }
            }
            return anoParametro;
        }
    }
}
