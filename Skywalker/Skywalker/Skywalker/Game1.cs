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
        SkywalkerStuff TheForce;
        Ryu MonkeyDude;
        Chun_LiStuff Dumpling;
        
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
            TheForce = new SkywalkerStuff(Content.Load<Texture2D>("skywalker"), new Vector2(600, 550), new Vector2(3), Color.White, new List<Frame>());
            MonkeyDude = new Ryu(Content.Load<Texture2D>("ryu"), new Vector2(200, 350), new Vector2(3), Color.White, new List<Frame>());
            Dumpling = new Chun_LiStuff(Content.Load<Texture2D>("chun-li"), new Vector2(600, 350), new Vector2(3), Color.White, new List<Frame>());
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
            base.Update(gameTime);
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
            MonkeyDude.Draw(spriteBatch);
            Dumpling.Draw(spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
