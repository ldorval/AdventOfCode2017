using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day3
{
    public class Day3Part2
    {
        private readonly long input;
        private List<Square> squares;

        public Day3Part2(long input)
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
            currentSquare.Number = GetAdjacentSum(currentSquare);

            squares.Add(currentSquare.Clone());

            for (var i = 1; i <= currentSquareSize - 2; i++)
            {
                currentSquare.Y += 1;
                currentSquare.Number = GetAdjacentSum(currentSquare);
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private Square SecondLine(Square currentSquare, int currentSquareSize)
        {
            for (var i = 1; i <= currentSquareSize - 1; i++)
            {
                currentSquare.X -= 1;
                currentSquare.Number = GetAdjacentSum(currentSquare);
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private Square ThirdLine(Square currentSquare, int currentSquareSize)
        {
            for (var i = 1; i <= currentSquareSize - 1; i++)
            {
                currentSquare.Y -= 1;
                currentSquare.Number = GetAdjacentSum(currentSquare);
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private Square FourthLine(Square currentSquare, int currentSquareSize)
        {
            for (var i = 1; i <= currentSquareSize - 1; i++)
            {
                currentSquare.X += 1;
                currentSquare.Number = GetAdjacentSum(currentSquare);
                squares.Add(currentSquare.Clone());
            }

            return currentSquare;
        }

        private long GetAdjacentSum(Square currentSquare)
        {
            var adjacentSquares = new List<Square>();

            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X - 1 && s.Y == currentSquare.Y + 1));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X && s.Y == currentSquare.Y + 1));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X + 1 && s.Y == currentSquare.Y + 1));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X - 1 && s.Y == currentSquare.Y));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X - 1 && s.Y == currentSquare.Y - 1));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X && s.Y == currentSquare.Y - 1));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X + 1 && s.Y == currentSquare.Y - 1));
            adjacentSquares.Add(squares.FirstOrDefault(s => s.X == currentSquare.X + 1 && s.Y == currentSquare.Y));

            return adjacentSquares
                .FindAll(s => s != null)
                .Sum(s => s.Number);
        }

        public long GetSolution()
        {
            var square = squares.First(s => s.Number > input);
            return square.Number;
        }
    }
}