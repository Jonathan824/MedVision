using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedVision.Entities
{
    public class Persona
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }

        [Column("Cedula", TypeName = "int")]
        public int Cedula { get; set; }

        [Column("Nombre", TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column("Telefono", TypeName = "int")]
        public int Telefono { get; set; }

    }
}
