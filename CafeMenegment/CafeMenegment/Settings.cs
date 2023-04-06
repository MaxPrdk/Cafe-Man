using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMenegment
{
    public partial class Settings : Form
    {
        Functions Con;
        public Settings()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billing guest = new Billing();
            guest.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {
               
                    int Pr = Convert.ToInt32(PriceTb.Text);
                
               
                if(ItemCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select an Item!");
                } else if(ItemCb.SelectedIndex == 0){
                    Key = "Cake";
                    string Query = "Update CafeTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);  
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!");
                }
                else if (ItemCb.SelectedIndex == 1)
                {
                    Key = "Cinnamon Bun";
                    string Query = "Update CafeTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!");
                }
                else if (ItemCb.SelectedIndex == 2)
                {
                    Key = "Coffe";
                    string Query = "Update CafeTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!");
                }
                else if (ItemCb.SelectedIndex == 3)
                {
                    Key = "Coffe with milk";
                    string Query = "Update CafeTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!");
                }
                else if (ItemCb.SelectedIndex == 4)
                {
                    Key = "Cookie";
                    string Query = "Update CafeTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!");
                }
                else if (ItemCb.SelectedIndex == 5)
                {
                    Key = "Salad";
                    string Query = "Update CafeTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!");
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void PriceTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
