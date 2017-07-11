using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Db.Entity;

namespace TestGameV2.Entity.UI
{
    public class AnimationFrameUi
    {
        public Texture2D Texture { get; set; }
        public Size Size { get; set; }
        public TimeSpan TimeSpan { get; set; }
    }
}
