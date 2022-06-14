using System;

namespace Assi2
{
    //post class repersents a post with a title and body text
    class Post : Content
    {
        public string Title;
        public string Body;

        //basic two areg consructor
        public Post(string t, string b) {
            this.Title = t;
            this.Body = b;
        }

        //no args constructor
        public Post() { }

        public override Post Clone()
        {
            Post p = new Post(Title, Body);
            return p;
        }

        //sets the title
        public  void setTitle(string T)
        {
            Title = T;
        }

        //sets the body text
        public  void setBody(string B)
        {
            Body = B;
        }
        
        //overides from interface to return the title
        public override string GetPrintableHead()
        {
            return Title;
        }

        //overides from interface to return the body
        public override string GetPrintableBody()
        {
            return Body;
        }
    }
}
