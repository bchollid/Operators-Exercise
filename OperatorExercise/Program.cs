namespace OperatorExercise
{
    public class Program
    {

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI* Math.Pow(radius, 2);

            return area;
        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient}. And the remainder of {a} / {b} is {remainder}.");
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double circleArea = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {circleArea}");

            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs ?
                                    // the output is 16 because we put the increment operator in front of variable i.
                                    // Which means we add 1 to variable i before we do the mathematical operation of i * j.
                                    // If I were to write it as i++ then the answer would be 12. 

        }


    }
}
