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
            var listaVeiculos = Mock.Veiculos;
            return listaVeiculos;
        }

        [HttpPost("acelerar/{id}")]
        public List<Veiculo> Acelerar(int id)
        {
            var listaVeiculos = Mock.Veiculos;
            foreach (var item in listaVeiculos)
            {
                if(item.Id == id)
                {
                    item.Acelerar(1);
                }
            }
            Mock.Veiculos = listaVeiculos;
            return listaVeiculos;
        }
    }
}
