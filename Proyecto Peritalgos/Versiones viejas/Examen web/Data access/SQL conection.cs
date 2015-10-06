using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Examen_web.Páginas;
using System.Web;
using Examen_web.Data_access;

namespace Examen_web
{
    public class SQL_conection
    {
        private string preg1 = "";

        public string Preg1
        {
            get { return preg1; }
            set { preg1 = value; }
        }

        private string op1 = "";

        public string Op1
        {
            get { return op1; }
            set { op1 = value; }
        }

        private string op2 = "";

        public string Op2
        {
            get { return op2; }
            set { op2 = value; }
        }

        private string op3 = "";

        public string Op3
        {
            get { return op3; }
            set { op3 = value; }
        }

        private string op4 = "";

        public string Op4
        {
            get { return op4; }
            set { op4 = value; }
        }

        private string resp = "";

        public string Resp
        {
            get { return resp; }
            set { resp = value; }
        }

        public string JalarPreg1()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta1", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                              preg1 = reader["cpreguntas"].ToString();
                              op1 = reader["copcion1"].ToString();
                              op2 = reader["copcion2"].ToString();
                              op3 = reader["copcion3"].ToString();
                              op4 = reader["copcion4"].ToString();
                              resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg2()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta2", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg3()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta3", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg4()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta4", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg5()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta5", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg6()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta6", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg7()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta7", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg8()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta8", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg9()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta9", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg10()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta10", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg11()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta11", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg12()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta12", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg13()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta13", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg14()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta14", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg15()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta15", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg16()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta16", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg17()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta17", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg18()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta18", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg19()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta19", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg20()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta20", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg21()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta21", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg22()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta22", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg23()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta23", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg24()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta24", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg25()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta25", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg26()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta26", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg27()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta27", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg28()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta28", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg29()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta29", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg30()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta30", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg31()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta31", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg32()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta32", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg33()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta33", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg34()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta34", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg35()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta35", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg36()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta36", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg37()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta37", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg38()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta38", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg39()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta39", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg40()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta40", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg41()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta41", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg42()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta42", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg43()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta43", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg44()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta44", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg45()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta45", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg46()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta46", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg47()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta47", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg48()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta48", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg49()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta49", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg50()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta50", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg51()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta51", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg52()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta52", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg53()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta53", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg54()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta54", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg55()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta55", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg56()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta56", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg57()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta57", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg58()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta58", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg59()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta59", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg60()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta60", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg61()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta61", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg62()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta62", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg63()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta63", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg64()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta64", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg65()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta65", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg66()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta66", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg67()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta67", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg68()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta68", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg69()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta69", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg70()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta70", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg71()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta71", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg72()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta72", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg73()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta73", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg74()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta74", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public string JalarPreg75()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("Use ExamWeb select * from pregunta75", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                preg1 = reader["cpreguntas"].ToString();
                                op1 = reader["copcion1"].ToString();
                                op2 = reader["copcion2"].ToString();
                                op3 = reader["copcion3"].ToString();
                                op4 = reader["copcion4"].ToString();
                                resp = reader["crespuecor"].ToString();
                            }
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
            }
            return null;
        }


        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=ERICK-PC\\JETFIRE;Initial Catalog=ExamWeb;"
                + "Integrated Security=SSPI";
        }
    }
}
