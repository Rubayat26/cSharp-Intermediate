using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;  //this means the keys are of type string and values are aslo of type string 
     // private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>(); //we can initlize
                                                                                                    // the list here
                                                                                                    // instead of declaring
                                                                                                    // inside the constructor
                                                                                           

        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>(); // 1st string refers to key and 2nd string refers to value
        }

        /*
        public void SetItem(string key, string value)   //If we have not used the indexers we would have needeed 
                                                        //this code lines to implement the HTTP Cokkie List
        {

        }                                                  

        public string GetItem(string key)
        {
            
        }
        */

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }  // here value refers to the value we put right sid of assignement operator
                                               // main program, where we assigned the value MOSH
        }
    }
}
