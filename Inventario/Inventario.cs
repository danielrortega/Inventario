using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.IO;
using OpenNETCF.Data.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Inventario
{
    public partial class Inventario : Form
    {
        DataSet dsEstoque;
        DataSet dsNovos;
        OpenNETCF.Data.Text.TextDataAdapter daEstoque;
        OpenNETCF.Data.Text.TextDataAdapter daNovos;

        public Inventario()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String strCodigo = txtInputCodigo.Text.Trim();
            String filtro = "Num='" + strCodigo + "'";
            DataRow[] drResult = null;
            DataRow row;
            bool textIsNumeric = true;
            bool existe = false;
            try
            {
                int.Parse(strCodigo);
                drResult = dsEstoque.Tables[0].Select(filtro);
            }
            catch
            {
                textIsNumeric = false;
            }

            if (textIsNumeric & drResult != null)
                if (drResult.Length > 0)
                    existe = true;

            if (existe)
            {
                lblNumero.BackColor = System.Drawing.Color.Blue;
                lblNumero.Text = drResult[0]["Num"].ToString();
                lblMedidas.Text = drResult[0]["Larg"].ToString() + " mm x " + drResult[0]["Compr"].ToString() + " m";
                txtFrontal.Text = drResult[0]["Frontal"].ToString();
                if (!drResult[0]["Frontalgr"].ToString().Equals("", StringComparison.Ordinal))
                    txtFrontal.Text += " " + drResult[0]["Frontalgr"].ToString() + "g/m²";
                txtAdesivo.Text = drResult[0]["Adesivo"].ToString();
                if (!drResult[0]["Adesivogr"].ToString().Equals("", StringComparison.Ordinal))
                    txtAdesivo.Text += " " + drResult[0]["Adesivogr"].ToString() + "g/m²";
                txtLiner.Text = drResult[0]["Liner"].ToString();
                if (!drResult[0]["Linergr"].ToString().Equals("", StringComparison.Ordinal))
                    txtLiner.Text += " " + drResult[0]["Linergr"].ToString();
                txtFabricante.Text = drResult[0]["Fabricante"].ToString();
                txtEspecificacao.Text = drResult[0]["Especificacao"].ToString();
                if (!drResult[0]["Fabr"].ToString().Equals("", StringComparison.Ordinal))
                    txtFabricacao.Text = "Fabricado em " + drResult[0]["Fabr"].ToString();
                else
                    txtFabricacao.Text = "";
                drResult[0]["Existe"] = "Sim";
                daEstoque.Update(dsEstoque);
            }
            else
            {
                lblNumero.BackColor = System.Drawing.Color.Red;
                lblNumero.Text = "NÃO EXISTE";
                lblMedidas.Text = "";
                txtFrontal.Text = "";
                txtAdesivo.Text = "";
                txtLiner.Text = "";
                txtFabricante.Text = "";
                txtEspecificacao.Text = "";
                txtFabricacao.Text = "";

                row = dsNovos.Tables[0].NewRow();
                row["Num"] = strCodigo;
                dsNovos.Tables[0].Rows.Add(row);
                daNovos.Update(dsNovos);
            }

            txtInputCodigo.Text = "";
            txtInputCodigo.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String fileNameEstoque = @"\My Documents\Estoque.csv";
            String fileNameNovos = @"\My Documents\Novos.csv";

            lblNumero.Text = "";
            lblMedidas.Text = "";
            txtFrontal.Text = "";
            txtAdesivo.Text = "";
            txtLiner.Text = "";
            txtFabricante.Text = "";
            txtEspecificacao.Text = "";
            txtFabricacao.Text = "";

            if (File.Exists(fileNameEstoque) && File.Exists(fileNameNovos))
            {
                dsEstoque = new DataSet();
                daEstoque = new TextDataAdapter(fileNameEstoque, true, ';');
                daEstoque.Fill(dsEstoque);
                dsNovos = new DataSet();
                daNovos = new TextDataAdapter(fileNameNovos, true, ';');
                daNovos.Fill(dsNovos);
            }
            txtInputCodigo.Text = "";
            txtInputCodigo.Focus();
        }

        private void txtInputCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            FormGrid formGrid = new FormGrid(dsEstoque, daEstoque);
            formGrid.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            FormGridNovos formGrid = new FormGridNovos(dsNovos, daNovos);
            formGrid.Show();
        }
    }
}