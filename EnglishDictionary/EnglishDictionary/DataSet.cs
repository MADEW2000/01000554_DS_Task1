using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishDictionary
{
    class DataSet : IComparable
    {//setting the inputs to the word,mening
     public   string word { get; set; }

     public   List<string> meaning { get; set; }

    public void setmean(string mean) 
        {
         if(meaning == null)
            {
                meaning = new List<string> { mean };

            }
        
        }


        public int CompareTo(object obj) // store the Datas in alphabet order
        {
            DataSet wms = (DataSet)obj;
            return word.CompareTo(wms.word);

            //throw new NotImplementedException();
        }

        public  string Dispaly { get; set; } // Display the meanings


    }
}
