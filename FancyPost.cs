using System;

namespace Assi2
{
    //Fancy post class just a fancier post 
    class FancyPost : Post
    {

        //basic 2 args constructor
        public FancyPost(string t, string b) : base(t, b) {
            Title = t;
            Body = b;
        }

        //Print the title to the user in a fancy way
        public override string GetPrintableHead()
        {
            return $"{Title}";
        }

        //Prints the body to the user in a fancy way
        public override string GetPrintableBody()
        {
            return $"<><><><><>\n{Body} \n<><><><><>";
        }
    }
}
