using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Model
{
    [Table("Candidato")]
    public class Candidato
    {
        public int Id_candidato { get; set; }
        public string Nome { get; set; }
        public string Vice { get; set; }
        public string Codigo { get; set; }
        public string Legenda { get; set; }
        public DateTime Data_registro { get; set; }
        //public IEnumerable<Voto> Votos { get; set; }
    }
}
