using System;
using System.Collections.Generic;
using System.Linq;

namespace ShakespeareAssignment.Sorters
{
    public class TrieSort : ISort<string>
    {
        private static Node root = null;
        private static List<string> sorted = new List<string>();

        public static string[] sort(string[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                insert(arr[i], i);
            }
            sort(root, arr);
            return sorted.ToArray();
        }

        private static void insert(string word, int index) {
            if(root == null)
                root = new Node();

            Node current = root;

            for(int i = 0; i < word.Length; i++) {
                char c = word[i];

                if(current.getChild(c) == null)
                    current.addChild(c);

                current = current.getChild(c);
            }

            current.addIndex(index);
        }
        
        private static void sort(Node node, string[] arr) {
            if(node == null)
                return;

            if(node.getIndices().Count > 0)
                foreach(int index in node.getIndices())
                    sorted.Add(arr[index]);

            for(char index = 'a'; index <= 'z'; index++)
                sort(node.getChild(index), arr);
        }

        private class Node {
            Dictionary<char, Node> children;
            List<int> indices;

            public Node() {
                children = new Dictionary<char, Node>();
                indices = new List<int>();
            }

            public Node getChild(char c) {
                return children.ContainsKey(c) ? children[c] : null;
            }

            public Node addChild(char c) {
                return children[c] = new Node();
            }

            public List<int> getIndices() 
            {
                return indices;
            }
    
            public void addIndex(int index)
            {
                indices.Add(index);
            }
        }
    }
}