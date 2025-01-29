//Social Network  exercise
//author : KC NTSIE
//verion : Social Netork Practical 1

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = "Hello :)" ;//Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

class Post
{
    private string text ; // required for setting method 

//a Constructor, which outputs "New post" as called
        Public Post(){
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        //write a property for member text

  //Text property,  allow you to get and set the value of the text field.
         public string Text{
            set{ text = value; }
         }
        
}

}