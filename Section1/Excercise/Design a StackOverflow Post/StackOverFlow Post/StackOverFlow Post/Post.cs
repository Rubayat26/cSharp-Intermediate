// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"

namespace StackOverFlow
{
    public class Post
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostTime { get; set; }


        
        
        public string _check;        // just to check how normal
        
        public string Check
        {
            get
            {                         // get set works, instead 
                return _check;
            }
            set
            {
                _check = value;
            }
        }                             // of automiplementation
        
        public int voteValue { get; private set; }

       
        public Post(int voteValue)
        {
            this.voteValue = voteValue;
        }


        public int Upvote()
        {
            voteValue++;
            return voteValue;
        }

        public int Downvote()
        {
            voteValue--;
            return voteValue;
        }

    }
    
}