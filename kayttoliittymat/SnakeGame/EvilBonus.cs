using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SnakeGame
{
    class EvilBonus : IGameObject
    {
        public Point Position { get; set; }

        public int Radius { get; set; }

        public void Update()
        {

        }

        public void Draw(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(Brushes.Purple, null, Position, Radius, Radius);
        }
    }
}
