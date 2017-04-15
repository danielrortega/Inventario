using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormGridNovos : Form
    {
        private DataSet dsNovos;
        private System.Windows.Forms.BindingSource bindingSource;
        OpenNETCF.Data.Text.TextDataAdapter daNovos;

        public FormGridNovos(DataSet ds, OpenNETCF.Data.Text.TextDataAdapter da)
        {
            InitializeComponent();
            dsNovos = ds;
            daNovos = da;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGridNovos_Load(object sender, EventArgs e)
        {
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.bindingSource.DataMember = "Novos";
            this.bindingSource.DataSource = this.dsNovos;
            this.dataGrid1.DataSource = this.bindingSource;
        }
    }
}