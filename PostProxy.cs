using System;

namespace Assi2
{
    //A proxie for the Post and Fancy Post Class
    class PostProxy : Content
    {
        private Post _Post;
        public string Title;
        public string Body;


        //Proxie is initalized with loading 
        public PostProxy()
        {
            Title = "Loading....";
            Body = "Loading....";
        }

        //Proxies is passed a default post that is then clones to the proxie
        public PostProxy(Post defaultPost)
        {
            _Post = defaultPost.Clone();
        }

        //sets the title by calling the post class setTitle
        public void setTitle(string T)
        {
            _Post.setTitle(T);
        }

        //sets the body by calling the post class setBody
        public  void setBody(string B)
        {
            _Post.setBody(B);
        }

 
       
        public override Post Clone()
        {
            throw new NotImplementedException();
        }

        //overides the method to print the Title
        public override string GetPrintableHead()
        {
            if (_Post != null)
                return _Post.GetPrintableHead();
            return Title;
        }

        //overides the mehtod to print the Body
        public override string GetPrintableBody()
        {
            if (_Post != null)
                return _Post.GetPrintableBody();
            return Title;
        }

        //downloads the post turing it into a fancy post
        public void Download()
        {
            FancyPost fancyPost = new FancyPost("***Downloaded***", "Downloaded Body");
            _Post = fancyPost;

            Title = _Post.Title;
            Body = _Post.Body;
        }
    }
}
