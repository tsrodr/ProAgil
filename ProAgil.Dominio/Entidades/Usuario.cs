using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProAgil.Dominio.Entidades
{
   public class Usuario:Entidade
    {
        public int Id { get; set; }
         [StringLength(250)]
        public string Nome { get; set; }

         [StringLength(250)]
        public string Email { get; set; }

         [StringLength(250)]
        public string UserName { get; set; }

         [StringLength(400)]
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarCritica("Favor digitar o Nome");

            if (string.IsNullOrWhiteSpace(UserName))
                AdicionarCritica("Favor digitar o UserName");

            if (string.IsNullOrWhiteSpace(Email))
                AdicionarCritica("Favor digitar o Email");

            if (string.IsNullOrWhiteSpace(Senha))
                AdicionarCritica("Favor digitar a Senha");
            else if(Senha.Length <= 5)
                AdicionarCritica("A Senha deve ter mais de 5 caracteres");

        }
    }
}
