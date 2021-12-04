using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class CasasResponse
    {
        public int dias { get; set; }
        public int[] lstCasas { get; set; } 
        public List<int> salida { get; set; }

    }
}
