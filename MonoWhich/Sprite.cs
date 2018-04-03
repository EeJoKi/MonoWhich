using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGameHaa2
{
    class SpriteBlock
    {
        private Texture2D _texture;
        public Vector2 _position;

        public SpriteBlock(Texture2D texture)
        {
            _texture = texture;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spritepatch)
        {
            spritepatch.Draw(_texture, _position, Color.White);
        }
        
    }
}
