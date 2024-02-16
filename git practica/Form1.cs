using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace git_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Edad");
            dt.Rows.Add("pepa", "pig", 10);
            dt.Rows.Add("pepe", "pig", 35);
            dt.Rows.Add("tom", "perez", 21);
            dt.Rows.Add("anna", "redfield", 20);
            dt.Rows.Add("elsa", "pato", 22);
            dt.Rows.Add("pepe", "argento", 40);
            dtg_persona.DataSource = dt;
            dtg_persona.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtg_persona.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dtg_persona.Columns["Edad"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtg_persona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice != -1)
            {
                txt_nombre_borrar.Text = dtg_persona["Nombre", indice].Value.ToString();
                txt_apellido_borrar.Text = dtg_persona["Apellido", indice].Value.ToString();
                txt_edad_borrar.Text = dtg_persona["Edad", indice].Value.ToString();
            }
        }
    }
}
