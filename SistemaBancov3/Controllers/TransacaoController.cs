using Microsoft.AspNetCore.Mvc;
using SistemaBancov3.Models;
using SistemaBancov3.Controllers;
using SistemaBancov3.Services;
using SistemaBancov3.Interfaces;

namespace SistemaBancov3.Controllers
{
    public class TransacaoController : Controller
    {
        public TransacaoController()
        {
            Transacao transacaoModel = new Transacao();
        }

        [HttpPost("Transacao/{idCliente}")]
        public ActionResult PostTransacao(int idCliente)
        {
            return Ok();
        }

        [HttpGet("Transacao/{idCliente}")]
        public ActionResult ListTransasao(int idCliente)
        {
            return Ok();
        }
    }
}
