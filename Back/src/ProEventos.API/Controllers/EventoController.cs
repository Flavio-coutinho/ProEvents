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

        public IEnumerable <Evento> _evento = new Evento[] {
                new Evento() {
                  EventoId = 1,
                  Tema = "Angular 13 e .NET 7",
                  Local = "Luanda",
                  Lote = "Lote 1",
                  QtdPessoas = 250,
                  DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                  ImagemURL = "foto.png"

                },
                 new Evento() {
                  EventoId = 2,
                  Tema = "Angular 13 e suas Actualizações",
                  Local = "Benguela",
                  Lote = "Lote 2",
                  QtdPessoas = 350,
                  DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                  ImagemURL = "foto1.png"

                }
            };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


    }
}

