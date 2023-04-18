using SistemaBancov3.Models;
using SistemaBancov3.Controllers;
using SistemaBancov3.Interfaces;
using SistemaBancov3.Services;

namespace SistemaBancov3.Interfaces
{
    public interface IClienteService
    {
        void CriarConta(Cliente cliente);
        List<PessoaFisica> ExibirClientesPF();
        List<PessoaJuridica> ExibirClientesPJ();
        Cliente BuscarCliente(int id);
        Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id);
        Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id);
        void DeletarCliente(Cliente clienteDeletar);
        void AdicionarTransacao(Transacao transacao, int idCliente);
        List<Transacao> ListarTransacao(int idCliente);
    }
}
