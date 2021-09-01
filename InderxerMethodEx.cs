using System;

namespace IndexerMethodDemo
{
    public class IndexerNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;
        public IndexerNames()
        {
            for(int i=0;i<size;i++)
            {
                namelist[i] = "N/A";
            }
        }
        public string this[int index]
        {
            get
            {
                string temp;
                if(index>=0 && index <= size-1)
                {
                    temp = namelist[index];
                }
                else
                {
                    temp = " ";
                }
                return temp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
    }
    class InderxerMethodEx
    {
        static void Main(string[] args)
        {
            IndexerNames names = new IndexerNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            for (int i = 0; i < IndexerNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
