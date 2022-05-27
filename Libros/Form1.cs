using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConexionPostgre conectando = new ConexionPostgre();

        private void btn_conectar_Click(object sender, EventArgs e)
        {
           
            conectando.conectar();
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            conectando.desconectar();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            if (txt_consulta.Text == "")
            {
                dgv_muestra.DataSource = conectando.consulta();
            }
            else
            {
                dgv_muestra.DataSource = conectando.consulta(txt_consulta.Text);
            }
        }
    }
}
