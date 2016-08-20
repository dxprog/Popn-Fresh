using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Popn_Fresh
{
    class Background
    {

        Texture2D _texture;
        Rectangle _screen;

        public void Initialize(ContentManager Content)
        {
            _texture = Content.Load<Texture2D>("Backgrounds\\background");
            _screen = new Rectangle(0, 0, 1280, 720);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _screen, Color.White);
        }

    }
}
