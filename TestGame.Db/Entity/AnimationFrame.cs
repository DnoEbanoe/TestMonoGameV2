using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Db.Entity
{
    public class AnimationFrame
    {
        public Guid Id { get; set; }
        public Texture2D Texture { get; set; }
        public TimeSpan Time { get; set; }
    }
}
