using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Db.Entity
{
    public class GameObjectByScena
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? ScenaId { get; set; }
        public Scena Scena { get; set; }
        public Guid? GameObjectId { get; set; }
        public GameObject2D GameObject { get; set; }
        public int Count { get; set; }
    }
}
