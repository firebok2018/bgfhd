using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace conecion_a_base_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection wi = new SqlConnection("server=.;database=BD_PUBLICIDAD3D;uid=sa;pwd=sql");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter winadap = new SqlDataAdapter("select*from CONTACTOS",wi);
            DataTable datatablewin =new DataTable();
            winadap.Fill(datatablewin);
            dgClientes.DataSource = null;
            dgClientes.DataSource = datatablewin;
        }
    }
}
