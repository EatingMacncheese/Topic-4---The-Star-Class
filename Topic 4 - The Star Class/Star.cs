using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Topic_4___The_Star_Class
{
    public class Star
    {
        private Rectangle _location;
        private Vector2 _speed;
        private Texture2D _texture;
        private Texture2D starTexture;
        private Microsoft.Xna.Framework.Rectangle rectangle;
        private Microsoft.Xna.Framework.Vector2 vector2;
        internal static int X;

        public Star(Texture2D texture, Rectangle location, Vector2 speed)
        {
            _location = location;
            _speed = speed;
            _texture = texture;
        }

        public Star(Texture2D starTexture, Microsoft.Xna.Framework.Rectangle rectangle, Microsoft.Xna.Framework.Vector2 vector2)
        {
            this.starTexture = starTexture;
            this.rectangle = rectangle;
            this.vector2 = vector2;
        }

        public void Update()
        {
            _location.Offset(_speed);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _location, Color.White);
        }
        public Rectangle Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public int Y
        {
            get { return _location.Y; }
            set { _location.Y = value; }
        }
        public Rectangle Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
