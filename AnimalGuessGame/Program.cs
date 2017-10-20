using System;
using static AnimalGuessGame.SearchTree;

namespace AnimalGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree testTree = new SearchTree("Is it a Mammal?");
            //testTree.Root.Left = new Node("Does it Bark?")
            //{
            //    Left = new Node("Dog"),
            //    Right = new Node("Cat")
            //};

            //testTree.Root.Right = new Node("Can it fly?")
            //{
            //    Left = new Node("Bird"),
            //    Right = new Node("Fish")
            //};

            testTree.Question(testTree.Root);




            Console.Read();
        }
    }
}
