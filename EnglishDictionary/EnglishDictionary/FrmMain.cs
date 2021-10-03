using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDictionary
{
    public partial class FrmMain : Form
    {
        BindingSource BS = new BindingSource();
        DataStoreJson SD = new DataStoreJson();
        string serchword;

        public FrmMain()
        {

            InitializeComponent();

            string fileName = "listwms_Listing_object.json";
            string jsonString = File.ReadAllText(fileName);
            List<DataSet> jwms = JsonSerializer.Deserialize<List<DataSet>>(jsonString);
            for (int i = jwms.Count - 1; i >= 0; i--)
            {
                List.Listing.Add(jwms[i]);
                // add the word amd all the Meanings that word has 
            }
            BS.DataSource = List.Listing;
            LbDictionaryData.DataSource = BS;
            LbDictionaryData.DisplayMember = "Dispaly";
            BS.ResetBindings(false);
            //// Load the existing data from the file
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            // setting the inputs to strings 
            string words = TxtWord.Text;
            string means = TxtMeaning.Text;
            string wordandmean = " Word is --> " + words + " See definitions --> " + "'" + means + "'"; 

            bool istherword = true; // cheking there's any inputs
            if (words == "" || means =="")
            {
                MessageBox.Show(" Please input the word", "NOTICE"); // if there's no inputs it will show a message
                TxtWord.Focus();
                TxtMeaning.Focus();
                istherword = false;
            }
            if(istherword == true)
            {
               
               DataSet wm = new DataSet();
               List.Listing.Add(new DataSet());
               for (int i = 0;  i < List.Listing.Count ; i++)  // Checking if the word already exists or not 
                {
                    if (((DataSet)List.Listing[i]).word == words) // if its exist it will show a message
                    {
                        MessageBox.Show(" The Word is already there ", "NOTICE "); 
                        
                       if (((DataSet)List.Listing[i]).meaning.Contains(means) == true) // Checking if the meaning already exists or not 
                        {
                        MessageBox.Show(" The Meaning is already there ", "NOTICE ");// if its exist it will show a message
                            break;

                       }
                       if (((DataSet)List.Listing[i]).meaning.Contains(means) == false)  
                       {
                         DialogResult K = MessageBox.Show("Do you like to add another meaning ?  ", "NOTICE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       if (K == DialogResult.Yes)// replacing the men=aning 
                            {

                                ((DataSet)List.Listing[i]).meaning.Add(means);
                                ((DataSet)List.Listing[i]).Dispaly = ((DataSet)List.Listing[i]).Dispaly + "*/*" + means + "*/*";

                            }
                            else if (K == DialogResult.No) 
                            {
                                DialogResult Ko = MessageBox.Show(" Do you like to replace the meaning ? ", "NOTICE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Ko == DialogResult.Yes) //ading a another meaning
                                {
                                    try
                                    {
                                        ((DataSet)List.Listing[i]).setmean(means);
                                    }
                                    catch (Exception)
                                    {
                                        int idx = ((DataSet)List.Listing[i]).meaning.IndexOf(means);
                                        ((DataSet)List.Listing[i]).meaning[idx] = means;

                                    }

                                }
                                else if (Ko == DialogResult.No)
                                {

                                }

                            }
                       }

                      break;
                    } // Adding the new word and the meaning 
                    if (((DataSet)List.Listing[i]).word == null && ((DataSet)List.Listing[i]).meaning == null)
                    {
                       ((DataSet)List.Listing[i]).word = words;
                       ((DataSet)List.Listing[i]).setmean(means);
                       ((DataSet)List.Listing[i]).Dispaly = wordandmean;
                        MessageBox.Show("The word and the meaning is successfully added ", "NOTICE");

                    }
                  
               }

              foreach (DataSet o in List.Listing)
              {
                    if(o.word == null)
                    {
                        List.Listing.Remove(o);
                        break;
                    }
              }
                      // show the word, meanings in the displaybox         
                LbDictionaryData.DisplayMember = "Dispaly";
                BS.ResetBindings(false);

            }

            

            // Check if the word already exists
            // If it exists, check if the meaning already exists
            // If the meaning already exists, replace it after confirmation
            // If the meaning doesn't exist, add it
            // If the word doesn't exist, add it
        }

        private void BtnFind_Click(object sender, EventArgs e)
        { 
           
       
            for (int i = List.Listing.Count - 1; i >= 0; i--) // Search for the matching words

            {
                LbDictionaryData.DataSource = null;
                if (((DataSet)List.Listing[i]).word == textBox1.Text)
                {
                    LbDictionaryData.Items.Clear();
                    LbDictionaryData.Items.Add(((DataSet)List.Listing[i]).Dispaly);// If there are results display them in the list box
                    serchword = ((DataSet)List.Listing[i]).word;
                    break;
                }
            }            
            BS.ResetBindings(false);
        }

        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
           
            // Ask for confirmation; Warn for unrecoverability
            DialogResult Ko = MessageBox.Show(" Do you like to Delete ?\n deleted datas cannot be recover \n press Yes to countine ", "NOTICE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ko == DialogResult.Yes)
            {
               try
               {
                 for (int i = List.Listing.Count - 1; i >= 0; i--)
                 {                               
                    if (((DataSet)List.Listing[i]).word == serchword)
                    {
                        List.Listing.RemoveAt(i);
                        LbDictionaryData.Items.Clear();
                    }      
                 }
               }
               catch (Exception)
               {
                    List.Listing.Remove((DataSet)LbDictionaryData.SelectedItem);
                    BS.ResetBindings(false);    
               }                 
            }
            else { }
        }

        private void BtnListAll_Click(object sender, EventArgs e)
        {

            BS.DataSource = List.Listing;
            LbDictionaryData.DataSource = BS;
            LbDictionaryData.DisplayMember = "Dispaly";
            BS.ResetBindings(false);
            List.Listing.Sort();

            // Iteratively populate the list box in the ascending order of words
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {

            DialogResult K = MessageBox.Show("DO YOU LIKE TO DELETE ALL ? ", "NOTICE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (K == DialogResult.Yes) // Ask for confirmation TWICE; Warn for unrecoverability
            {
                DialogResult X = MessageBox.Show(" ALL DATA WILL BE ERASED ? ", "NOTICE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)            // If confirmed delete the word
                {
                    List.Listing.Clear();
                    BS.ResetBindings(false);
                }
                else
                {

                }
            }
            else if (K == DialogResult.No)
            {

            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)// the timer is set for one minute
        {
            timer1.Start();
            SD.updatetextfile(); 
           MessageBox.Show("timer working", "word is set ");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // update when program is closing 
            SD.updatetextfile();
        }



        // Implement a timed task to automatically check if there are unsaved changes and save them if there are any
    }
}
