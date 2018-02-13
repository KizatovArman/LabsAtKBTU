using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    class Snakeitself
    {
        public ConsoleColor color;
        public string sign;
        public List<Point> body;
    
        public Snakeitself()
        {
            color = ConsoleColor.Green;
            sign = "O";
            body = new List<Point>();
            body.Add(new Point(2, 2));
            body.Add(new Point(2, 3));
            body.Add(new Point(2, 4));
        }
       
        public void Draw()
        {
            int ind = 0;
            foreach(Point p in body)
            {
                if (ind == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p._x, p._y);
                Console.WriteLine(sign);
                ind++;
            }
        }

        public void Movement(int dx, int dy)
        {
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i]._x = body[i - 1]._x;
                body[i]._y = body[i - 1]._y;
            }

            body[0]._x = body[0]._x + dx;
            body[0]._y = body[0]._y + dy;
        }

        public bool CollisionWithWall(Wall w)
        {
            bool res2 = true;
            foreach (Point p in body)
            {
                if (p._x == body[0]._x && p._y == body[0]._y)
                    res2 = true; 
            }
            res2 = false;

            return res2;
        }

        
    }
}
