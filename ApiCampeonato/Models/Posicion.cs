using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiCampeonato.Models
{
    public partial class Posicion
    {
        public Guid PosId { get; set; }
        public Guid PosIdEquipo { get; set; }
        public int PosPuntos { get; set; }
        public int PosGolesFavor { get; set; }
        public int PosGolesContra { get; set; }

        public virtual Equipo PosIdEquipoNavigation { get; set; }
    }
}
