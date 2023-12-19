using System;
using System.Diagnostics;
using System.Drawing;


public interface ISmallPaint
{
    void Paint(Graphics graphics);
}



public class NewYearPaint
{
    private List<ISmallPaint> paintObjects;

    public NewYearPaint()
    {
        paintObjects = new List<ISmallPaint>();
        Console.ReadLine();
    }
    
    public void Create()
    {
        // Создаем Graphics объект для рисования на форме
        Graphics graphics = Graphics.FromHwndInternal(Process.GetCurrentProcess().MainWindowHandle);
       

        // Проходим по всем объектам и вызываем их метод Paint
        foreach (ISmallPaint paintObject in paintObjects)
        {
            paintObject.Paint(graphics);
        }

    }

    public void AddPaintObject(ISmallPaint paintObject)
    {
        paintObjects.Add(paintObject);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Создаем объект NewYearPaint
        NewYearPaint newYearPaint = new NewYearPaint();

        // Создаем отдельные объекты для рисования
        ChristmasTree christmasTree = new ChristmasTree();
        Snowman snowman = new Snowman();
        House house = new House();
        Sleigh sleigh = new Sleigh();
        Gift gift = new Gift();

        // Добавляем объекты в общий список для рисования
        newYearPaint.AddPaintObject(house);
        newYearPaint.AddPaintObject(christmasTree);
        newYearPaint.AddPaintObject(snowman);
        newYearPaint.AddPaintObject(sleigh);
        newYearPaint.AddPaintObject(gift);

        // Запускаем рисование всего рисунка
        newYearPaint.Create();
        Console.ReadLine();
    }
}
