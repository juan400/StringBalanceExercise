using System.Collections.Generic;
using System.Linq;

namespace StringBalanceExercise
{
    public class Checkers
    {
        private static readonly char[] openingCharacters = { '{', '[', '(' };
        private static readonly char[] closureCharacters = { '}', ']', ')' };
        private Dictionary<char, char> charactersEquivalency = new Dictionary<char, char>();

        public Checkers()
        {
            charactersEquivalency.Add('{', '}');
            charactersEquivalency.Add('[', ']');
            charactersEquivalency.Add('(', ')');
        }

        public bool CheckBalance(string str)
        {
            var openings = new Stack<char>();
            foreach (var currentChar in str)
            {
                if (IsOpening(currentChar)) openings.Push(currentChar);

                if (IsClosing(currentChar) && openings.Count == 0)
                    return false;
                else if (IsClosing(currentChar) && !IsACorrectClosing(openings.Pop(), currentChar))
                    return false;
            }
            return openings.Count == 0;
        }

        private bool IsACorrectClosing(char openingChar, char closureChar)
        {
            return charactersEquivalency[openingChar] == closureChar;
        }

        private bool IsClosing(char c)
        {
            return closureCharacters.Contains(c);
        }

        private bool IsOpening(char c)
        {
            return openingCharacters.Contains(c);
        }
    }
}