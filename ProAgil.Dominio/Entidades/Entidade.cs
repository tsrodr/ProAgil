using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProAgil.Dominio.Entidades
{
    public abstract class Entidade
    {

        private List<string> _mensagemValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get {return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        public abstract void Validate();

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        protected void LimparMensagemValidacao()
        {
           MensagemValidacao.Clear();
        }

        protected bool EhValidado
        {
            get { return !MensagemValidacao.Any(); }
        }  
    }
}
