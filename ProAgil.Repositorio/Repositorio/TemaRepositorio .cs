using ProAgil.Dominio.Entidades;
using ProAgil.Dominio.Interfaces;
using ProAgil.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Repositorio.Repositorio
{
    public class TemaRepositorio : BaseRepositorio<Tema>, ITemaRepositorio
    {
        public TemaRepositorio(DataContext context) : base(context)
        {
        }
    }
}
