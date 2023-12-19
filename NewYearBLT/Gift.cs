using System;
using System.Drawing;

public class Gift : ISmallPaint
{
    public void Paint(Graphics g)
    {
            // Подарок
            g.FillRectangle(Brushes.Green, new Rectangle(300, 550, 100, 100)); // коробка
            g.FillRectangle(Brushes.Red, new Rectangle(335, 550, 27,100)); // бант
        g.FillRectangle(Brushes.Red, new Rectangle(300, 585, 100, 27)); // бант
    }
}