using System;
using System.Collections.Generic;
using System.Linq;
namespace mpst
{
    class MST
    {
        int vx;
        int[] pt;
        int[] minimumValue;
        bool[] checker;
        bool[] isisVisitedOrNotOrNot;
        public MST(int vx)
        {
            this.vx = vx;
            this.pt = new int[vx];
            this.minimumValue =new int [vx];
            this.checker = new bool[vx];
            this.isisVisitedOrNotOrNot = new bool[vx];
            for (int counter = 0; counter < vx; counter++)
            {
                minimumValue[counter] = 99999999;
                checker[counter] = false;
            }
            minimumValue[0] = 0;
            pt[0] = -1;
            
        }

        int minidx()
        {
            int MW = 999999;
            int idx= 0;
            for (int counter = 0; counter < vx; counter++)
            {
                if(checker[counter]==false&&minimumValue[counter]<MW)
                {
                    MW = minimumValue[counter];
                    idx= counter;
                }
            }
            return idx;
        }
        public int minimumSpannigTree(int[,] g)
        {
            int poh = 0;
            for (int counter = 0; counter < vx-1; counter++)
            {
                int idx= minidx();
                checker[idx] = true;
                for (int counter2 = 0; counter2 < vx; counter2++)
                {
                    if(g[idx,counter2]>-1&&checker[counter2]==false&&g[idx,counter2]<minimumValue[counter2])
                    {
                        minimumValue[counter2] =g[idx, counter2];
                        pt[counter2] = idx;
                    }
                }
            }
          
            
                for (int counter = 1; counter < vx; counter++)
                {
                    poh += g[counter, pt[counter]];

                }
                return poh;
          
            
        }
        public bool depthfirstsearch(int[,]graph)
        {
            int s = 0;
           
            Stack<int> stack = new Stack<int>();
            stack.Push(s);
            while (stack.Count!=0)
            {
                s = stack.Pop();
               
                isisVisitedOrNotOrNot[s] = true;
                for (int counter = 0; counter < vx; counter++)
                {   
                    if(isisVisitedOrNotOrNot[counter]==false&&graph[s,counter]>-1)
                    {
                        stack.Push(counter);
                    }
                }



            }
            if (isisVisitedOrNotOrNot.Any(x => x == false))
                return false;
            else
                return true;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            string[] inputs = Console.ReadLine().Split(' ');
            int counter = 0;
            int numberVx = int.Parse(inputs[0]);
            int edge = int.Parse(inputs[1]);
            int numberBuilt = int.Parse(inputs[2]);
            int[,] matrix_adj =new  int[numberVx,numberVx];
            for (int counter1 = 0; counter1 < numberVx; counter1++)
            {
                for (int counter2 = 0; counter2 <numberVx; counter2++)
                {

                 
                        matrix_adj[counter1, counter2] = -1;
                }
            }
            for (int counter1 = 0; counter1 < edge; counter1++)
            {
                string[] poin = Console.ReadLine().Split(' ');
                    int idx1 = int.Parse(poin[0]);
                    int idx2 = int.Parse(poin[1]);
                    int cost = int.Parse(poin[2]);
                matrix_adj[idx1-1, idx2-1] = cost;
                matrix_adj[idx2-1, idx1-1] = cost;
                counter += 2;
                   
            }
            for (int counter1 = 0; counter1 < numberBuilt; counter1++)
            {
                string[] poin = Console.ReadLine().Split(' ');
                int idx1 = int.Parse(poin[0]);
                int idx2 = int.Parse(poin[1]);
                matrix_adj[idx1-1, idx2-1] = 0;
                matrix_adj[idx2 - 1, idx1 - 1] = 0;
                counter++;
            }
           
            MST pro = new MST(numberVx);
            if (pro.depthfirstsearch(matrix_adj))
            {
                Console.WriteLine(pro.minimumSpannigTree(matrix_adj));
            }
            else
            {
                Console.WriteLine(-1);

            }

        }
      
    }
}

//class MST:
//    vertex = 0
//    parent= []
//    value_min = []
//    ismsp = []
//    visited = []
//    def __init__(self,vertex):
//        self.vertex = vertex
//        self.parent = [None for i in range(vertex)]
//        self.value_min =[None for i in range(vertex)]
//        self.ismsp = [None for i in range(vertex)]
//        self.visited = [False for i in range(vertex)]
//        for i in range(vertex):
//            self.value_min[i] = 999999999
//            self.ismsp[i] = False
//        self.value_min[0] = 0
//    def GetmeMinimumWeightiIndex(self):
//        minimumWeight = 9999999999.0
//        index = 0
//        for i in range(self.vertex):
//            if(self.ismsp[i]==False and self.value_min[i]<minimumWeight):
//                minimumWeight = self.value_min[i]
//                index = i
//        return index
//    def mst(self,maingraph):
//        p = 0
//        for i in range(self.vertex - 1):
//            index = self.GetmeMinimumWeightiIndex()
//            self.ismsp[index] = True
//            for j in range(self.vertex):
//                if(maingraph[index][j]>-1 and self.ismsp[j]==False and maingraph[index][j]<self.value_min[j]):
//                    self.value_min[j] =maingraph[index][j]
//                    self.parent[j] = index
//            for i in range(1,self.vertex):
//                if self.parent[i] != None:
//                    p += maingraph[i][self.parent[i]]
//            return p
//    def dfs(self,graph):
//        s = 0
//        st = []
//        st.append(s)
//        while (st):
//            s = st.pop()
//            self.visited[s] = True
//            for i in range(self.vertex):
//                if(self.visited[i]==False and graph[s][i]>-1):
//                    st.append(i)
//        for i in self.visited:
//            if i == False:
//                return False
//        else:
//            return True
//maininput = input().split()
//counter = 0
//num_vertex = int(maininput[0])
//edge = int(maininput[1])
//num_built = int(maininput[2])
//matrix_adj =[[None for i in range(num_vertex)]for j in range(num_vertex)]
//for i in range(num_vertex):
//    for j in range(num_vertex):     
//            matrix_adj[i][j] = -1
//for i in range(edge):
//    poin = input().split()
//    index1 = int(poin[0])
//    index2 = int(poin[1])
//    cost = int(poin[2])
//    matrix_adj[index1-1][index2-1] = cost
//    matrix_adj[index2-1][index1-1] = cost
//    counter += 2
//for i in range(num_built):
//    poin = input().split()
//    index1 = int(poin[0])
//    index2 = int(poin[1])
//    matrix_adj[index1-1][index2-1] = 0
//    matrix_adj[index2 - 1][index1 - 1] = 0
//    counter+=1
//pro =MST(num_vertex)
//if(pro.dfs(matrix_adj)):
//    print(pro.mst(matrix_adj))
//else:
//    print(-1)     