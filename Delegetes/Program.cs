namespace Delegetes
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            var helper = new Rectangualrhelper();

            // Calling Delegate
            RecDelegate rect;

            // join delegate to the method we want to functionate it
            rect = helper.GetArea;
            rect += helper.GetPreimeter;

            rect(10,5);

            Console.WriteLine("Removing GetPerimetre from Delegate");

            // rect -= helper.GetPreimeter;

            rect(10, 5);


            Console.ReadKey();

        }

    }

    public delegate void RecDelegate(decimal width, decimal height);


    public class Rectangualrhelper
    {
        public void GetArea(decimal width,decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area: {width} x {height} = {result}");
        }
        public void GetPreimeter(decimal width, decimal height)
        {
            var result = 2 *(width + height);
            Console.WriteLine($"Perimeter:2 x ({width} + {height}) = {result}");
        }
    }

}