//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\PiXiPaint\PiXiPaint\Core\Draw\Drawing.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using PiXiPaint.Core.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PiXiPaint.Core.Draw
{
    public class Drawing
    {

        private static List<Vector2> temp_points;

        public static List<Vector2> points
        {
            get => temp_points;
            set
            {
                if (temp_points != value)
                {
                    temp_points = value;
                    Events.DrawEvent.isPointsChanged();
                }
            }
        }

    }
}
