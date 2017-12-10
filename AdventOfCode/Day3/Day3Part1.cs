using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day3Part1
    {
        private readonly long input;
        private List<Square> squares;

        public Day3Part1(long input)
        {
            this.input = input;
            squares = new List<Square>();
            
            var currentSquare = new Square {X = 0, Y = 0, Number = 1};
            squares.Add(currentSquare.Clone());
            var currentSquareSize = 3;

            while (currentSquare.Number <= input)
            {
                currentSquare = FirstLine(currentSquare, currentSquareSize);
                currentSquare = SecondLine(currentSquare, currentSquareSize);
                currentSquare = ThirdLine(currentSquare, currentSquareSize);
                currentSquare = FourthLine(currentSquare, currentSquareSize);

                currentSquareSize += 2;
            }
        }

        private Square FirstLine(Square currentSquare, int currentSquareSize)
        {
            currentSquare.X += 1;
            currentSquare.Number += 1;
            squares.Add(currentSquare.Clone());
            
            for (var i = 1; i <= currentSquareSize - 2; i++)
            {
                currentSquare.Y += 1;
                currentSquare.Number += 1;
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private Square SecondLine(Square currentSquare, int currentSquareSize)
        {
            for (var i = 1; i <= currentSquareSize - 1; i++)
            {
                currentSquare.X -= 1;
                currentSquare.Number += 1;
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private Square ThirdLine(Square currentSquare, int currentSquareSize)
        {
            for (var i = 1; i <= currentSquareSize - 1; i++)
            {
                currentSquare.Y -= 1;
                currentSquare.Number += 1;
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private Square FourthLine(Square currentSquare, int currentSquareSize)
        {
            for (var i = 1; i <= currentSquareSize - 1; i++)
            {
                currentSquare.X += 1;
                currentSquare.Number += 1;
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }


        public int GetSteps()
        {
            var square = squares.First(s => s.Number == input);
            return Math.Abs(square.X) + Math.Abs(square.Y);
        }
    }
}