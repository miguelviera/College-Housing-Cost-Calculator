using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Cost_Calculator
{
    // Declaring dorm stucture 
    struct Dorm
    {
        public string dormName;
        public int dormCost;
    }

    // Declaring meal structure
    struct Meal
    {
        public string mealName;
        public int mealCost;
    }

    public partial class Form1 : Form
    {
        // Global lists to store data from the text files
        List<Dorm> dormList = new List<Dorm>();
        List<Meal> mealList = new List<Meal>();

        public Form1()
        {
            InitializeComponent();
        }

        // Method to read the dorm text file
        private void ReadDormFile()
        {
            // Open the Dorms.txt text file and store data in an array
            string[] dormDataFile = File.ReadAllLines("Dorms.txt");
            Dorm dormItem = new Dorm();

            // Read the file till End of Stream
            for (int i = 0; i < dormDataFile.Length - 1; i += 2)
            {
                dormItem.dormName = dormDataFile[i];
                dormItem.dormCost = Convert.ToInt32(dormDataFile[i + 1]);
                dormList.Add(dormItem);
            }
        }

        // Method to read the meal plans text file
        private void ReadMealPlanFile()
        {
            // Open the MealPlans.txt text file and store data in an array
            string[] mealDataFile = File.ReadAllLines("MealPlans.txt");
            Meal mealPlanItem = new Meal();

            // Read the file till End of Stream
            for (int i = 0; i < mealDataFile.Length - 1; i += 2)
            {
                mealPlanItem.mealName = mealDataFile[i];
                mealPlanItem.mealCost = Convert.ToInt32(mealDataFile[i + 1]);
                mealList.Add(mealPlanItem);
            }
        }

        // Method to populate listboxes with data stored in lists
        private void DisplayLists()
        {
            // Loop to add dorm names items into dormListBox
            foreach (Dorm dorm in dormList)
            {
                dormListBox.Items.Add((string)dorm.dormName + " $" + (int)dorm.dormCost);
            }

            // Loop to add meal names into mealListBox
            foreach (Meal meal in mealList)
            {
                mealListBox.Items.Add((string)meal.mealName + " $" + (int)meal.mealCost);
            }

        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declaring variables to store the index of the selected items 
            int dormIndex = dormListBox.SelectedIndex;
            int mealIndex = mealListBox.SelectedIndex;

            // Declaring new form
            ResultForm resForm = new ResultForm();

            // Variable to hold the total cost of the selected plans 
            int total;

            // Using try and catch in case an error occurs 
            try
            {
                if (dormListBox.SelectedIndex == -1 && mealListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Dorm and a Meal Plan!");

                }
                else if (dormListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Dorm!");

                }
                else if (mealListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Meal Plan!");

                }
                else
                {
                    // Displaying the selected dorm, and cost
                    resForm.dormPlanTextbox.Text = dormList[dormIndex].dormName;
                    resForm.dormCostTextbox.Text = dormList[dormIndex].dormCost.ToString("c");

                    // Displaying the meal plan, and cost
                    resForm.mealPlanTextbox.Text = mealList[mealIndex].mealName;
                    resForm.mealCostTextbox.Text = mealList[mealIndex].mealCost.ToString("c");

                    // Calculating the final cost adding the dorm cost and the meal cost
                    total = dormList[dormIndex].dormCost + mealList[mealIndex].mealCost;

                    // Displays total in the textbox of the result form
                    resForm.totalCostTextbox.Text = total.ToString("c");

                    //Displaying result form
                    resForm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Calling the methods 
            ReadDormFile();
            ReadMealPlanFile();
            DisplayLists();
        }

        // Closing program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
