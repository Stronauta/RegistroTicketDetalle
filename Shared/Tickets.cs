using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroTicketsDetalle.Shared
{
    public class Tickets
    {
        [Key]
        public int TicketsId { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo 'Solicitado por' es requerido.")]
        [StringLength(100, ErrorMessage = "El campo 'Solicitado por' no debe tener más de 100 caracteres.")]
        public string SolicitadoPor { get; set; }

        [Required(ErrorMessage = "El campo 'Asunto' es requerido.")]
        [StringLength(200, ErrorMessage = "El campo 'Asunto' no debe tener más de 200 caracteres.")]
        public string Asunto { get; set; }

        [Required(ErrorMessage = "El campo 'Descripción' es requerido.")]
        [StringLength(1000, ErrorMessage = "El campo 'Descripción' no debe tener más de 1000 caracteres.")]
        public string Descripcion { get; set; }
        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalles { get; set; } = new List<TicketsDetalle>();
	}
}
