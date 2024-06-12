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
    public partial class FrmCadastroForn : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string CNPJantigo;
        string id; //variavel que puxa o ID

        public FrmCadastroForn()
        {
            InitializeComponent();
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "Código: ";
            grid.Columns[1].HeaderText = "CNPJ: ";
            grid.Columns[2].HeaderText = "Empresa: ";
            grid.Columns[3].HeaderText = "Responsável: ";
            grid.Columns[4].HeaderText = "Telefone: ";
            grid.Columns[5].HeaderText = "E-mail: ";
            grid.Columns[6].HeaderText = "Endereço: ";
            grid.Columns[7].HeaderText = "Descrição: ";

            grid.Columns[0].Visible = false;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ListarGD();
        }
        private void ListarGD()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedores ORDER BY empresa ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarTextos();
            txtCNPJ.Focus();

            DesabilitarBotoes();
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "  .   .   /    -" || txtCNPJ.Text.Length < 18)
            {
                MessageBox.Show("Digite o CNPJ!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCNPJ.Focus();
                return;
            }
            if (txtEmp.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome da empresa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmp.Text = "";
                txtEmp.Focus();
                return;
            }
            if (txtResp.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome do funcionário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResp.Text = "";
                txtResp.Focus();
                return;
            }
            if (txtEmail.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o e-mail da empresa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }
            if (txtTel.Text == "(  )      -" || txtTel.Text.Length < 15)
            {
                MessageBox.Show("Digite o telefone do responsável!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTel.Focus();
                return;
            }

        
            con.AbrirConexao();
            sql = "INSERT INTO fornecedores (cnpj, empresa, responsavel, telefone, email, endereco, descricao) VALUES (@cnpj, @empresa, @responsavel, @telefone, @email, @endereco, @descricao)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
            cmd.Parameters.AddWithValue("@empresa", txtEmp.Text);
            cmd.Parameters.AddWithValue("@responsavel", txtResp.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
            cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);

            //verificar cnpj
            if (txtCNPJ.Text != CNPJantigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM fornecedores WHERE cnpj=@cnpj", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CNPJ já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPJ.Text = "";
                    txtCNPJ.Focus();
                    return;
                }
            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparCampos();
            DesabilitarTextos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;

            ListarGD();
            MessageBox.Show("Registro salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "UPDATE fornecedores SET cnpj=@cnpj, empresa=@empresa, responsavel=@responsavel, telefone=@telefone, email=@email, endereco=@endereco, descricao=@descricao WHERE id=@id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
            cmd.Parameters.AddWithValue("@empresa", txtEmp.Text);
            cmd.Parameters.AddWithValue("@responsavel", txtResp.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
            cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);
            
            if (txtCNPJ.Text != CNPJantigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM fornecedores WHERE cnpj=@cnpj", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CNPJ já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPJ.Text = "";
                    txtCNPJ.Focus();
                    return;
                }
            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();


            LimparCampos();
            DesabilitarTextos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;

            ListarGD();
            MessageBox.Show("Registro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente excluir esse registro?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM fornecedores WHERE id=@id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                LimparCampos();
                DesabilitarTextos();
                DesabilitarBotoes();
                btnNovo.Enabled = true;

                MessageBox.Show("Deletado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarGD();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimparCampos();
            DesabilitarTextos();
            DesabilitarBotoes();
            btnNovo.Enabled= true;
        }

        private void DesabilitarTextos()
        {
            txtEmp.Enabled = false;
            txtEnd.Enabled = false;
            txtCNPJ.Enabled = false;
            txtTel.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtDesc.Enabled = false;
            txtResp.Enabled = false;
        }
        private void HabilitarTextos()
        {
            txtEmp.Enabled = true;
            txtEnd.Enabled = true;
            txtCNPJ.Enabled = true;
            txtTel.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtDesc.Enabled = true;
            txtResp.Enabled = true;
        }
        private void DesabilitarBotoes()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }
        private void HabilitarBotoes()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtEmp.Text = "";
            txtEnd.Text = "";
            txtCNPJ.Text = "";
            txtTel.Text = "";
            txtDesc.Text = "";
            txtEmail.Text = "";
            txtResp.Text = "";
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes();
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            HabilitarTextos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtCNPJ.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtEmp.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtResp.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txtEnd.Text = grid.CurrentRow.Cells[6].Value.ToString();
            txtDesc.Text = grid.CurrentRow.Cells[7].Value.ToString();

            CNPJantigo = grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void BuscarEmpresa()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedores WHERE cnpj LIKE @cnpj ORDER BY cnpj ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cnpj", txtBuscar.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpresa();
        }        
    }
}