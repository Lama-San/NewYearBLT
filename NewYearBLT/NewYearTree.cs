using System;
using System.Drawing;

public class ChristmasTree : ISmallPaint
{
    public void Paint(Graphics graphics)
    {
        
            
            //Ёлка
        
        Brush gr = new SolidBrush(Color.DarkGreen);
        Brush st = new SolidBrush(Color.Brown);

        Point point1 = new Point(400, 400);
        Point point2 = new Point(500, 275);
        Point point3 = new Point(600, 400);
        
        Point point4 = new Point(400, 300);
        Point point5 = new Point(500, 175);
        Point point6 = new Point(600, 300);
        
        Point point7 = new Point(400, 200);
        Point point8 = new Point(500, 75);
        Point point9 = new Point(600, 200);
        Point[] curvePoints ={point1,point2,point3,};
        Point[] curvePoints2 ={point4,point5,point6,}; 
        Point[] curvePoints3 ={point7,point8,point9,};


        graphics.FillPolygon(gr, curvePoints); 
        graphics.FillPolygon(gr, curvePoints2);
        graphics.FillPolygon(gr, curvePoints3);
        graphics.FillRectangle(st, 490, 400, 25, 100);


    }
}