using System;
using System.Collections.Generic;

namespace TestGame.Db.Entity
{
    public class GameObject2D
    {
        public Guid Id { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }
        public GameObjectType Type { get; set; }
        public Guid? TextureId { get; set; }
        public Texture2D Texture { get; set; }
        public List<Animation> Animations { get; set; }
    }
}
