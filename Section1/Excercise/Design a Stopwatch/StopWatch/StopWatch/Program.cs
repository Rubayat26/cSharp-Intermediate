// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*
Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should 
provide two methods: Start and Stop. We call the start method first, and the stop method next. 
Then we ask the stopwatch about the duration between start and stop. Duration should be a 
value in TimeSpan. Display the duration on the console. 
We should also be able to use a stopwatch multiple times. So we may start and stop it and then 
start and stop it again. Make sure the duration value each time is calculated properly. 
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial 
start time). So the class should throw an InvalidOperationException if its started twice. 
1
Educational tip: The aim of this exercise is to make you understand that a class should be 
always in a valid state. We use encapsulation and information hiding to achieve that. The class 
should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the 
outside, you should not be able to misuse a class because you shouldn’t be able to see the 
implementation detail. 
‘


*/




using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Watch();
            while (true)
            {
                Console.Write("Type Start/Stop for the timer: ");

                var input1 = Console.ReadLine().ToLower();


                if (input1 == "start")
                {
                    watch.Start();

                }


                if (input1 == "stop")
                {
                    watch.Stop();
                }
            }
        }
    }
}




// pseudo code thinking
// At first we created the class watch
// Then intrduces two method start and stop in it
// if you want to retrun something from a mothod you need to give the return type infront 
//of it
// if you dont want to return anything from the method you can simply declare void infront
//of the method
// inside stop method we declared timespan 
// in the main method created a instance of the Watch class 
// Now we can call the methods declared inside the Watch class
// We declared the variables as private inside watch to keep it inaccessible from the oputside methods
// 
