﻿
using Cirrus.Numeric;
using Cirrus.TutorialQuest.World.Objects;
using Microsoft.Xna.Framework;
using Nez;


namespace Cirrus.TutorialQuest.World.Objects
{
    public class SlimeController : Component, IUpdatable
    {
        public Avatar Avatar;

        private Slime slime;

        public SlimeController(Slime slime)
        {
            this.slime = slime;        
        }


        public void Update()
        {
            if (Avatar != null)
            {                
                slime.Axes = (Avatar.Position - slime.Position).Normalized(); 
            }
        }
    }
}
