using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiCampeonato.Models
{
    public partial class EquipoResultado
    {
        public Guid EreId { get; set; }
        public Guid EreIdEquipo { get; set; }
        public Guid EreIdResultado { get; set; }

        public virtual Equipo EreIdEquipoNavigation { get; set; }
        public virtual Resultado EreIdResultadoNavigation { get; set; }
    }
}
