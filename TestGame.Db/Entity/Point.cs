using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Db.Entity
{
    public class Point
    {
        [Key]
        public Guid Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
