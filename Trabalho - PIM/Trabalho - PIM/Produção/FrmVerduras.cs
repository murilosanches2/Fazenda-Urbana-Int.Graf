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
    public partial class FrmVerduras : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string HORAantigo, DATAantigo;
        string id;

        public FrmVerduras()
        {
            InitializeComponent();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "Código: ";
            grid.Columns[1].HeaderText = "Alfaces: ";
            grid.Columns[2].HeaderText = "Rúculas: ";
            grid.Columns[3].HeaderText = "Brócolis: ";
            grid.Columns[4].HeaderText = "Datas: ";
            grid.Columns[5].HeaderText = "Horário: ";

            grid.Columns[0].Visible = false;
        }
        private void FrmVerduras_Load(object sender, EventArgs e)
        {
            ListarGD();
        }
        private void ListarGD()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM verduras ORDER BY data DESC, hora DESC";
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
            txtAlface.Focus();
            HabilitarBotoes();
            btnAdd.Enabled = false;
            btnAlterar.Enabled = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAlface.Text == "   " || txtAlface.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlface.Focus();
                return;
            }
            if (txtRucula.Text == "   " || txtRucula.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRucula.Focus();
                return;
            }
            if (txtBrocolis.Text == "   " || txtBrocolis.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrocolis.Focus();
                return;
            }
            if (txtData.Text == "  /  /    " || txtData.Text.Length < 10)
            {
                MessageBox.Show("Informe a data!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtData.Focus();
                return;
            }
            if (txtHora.Text == "  :  " || txtHora.Text.Length < 5)
            {
                MessageBox.Show("Informe o horário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "INSERT INTO verduras (alface, rucula, brocolis, data, hora) VALUES (@alface, @rucula, @brocolis, @data, @hora)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@alface", txtAlface.Text);
            cmd.Parameters.AddWithValue("@rucula", txtRucula.Text);
            cmd.Parameters.AddWithValue("@brocolis", txtBrocolis.Text);
            cmd.Parameters.AddWithValue("@data", txtData.Text);
            cmd.Parameters.AddWithValue("@hora", txtHora.Text);
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            LimparCampos();
            DesabilitarTextos();
            DesabilitarBotoes();
            btnAdd.Enabled = true;
            ListarGD();
            MessageBox.Show("Registro salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlface.Text == "   " || txtAlface.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlface.Focus();
                return;
            }
            if (txtRucula.Text == "   " || txtRucula.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRucula.Focus();
                return;
            }
            if (txtBrocolis.Text == "   " || txtBrocolis.Text.Length < 1)
            {
                MessageBox.Show("Informe a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrocolis.Focus();
                return;
            }
            if (txtData.Text == "  /  /    " || txtData.Text.Length < 10)
            {
                MessageBox.Show("Informe a data!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtData.Focus();
                return;
            }
            if (txtHora.Text == "  :  " || txtHora.Text.Length < 5)
            {
                MessageBox.Show("Informe o horário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "UPDATE verduras SET alface=@alface, rucula=@rucula, brocolis=@brocolis, data=@data, hora=@hora WHERE id=@id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@alface", txtAlface.Text);
            cmd.Parameters.AddWithValue("@rucula", txtRucula.Text);
            cmd.Parameters.AddWithValue("@brocolis", txtBrocolis.Text);
            cmd.Parameters.AddWithValue("@data", txtData.Text);
            cmd.Parameters.AddWithValue("@hora", txtHora.Text);            
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente excluir esse registro?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM verduras WHERE id=@id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                LimparCampos();
                DesabilitarTextos();
                DesabilitarBotoes();
                btnAdd.Enabled = true;

                MessageBox.Show("Deletado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarGD();
        }

        private void DesabilitarTextos()
        {
            txtAlface.Enabled = false;
            txtBrocolis.Enabled = false;
            txtRucula.Enabled = false;
            txtData.Enabled = false;
            txtHora.Enabled = false;
        }
        private void HabilitarTextos()
        {
            txtAlface.Enabled = true;
            txtBrocolis.Enabled = true;
            txtRucula.Enabled = true;
            txtData.Enabled = true;
            txtHora.Enabled = true;
        }
        private void DesabilitarBotoes()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAdd.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void HabilitarBotoes()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdd.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void LimparCampos()
        {
            txtAlface.Text = "";
            txtRucula.Text = "";
            txtBrocolis.Text = "";
            txtData.Text = "";
            txtHora.Text = "";
        }        

        private void grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes();
            btnAdd.Enabled = false;
            btnSalvar.Enabled = false;
            HabilitarTextos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtAlface.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtRucula.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtBrocolis.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtData.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtHora.Text = grid.CurrentRow.Cells[5].Value.ToString();

            HORAantigo = grid.CurrentRow.Cells[5].Value.ToString();
            DATAantigo = grid.CurrentRow.Cells[4].Value.ToString();
        }
        private void BuscarDATA()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM verduras WHERE data LIKE @data ORDER BY data ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@data", txtBuscar.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }


        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            BuscarDATA();
        }
    }
}
