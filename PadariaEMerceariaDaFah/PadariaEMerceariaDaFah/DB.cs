using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Chamada para utilizar as tables internas do C#(DataTable)
using System.Data;

//Chamada da DLL de acesso ao MySQL
using MySql.Data.MySqlClient;

//Visu o MessageBox
using System.Windows.Forms;

namespace Formulario
{
    public class DB
    {
        private MySqlConnection connection;
        //Informações do banco
        private string host = "localhost"; //endereço do banco
        private string database; //nome do banco de dados
        private string username = "root"; //login no servidor
        private string password = ""; //senha no servidor
        public DB(string DATABASE = "mysql")
        {
            database = DATABASE;
            string connectionString = "SERVER=" + host + ";" +
                                       "DATABASE=" + database + ";" +
                                       "UID=" + username + ";" +
                                       "PASSWORD=" + password + ";";
            //Passo a conexão pra funçao de conexão
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                //Erro --> TRATAMENTO
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //Erro --> TRATAMENTO
                MessageBox.Show("Erro ao fechar banco de dados: " + ex.Message);
                return false;
            }
        }

        public bool Insert(string query)
        {
            if(OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }
            }

            return false;
        }

        public bool Update(string query)
        {
            return Insert(query);
        }
        public bool Delete(string query)
        {
            return Insert(query);
        }

        public DataTable Select(string query)
        {
            if(OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader data = cmd.ExecuteReader(); //contem informações trazidas pelo SGBD

                //montando o esquema do datatable de retorno
                DataTable tbEsquema = data.GetSchemaTable();
                DataTable tbRetorno = new DataTable();

                try
                {
                    if (data != null && tbEsquema != null)
                    {
                        foreach (DataRow linha in tbEsquema.Rows)
                        {
                            if (!tbRetorno.Columns.Contains(linha["ColumnName"].ToString()))
                            {
                                /*preenche os dados da tabela*/
                                DataColumn col = new DataColumn()
                                {
                                    ColumnName = linha["ColumnName"].ToString(),
                                    Unique = Convert.ToBoolean(linha["IsUnique"]),
                                    AllowDBNull = Convert.ToBoolean(linha["AllowDBNull"]),
                                    ReadOnly = Convert.ToBoolean(linha["IsReadOnly"])
                                };

                                tbRetorno.Columns.Add(col);
                            }
                        }

                        //buscando linha à linha
                        while (data.Read())
                        {
                            DataRow novaLinha = tbRetorno.NewRow();

                            //preenchendo a linha da tabela
                            for (int i = 0; i < tbRetorno.Columns.Count; i++)
                            {
                                novaLinha[i] = data.GetValue(i); //info está aqui!!!

                            }
                            tbRetorno.Rows.Add(novaLinha);
                        }

                        data.Close();
                        return tbRetorno;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao selecionar dados do banco de dados: " + ex.Message);
                    return null;
                }
                finally
                {
                    CloseConnection();
                }
            }
            return null;
        }
    }
}
