using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedVision.Entities
{
    public class Cita
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }

        [Column("Motivo", TypeName = "int")]
        public int Motivo { get; set; }

        [Column("Persona", TypeName = "int")]
        public int Persona { get; set; }

        [Column("FechaCita", TypeName = "datetime")]
        public DateTime FechaCita { get; set; }

        // Clave Externa
        [ForeignKey("CedulaPersona")]
        public int IdPersona { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("IdPersona")]
        public virtual Persona? Personas { get; set; }

        // Clave Externa
        [ForeignKey("CodMotivoCita")]
        public int CodMotivoCita { get; set; }

        // Objeto que representa la clave externa.
        [ForeignKey("IdMotivo")]
        public virtual MotivoCita? MotivoCitas { get; set; }

    }
}
