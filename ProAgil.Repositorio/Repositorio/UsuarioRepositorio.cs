using ProAgil.Dominio.Entidades;
using ProAgil.Dominio.Interfaces;
using ProAgil.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Repositorio.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(DataContext context) : base(context)
        {
        }
    }
}
