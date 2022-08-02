
namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
//            var shape = new Shape();  // Abstract classes cannot be initiated,
//                                      // wont compile


            var circle = new Circle();
            circle.Draw(); 
           
            circle.Copy();
                    

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
