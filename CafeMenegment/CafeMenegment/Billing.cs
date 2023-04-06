using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMenegment
{
    public partial class Billing : Form
    {
        Functions Con;
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        public Billing()
        {
            Con = new Functions();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings price = new Settings();
            price.Show();
        }
        int Key = 0;
        int Price = 0;
        
        private void GetPrice(int Key)
        {
            string Cafe = "";
            if (Key == 1)
            {
                Cafe = "Coffe";
            } else if (Key == 2)
            {
                Cafe = "Coffe with milk";
            }
            else if (Key == 3)
            {
                Cafe = "Cinnamon Bun";
            }
            else if (Key == 4)
            {
                Cafe = "Coockie";
            }
            else if (Key == 5)
            {
                Cafe = "Salad";
            }
            else if (Key == 6)
            {
                Cafe = "Cake";
            }
            string Query = "select * from CafeTbl where Item = '{0}'";
            Query = string.Format(Query, Cafe);
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
           
        }
        string Items;
        int n = 0;
        double GrdTotal = 0;
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (CoffeBtn.Checked == true)
            {
                Key = 1;
                Items = "Coffe";
            } else if (CoffewithmilkBtn.Checked == true)
            {
                Key = 2;
                Items = "Coffe with milk";
            }
            else if (CinnamonbunBtn.Checked == true)
            {
                Key = 3;
                Items = "Cinnamon Bun";
            }
            else if (CoockieBtn.Checked == true)
            {
                Key = 4;
                Items = "Cockie";
            }
            else if (SaladBtn.Checked == true)
            {
                Key = 5;
                Items = "Salad";
            }
            else if (CakeBtn.Checked == true)
            {
                Key = 6;
                Items = "Cake";
            }

            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyTb.Text);
            int total = Qty * Price;
            
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;
            BillDGV.Rows.Add(newRow);
            n++;
            GrdTotal = GrdTotal + total;
            GrandTotalLbl.Text = "UAH " + GrdTotal;
        }

        
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CoffewithmilkBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CinnamonbunBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CoockieBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaladBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CakeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

     
        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void GrandTotalLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
