using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONB_OFB_CC_App
{
    public partial class Search_GUI : Form
    {
        public Search_GUI()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";

            string fName = textBox1.Text;
            string lName = textBox2.Text;

            ADODB.Connection conn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            string cnStr;
            string query;

            cnStr = "Provider=OraOLEDB.Oracle; Data Source=GWPROD; User Id=petepx; Password=TipToeTulips16;";

            if (textBox1.Text != "" & textBox2.Text != "")
            {
                query = "select distinct " +
                            "con.firstname, con.lastname " +
                        "from " +
                            "ccuser.cc_user u, " +
                            "ccuser.cc_contact con " +
                        "where u.contactid = con.id " +
                        "and upper(con.firstname) like upper('" + fName + "') " +
                        "and upper(con.lastname) like upper('" + lName + "')";

                conn.Open(cnStr, null, null, 0);

                rs.Open(query, conn);
            }
            else if (textBox1.Text == "" & textBox2.Text != "")
            {
                query = "select distinct " +
                           "con.firstname, con.lastname " +
                        "from " +
                            "ccuser.cc_user u, " +
                            "ccuser.cc_contact con " +
                        "where u.contactid = con.id " +
                        "and upper(con.lastname) like upper('" + lName + "')";

                conn.Open(cnStr, null, null, 0);

                rs.Open(query, conn);
            }
            else if (textBox2.Text == "" & textBox1.Text != "")
            {
                query = "select distinct " +
                           "con.firstname, con.lastname " +
                        "from " +
                            "ccuser.cc_user u, " +
                            "ccuser.cc_contact con " +
                        "where u.contactid = con.id " +
                        "and upper(con.firstname) like upper('" + fName + "')";

                conn.Open(cnStr, null, null, 0);

                rs.Open(query, conn);
            }
            else if (textBox1.Text == "" & textBox2.Text == "")
            {
                MessageBox.Show("Please enter a minimum of a First Name or Last Name.");
            }


            while (!rs.EOF)
            {
                if (comboBox1.Items.Contains(rs.Fields[0].Value + " " + rs.Fields[1].Value))
                {
                    // Do Nothing
                }
                else if (comboBox1.Items.Contains(rs.Fields[0].Value + " " + rs.Fields[1].Value) != true)
                {
                    comboBox1.Items.Add(rs.Fields[0].Value + " " + rs.Fields[1].Value);
                    rs.MoveNext();
                }
            }

            cnStr = "";
            query = "";
            rs.Close();
            conn.Close();

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Text = "";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            DialogResult clearMsg = MessageBox.Show("Would you like to clear old search results?", "", MessageBoxButtons.YesNo);

            if (clearMsg == DialogResult.Yes)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
            }
            else if (clearMsg == DialogResult.No)
            {
                // Do Nothing
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            using () ;
            this.Hide();

        }
    }
}