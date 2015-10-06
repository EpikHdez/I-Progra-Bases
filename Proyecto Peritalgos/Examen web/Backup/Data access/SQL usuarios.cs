using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace Examen_web.Data_access
{
    public class SQL_usuarios
    {
        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private string tipo_de_usuario;

        public string Tipo_de_usuario
        {
            get { return tipo_de_usuario; }
            set { tipo_de_usuario = value; }
        }

        private string seccion;

        public string Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }

        public static string contrajalada;

        string ups = "Ins_Usuario";

        public string Agregar()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand(ups, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@NombUsuar", System.Data.SqlDbType.VarChar).Value = nombre_usuario;
                    cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar).Value = contraseña;
                    cmd.Parameters.Add("@CodTipoUsua", System.Data.SqlDbType.VarChar).Value = tipo_de_usuario;
                    cmd.Parameters.Add("@Seccion", System.Data.SqlDbType.VarChar).Value = seccion;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        string upsujalar = "Select_filter_usuarios";

        public void JalarUsuarios(string usuari, string contra)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand(upsujalar, con))
                {
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@cnombralum", System.Data.SqlDbType.VarChar).Value = usuari;
                        cmd.Parameters.Add("@ccontrase", System.Data.SqlDbType.VarChar).Value = contra;

                        try
                        {
                            con.Open();

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    nombre_usuario = reader["cnombralum"].ToString();
                                    contrajalada = reader["ccontrase"].ToString();
                                    seccion = reader["cseccion"].ToString();
                                    tipo_de_usuario = reader["ccodtipusu"].ToString();
                                }
                            }

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=CTP_Server;Initial Catalog=ExamWeb;"
                + "Integrated Security=SSPI";
        }
    }
}