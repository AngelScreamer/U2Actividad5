using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad2Actividad5.Models
{
    public class AnimalesViewModel
    {
        public int Imagen { get; set; }
        public IEnumerable<Clase> Clase { get; set; }
    }
}
