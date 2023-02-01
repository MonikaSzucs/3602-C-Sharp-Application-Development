using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypePassAndSwapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget firstWidget = new Widget();
            Widget secondWidget = new Widget();

            firstWidget.Id = 10;
            secondWidget.Id = 200;

            Console.WriteLine($"firstWidget Id at start: {firstWidget.Id}");
            Console.WriteLine($"secondWidget Id at start: {secondWidget.Id}");

            SwapWidgetByValue(firstWidget, secondWidget);

            Console.WriteLine($"firstWidget Id after swap by value (Pass by value, non-permanent change): {firstWidget.Id}");
            Console.WriteLine($"secondWidget Id after swap by value (Pass by value, non-permanent change): {secondWidget.Id}");


            SwapWidgetByRef(ref firstWidget, ref secondWidget);

            Console.WriteLine($"firstWidget Id after swap by ref  (Pass by reference, permanent change): {firstWidget.Id}");
            Console.WriteLine($"secondWidget Id after swap by ref  (Pass by reference, permanent change): {secondWidget.Id}");

            SetSerialNumberToZero(firstWidget);
            Console.WriteLine($"firstWidget Id after set to zero (Now both variables point to the same object): {firstWidget.Id}");
            Console.WriteLine($"secondWidget Id after set to zero (Now both variables point to the same object): {secondWidget.Id}");
        }

        static void SetSerialNumberToZero(Widget widget)
        {
            widget.Id = 0;
        }

        static void SwapWidgetByValue(Widget widgetOne, Widget widgetTwo)
        {
            widgetOne = widgetTwo;
        }

        static void SwapWidgetByRef(ref Widget widgetOne, ref Widget widgetTwo)
        {
            widgetOne = widgetTwo;
        }
    }
}
