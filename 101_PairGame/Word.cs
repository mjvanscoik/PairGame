using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_PairGame
{
    public class Word
    {
        public Word(string wordName, string letterLength, int pointValue) 
        {
            WordName = wordName;
            LetterLength = letterLength;
            PointValue = pointValue;
            
        }
        public string WordName { get; set; }
        public string LetterLength { get; set; }
        public int PointValue { get; set; }
        public char[] CharArray
        {
            get
            {
                char[] WordNameArray = WordName.ToCharArray();
                return WordNameArray;
            }
            
        }

    }
}

