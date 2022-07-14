using System;
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
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento() {
                EventoId = 1,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular e .NET Core",
                QtdPessoas = 250,
                Lote = "Lote 1",
                ImagemUrl = "https://miro.medium.com/max/1400/0*0RYaFUJNAQuxSagN.png"
            },
            new Evento() {
                EventoId = 2,
                Local = "Belo Horizonte",
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                Tema = "NodeJS e ReactJS",
                QtdPessoas = 300,
                Lote = "Lote 1",
                ImagemUrl = "https://miro.medium.com/max/1040/1*q5Tn2FkQ6Q99DrMVxGeHpw.png"
            },
        };
        public EventoController() { }

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