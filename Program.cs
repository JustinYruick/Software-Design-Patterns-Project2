using System;
using System.Collections.Generic;

namespace Assi2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Defines a default post to be cloned later
            Post defaultPost = new Post("Default Title", "Defualt Body");

            //List of PostProxys to hold the proxies of the posts
            List<PostProxy> Posts = new List<PostProxy>();

            //add three loading post to the list
            PostProxy p1 = new PostProxy();
            Posts.Add(p1);

            PostProxy p2 = new PostProxy();
            Posts.Add(p2);

            PostProxy p3 = new PostProxy();
            Posts.Add(p3);

            Console.WriteLine("Welcome to the Social Network!\nEnter a command to get started, or 'help' to see a list of commands:");
            string command = "";

            while(command != "quit") {
                string[] commandArgs = command.Split(":");
                int postNum = -1;
                if(commandArgs.Length > 1) {
                    try {
                        postNum = (int.Parse(commandArgs[1]));
                    } catch(FormatException) {
                        Console.WriteLine("Error: Invalid post number specified!");
                    }

                    if(postNum < 0 || postNum > Posts.Count) {
                        Console.WriteLine("Error: Invalid post number specified!");
                        break;
                    }
                }

                switch (commandArgs[0]) {
                    case "help":
                        Console.WriteLine("help\t\t\tDisplay this menu");
                        Console.WriteLine("new\t\t\tCreate a new post.");
                        Console.WriteLine("list\t\t\tList all posts.");
                        Console.WriteLine("download:[id]\t\tDownload a post.");
                        Console.WriteLine("settitle:[id]:[title]\tSet a post's title.");
                        Console.WriteLine("setbody:[id]:[body]\tSet a post's body.");
                        Console.WriteLine("view:[id]\t\tView a post.");
                        Console.WriteLine("quit\t\t\tQuit the application");
                        break;
                    case "new":
                        //creates new post PosTPRoxy by calling the one arg constructor that clones the default post
                        PostProxy newPost = new PostProxy(defaultPost);
                        Posts.Add(newPost);
                        Console.WriteLine("Added a new Post.");
                        break;
                    case "list":
                        int x = 0;
                        foreach(PostProxy post in Posts)
                        {
                            //loops trough the post list calling the GetPrintableHead method on each post to print the title
                            Console.WriteLine("[" + x + "]       " + post.GetPrintableHead());
                            x++;
                        }
                        break;
                    case "download":
                        //downloads a post turning it into a fancy post
                        Posts[postNum].Download();
                        Console.WriteLine("Done.");
                        break;
                    case "settitle":
                        //sets the title of specifies post
                        Posts[postNum].setTitle(commandArgs[2]);
                        Console.WriteLine("Done.");
                        break;
                    case "setbody":
                        //sets the body of specifies post
                        Posts[postNum].setBody(commandArgs[2]);
                        Console.WriteLine("Done.");
                        break;
                    case "view":
                        //calls the Content class print method to print the 
                        Posts[postNum].Print();
                        break;
                    default:
                        if(command != "") {
                            Console.WriteLine("Invalid command.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
