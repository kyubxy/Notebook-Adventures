﻿using Microsoft.Xna.Framework;
using Sh.Framework.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nice_game.Objects.tiles
{
    public class t6 : GameObject
    {
        private Game game;
        private Vector2 Position;

        public t6(Game Game, Vector2 pos) : base (Game)
        {
            game = Game;
            Position = pos;
        }

        public override void LoadContent()
        {
            position = Position;
            texturename = @"Textures/tiles/t4";
            base.LoadContent();
        }
    }
}
