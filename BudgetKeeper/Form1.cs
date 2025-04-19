using BudgetKeeper.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BudgetKeaper
{

    public partial class Form1 : Form
    {
        bool Slided = false;
        bool SlidedRadio = false;
        bool SetBudgetButton_Clicked = false;
        bool EditOrNull = false;
        bool EditAndNull = false;
        double Amount = 0;
      


        public Form1()
        {
            InitializeComponent();
        }



        private void SlideButtonClick(object sender, EventArgs e)
        {
            if (Slided == false)
            {
                contextMenuStrip1.Show(SliderButton, 0, 40);
                Slided = true;
            }
            else
            {
                contextMenuStrip1.Hide();
                Slided = false;
            }

            //This is the options button it was previous refered as "Slide"
        }


        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            SlideButtonClick(sender, e);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            SlideButtonClick(sender, e);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPanel.Show();
            panel1.Hide();
            panel2.Hide();
            SlideButtonClick(sender, e);
            SliderButton.Hide();
            CautionLabel.Text = "This process will REMOVE the prvious budget and let you make a new one.\r\nThis won't effect your purchase history";
            EditOrNull = false;
        }

        //The "Edit" and "Nullify" button use the same panel with th "no" button doing the samething, while the "yes" one uses a bool to check what it should do
        private void YesEditButtonClick(object sender, EventArgs e)
        {
            if (EditOrNull == false) 
            {
                BudgetTxtBox.Show();
                RadButDay.Show();
                RadButWeek.Show();
                RadButMonth.Show();
                PeriodButton.Show();
                SetBudgetButton.Show();
                MainBudgetLbl.Text = "Plese select a time period for your budget";
                informationToolStripMenuItem_Click(sender, e);
                SliderButton.Show();
                EditPanel.Hide();
                SetBudgetButton_Clicked = false;
                EditAndNull = true;
                ChangeColor(sender, e);

                //resets the "info" tab, but doesn't effect the HistoryList list
            }
            else if (EditOrNull == true)
            {
                BudgetTxtBox.Show();
                BudgetTxtBox.Clear();
                RadButDay.Show();
                RadButWeek.Show();
                RadButMonth.Show();
                PeriodButton.Show();
                SetBudgetButton.Show();
                MainBudgetLbl.Text = "Plese select a time period for your budget";
                informationToolStripMenuItem_Click(sender, e);
                SliderButton.Show();
                EditPanel.Hide();
                HistoryList.Clear();
                SetBudgetButton_Clicked = false;
                EditAndNull = true;
                ChangeColor(sender, e);

                //Brings the program to it's original state
            }

        }
        private void NoEditButtonClick(object sender, EventArgs e)
        {
            informationToolStripMenuItem_Click(sender, e);
            SliderButton.Show();
            EditPanel.Hide();
            EditOrNull = false;
        }

        private void nullifyProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrNull = true;
            EditPanel.Show();
            panel1.Hide();
            panel2.Hide();
            SlideButtonClick(sender, e);
            SliderButton.Hide();
            CautionLabel.Text = "This process will DELETE all saved data\r\nand return the program to it's orginal state";
        }


        private void PeriodButton_Click(object sender, EventArgs e)
        {
            if (SlidedRadio)
            {
                RadButDay.Enabled = false;
                RadButDay.Hide();
                RadButWeek.Enabled = false;
                RadButWeek.Hide();
                RadButMonth.Enabled = false;
                RadButMonth.Hide();

                SlidedRadio = false;
            }
            else
            {
                RadButDay.Enabled = true;
                RadButDay.Show();
                RadButWeek.Enabled = true;
                RadButWeek.Show();
                RadButMonth.Enabled = true;
                RadButMonth.Show();

                SlidedRadio = true;
            }
        }

        //The periods radio buttons currecntly don't have any other effect on anything other than "MainBudgetLbl", in the future a timer might be added conected to the choosen period of time


        private void BudgetTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (BudgetTxtBox.Text == "")
            {
                SetBudgetButton.Enabled = false;
            }
            else
            {
                SetBudgetButton.Enabled = true;
            }
        }

        private void BudgetTextBoxPress(object sender, KeyPressEventArgs e)
        {

            var regex = new Regex(@"[^0-9.\b]");
            char NumberOnly = e.KeyChar;
            //Let's user use only numbers from 0 to 9 when entering text in the TextBox

            if (BudgetTxtBox.SelectionStart == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

            }

            if (!Char.IsDigit(NumberOnly) && NumberOnly != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            BudgetTxtBox.Text = BudgetTxtBox.Text.TrimStart();

            if (BudgetTxtBox.Text.Contains("."))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }

            //The 3 ifs are so the user can use a single "." anywhere, but the start. This is for creating decimal numbers
        }

        private void SetBudgetButton_Click(object sender, EventArgs e)
        {

            Double BoxText = Double.Parse(BudgetTxtBox.Text);

            BoxText.ToString();

            Amount = BoxText;
            if (RadButDay.Checked)
            {
                MainBudgetLbl.Text = "Your budget for the day is " + Amount.ToString() + ".лв";
            }
            else if (RadButWeek.Checked)
            {
                MainBudgetLbl.Text = "Your budget for the week is " + Amount.ToString() + ".лв";
            }
            else
            {
                MainBudgetLbl.Text = "Your budget for the month is " + Amount.ToString() + ".лв";
            }

            BudgetTxtBox.Hide();
            RadButDay.Hide();
            RadButWeek.Hide();
            RadButMonth.Hide();
            PeriodButton.Hide();
            SetBudgetButton.Hide();

            //Once the button is clicked everything, but the MainBudgetLbl will be hided, to make them be seen again user will need to use the edit or null button to open a panel and click yes 

            ChangeColor(sender, e);

            SetBudgetButton_Clicked = true;
        }

        private void CostTxtBoxPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9.\b]");
            char NumberOnly = e.KeyChar;

            if (CostTxtBox.SelectionStart == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

            }

            if (!Char.IsDigit(NumberOnly) && NumberOnly != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (CostTxtBox.Text.Contains("."))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }

            //Same as previous TextBox
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BudgetTxtBox.Text) && string.IsNullOrEmpty(CostTxtBox.Text) &&
                string.IsNullOrEmpty(ItemNameBox.Text))
            {
                return;
            }

            //The if is there to prevent an error if the boxes are empty, them being empty gives an error when doing the math in the else

            else
            {
                double Y = double.Parse(CostTxtBox.Text);
                Amount = Amount - Y;
                Amount.ToString();
                HistoryList.Items.Add(ItemNameBox.Text + " " + Y.ToString() + ".лв");
                CostTxtBox.Clear();
                CostTxtBox.Focus();
                ItemNameBox.Clear();

                if (RadButDay.Checked)
                {
                    MainBudgetLbl.Text = "Your budget for the day is " + Amount.ToString() + ".лв";
                }
                else if (RadButWeek.Checked)
                {
                    MainBudgetLbl.Text = "Your budget for the week is " + Amount.ToString() + ".лв";
                }
                else
                {
                    MainBudgetLbl.Text = "Your budget for the month is " + Amount.ToString() + ".лв";
                }

                ChangeColor(sender, e);
            }
        }

        public void ChangeColor (object sender, EventArgs e)
        {
            if (Amount > 0 && SetBudgetButton.Visible == false)
            {
                MainBudgetLbl.ForeColor = Color.Green;
            }
            else if (Amount < 0 && SetBudgetButton.Visible == false)
            {
                MainBudgetLbl.ForeColor = Color.Red;
            }
            else if (Amount == 0 && SetBudgetButton.Visible == false)
            {
                MainBudgetLbl.ForeColor = Color.OrangeRed;
            }
            else
            {
                MainBudgetLbl.ForeColor = Color.Black;
            }

            //Simple flavour for user, using the "SetBudgetButton.Visible == false" makes sure the right color is used even when program is reopened or nullified
        }

        private void ItemBoxChanged(object sender, EventArgs e)
        {
            if (ItemNameBox.Text == "" || CostTxtBox.Text == "")
            {
                AddExpenseButton.Enabled = false;
            }
            else
            {
                AddExpenseButton.Enabled = true;
            }
        }

        private void CostTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemNameBox.Text == "" || CostTxtBox.Text == "")
            {
                AddExpenseButton.Enabled = false;
            }
            else
            {
                AddExpenseButton.Enabled = true;
            }
        }


        private void RadButDay_Click(object sender, EventArgs e)
        {
            MainBudgetLbl.Text = "Please write your budget for the day";
        }

        private void RadButWeel_Click(object sender, EventArgs e)
        {
            MainBudgetLbl.Text = "Please write your budget for the week";
        }

        private void RadButMonth_Click(object sender, EventArgs e)
        {
            MainBudgetLbl.Text = "Please write your budget for the month";  
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.MainBudgetS = MainBudgetLbl.Text;
            Settings.Default.Loss = Amount;
    

            if (SetBudgetButton.Visible == true)
            {
                Settings.Default.BigButton = false;
            }
            else
            {
                Settings.Default.BigButton = true;
            }

            if (HistoryList.Items != null)
            {
                Settings.Default.HistoryListS = Settings.Default.HistoryListS ?? new System.Collections.Specialized.StringCollection();
                //Without this line the program will give an error when closed, do to object not found or null. the line makes it reffer to an object

                foreach (ListViewItem item in HistoryList.Items)
                {
                    Settings.Default.HistoryListS.Add(item.Text);
                }


                Settings.Default.Save();

            }
            //When the program is closed this information is saved in the aplication settings database, the table for it can be found by view - solution explorer - Settings.Settings
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Amount = Settings.Default.Loss;
            MainBudgetLbl.Text = Settings.Default.MainBudgetS;



            if (Settings.Default.BigButton == true)
            {
                BudgetTxtBox.Hide();
                RadButDay.Hide();
                RadButWeek.Hide();
                RadButMonth.Hide();
                PeriodButton.Hide();
                SetBudgetButton.Hide();
            }

            if (Settings.Default.HistoryListS != null)
            {
                foreach (string item in Settings.Default.HistoryListS)
                {
                    HistoryList.Items.Add(item);
                }
                Settings.Default.HistoryListS.Clear();
            }

            ChangeColor(sender, e);

            //Pulls the saved information from Settings.settings and puts in where it copied it from + ChangeColor function to properly color 
        }
    }
}

//Program is not yet fully ready for use on diffrent screen and design/visual might not fit from device/srceen to device/screen!
