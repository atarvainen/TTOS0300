using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SnakeGame
{
    class SpeedBonus : IGameObject
    {
        public Point Position { get; set; }

        public int Radius { get; set; }

        public void Update()
        {

        }

        public void Draw(DrawingContext drawingContext)
        {
            ColorAnimation blackToWhite = new ColorAnimation(Colors.White, Colors.Black, new Duration(new TimeSpan(1500000)));
            blackToWhite.AutoReverse = true;
            blackToWhite.RepeatBehavior = RepeatBehavior.Forever;
            SolidColorBrush scb = new SolidColorBrush(Colors.Black);
            scb.BeginAnimation(SolidColorBrush.ColorProperty, blackToWhite);

            drawingContext.DrawEllipse(scb, null, Position, Radius, Radius);
        }
    }
}
