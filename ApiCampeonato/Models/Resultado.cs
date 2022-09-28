using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiCampeonato.Models
{
    public partial class Resultado
    {
        public Resultado()
        {
            EquipoResultado = new HashSet<EquipoResultado>();
        }

        public Guid EncId { get; set; }
        public Guid EncIdEquipoRival { get; set; }
        public int EncGolesFavor { get; set; }
        public int EncGolesContra { get; set; }
        public int EncPuntos { get; set; }

        public virtual Equipo EncIdEquipoRivalNavigation { get; set; }
        public virtual ICollection<EquipoResultado> EquipoResultado { get; set; }
    }
}
