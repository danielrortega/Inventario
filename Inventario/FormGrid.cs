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
    public partial class FormGrid : Form
    {
        private DataSet dsEstoque;
        private System.Windows.Forms.BindingSource bindingSource;
        OpenNETCF.Data.Text.TextDataAdapter daEstoque; 

        public FormGrid(DataSet ds, OpenNETCF.Data.Text.TextDataAdapter da)
        {
            InitializeComponent();
            dsEstoque = ds;
            daEstoque = da;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGrid_Load(object sender, EventArgs e)
        {
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.bindingSource.DataMember = "Estoque";
            this.bindingSource.DataSource = this.dsEstoque;
            this.dataGrid1.DataSource = this.bindingSource;
        }
    }
}