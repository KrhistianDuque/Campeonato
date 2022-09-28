using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiCampeonato.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            EquipoResultado = new HashSet<EquipoResultado>();
            Posicion = new HashSet<Posicion>();
            Resultado = new HashSet<Resultado>();
        }

        public Guid EquId { get; set; }
        public string EquNombre { get; set; }

        public virtual ICollection<EquipoResultado> EquipoResultado { get; set; }
        public virtual ICollection<Posicion> Posicion { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
    }
}
