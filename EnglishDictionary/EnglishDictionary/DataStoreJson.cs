using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace EnglishDictionary
{
    class DataStoreJson
    {


        public void serializelisList()
        {
            string fileName = "listwms_Listing_object.json";
            string jsonString = JsonSerializer.Serialize(List.Listing);
            File.WriteAllText(fileName, jsonString);
        }

        public void cratetext()
        {
            string TxtjsonString = File.ReadAllText("listwms_Listing_object.json");
            //stremWriter wil save the file will avalable at folder Debug 
            List<DataSet> List = JsonSerializer.Deserialize<List<DataSet>>(TxtjsonString);

            //writing the every object seperatli
            using (StreamWriter ws = new StreamWriter(@"datafile.dat.Text"))
                foreach (DataSet o in List)
                {
                    string jsonString = JsonSerializer.Serialize(o);
                    ws.WriteLine(jsonString);
                }



        }


        public void updatetextfile() 
        {

            //serualizing the list
            serializelisList();

            //it Derislize the jsom file listwms_Listing_object.json
            string fileName = "listwms_Listing_object.json";
            string jsonString = File.ReadAllText(fileName);
            List<DataSet> jwms = JsonSerializer.Deserialize<List<DataSet>>(jsonString);

            
            //check the Derislize list with Exsisting list in the program
            foreach (DataSet o in List.Listing)
            {    
                if(jwms.Contains(o) == false)
                {
                    cratetext();
                    break;
                }
            }
            if(List.Listing.Count == 0)
            {
                using (StreamWriter ws = new StreamWriter(@"datafile.dat.Text"))
                    foreach (DataSet o in List.Listing)
                    {
                        string jsonString1 = JsonSerializer.Serialize(o);
                        ws.WriteLine(jsonString1);
                    }
            }
        }



    }
}
