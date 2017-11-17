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
      
      nodes.Add(n);
          // adds a node to the arraylist
          
      int[,] tempMatrix = new int [adjMatrix.GetLength(0) +1 , adjMatrix.GetLength(1) + 1];
      
      
      for (int i = 0; i < adjMatrix.GetLength(0); i++)
      {
         for (int j = 0; j < adjMatrix.GetLength(1); j++)
         {
            tempMatrix[i, j] = adjMatrix[i, j];
         }
      }
      adjMatrix = tempMatrix;
      
      // increases the array to store the newly added node

      
 
   }


   public void AddEdge(Node n, Node m, int a)
   {
      
      int[,] newEdge = new int[adjMatrix.GetLength(0), adjMatrix.GetLength(1)];

      //if (a > 0)
      //{
         for (int i = 0; i < adjMatrix.GetLength(0); i++)
         {
            for (int j = 0; j < adjMatrix.GetLength(1); j++)
            {

                  adjMatrix[i, j] = a;
                 
            }
            
            
         }
         
         
         //newEdge.AddEdge(a);
         //  adjMatrix[indexA, indexB] = c;

      //}
      
   }


   public List<Node> Neighbours(Node a)
   {// checks the row in the matrix, if it is 0, add the node to neighbour list
      List<Node> neighbourList = new List<Node>();

      for (int i = 0; i < adjMatrix.GetLength(0); i++)
      {
         if (adjMatrix[a.Id, i] == 0)
         {
            foreach (Node n in nodes)
            {
               if (n.Id.Equals(i))
               {
                  neighbourList.Add(n);

               }
               
            }

         }

      }
// checks the columns
      for (int j = 0; j < adjMatrix.GetLength(1); j++)
      {
         if (adjMatrix[a.Id, j] == 0)
         {
            foreach (Node n in nodes)
            {
               if (n.Id.Equals(j))
               {
                  neighbourList.Add(n);

               }
               
            }

         }
         
      }

return neighbourList;

   }


   public int Cost(Node n, Node m)
   {
      
      
      return 1;

   }
   
   public List<Node> Nodes() {
      return nodes;
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