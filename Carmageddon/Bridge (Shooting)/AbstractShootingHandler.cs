﻿using Carmageddon.Forms.Models;

namespace Carmageddon.Forms.Bridge__Shooting_
{
    public abstract class AbstractShootingHandler
    {
        public Weapon Weapon { get; set; }

        public abstract Task<string> HandleShot(int coordX, int coordY, string username);
    }
}
