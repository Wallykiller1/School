﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    //Hides the basic setup from the XYZ class.
    public class AbstractGame : GameObject
    {
        public override void GameInitialize()
        {
            // Set the required values
            GAME_ENGINE.SetTitle("Canvas v1.0.2");
            GAME_ENGINE.SetIcon("icon.ico");

            // Set the optional values
            GAME_ENGINE.SetWidth(320);
            GAME_ENGINE.SetHeight(370);
            GAME_ENGINE.SetBackgroundColor(220, 220, 220); //Appelblauwzeegroen
            //GAME_ENGINE.SetBackgroundColor(49, 77, 121); //The Unity background color
        }
    }
}
