using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGameComponentExampleEaster2016
{


    public static class GameLoader
    {
        public static Dictionary<string, Texture2D> dctTextures = new Dictionary<string, Texture2D>();
        public static Dictionary<string, SpriteFont> dctFonts = new Dictionary<string, SpriteFont>();
        public static Dictionary<string, SoundEffect> dctEffects = new Dictionary<string, SoundEffect>();
    }
}
