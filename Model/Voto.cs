using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Model
{
    [Table("Voto")]
    public class Voto
    {
        public Guid Id_voto { get; set; }
        public int Id_candidato { get; set; }
        public DateTime Data_registro { get; set; }
        //public Candidato Candidato { get; set; }

    }
}
