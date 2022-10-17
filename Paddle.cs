﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreakerV2
{
    /// <summary>
    /// Manages the paddle and related data
    /// </summary>
    internal class Paddle
    {
        private int xPos;
        private int yPos;
        private int width;
        private int height;
        private Color color;

        // Turns fields into properties
        // Allows other classes to access the values
        // Reduces creation of extra variables
        public int X { get => xPos; set => xPos = value; }
        public int Y { get => yPos; set => yPos = value; }
        public int Width { get => width; }
        public int Height { get => height; }
        public Color PaddleColor { get => color; set => color = value; }
    }
}
