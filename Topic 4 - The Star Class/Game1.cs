using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Topic_4___The_Star_Class
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Random generator = new Random();
        Star star1;
        List<Star> stars;
        Rectangle window, shipRect;
        Texture2D shipTexture, starTexture; 
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            star1 = new Star(starTexture, new Rectangle(100, 100, 2, 2), new Vector2(-2, 0));
            shipRect = new Rectangle(50, 250, 150, 40);
            window = new Rectangle(0, 0, 800, 600);
            stars = new List<Star>();
            for (int i = 0; i < 150; i++)
            {
                int x, y;
                x = generator.Next(window.Width);
                y = generator.Next(window.Height);
                Rectangle star = new Rectangle(x, y, 3, 3);
                stars.Add(new Star(starTexture, star, new Vector2(-2, 0)));
            }
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            shipTexture = Content.Load<Texture2D>("Images/enterprise");
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            foreach (Star star in stars)
                star.Update();
            if (Star.Location.Right < 0)
                star.X = window.Width;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            Star.Draw(_spriteBatch);
            foreach (var star in stars)
                star.Draw(_spriteBatch);
            _spriteBatch.Draw(shipTexture, shipRect, Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
