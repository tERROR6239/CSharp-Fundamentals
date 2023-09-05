using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using static _03.ThePianist.Program;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesNumber = int.Parse(Console.ReadLine());
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < piecesNumber; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");
                string piece = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new Piece());
                }

                pieces[piece].Title = piece;
                pieces[piece].Composer = composer;
                pieces[piece].Key = key;
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arguments = command.Split("|");
                string pieceTitle = arguments[1];

                switch (arguments[0])
                {
                    case "Add":
                        string composer = arguments[2];
                        string key = arguments[3];

                        if (!pieces.ContainsKey(pieceTitle))
                        {
                            pieces.Add(pieceTitle, new Piece());
                            pieces[pieceTitle].Title = pieceTitle;
                            pieces[pieceTitle].Composer = composer;
                            pieces[pieceTitle].Key = key;
                            Console.WriteLine($"{pieceTitle} by {composer} in {key} added to the collection!");                            
                        }
                        else
                        {
                            Console.WriteLine($"{pieceTitle} is already in the collection!");
                        }
                        break;

                    case "Remove":

                        if (pieces.ContainsKey(pieceTitle))
                        {
                            Console.WriteLine($"Successfully removed {pieceTitle}!");
                            pieces.Remove(pieceTitle);
                        }
                        else 
                        {
                            Console.WriteLine($"Invalid operation! {pieceTitle} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string newKey = arguments[2];
                        
                        if (pieces.ContainsKey(pieceTitle))
                        {
                            pieces[pieceTitle].Key = newKey;
                            Console.WriteLine($"Changed the key of {pieceTitle} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceTitle} does not exist in the collection.");
                        }
                        break;
                }
            }

            foreach (Piece piece in pieces.Values)
            {
                Console.WriteLine($"{piece.Title} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        public class Piece
        {
            public string Title { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }
        }
    }
}
