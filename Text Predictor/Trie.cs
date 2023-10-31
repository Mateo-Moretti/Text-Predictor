using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Predictor
{
    public class Trie
    {
        private TrieNode root;

        public void AddWord(string word)
        {
            TrieNode current = root;

            foreach (char c in word)
            {
                if (!current.Children.ContainsKey(c))
                    current.Children[c] = new TrieNode(c);

                current = current.Children[c];
            }

            current.Frequency++;
        }
    }
}
