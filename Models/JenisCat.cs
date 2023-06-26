using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spjeniscat.Models
{
    public class JenisCat
    {
        public int Id { get; set; }
        public String KodeJenis { get; set; }
        public String Nama { get; set; }

        ICollection<BasisPengetahuan> Pengetahuan { get; set; } =  new List<BasisPengetahuan>();
    }
}