﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOO
{
    struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public readonly double X;
        public readonly double Y;
    }
    class Line
    {
        public Line(double k, double l)
        {
            this.k = k;
            this.l = l;
        }
        public readonly double k;
        public readonly double l;
        public Point? Intersection(Line other)
        {
            if (k == other.k)
                return null;
            double x = (other.l - l) / (k - other.k);
            double y = k * x + l;
            return new Point(x, y);
            }
        }
    }
}

