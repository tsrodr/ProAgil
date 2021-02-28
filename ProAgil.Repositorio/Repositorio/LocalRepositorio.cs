using ProAgil.Dominio.Entidades;
using ProAgil.Dominio.Interfaces;
using ProAgil.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Repositorio.Repositorio
{
    public class LoalRepositorio : BaseRepositorio<Local>, ILocalRepositorio
    {
        public LoalRepositorio(DataContext context) : base(context)
        {
        }
    }
}
