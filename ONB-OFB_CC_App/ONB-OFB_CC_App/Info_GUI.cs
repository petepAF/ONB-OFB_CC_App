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
    public partial class Info_GUI : Form
    {
        public Info_GUI()
        {
            InitializeComponent();
        }

        public void dataGridView1_onLoad(object sender, EventArgs e)
        {
            Search_GUI sg = new Search_GUI();

            string name = sg.comboBox1.SelectedText;

            sg.Hide();

            ADODB.Connection conn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            string cnStr;
            string query;

            cnStr = "Provider=OraOLEDB.Oracle; Data Source=GWPROD; User Id=petepx; Password=TipToeTulips16;";

            query = "select distinct " +
                           "con.firstname, con.lastname " +
                        "from " +
                            "ccuser.cc_user u, " +
                            "ccuser.cc_contact con " +
                        "where u.contactid = con.id " +
                        "and concat(concat(upper(con.firstname), ' '), upper(con.lastname)) " +
                        "like upper('" + name + "')";

            conn.Open(cnStr, null, null, 0);

            rs.Open(query, conn);

            cnStr = "";
            query = "";
            rs.Close();
            conn.Close();
        }
    }
}
