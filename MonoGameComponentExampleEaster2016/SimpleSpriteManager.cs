using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGameComponentExampleEaster2016
{
    public class SimpleSpriteManager: DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        public SimpleSpriteManager(Game g) : base(g)
        {
            g.Components.Add(this);
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Game.Services.AddService<SpriteBatch>(spriteBatch);

            GameLoader.dctTextures.Add("Black Knight",
                Game.Content.Load<Texture2D>("Black Knight"));

            new SimpleSprite(Game, "Black Knight");

            base.LoadContent();
        }
    }
}
