using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGameComponentExampleEaster2016
{
    public class SimpleSprite: DrawableGameComponent
    {
        string _name;
        public SimpleSprite(Game g, string SpriteName)
                                : base(g)
        {
            _name = SpriteName;
            g.Components.Add(this);
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch sp = Game.Services.GetService<SpriteBatch>();
            sp.Begin();
            sp.Draw(GameLoader.dctTextures[_name], 
                new Vector2(200, 200), Color.White);
            sp.End();
            base.Draw(gameTime);
        }
    }
}
