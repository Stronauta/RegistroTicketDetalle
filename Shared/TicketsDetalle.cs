using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroTicketsDetalle.Shared
{
    public class TicketsDetalle
    {
        [Key]
        public int Id { get; set; }
		[ForeignKey("TicketId")]
		public int TicketId { get; set; }
		[Required(ErrorMessage = "El campo Emisor es requerido")]
        [StringLength(100, ErrorMessage = "El campo Emisor no debe tener más de 100 caracteres.")]
        public string Emisor { get; set; }
        [Required(ErrorMessage = "El campo Mensaje es requerido")]
        [StringLength(1000, ErrorMessage = "El campo Mensaje no debe tener más de 1000 caracteres.")]
        public string Mensaje { get; set; }

	}
}

