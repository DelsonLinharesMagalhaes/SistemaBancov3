using SistemaBancov3.Interfaces;
using SistemaBancov3.Controllers;
using SistemaBancov3.Models;
using SistemaBancov3.Services;

namespace SistemaBancov3.Models
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        
        public Transacao() 
        { 
        }

        public Transacao(DateTime data, double valor)
        {
            Data = data;

            Valor = valor;
        }
    }
}
