using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spjeniscat.Models
{
    public class BasisPengetahuan
    {
        public int Id { get; set; }
        public KondisiRumah KondisiRumah { get; set; }
        public double CF { get; set; }
    }
}