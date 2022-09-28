using ApiCampeonato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCampeonato.Repositorios
{
    public class EquipoResultadorRepositorio
    {
        DB_CAMPEONATOContext _context;
        public EquipoResultadorRepositorio(DB_CAMPEONATOContext context)
        {
            _context = context;
        }
        public void AgregarResultado(Resultado equipoResultado)
        {
            equipoResultado.EncId = Guid.NewGuid();
            _context.Resultado.Add(equipoResultado);
            _context.SaveChanges();


        }








    }

}
