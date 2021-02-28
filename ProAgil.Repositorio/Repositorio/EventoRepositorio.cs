using Microsoft.EntityFrameworkCore;
using ProAgil.Dominio.Entidades;
using ProAgil.Dominio.Interfaces;
using ProAgil.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProAgil.Repositorio.Repositorio
{
    public class EventoRepositorio : BaseRepositorio<Evento>, IEventoRepositorio
    {
        public EventoRepositorio(DataContext context) : base(context)
        {
        }

        public new IEnumerable<Evento> ToList()
        {
            return Context.Eventos.Include(i=>i.Tema)
                .Include(i => i.Local).ToList();
        }
    }
}
