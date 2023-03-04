﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "BH",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
                },
                new Evento() {
                EventoId = 2,
                Tema = "Angular 11 e .NET 5",
                Local = "SP",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
                }
            };

        public EventoController()
        {
          
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByid(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
    }
}
