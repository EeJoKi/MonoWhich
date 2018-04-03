using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace GameGameHaa2
{
    //https://www.youtube.com/watch?v=r5dM0_J7KuY
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D playerSprite;
        private Vector2 playerPos;
        private float playerSpeed = 10;
        List<Texture2D> levelTextures = new List<Texture2D>();
        LevelManager levelManager;

        public Game1()
        {
            Debug.WriteLine("Got to game");
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            levelManager = new LevelManager();
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

            playerSprite = Content.Load<Texture2D>("Witch_Idle01");
            playerPos = new Vector2(0, 0);
            Debug.WriteLine("Got to Game1");

            levelTextures.Add(Content.Load<Texture2D>("Tile_Floor"));
            
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
           //if(Keyboard.GetState().IsKeyDown(Keys.Up))
           // {
           //     playerPos.Y -= playerSpeed;
           // }
           // if (Keyboard.GetState().IsKeyDown(Keys.Down))
           // {
           //     playerPos.Y += playerSpeed;
           // }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                playerPos.X += playerSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                playerPos.X -= playerSpeed;
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            //Draw Room
            List <Vector2> posToDraw = levelManager.GetPotitions();
            List <int> typesToDraw = levelManager.GetTextureTypes();
            for (int i = 0; i < posToDraw.Count; i++)
            {
                spriteBatch.Draw(levelTextures[0], posToDraw[i], Color.White);
            }
            
            spriteBatch.Draw(playerSprite, playerPos, Color.White);

            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
