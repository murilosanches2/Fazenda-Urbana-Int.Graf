using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho___PIM
{
    public partial class FrmFrutas : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string DATAantigo;
        string id;

        public FrmFrutas()
        {
            InitializeComponent();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "Código: ";
            grid.Columns[1].HeaderText = "Maças: ";
            grid.Columns[2].HeaderText = "Morangos: ";
            grid.Columns[3].HeaderText = "Uvas: ";
            grid.Columns[4].HeaderText = "Datas: ";
            
            grid.Columns[0].Visible = false;
        }

        private void FrmFrutas_Load(object sender, EventArgs e)
        {
            ListarGD();
        }

        private void ListarGD()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM frutas ORDER BY data ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HabilitarTextos();
            txtMaca.Focus();
            HabilitarBotoes();
            btnAdd.Enabled = false;
            btnAlterar.Enabled = false;

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtMaca.Text == "   " || txtMaca.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaca.Focus();
                return;
            }
            if (txtMorango.Text == "   " || txtMorango.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMorango.Focus();
                return;
            }
            if (txtUva.Text == "   " || txtUva.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUva.Focus();
                return;
            }
            if (txtData.Text == "  /  /    " || txtData.Text.Length < 10)
            {
                MessageBox.Show("Informe a data!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtData.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "INSERT INTO frutas (maca, morango, uva, data) VALUES (@maca, @morango, @uva, @data)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@maca", txtMaca.Text);
            cmd.Parameters.AddWithValue("@morango", txtMorango.Text);
            cmd.Parameters.AddWithValue("@uva", txtUva.Text);
            cmd.Parameters.AddWithValue("@data", txtData.Text);
            if (txtData.Text != DATAantigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM frutas WHERE data=@data", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@data", txtData.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data já inserida, verifique a consulta abaixo e realize a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    DesabilitarTextos();
                    DesabilitarBotoes();
                    btnAdd.Enabled = true;
                    return;
                }
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                LimparCampos();
                DesabilitarTextos();
                DesabilitarBotoes();
                btnAdd.Enabled = true;
                ListarGD();
                MessageBox.Show("Produção salva com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "UPDATE frutas SET maca=@maca, morango=@morango, uva=@uva, data=@data WHERE id=@id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@maca", txtMaca.Text);
            cmd.Parameters.AddWithValue("@morango", txtMorango.Text);
            cmd.Parameters.AddWithValue("@uva", txtUva.Text);
            cmd.Parameters.AddWithValue("@data", txtData.Text);

            if (txtData.Text != DATAantigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM frutas WHERE data=@data", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@data", txtData.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data já inserida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtData.Text = "";
                    txtData.Focus();
                    return;
                }
            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            LimparCampos();
            DesabilitarTextos();
            DesabilitarBotoes();
            btnAdd.Enabled = true;
            ListarGD();
            MessageBox.Show("Registro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarTextos();
            DesabilitarBotoes();
            btnAdd.Enabled = true;
        }

        private void DesabilitarTextos()
        {
            txtMaca.Enabled = false;
            txtUva.Enabled = false;
            txtMorango.Enabled = false;
            txtData.Enabled = false;
        }
        private void HabilitarTextos()
        {
            txtMaca.Enabled = true;
            txtUva.Enabled = true;
            txtMorango.Enabled = true;
            txtData.Enabled = true;
        }
        private void DesabilitarBotoes()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAdd.Enabled = false;
            btnAlterar.Enabled = false;
        }
        private void HabilitarBotoes()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdd.Enabled = true;
            btnAlterar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtMaca.Text = "";
            txtMorango.Text = "";
            txtUva.Text = "";
            txtData.Text = "";
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes();
            btnAdd.Enabled = false;
            btnSalvar.Enabled = false;
            HabilitarTextos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtMaca.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtMorango.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtUva.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtData.Text = grid.CurrentRow.Cells[4].Value.ToString();
            
            DATAantigo = grid.CurrentRow.Cells[4].Value.ToString();
        }

    }
}
