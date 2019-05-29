//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\PiXiPaint\PiXiPaint\Core\Math\Vectors.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace PiXiPaint.Core.Math
{
    public class Vector3
    {

        public readonly float X;
        public readonly float Y;
        public readonly float Z;

        Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public class Vector2
    {

        public readonly float X;
        public readonly float Y;

        Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
