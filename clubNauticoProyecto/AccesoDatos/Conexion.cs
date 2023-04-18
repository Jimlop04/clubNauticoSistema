using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clubNauticoProyecto.AccesoDatos
{
    public class Conexion
    {
        private SqlConnection oConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable registroConsultaTabla;
        private string server, nameDataBase, user, password;
        private string sentenciaSQL;
        private SqlParameter parameter;

        public string SentenciaSQL { get => sentenciaSQL; set => sentenciaSQL = value; }
        public SqlParameter Parameter { get => parameter; set => parameter = value; }

        public Conexion()
        {
            server = ".";
            user = "sa";
            password = "1234";
            nameDataBase = "CLUB_NAUTICO";
            parameter = new SqlParameter();
        }

        public Conexion(string server, string nameDataBase, string user, string password)
        {
            this.server = server;
            this.nameDataBase = nameDataBase;
            this.user = user;
            this.password = password;
        }
        private bool abrirConexion()
        {
            try
            {
                oConnection = new SqlConnection();
                oConnection.ConnectionString = "Server= " + server + ";DataBase= " + nameDataBase + ";User id= " + user + ";Password= " + password;
                oConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private bool cerrarConexion()
        {
            try
            {
                oConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public DataTable ejecutarSentencia(params SqlParameter[] parametros)
        {
            registroConsultaTabla = new DataTable();
            if (abrirConexion())
            {
                    sqlDataAdapter = new SqlDataAdapter(sentenciaSQL, oConnection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                    {
                        sqlDataAdapter.SelectCommand.Parameters.AddRange(parametros);
                    }
                    sqlDataAdapter.Fill(registroConsultaTabla);
                    cerrarConexion();     
            }
            return registroConsultaTabla;
        }
        
    }
}
