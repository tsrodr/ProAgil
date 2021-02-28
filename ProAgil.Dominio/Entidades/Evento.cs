using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProAgil.Dominio.Entidades
{
    public class Evento:Entidade
    {

        public int Id { get; set; }
        [StringLength(250)]
        public string Nome { get; set; }

        [Column("Local_Id")]
        public int? LocalId { get; set; }
        public Local Local { get; set; }
        public int QtdPessoas { get; set; }

        [Column("Tema_Id")]
        public int? TemaId { get; set; }
        public Tema Tema { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (TemaId == null || TemaId == 0 )
                AdicionarCritica("Tema é obrigatorio");

            if (LocalId == null || LocalId == 0)
                AdicionarCritica("Tema é obrigatorio");

            if(QtdPessoas >= 100 && QtdPessoas <= 500)
                AdicionarCritica("Quantidade de Pessoas deve ser entre 100 a 500 pessoas");
        }
    }
}
