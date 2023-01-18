using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Clinica")]
    public class Clinica
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar")] 
        [StringLength(50)] 
        [Required]
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public List<Habitacion> Habitaciones { get;set; }
        public List<Enfermero> Enfermeros { get;set; }
        public List<Medico> Medicos { get;set; }
        public List<Paciente> Pacientes { get;set; }

        public Director Director { get; set; }
        [ForeignKey(nameof(Director))]
        public int DirectorId { get; set; }
    }
}
