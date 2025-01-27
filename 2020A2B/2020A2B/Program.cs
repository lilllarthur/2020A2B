﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020A2B
{
    internal class Program
    {
        class Node : IComparable
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(char character, int frequency, Node left, Node right) 
            {
                Character = character;
                Frequency = frequency;
                left = null;
                right = null;
            }
            // 3 marks
            public int CompareTo(Object obj) 
            {
                return 1;
            }
        }
        class Huffman
        {
            private Node HT; // Huffman tree to create codes and decode text
            private Dictionary<char, string> D; // Dictionary to encode text
                                                // Constructor
            public Huffman(string S) 
            {
            
            }
            // 8 marks
            // Return the frequency of each character in the given text (invoked by Huffman)
            private int[] AnalyzeText(string S) 
            {
                int[] freqStorage = new int[53];
                for (int i = 0; i < S.Length; i++)
                {
                    if ((int)S[i] == 32)
                    {
                        freqStorage[52]++;
                    }
                    else
                    {
                        if ((int)S[i] >= 97)
                        {
                            freqStorage[(int)S[i] - 71]++;
                        }
                        else
                        {
                            freqStorage[(int)S[i] - 65]++;
                        }
                    }
                }
                return freqStorage;
            }
            // 16 marks
            // Build a Huffman tree based on the character frequencies greater than 0 (invoked by Huffman)
            private void Build(int[] F)
            {
                //PriorityQueue<Node> PQ; …
            }
            // 12 marks
            // Create the code of 0s and 1s for each character by traversing the Huffman tree (invoked by Huffman)
            // Store the codes in Dictionary D using the char as the key
            private void CreateCodes() 
            { 
            
            }
            // 8 marks
            // Encode the given text and return a string of 0s and 1s
            public string Encode(string S) 
            {
                return "";
            }
            // 8 marks
            // Decode the given string of 0s and 1s and return the original text
            public string Decode(string S) 
            {
                return "";
            }
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
