using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public List<Pessoa> Get()
        {
            var listaPessoa = new List<Pessoa>();

            var pf1 = new PessoaFisica("Nome1");
            var pf2 = new PessoaFisica("Nome2");
            
            var p2 = new PessoaJuridica("Nome PJ");

            listaPessoa.Add(pf1);
            listaPessoa.Add(pf2);
            listaPessoa.Add(p2);

            return listaPessoa;
        }
    }
}
