using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeGame
{
    public abstract class GameObject
    {
        protected Texture2D[] sprites;

        protected Texture2D sprite;

        protected int fps;

        protected float speed;

        protected Vector2 velocity;

        public Vector2 position;

        protected Vector2 origin;

        private int currentIndex;

        private float timeElapsed;

        protected void Animation(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {

        }
        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);
        
    }
}
