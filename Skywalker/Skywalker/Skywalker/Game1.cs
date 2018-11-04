using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Saiyuki_VS_Skywalker
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D pixel;
        Labels label;
        Labels label2;
        Labels label3;
        SkywalkerStuff TheForce;
        Ryu MonkeyDude;
        Chun_LiStuff Dumpling;
        MBison Buffalo;
        int count = 100;
        int count2 = 150;
        int count3 = 75;
        
        public static Viewport Viewport { get { return temp; } }
        public static Viewport Viewport2 { get { return temp; } }
        public static Viewport Viewport3 { get { return temp; } }
        private static Viewport temp;
        private static Viewport temp2;
        private static Viewport temp3;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";


        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            temp = GraphicsDevice.Viewport;
            temp2 = GraphicsDevice.Viewport;
            temp3 = GraphicsDevice.Viewport;
            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData(new Color[] { Color.White });
            label = new Labels(Color.Red, new Vector2(10,10), Content.Load<SpriteFont>("font"), "Ryu's Health: 100");
            label2 = new Labels(Color.MediumPurple, new Vector2(250, 10), Content.Load<SpriteFont>("font"), "MBison's Health: 150");
            label3 = new Labels(Color.Blue, new Vector2(490, 10), Content.Load<SpriteFont>("font"), "Chun-Li's Health: 75");
            TheForce = new SkywalkerStuff(Content.Load<Texture2D>("skywalker"), new Vector2(600, 6050), new Vector2(3), Color.White, new List<Frame>());
            MonkeyDude = new Ryu(Content.Load<Texture2D>("ryu"), new Vector2(200, 350), new Vector2(3), Color.White, new List<Frame>());
            Dumpling = new Chun_LiStuff(Content.Load<Texture2D>("chun-li"), new Vector2(600, 150), new Vector2(3), Color.White, new List<Frame>());
            Buffalo = new MBison(Content.Load<Texture2D>("mbison"), new Vector2(200, 350), new Vector2(3), Color.White, new List<Frame>());
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit


            TheForce.Update(gameTime, Keyboard.GetState());
            MonkeyDude.Update(gameTime, Keyboard.GetState());
            Dumpling.Update(gameTime, Keyboard.GetState());
            Buffalo.Update(gameTime, Keyboard.GetState());
            base.Update(gameTime);
        
            if (Dumpling.punch == true)
            {
                if (Dumpling.Hitbox.Intersects(MonkeyDude.Hitbox))
                {
                    label.text = $"Ryu's Health: {count}";
                    count--;
                }
                else if (Dumpling.Hitbox.Intersects(Buffalo.Hitbox))
                {
                    label2.text = $"MBison's Health: {count2}";
                    count2--;
                }
            }          
            if (Dumpling.regkick == true)
            {
                if (Dumpling.Hitbox.Intersects(MonkeyDude.Hitbox))
                {
                    label.text = $"Ryu's Health: {count}";
                    count = count -2;
                }
                else if (Dumpling.Hitbox.Intersects(Buffalo.Hitbox))
                {
                    label2.text = $"MBison's Health: {count2}";
                    count2 = count2 - 2;
                }
            }
            if (Dumpling.spinkick == true)
            {
                if (Dumpling.Hitbox.Intersects(MonkeyDude.Hitbox))
                {
                    label.text = $"Ryu's Health: {count}";
                    count = count - 3;
                }
                else if (Dumpling.Hitbox.Intersects(Buffalo.Hitbox))
                {
                    label2.text = $"MBison's Health: {count}";
                    count = count - 3;
                }
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            //GraphicsDevice.Clear(Color.OliveDrab);
            spriteBatch.Begin();
            TheForce.Draw(spriteBatch);
            MonkeyDude.Draw(spriteBatch, pixel);
            Dumpling.Draw(spriteBatch, pixel);
            Buffalo.Draw(spriteBatch, pixel);
            label.Draw(spriteBatch);
            label2.Draw(spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
