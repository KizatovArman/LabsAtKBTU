using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// we created special class called point. we imagine that our console is x,y dimensional space so we need two points to draw other objects;
/// </summary>
namespace SnakeProject
{
    public class Point
    {
        public int _x, _y;
        public Point(int x,int y)
        {
            _x = x;
            _y = y;
        }

    }
}
