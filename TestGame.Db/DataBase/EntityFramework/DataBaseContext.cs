using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Db.Entity;

namespace TestGame.Db.DataBase.EntityFramework
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Animation> Animations { get; set; }
        public DbSet<Texture2D> Textures { get; set; }
        public DbSet<GameObject2D> GameObjects { get; set; }

    }
}
