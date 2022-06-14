using System;

namespace Assi2
{
    abstract class Content
    {
        //print method that prints a post
        public void Print()
        {
            Console.WriteLine($"{GetPrintableHead()}\n------------------\n{GetPrintableBody()}");
        }

        //abstarct clone method to be overiden is subclasses
        public abstract Post Clone();

        //abstarct method that prints the title to be overiden is subclasses
        public abstract string GetPrintableHead();

        //abstarct method that prints the body to be overiden is subclasses
        public abstract string GetPrintableBody();
    }
}
