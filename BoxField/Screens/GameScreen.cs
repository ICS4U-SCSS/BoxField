﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys
        Boolean leftArrowDown, rightArrowDown;

        //used to draw boxes on screen
        SolidBrush boxBrush = new SolidBrush(Color.White);

        //create a list to hold a column of boxes   


        public GameScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            //TODO - set game start values
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;           
            }
        }


        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //TODO - update location of all boxes (drop down screen)

            //TODO - remove box if it has gone of screen

            //TODO - add new box if it is time

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //TODO - draw boxes to screen
        }
    }
}
