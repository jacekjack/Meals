using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Posilki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Meal();
        }
        int nKcal = 0;
        int nCarbonhydrates = 0;
        int nSugar = 0;
        int nSalt = 0;
        int nFat = 0;
        int nProtein = 0;
        string path = @"D:\Meals";
        string filepath = @"D:\Meals\data.txt";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Meal()
        {

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(filepath))
            {
                File.CreateText(filepath);

                FileStream meals = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter ml = new StreamWriter(meals);
                foreach (var Things in oThingsLists)
                {
                    ml.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} ",
                                 Things.Name, Things.Kcal, Things.Weight,
                                 Things.Carbohydrates, Things.Sugar, Things.Fat,
                                 Things.Salt, Things.Protein, Things.Cost);
                }
                ml.Close();

            }
        }
        public bool LoadMeal(string filepath)
        {
            int counter = 0;
            string line;
            if (File.Exists(filepath))
            {
                StreamReader buffor = new StreamReader(filepath);
                List<string> oTempList = new List<string>();
                while ((line = buffor.ReadLine()) != null)
                {
                    oTempList.Add(line);
                    counter++;
                }
                for (int x = 0; x < counter; x++)
                {
                    if (oTempList[x].Equals(
                        oThingsLists[x].Name + " " + oThingsLists[x].Kcal + " " + oThingsLists[x].Weight + " " +
                        oThingsLists[x].Carbohydrates + " " + oThingsLists[x].Sugar + " " + oThingsLists[x].Fat + " " +
                        oThingsLists[x].Salt + " " + oThingsLists[x].Protein + " " + oThingsLists[x].Cost + " "
                        )) Console.WriteLine(true);
                    else return false;
                }
                return true;


            }
            return false;
        }
        public void AddMeal(string name)        // creating file and adding list to it
        {

            if (File.Exists(filepath))     
            {
                FileStream meals = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter ml = new StreamWriter(meals);

                var oSelectedThings = from Things oThings in oThingsLists
                                      where oThings.Name == name
                                      select oThings;

                foreach (var Things in oSelectedThings)
                {
                    ml.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} ",
                                 Things.Name, Things.Kcal, Things.Weight,
                                 Things.Carbohydrates, Things.Sugar, Things.Fat,
                                 Things.Salt, Things.Protein, Things.Cost);
                }
                ml.Close();
            }
            else
            {
                File.CreateText(filepath);

                FileStream meals = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter ml = new StreamWriter(meals);  
                foreach (var Things in oThingsLists)
                {
                    ml.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} ",
                                 Things.Name, Things.Kcal, Things.Weight,
                                 Things.Carbohydrates, Things.Sugar, Things.Fat,
                                 Things.Salt, Things.Protein, Things.Cost);
                }
                ml.Close();
            }
        }

        List<Things> oThingsLists = new List<Things>()
        {
            new Things("Rice", 365, 100, 80, 0, 1, 1, 7 , 70),
            new Things("Potatoes", 77, 100, 17, 0, 0, 1, 2 , 20),
            new Things("Groats", 123, 100, 28, 0, 0, 1, 2 , 100),
            new Things("Pasta", 163, 100, 30, 0, 1, 1, 6 , 150),
            new Things("Bread", 238, 100, 50, 0, 1, 1, 6 , 60),
            new Things("Cheese", 352, 100, 0, 0, 28, 1, 25 , 200),
            new Things("Cola", 38, 100, 10, 9, 1, 1, 7 , 40),
            new Things("Apple", 52, 100, 14, 10, 1, 1, 0 , 30),
            new Things("Chips", 311, 100, 41, 0, 1, 15, 3, 60),
            new Things("Chicken Breast Fry", 239, 100, 0, 0, 15, 8, 25 , 200),
            new Things("Chicken Breast Boiled", 151, 100, 0, 0, 2, 1, 33 , 180),
            new Things("Carrot", 41, 100, 10, 0, 1, 1, 1, 30),
            new Things("Ham", 145, 100, 2, 0, 6, 2, 21, 200),
            new Things("Egg", 150, 100, 1, 0, 11, 1, 13 , 400),
            new Things("Oil", 84, 10, 0, 0, 10, 0, 0 , 5),
            new Things("Bun", 310, 100, 52, 0, 6, 1, 11 , 140),
            new Things("Margarine", 71, 10, 0, 0, 8, 1, 0 , 20),
            new Things("Pork Chop", 120, 100, 0, 0, 4, 1, 21 , 70),
            new Things("Apple juice", 45, 100, 11, 10, 1, 1, 0 , 30),
            new Things("Yoghourt", 58, 100, 4, 3, 1, 1, 10 , 70),
            new Things("Cookie", 500, 100, 65, 15, 24, 1, 6 , 70),
            new Things("Soup", 42, 100, 3, 0, 1, 1, 2 , 70)
        };

        private void button1_Click(object sender, EventArgs e)
        {
            
                
                if (comboBox1.SelectedItem != null)
                {
                    AmountError.Clear();

                        var oSelectedThings = from Things oThings in oThingsLists
                                              where oThings.Name == (string)comboBox1.SelectedItem
                                              select oThings;

                       
                          for (int i = 0; i < numericAmount.Value ; i++)
                            {
                               foreach (var Things in oSelectedThings)
                                {
                                    listBox1.Items.Add(Things.Name);
                                    nKcal += Things.Kcal;
                                    Kcal.Text = nKcal.ToString();
                                    nSalt += Things.Salt;
                                    Salt.Text = nSalt.ToString();
                                    nFat += Things.Fat;
                                    Fat.Text = nFat.ToString();
                                    nCarbonhydrates += Things.Carbohydrates;
                                    Carbohydrates.Text = nCarbonhydrates.ToString();
                                    nProtein += Things.Protein;
                                    Protein.Text = nProtein.ToString();
                                    nSugar += Things.Sugar;
                                    Sugar.Text = nSugar.ToString();
                                    if (nKcal <= progressBar1.Maximum)
                                        progressBar1.Value = nKcal;
                                    else progressBar1.Value = progressBar1.Maximum;

                                }
                            }
                }
                else AmountError.SetError(comboBox1, "Not selected");

            
        }

        

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (listBox1.Items != null)
            {
                AmountError.Clear();

                var oSelectedThings = from Things oThings in oThingsLists
                                      where oThings.Name == (string)listBox1.SelectedItem
                                      select oThings;

                if (listBox1.SelectedItem != null)
                {
                    AmountError.Clear();
                    foreach (var Things in oSelectedThings)
                    {
                        listBox1.Items.Remove(Things.Name);
                        nKcal -= Things.Kcal;
                        Kcal.Text = nKcal.ToString();
                        nSalt -= Things.Salt;
                        Salt.Text = nSalt.ToString();
                        nFat -= Things.Fat;
                        Fat.Text = nFat.ToString();
                        nCarbonhydrates -= Things.Carbohydrates;
                        Carbohydrates.Text = nCarbonhydrates.ToString();
                        nProtein -= Things.Protein;
                        Protein.Text = nProtein.ToString();
                        nSugar -= Things.Sugar;
                        Sugar.Text = nSugar.ToString();
                        if (nKcal <= progressBar1.Maximum)
                            progressBar1.Value = nKcal;
                        else progressBar1.Value = progressBar1.Maximum;

                    }
                }
                else AmountError.SetError(button2, "Not selected");
            }
            else AmountError.SetError(listBox1, "Empty list");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!oThingsLists.Exists(Things => Things.Name.Equals(inputName.Text)))
            {
                AmountError.Clear();
                if (inputName.Text != null)
                {
                    oThingsLists.Add(new Things(inputName.Text, (int)numericKcal.Value
                                                , (int)numericWeight.Value, (int)numericCarbohydrates.Value, (int)numericSugar.Value
                                                , (int)numericFat.Value, (int)numericSalt.Value, (int)numericProtein.Value
                                                , (int)numericCost.Value));
                    comboBox1.Items.Add(inputName.Text);
                }
                else AmountError.SetError(button3, "Empty name!");
            }
            else AmountError.SetError(button3, "There is that thing already!");
            AddMeal(inputName.Text);
        }

        private void staticKcal_Click(object sender, EventArgs e)
        {

        }
    }
}

