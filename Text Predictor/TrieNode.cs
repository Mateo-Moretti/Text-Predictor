using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Predictor
{
    public class TrieNode
    {
        public char Value;
        public Dictionary<char, TrieNode> Children;
        public int Frequency;
        public bool EndOfWord;

        public TrieNode(char value)
        {
            this.Value = value;
            this.Children = new Dictionary<char, TrieNode>();
            this.Frequency = 0;
            this.EndOfWord = false;
        }

    }
}
