using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1
{
    class Point : IPoint
    {
        // Implementacija svojstava deklariranih u interfejsu IPoint
        // Polja:
        private int _x;
        private int _y;

        // Konstruktor:
        public Point (int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int x
        {
            get { return _x; ; }
            set
            {
                _x = value;
            }
        }
        public int y
        {
            get { return _y; }
            set
            {
                _y=value);
            }
        }
    }
}
