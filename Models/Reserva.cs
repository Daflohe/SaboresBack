using System;
using System.Collections.Generic;

namespace Sabores_Backend.Models
{
    public partial class Reserva
    {


        public int IdReserva { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdSede { get; set; }
        public DateTime? FechaReserva { get; set; }
        public int? CantidadPersonas { get; set; }
        public string? Evento { get; set; }
        public TimeSpan? Hora { get; set; }
        public bool? Activo { get; set; }

    }
}
