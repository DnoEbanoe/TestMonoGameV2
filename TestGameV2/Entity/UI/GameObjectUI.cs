using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Db.Entity;

namespace TestGameV2.Entity.UI
{
    public class GameObjectUI
    {
        public event Action<GameObjectUI, EventArgs> Creater;
        public event Action<GameObjectUI, EventArgs> Showed;
        public event Action<GameObjectUI, EventArgs> Hidden;
        public Point Position { get; set; }
        public GameObjectType Type { get; set; }
        private List<AnimationUi> Animations { get; set; }

        public GameObjectUI()
        {
            OnCreater(this);
        }

        public virtual void Show()
        {
            OnShowed(this);
        }

        public virtual void Hide()
        {
            OnHidden(this);
        }

        protected virtual void OnCreater(GameObjectUI arg1)
        {
            Creater?.Invoke(arg1, EventArgs.Empty);
        }

        protected virtual void OnShowed(GameObjectUI arg1)
        {
            Showed?.Invoke(arg1, EventArgs.Empty);
        }

        protected virtual void OnHidden(GameObjectUI arg1)
        {
            Hidden?.Invoke(arg1, EventArgs.Empty);
        }
    }
}
