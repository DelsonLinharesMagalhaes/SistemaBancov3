using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaBancov3.Controllers;
using SistemaBancov3.Models;
using SistemaBancov3.Services;




namespace SistemaBancov3.Controllers
{
    public class ClienteController : Controller
    {
        [HttpPost("ClientesPF")]
        public ActionResult PessoaFisica([FromBody] Cliente PessoaFisica)
        {
            return Ok("Ok");
        }
        [HttpPost("ClientesPJ")]
        public ActionResult PessoaJuridica(Cliente PessoaJuridica)
        {
            return Ok("Created");
        }
        [HttpGet("Clientes")]
        public ActionResult ObterClientes()
        {
            return Ok("Success");
        }
        [HttpGet("Clientes/{id}")]
        public ActionResult ObterClientes(int id)
        {
            return Ok("Success");
        }
        [HttpPut("ClientesPF/{id}")]
        public ActionResult PessoaFisica(int id)
        {
            return Ok("Success");
        }
        [HttpPut("ClientesPJ/{id}")]
        public ActionResult PessoaJuridica(int id)
        {
            return Ok("Success");
        }
        [HttpDelete("Clientes/{id}")]
        public ActionResult DeletarCliente([FromRoute] int id)
        {
            var clienteService = new ClienteService();
            Cliente clienteDeletar = clienteService.BuscarCliente(id);

            if (clienteDeletar.Saldo != 0)
            {
                return BadRequest($"Não foi possível deletar cliente. Cliente há saldo de: {clienteDeletar.Saldo}");
            }


            clienteService.DeletarCliente(clienteDeletar);
            return Ok();


        }

    }
}
