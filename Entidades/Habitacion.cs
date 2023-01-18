using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Habitacion")]
    public class Habitacion
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public bool Estado { get; set; }

        public Clinica Clinica { get; set; }

        [ForeignKey(nameof(Clinica))]
        public int ClinidaId { get; set; }
    }
}
