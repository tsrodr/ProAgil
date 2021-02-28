using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.Dominio.Entidades
{
    public class Local : Entidade
    {
        public int Id { get; set; }

         [StringLength(250)]
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public override void Validate()
        {

            List<string> locaisProibidos = new List<string>()
            {
                "Shopping", "Boate"
            };

            if (locaisProibidos.Contains(Nome))
                AdicionarCritica("Local não permitido para o Evento");
        }
    }
}