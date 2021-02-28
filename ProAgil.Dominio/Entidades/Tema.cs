using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.Dominio.Entidades
{
    public class Tema : Entidade
    {
        public int Id { get; set; }
        
        [StringLength(250)]
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public override void Validate()
        {
            List<string> temasProibidos = new List<string>()
            {
                "Xuxa", "Turma da Monica"
            };

            if (temasProibidos.Contains(Nome))
                AdicionarCritica("Tema não permitido para o Evento");
        }
    }
}