using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseWork
{
  
    struct NodeStruct
    {
        public int ID;
        public List<int> Childs;

        public NodeStruct(int ID, List<int> Childs)
        {
            this.ID = ID;
            this.Childs = new List<int>();
            if (Childs != null)
                for (int i = 0; i < Childs.Count; i++)
                    this.Childs.Add(Childs[i]);
        }
    }

    class Data
    {
       
        private List<NodeStruct> treeData;

        public Data(StreamReader stream)
        {
           
            treeData = new List<NodeStruct>();

            try
            {
                using (stream)
                {
                    string line;
                    int c = 0;
                    treeData.Clear();
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] lineParams = line.Split(' ');
                        List<int> childs = new List<int>();

                        for (int i = 0; i < lineParams.Count(); i++)
                            if (lineParams[i] == "1" && i != c)   
                                childs.Add(i);
                        NodeStruct treeBranch = new NodeStruct(Convert.ToInt32(c), childs);
                        treeData.Add(treeBranch);
                        c++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        
        public List<NodeStruct> GetTreeData
        {
            get { return treeData; }
        }
    }
}
