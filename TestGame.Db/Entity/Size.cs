using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Db.Entity
{
    public class Size
    {
        [Key]
        public Guid Id { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
