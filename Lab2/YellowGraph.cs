using System;
using System.Collections.Generic;

class YellowGraph : Graph {
   
   // List of nodes in this graph
   private List<Node> nodes;

   // An adjacency matrix, recording edges between nodes
   // Edge FROM node i to node j is recorded in adjMatrix[i,j]
   // Each int entry records the edge cost (> -1)
   // If entry is 0 there is no edge 
   private int[,] adjMatrix;

   public YellowGraph() {
      nodes = new List<Node>();
      //the arraylist of nodes
      adjMatrix = new int[0,0];
      //adjecency matrix
   }


   public void AddNode(Node n)
   {
      
      
   }


   public void AddEdge(Node n, Node m, int a)
   {
      
      
   }

   public int Cost(Node n, Node m)
   {
      return 1;

   }

   public List<Node> Neighbours(Node a) {
      return new List<Node>();
   }     
   
   
   public List<Node> Nodes() {
      return new List<Node>();
   }
   
   // ADD MISSING METHODS HERE



   public void Write() {
      Console.WriteLine("YellowGraph");

      for (int i = 0; i < nodes.Count; i++) {
         Console.Write(nodes[i] + ": ");

         bool first = true;
         for (int j = 0; j < nodes.Count; j++) {
            if (adjMatrix[i,j] > 0) {
               if (!first) Console.Write(", ");
               Console.Write(nodes[j] + "(" + adjMatrix[i,j] + ")");
               first = false;
            }
         }

         Console.Write("\n");
      }
   }
}