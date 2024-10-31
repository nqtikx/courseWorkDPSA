﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сursac.temerev.util;

namespace Сursac.temerev.model
{
    class MyHuffmanTree
    {
        public Node Root { get; set; }
        private List<Node> nodes = new List<Node>();
        public Dictionary<char, int> Frequencies;

        public MyHuffmanTree()
        {

        }

        public void setFrequencies(Dictionary<char, int> frequencies)
        {
            Frequencies = frequencies;
        }

        public void Build()
        {

            foreach (KeyValuePair<char, int> symbol in Frequencies)
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            while (nodes.Count > 1)
            {

                List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {
                    
                    List<Node> taken = orderedNodes.Take(2).ToList<Node>();
                    
                    Node parent = new Node()
                    {
                        Symbols = taken[0].Symbol.ToString() + taken[1].Symbol.ToString(),
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };
                    
                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }
                Root = nodes.FirstOrDefault();
            }
        }

        public Node GetRoot()
        {
            return Root;
        }
        public string[] Encode(string source, Dictionary<char, int> dict)
        {
            int countt = WorkerWithDictionary.CountSymbols(dict);
            List<bool> encodedSource = new List<bool>();

            string str = "";
            string[] massEachSymbol = new string[countt];


            int j = 0;
            int a = 0;


            foreach (KeyValuePair<char, int> keyValue in dict)
            {
                List<bool> encodedSymbol = Root.Traverse(keyValue.Key, new List<bool>());

                while (a != (encodedSymbol.Count))
                {
                    str += (encodedSymbol[a] ? "1" : "0");
                    a++;
                }

                massEachSymbol[j] = str;
                str = "";
                j++;
                a = 0;

                if (j > dict.Count) { break; };
            }
            return massEachSymbol;
        }


        public BitArray FullCode(string source)
        {
            List<bool> encodedSource = new List<bool>();

            for (int i = 0; i < source.Length; i++)
            {
                List<bool> encodedSymbol = Root.Traverse(source[i], new List<bool>());
                encodedSource.AddRange(encodedSymbol);
            }

            BitArray bits = new BitArray(encodedSource.ToArray());
            return bits;
        }

        public string Decode(BitArray bits)
        {
            Node current = Root;
            string decoded = "";

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = this.Root;
                }
            }

            return decoded;
        }

        public bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }
    }
}
