using App.ViewModels;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{

    [Route("Eventos")]
    public class EventosController : Controller
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly IEventoRepository _eventoRepository;
        private readonly IEnderecoEventoRepository _enderecoEventoRepository;
        private readonly IMapper _mapper;


        public EventosController(IClienteRepository clienteRepository,
                                 IEventoRepository eventoRepository,
                                 IEnderecoEventoRepository enderecoEventoRepository,
                                 IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _eventoRepository = eventoRepository;
            _enderecoEventoRepository = enderecoEventoRepository;
            _mapper = mapper;
        }


        //###################  INDEX GET  ###################################

        [Route("")]
        [Route("Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<EventoViewModel>>(await _eventoRepository.ObterTodosEventosECliente()));
        }


        //###################  CREATE GET  ###################################

        [Route("Create")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var eventoCreate = new EventoViewModel();

            var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());

            if (!meusClientes.Any())
                return RedirectToAction("DontHaveClientes", "Eventos");



            eventoCreate.Clientes = meusClientes;

            return View(eventoCreate);
        }



        //###################  CREATE POST  ###################################


        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventoViewModel eventoViewModel)
        {


            var dataEvento = Convert.ToDateTime(eventoViewModel.DataEvento);

            //Se o modelo for válido
            if (!ModelState.IsValid)
            {
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }


            //Se já existir um evento na mesma data
            if (_eventoRepository.Buscar(x => x.DataEvento.Date == Convert.ToDateTime(eventoViewModel.DataEvento).Date).Result.Any())
            {
                ModelState.AddModelError(nameof(EventoViewModel.DataEvento), "Já existe um evento nesta data");
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }


            //Checar se o novo cliente informado realmente existe no banco, não importa se ele é ativo ou não pois na edição pode haver um cliente q não está ativo mas ainda sim está em um evento.
            if (!_clienteRepository.Buscar(x => x.Id == eventoViewModel.ClienteId).Result.Any())
            {

                // Se não existir e nem estiver ativo...
                ModelState.AddModelError(nameof(EventoViewModel.ClienteId), "Esse Cliente não existe ou foi desativado");
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }


            if (dataEvento < DateTime.Now)
            {
                ModelState.AddModelError(nameof(EventoViewModel.DataEvento), "O evento não pode acontecer no passado");
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }

            eventoViewModel.DataCadastro = DateTime.Now;

            var evento = _mapper.Map<Evento>(eventoViewModel);

            //Converter o valor para decimal, pois ele está vindo como string.
            var valor = decimal.Parse(eventoViewModel.Valor, new CultureInfo("pt-BR"));

            evento.Valor = valor;

            await _eventoRepository.Adicionar(evento);

            return RedirectToAction("Index");

        }



        //###################  DETAILS GET  ###################################

        [Route("Details/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var evento = await _eventoRepository.ObterEventoEndereco(id);

            if (evento == null)
                return RedirectToAction("NotFound");

            var refCliente = _mapper.Map<ClienteViewModel>(await _clienteRepository.ObterPorId(evento.ClienteId));
            var eventoViewModel = _mapper.Map<EventoViewModel>(evento);

            eventoViewModel.Cliente = refCliente;

            return View(eventoViewModel);
        }



        //###################  EDIT GET  ###################################


        [Route("Edit/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var evento = await _eventoRepository.ObterEventoEndereco(id);

            if (evento == null)
                return RedirectToAction("NotFound");

            //Erro se não encontrar nenhum, informe que não é possível editar.
            var listaClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterTodos());

            // Erro (cliente do evento não existe), mostre um not found
            var refCliente = _mapper.Map<ClienteViewModel>(await _clienteRepository.ObterPorId(evento.ClienteId));

            var eventoViewModel = _mapper.Map<EventoViewModel>(evento);

            eventoViewModel.Cliente = refCliente;
            eventoViewModel.Clientes = listaClientes;

            return View(eventoViewModel);
        }


        //###################  EDIT POST  ###################################

        [Route("Edit/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, EventoViewModel eventoViewModel)
        {
            var eventoBanco = await _eventoRepository.ObterEventoEndereco(id);
            var dataEvento = Convert.ToDateTime(eventoViewModel.DataEvento);

            if (eventoBanco == null || eventoBanco.Id != eventoViewModel.Id) return RedirectToAction("NotFound");

            if (!ModelState.IsValid)
                return View(eventoViewModel);

            //Checar se tem um evento na data editada
            if (_eventoRepository.Buscar(c => c.DataEvento.Date == Convert.ToDateTime(eventoViewModel.DataEvento).Date && c.Id != eventoViewModel.Id).Result.Any())
            {
                ModelState.AddModelError(nameof(EventoViewModel.DataEvento), "Já existe um evento nesta data, impossível alterar");
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }

            if (dataEvento < DateTime.Now)
            {
                ModelState.AddModelError(nameof(EventoViewModel.DataEvento), "O novo valor só pode ser uma data futura");
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }

            //Checar se o novo cliente informado realmente existe no banco, não importa se ele é ativo ou não pois na edição pode haver um cliente q não está ativo mas ainda sim está em um evento.
            if (!_clienteRepository.Buscar(x => x.Id == eventoViewModel.ClienteId).Result.Any())
            {
                // Se não existir e nem estiver ativo...
                ModelState.AddModelError(nameof(EventoViewModel.ClienteId), "Esse Cliente não existe ou foi desativado");
                var meusClientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.ObterClientesAtivos());
                eventoViewModel.Clientes = meusClientes;
                return View(eventoViewModel);
            }



            #region Atualização Evento DB

            //Infos
            eventoBanco.ClienteId = eventoViewModel.ClienteId;
            eventoBanco.Titulo = eventoViewModel.Titulo;
            eventoBanco.Descricao = eventoViewModel.Descricao;
            eventoBanco.Convidados = eventoViewModel.Convidados;
            eventoBanco.Valor = decimal.Parse(eventoViewModel.Valor, new CultureInfo("pt-BR"));
            eventoBanco.DataEvento = Convert.ToDateTime(eventoViewModel.DataEvento);
            //Endereço
            eventoBanco.Endereco.Logradouro = eventoViewModel.Endereco.Logradouro;
            eventoBanco.Endereco.Numero = eventoViewModel.Endereco.Numero;
            eventoBanco.Endereco.Complemento = eventoViewModel.Endereco.Complemento;
            eventoBanco.Endereco.Cep = eventoViewModel.Endereco.Cep;
            eventoBanco.Endereco.Bairro = eventoViewModel.Endereco.Bairro;
            eventoBanco.Endereco.Cidade = eventoViewModel.Endereco.Cidade;
            eventoBanco.Endereco.Estado = eventoViewModel.Endereco.Estado;

            #endregion

            await _eventoRepository.Atualizar(eventoBanco);


            //Evento editado com sucesso!
            return RedirectToAction("Index");

        }


        //###################  DELETE GET  ###################################

        [Route("Delete/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var evento = await _eventoRepository.ObterEventoEnderecoCliente(id);

            if (evento == null)
                return RedirectToAction("NotFound");

            var eventoViewModel = _mapper.Map<EventoViewModel>(evento);

            return View(eventoViewModel);
        }


        //###################  DELETE POST  ###################################

        [HttpPost("Delete/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (!VerifyEventExistence(id))
                return RedirectToAction("NotFound");


            var endereco = await _enderecoEventoRepository.ObterEnderecoPorEvento(id);

            await _enderecoEventoRepository.Remover(endereco.Id);
            await _eventoRepository.Remover(id);

            return RedirectToAction("Index");
        }


        private bool VerifyEventExistence(Guid id)
        {

            if (!_eventoRepository.Buscar(c => c.Id == id).Result.Any())
                return false;

            return true;
        }



        //###################  SE NÃO ENCONTRAR O EVENTO  ###################################

        [Route("NotFound")]
        [HttpGet]
        public IActionResult NotFound()
        {
            return View();
        }


        //################### SE NÃO TIVER CLIENTES AINDA  ###################################

        [Route("DontHaveClientes")]
        [HttpGet]
        public IActionResult DontHaveClientes()
        {
            return View();
        }


    }
}
