using App.ViewModels;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{

    [Route("")]
    [Route("Clientes")]
    public class ClientesController : Controller
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly IEventoRepository _eventoRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;


        public ClientesController(IClienteRepository clienteRepository,
                                  IEventoRepository eventoRepository,
                                  IEnderecoRepository enderecoRepository,
                                    IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _eventoRepository = eventoRepository;
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

        [Route("Edit/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var cliente = await _clienteRepository.ObterClienteEndereco(id);

            if (cliente == null)
                RedirectToAction("NotFound");

            return View(_mapper.Map<ClienteViewModel>(cliente));
        }

        [Route("Edit/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, ClienteViewModel clienteViewModel)
        {
            var clienteBanco = await _clienteRepository.ObterClienteEndereco(id);

            if (clienteBanco == null || clienteBanco.Id != clienteViewModel.Id) RedirectToAction("NotFound");


            if (_clienteRepository.Buscar(c => c.Documento == clienteViewModel.Documento && c.Id != clienteViewModel.Id).Result.Any())
            {
                ModelState.AddModelError(nameof(ClienteViewModel.Documento), "Este documento já é cadastrado");
                return View(clienteViewModel);
            }


            if (!ModelState.IsValid)
            {

                clienteViewModel.NomeCompleto = clienteBanco.NomeCompleto;
                clienteViewModel.Id = clienteBanco.Id;
                return View(clienteViewModel);

            }

            #region Atualização Cliente DB
            //Informações Pessoais
            clienteBanco.NomeCompleto = clienteViewModel.NomeCompleto;
            clienteBanco.Tipo = clienteViewModel.Tipo;
            clienteBanco.Documento = clienteViewModel.Documento;
            clienteBanco.Telefone = clienteViewModel.Telefone;
            clienteBanco.Genero = clienteViewModel.Genero;
            clienteBanco.DataNascimento = clienteViewModel.DataNascimento;
            clienteBanco.Ativo = clienteViewModel.Ativo;
            //Endereço
            clienteBanco.Endereco.Logradouro = clienteViewModel.Endereco.Logradouro;
            clienteBanco.Endereco.Numero = clienteViewModel.Endereco.Numero;
            clienteBanco.Endereco.Complemento = clienteViewModel.Endereco.Complemento;
            clienteBanco.Endereco.Cep = clienteViewModel.Endereco.Cep;
            clienteBanco.Endereco.Bairro = clienteViewModel.Endereco.Bairro;
            clienteBanco.Endereco.Cidade = clienteViewModel.Endereco.Cidade;
            clienteBanco.Endereco.Estado = clienteViewModel.Endereco.Estado;
            #endregion

            await _clienteRepository.Atualizar(clienteBanco);

            return RedirectToAction("Index", "Clientes");

        }

        [Route("Details/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var cliente = await _clienteRepository.ObterClienteCompleto(id);

            if (cliente == null)
                RedirectToAction("NotFound");

            return View(_mapper.Map<ClienteViewModel>(cliente));
        }

        [Route("")]
        [Route("Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesEventos()));
        }

        [Route("Criar")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Criar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClienteViewModel clienteViewModel)
        {

            ModelState.Remove("Ativo");
            ModelState.Remove("DataCadastro");

            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }


            if (_clienteRepository.Buscar(c => c.Documento == clienteViewModel.Documento).Result.Any())
            {
                ModelState.AddModelError(nameof(ClienteViewModel.Documento), "Este documento já é cadastrado");
                return View(clienteViewModel);
            }


            clienteViewModel.Ativo = true;
            clienteViewModel.DataCadastro = DateTime.Now;

            var novoCliente = _mapper.Map<Cliente>(clienteViewModel);

            await _clienteRepository.Adicionar(novoCliente);

            return RedirectToAction("Index");

        }

        [Route("NoAuthorizedDelete")]
        public ActionResult NoAuthorizedDelete()
        {
            return View();
        }

        [Route("NotFound")]
        public ActionResult NotFound()
        {
            return View();
        }

        [Route("Delete/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cliente = await _clienteRepository.ObterClienteCompleto(id);

            if (cliente == null)
                RedirectToAction("NotFound");

            //Se o cliente tiver eventos
            if (cliente.Eventos.Any())
                return RedirectToAction("NoAuthorizedDelete");


            return View(_mapper.Map<ClienteViewModel>(cliente));
        }

        [HttpPost("Delete/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {


            if (!VerifyClienteExistence(id))
                RedirectToAction("NotFound");

            if (!VerifyEventsExistence(id))
                return RedirectToAction("NoAuthorizedDelete");


            var endereco = await _enderecoRepository.ObterEnderecoPorCliente(id);

            await _enderecoRepository.Remover(endereco.Id);
            await _clienteRepository.Remover(id);

            return RedirectToAction("Index");
        }

        private bool VerifyClienteExistence(Guid id)
        {

            if (!_clienteRepository.Buscar(c => c.Id == id).Result.Any())
                return false;

            return true;
        }

        private bool VerifyEventsExistence(Guid id)
        {

            var events = _eventoRepository.ObterEventosDoCliente(id);

            if (events == null)
                return false;

            return true;
        }


    }
}
