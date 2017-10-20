using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGuessGame
{
    class SearchTree
    {
        public Node Root { get; set; }

        public SearchTree(string data)
        {
            Root = new Node(data);
        }

        public void Question(Node Current)
        {
            if (Current.Left == null && Current.Right == null)
            {
                Guess(Current);
            }
            else
            {
                Console.WriteLine($"{ Current.Data}");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y" || answer == "yes")
                {
                    Question(Current.Left);
                }
                else
                {
                    Question(Current.Right);
                }
            }
        }
        public void Guess(Node node)
        {
            Console.WriteLine($"Is is a {node.Data}?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            {
                Console.WriteLine("YAY");
            }
            else
            {
                Console.WriteLine("What animal did you have in mind?");
                string newAnimal = Console.ReadLine();
                Console.WriteLine($"Give a Question to help me guess {node.Data}");
                string newQuestion = Console.ReadLine();
                node.Right = new Node(newAnimal);
                node.Left = new Node(node.Data);
                node.Data = newQuestion;

                TryAgain();
            }
        }

        public void TryAgain()
        {
            Console.WriteLine("Play again?");
            string answer = Console.ReadLine().ToLower();
            if(answer == "y" || answer == "yes")
            {
                Question(Root);
            }
            else
            {
                Console.WriteLine("Ill get it next time");
                return;
            }
        }



       
        public class Node
        {
            public string Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Current { get; set; }

            public Node(string data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
    }
}
