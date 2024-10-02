using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acitivity5
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;

            string middlename = textBox2.Text;
            string lastname = textBox3.Text;
            string address = textBox4.Text;
            string old = richTextBox1.Text;
            Boolean status1 = radioButton3.Checked;
            Boolean status2 = radioButton4.Checked;
            Boolean status3 = radioButton5.Checked;
            Boolean status4 = radioButton7.Checked;
            Boolean status5 = radioButton6.Checked;
            Boolean gender1 = radioButton1.Checked;
            Boolean gender2 = radioButton2.Checked;
            Boolean hobbies1 = checkBox1.Checked;
            Boolean hobbies2 = Reading.Checked;
            Boolean hobbies3 = checkBox3.Checked;
            Boolean hobbies4 = checkBox4.Checked;
            Boolean hobbies5 = checkBox5.Checked;
            Boolean hobbies6 = checkBox6.Checked;
            Boolean hobbies7 = checkBox7.Checked;
            Boolean hobbies8 = checkBox8.Checked;
            Boolean hobbies9 = checkBox9.Checked;
            Boolean hobbies10 = checkBox10.Checked;
            string course = listBox1.Text;
            string month = comboBox1.Text;
            string day = comboBox3.Text;
            string year = comboBox4.Text;
            string hobbies = "";
            string gender = "";
            string status = "";





            if (status1)
            {
                status = "Single";
            }
            else if (status2)
            {
                status = "In a Relationship";
            }
            else if (status3)
            {
                status = "Engaged";
            }
            else if (status4)
            {
                status = "Married";
            }
            else if (status5)
            {
                status = "Divorced";
            }

            if (gender1)
            {
                gender = "Male";
            }
            else if (gender2)
            {
                gender = "Female";
            }


            if (hobbies1)
            {
                hobbies += "Singing, ";

            }
            if (hobbies2)
            {
                hobbies += "Fishing, ";

            }
            if (hobbies3)
            {
                hobbies += "Cooking or Baking, ";

            }
            if (hobbies4)
            {
                hobbies += "Traveling, ";

            }
            if (hobbies5)
            {
                hobbies += "Photography, ";

            }
            if (hobbies6)
            {
                hobbies += "Cycling, ";

            }
            if (hobbies7)
            {
                hobbies += "Playing Music, ";

            }
            if (hobbies8)
            {
                hobbies += "Astrophotography  ";

            }
            if (hobbies9)
            {
                hobbies += "Crafting, ";

            }
            if (hobbies10)
            {
                hobbies += "Fitness or Sports, ";

            }

            if (progressBar1.Value < 9)
            {
                MessageBox.Show("Please Fill Out the Form");
            }
            else
            {

                richTextBox1.Text = old + firstname + " " + lastname + " " + middlename + " / " + address + " / " + status + " / " + gender + " / " + course + " / " + month + " " + day + ", " + year + " / " + hobbies + "\n";

                progressBar1.Value = 0;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                listBox1.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                checkBox1.Checked = false;
                Reading.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;

            }


        }

        private void UpdateProgressBar()
        {
            Boolean firstnmeron = !string.IsNullOrWhiteSpace(textBox1.Text);
            Boolean middlenmeron = !string.IsNullOrWhiteSpace(textBox2.Text);
            Boolean lastnmeron = !string.IsNullOrWhiteSpace(textBox3.Text);
            Boolean addressmeron = !string.IsNullOrWhiteSpace(textBox4.Text);
            Boolean course = !string.IsNullOrWhiteSpace(listBox1.Text);
            Boolean month = !string.IsNullOrWhiteSpace(comboBox1.Text);
            Boolean day = !string.IsNullOrWhiteSpace(comboBox3.Text);
            Boolean year = !string.IsNullOrWhiteSpace(comboBox4.Text);
            Boolean status1 = radioButton3.Checked;
            Boolean status2 = radioButton4.Checked;
            Boolean status3 = radioButton5.Checked;
            Boolean status4 = radioButton7.Checked;
            Boolean status5 = radioButton6.Checked;
            Boolean gender1 = radioButton1.Checked;
            Boolean gender2 = radioButton2.Checked;
            Boolean hobbies1 = checkBox1.Checked;
            Boolean hobbies2 = Reading.Checked;
            Boolean hobbies3 = checkBox3.Checked;
            Boolean hobbies4 = checkBox4.Checked;
            Boolean hobbies5 = checkBox5.Checked;
            Boolean hobbies6 = checkBox6.Checked;
            Boolean hobbies7 = checkBox7.Checked;
            Boolean hobbies8 = checkBox8.Checked;
            Boolean hobbies9 = checkBox9.Checked;
            Boolean hobbies10 = checkBox10.Checked;
            int total = 0;


            if (firstnmeron)
                total++;
            if (middlenmeron)
                total++;
            if (lastnmeron)
                total++;
            if (addressmeron)
                total++;

            if (month && day && year)
            {
                total++;
            }


            if (status1)
            {
                total++;
            }
            else if (status2)
            {
                total++;
            }
            else if (status3)
            {
                total++;
            }
            else if (status4)
            {
                total++;
            }
            else if (status5)
            {
                total++;
            }


            if (gender1)
            {
                total++;
            }
            else if (gender2)
            {
                total++;
            }


            if (course)
            {
                total++;
            }

            if (hobbies1)
            {
                total++;
            }
            else if (hobbies2)
            {
                total++;
            }
            else if (hobbies3)
            {
                total++;
            }
            else if (hobbies4)
            {
                total++;
            }
            else if (hobbies5)
            {
                total++;
            }
            else if (hobbies6)
            {
                total++;
            }
            else if (hobbies7)
            {
                total++;
            }
            else if (hobbies8)
            {
                total++;
            }
            else if (hobbies9)
            {
                total++;
            }
            else if (hobbies10)
            {
                total++;
            }

            progressBar1.Value = total;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
