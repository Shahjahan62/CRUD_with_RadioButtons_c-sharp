using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
        
    {
        DataTable data = new DataTable();
        public Form1()
        {
            InitializeComponent();
            data.Columns.Add("Name");
            data.Columns.Add("RollNo");
            data.Columns.Add("CNIC");
            data.Columns.Add("Gender");
            data.Columns.Add("Skills");
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string roll = textBox2.Text;
            string cnic = textBox3.Text;
            string gender;
            if (radioButton1.Checked==true  )
            {
                gender = "male";
            }
            else
            {
                gender = "Female";
            }
            string skills="";
            if (checkBox1.Checked)
            {
                skills = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                skills = skills +" "+checkBox2.Text;

            }
            if (checkBox3.Checked){
                skills = skills + " " + checkBox3.Text;
            }

            DataRow row1 = data.NewRow();
            row1["Name"] = name;
            row1["RollNo"] = roll;
            row1["CNIC"] = cnic;
            row1["Gender"] = gender;
            row1["Skills"] = skills;

            data.Rows.Add(row1);
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in data.Rows)
            {
                if(row["RollNo"].ToString()==textBox2.Text)
                {
                    row["Name"] = textBox1.Text;
                    row["CNIC"] = textBox3.Text;
                    string gender;
                    if (radioButton1.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string skills =" ";
                    if (checkBox1.Checked)
                    {
                        skills = checkBox1.Text;
                    }
                    if(checkBox2.Checked)
                    {
                        skills = skills + "  " + checkBox2.Text;
                    }
                    if (checkBox3.Checked)
                    {
                        skills = skills + "  " + checkBox3.Text;
                    }

                    row["Gender"] = gender;
                    row["Skills"] = skills;

                    
                    break;
                }
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                foreach(DataRow row in data.Rows)
                {
                    data.Rows.Remove(row);
                    break;
                }
            }
        }
    }
}
