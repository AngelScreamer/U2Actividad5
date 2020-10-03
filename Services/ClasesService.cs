using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unidad2Actividad5.Models;

namespace Unidad2Actividad5.Services
{
    public class ClasesService
    {
        public List<Clase> Clases { get; set; }
        public ClasesService()
        {
            using (animalesContext context = new animalesContext())
            {
                Clases = context.Clase.OrderBy(x => x.Nombre).ToList();
            }
        }
    }
}
