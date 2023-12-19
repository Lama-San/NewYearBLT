using System;
using System.Drawing;



public class Snowman : ISmallPaint
{
    public void Paint(Graphics g)
    {
        
           // Рисование снеговика
            g.FillEllipse(Brushes.White, new Rectangle(200, 400, 150, 150)); // тело снеговика
            g.FillEllipse(Brushes.White, new Rectangle(223, 305, 100, 100)); // голова снеговика
            g.FillEllipse(Brushes.Black, new Rectangle(250, 355, 25, 25)); // глаза
            g.FillEllipse(Brushes.Black, new Rectangle(290, 355, 25, 25));
            
        
    }
}