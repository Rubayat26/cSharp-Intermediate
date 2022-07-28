// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"


/*Exercise 2: Design a StackOverflow Post
//Design a class called Post. This class models a StackOverflow post. It should have properties 
//for title, description and the date/time it was created. We should be able to up-vote or down-vote 
//a post. We should also be able to see the current vote value. In the main method, create a post, 
//up-vote and down-vote it a few times and then display the the current vote value. 
//In this exercise, you will learn that a StackOverflow post should provide methods for up-voting 
//and down-voting. You should not give the ability to set the Vote property from the outside, 
//because otherwise, you may accidentally change the votes of a class to 0 or to a random 
//number. And this is how we create bugs in our programs. The class should always protect its 
//state and hide its implementation detail. 
//Educational tip: The aim of this exercise is to help you understand that classes should 
//encapsulate data AND behaviour around that data. Many developers (even those with years of 
//experience) tend to create classes that are purely data containers, and other classes that are 
//purely behaviour (methods) providers. This is not object-oriented programming. This is 
//procedural programming. Such programs are very fragile. Making a change breaks many parts 
//of the code
// * 
// * 
 * 
*/















namespace StackOverFlow
{


    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post(0);
            post.Title = "1st StackOverFlow Post";
            post.Description = "This is the first StackOverFlow Post";
            post.PostTime = new DateTime(2020, 1, 1);

            post.Check = "Hello There";   // just checking how things work 
                                         //without autoimplemented properties
            Console.WriteLine(post.Title);
            post.Upvote();
            post.Upvote();
            post.Downvote();
            //post.voteValue = 1;       // setting the method to private will only
                                        // let the user set the value at once in the benginning
                                        // reassigning not ok
                                        //otherwise there might be a bug to restart the vote value to 0 
            Console.WriteLine(post.voteValue);
            Console.WriteLine(post.Check); //just checking without the autoimplemantation get set
        }
    }

}











// Pseudocoding strategy
// at first tried to implement the get set like normal
// then used the autoimplemented properties 

// made the votevalue set private so it can only be initated at the time
// of the post creation once

//used upvote method to increase the vote value 

