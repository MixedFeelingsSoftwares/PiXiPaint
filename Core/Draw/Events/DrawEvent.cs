//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\PiXiPaint\PiXiPaint\Core\Draw\Events\DrawEvent.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace PiXiPaint.Core.Draw.Events
{
    public class DrawEvent
    {
        public static event System.EventHandler<List<Math.Vector2>> onPointsChanged;

        public static void isPointsChanged() => onPointsChanged?.Invoke(null, Draw.Drawing.points);
    }
}
