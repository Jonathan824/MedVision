using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedVision.Entities
{
    public class MotivoCita
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }

        [Column("Modelo", TypeName = "Varchar(max)")]
        public string Motivo { get; set; }

        // Clave Externa
        [ForeignKey("CodMotivoCita")]
        public int CodMotivoCita { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("IdMotivo")]
        public virtual Cita? Cita { get; set; }
    }
}
