using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        private Rectangle rectangle;
        private Vector2 vector2;
        //internal static int X;

        public Star(Texture2D texture, Rectangle location, Vector2 speed)
        {
            _location = location;
            _speed = speed;
            _texture = texture;
        }

        

        public void Update(Rectangle window)
        {
            _location.Offset(_speed);

            if (_location.Right < 0)
                _location.X = window.Width;
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

        public int X
        {
            get { return _location.X; }
            set { _location.X = value; }
        }

    }
}
