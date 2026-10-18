namespace IntroTillOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            double area = circle.GetArea(); 
            Console.WriteLine(area);
        }
    }
    class Circle
    {
        float _pi = 3.141f;
        int Radius;

        public Circle(int radie)
        {
            Radius = radie;
            
        }
        public double GetArea()
        {
            double area = Radius * Radius * _pi;
            return area;
        }
    }
}
