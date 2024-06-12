using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho___PIM
{
    internal class Conexao
    {
        public string conectar = "SERVER=localhost; DATABASE=fazenda; UID=root; PWD=; PORT=;"; //<-- CONEXÃO LOCAL
        //public string conectar = "SERVER=mysql831.umbler.com; DATABASE=projetopim; UID=murilosanches; PWD=158158mu; PORT=41890;"; //conexão remota

        public MySqlConnection con = null;
        
        //abrir conexão
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conectar);
                con.Open();
            }
            catch (Exception ex)
            {   //erro
                MessageBox.Show("Erro no servidor: " + ex.Message);
            }
        }
        //fechar conexão
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conectar);
                con.Close();
            }
            catch (Exception ex)
            {   //erro 
                MessageBox.Show("Erro no servidor: " + ex.Message);
            }
        }
    }
}
