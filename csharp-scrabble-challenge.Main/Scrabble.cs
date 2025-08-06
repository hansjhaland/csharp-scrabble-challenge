using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        string _word;

        public Scrabble(string word)
        {       
            _word = word;
        }

        public bool containsWhiteSpace(string word)
        {
            if (word.Contains("\n")) { return true; }
            if (word.Contains("\r")) { return true; }
            if (word.Contains("\t")) { return true; }
            if (word.Contains("\b")) { return true; }
            if (word.Contains("\f")) { return true; }
            return false;
        }

        public bool containsDigit(string word)
        {
            return word.Any(Char.IsDigit);
        }

        public bool isInvalidBracket(string word)
        {
            int numOpenSquare = 0;
            int numCloseSquare = 0;
            int numOpenCurly = 0;
            int numCloseCurly = 0;

            foreach (char c in word)
            {
                if (c == '[')
                {
                    numOpenSquare++;
                }
                if (c == ']')
                {
                    numCloseSquare++;
                    if (numCloseSquare > numOpenSquare)
                    {
                        return true;
                    }
                }
                if (c == '{') { 
                    numOpenCurly++;
                }
                if (c == '}') {
                    numCloseCurly++;
                    if (numCloseCurly > numOpenCurly)
                    {
                        return true;
                    }
                }
            }
            if (numOpenCurly != numCloseCurly)
            {
                return false;
            }
            if (numOpenSquare != numCloseSquare)
            {
                return false;
            }
            return false;
        }

        public int calcWordMultiplier(string upperCaseWord)
        {
            if (upperCaseWord[0] == '{' && upperCaseWord.Last() == '}')
            {
                foreach (char c in upperCaseWord)
                {

                }
                return 2;
            }
                if (upperCaseWord[0] == '[' && upperCaseWord.Last() == ']')
            {
                return 3;
            }
            return 1;
        }

        public int score()
        {

            if (String.IsNullOrWhiteSpace(_word)) { return 0; }
            // Method above did not catch all cases
            if (containsWhiteSpace(_word)) { return 0; }
            if (containsDigit(_word)) { return 0; }
            if (isInvalidBracket(_word)) { return 0; }

            Points points = new Points();

            int score = 0;

            // Match upper case letters in point dictionary
            string upperCaseWord = _word.ToUpper();


            int inSquareBracket = 0;
            int inCurlyBracket = 0;

            for (int i = 0; i<upperCaseWord.Length; i++)
            {

                if (upperCaseWord[i] == '[')
                {
                    inSquareBracket = 1;
                    continue;
                }
                if (upperCaseWord[i] == '{')
                {
                    inCurlyBracket = 1;
                    continue;
                }
                if (upperCaseWord[i] == ']')
                {
                    inSquareBracket = 0;
                    continue;
                }
                if (upperCaseWord[i] == '}')
                {
                    inCurlyBracket = 0;
                    continue;
                }

                char currentLetter = upperCaseWord[i];

                int multiplier = 1;
                if (inCurlyBracket == 1 && inSquareBracket == 1)
                {
                    multiplier = 6;
                }
                else if (inCurlyBracket == 1)
                {
                    multiplier = 2;
                }
                else if (inSquareBracket == 1)
                {
                    multiplier = 3;
                }

                score += points.PointsDict[currentLetter.ToString()] * multiplier;

            }

            return score;
        }
    }
}
