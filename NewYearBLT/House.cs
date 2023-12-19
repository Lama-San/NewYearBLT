using System;
using System.Drawing;



public class House : ISmallPaint
{
    public void Paint(Graphics g)
    {

            // Рисуем стены домика
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawRectangle(pen, 100, 100, 300, 300);

            // Рисуем крышу
            Point[] roofPoints = { new Point(100, 100), new Point(250, 50), new Point(400, 100) };
            g.DrawPolygon(pen, roofPoints);

            // Рисуем дверь
            g.FillRectangle(Brushes.Brown, 225, 300, 50, 100);

            // Рисуем окна
            g.FillRectangle(Brushes.White, 125, 175, 100, 100);
            g.FillRectangle(Brushes.White, 275, 175, 100, 100);
        

    }
}