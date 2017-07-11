using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Db.Entity
{
    public class Texture2D
    {
        [Key]
        public Guid Id { get; set; }
        public byte[] Texture { get; set; }
        public Size Size { get; set; }

    }
}
