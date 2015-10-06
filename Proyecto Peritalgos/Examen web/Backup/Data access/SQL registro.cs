using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace Examen_web.Data_access
{
    public class SQL_registro
    {
        public static string Nom_usu = "", seccion = "", preg1 = "1", resp1 = "", preg2 = "2", resp2 = "", preg3 = "3", resp3 = "", preg4 = "4", resp4 = "", preg5 = "5", resp5 = "",
            preg6 = "6", resp6 = "", preg7 = "7", resp7 = "", preg8 = "8", resp8 = "", preg9 = "9", resp9 = "", preg10 = "10", resp10 = "", 
            preg11 = "11", resp11 = "", preg12 = "12", resp12 = "", preg13 = "13", resp13 = "", preg14 = "14", resp14 = "", preg15 = "15", resp15 = "", 
            preg16 = "16", resp16 = "", preg17 = "17", resp17 = "", preg18 = "18", resp18 = "", preg19 = "19", resp19 = "", preg20 = "20", resp20 = "",
            preg21 = "21", resp21 = "", preg22 = "22", resp22 = "", preg23 = "23", resp23 = "", preg24 = "24", resp24 = "", preg25 = "25", resp25 = "", 
            preg26 = "26", resp26 = "", preg27 = "27", resp27 = "", preg28 = "28", resp28 = "", preg29 = "29", resp29 = "", preg30 = "30", resp30 = "",
            preg31 = "31", resp31 = "", preg32 = "32", resp32 = "", preg33 = "33", resp33 = "", preg34 = "34", resp34 = "", preg35 = "35", resp35 = "", 
            preg36 = "36", resp36 = "", preg37 = "37", resp37 = "", preg38 = "38", resp38 = "", preg39 = "39", resp39 = "", preg40 = "40", resp40 = "",
            preg41 = "41", resp41 = "", preg42 = "42", resp42 = "", preg43 = "43", resp43 = "", preg44 = "44", resp44 = "", preg45 = "45", resp45 = "", 
            preg46 = "46", resp46 = "", preg47 = "47", resp47 = "", preg48 = "48", resp48 = "", preg49 = "49", resp49 = "", preg50 = "50", resp50 = "",
            preg51 = "51", resp51 = "", preg52 = "52", resp52 = "", preg53 = "53", resp53 = "", preg54 = "54", resp54 = "", preg55 = "55", resp55 = "", 
            preg56 = "56", resp56 = "", preg57 = "57", resp57 = "", preg58 = "58", resp58 = "", preg59 = "59", resp59 = "", preg60 = "60", resp60 = "",
            preg61 = "61", resp61 = "", preg62 = "62", resp62 = "", preg63 = "63", resp63 = "", preg64 = "64", resp64 = "", preg65 = "65", resp65 = "", 
            preg66 = "66", resp66 = "", preg67 = "67", resp67 = "", preg68 = "68", resp68 = "", preg69 = "69", resp69 = "", preg70 = "70", resp70 = "",
            preg71 = "71", resp71 = "", preg72 = "72", resp72 = "", preg73 = "73", resp73 = "", preg74 = "74", resp74 = "", preg75 = "75", resp75 = "";

        private static int nota;

        public static int Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public string Resp75
        {
            get { return resp75; }
            set { resp75 = value; }
        }

        public string Preg75
        {
            get { return preg75; }
            set { preg75 = value; }
        }

        public string Resp74
        {
            get { return resp74; }
            set { resp74 = value; }
        }

        public string Preg74
        {
            get { return preg74; }
            set { preg74 = value; }
        }

        public string Resp73
        {
            get { return resp73; }
            set { resp73 = value; }
        }

        public string Preg73
        {
            get { return preg73; }
            set { preg73 = value; }
        }

        public string Resp72
        {
            get { return resp72; }
            set { resp72 = value; }
        }

        public string Preg72
        {
            get { return preg72; }
            set { preg72 = value; }
        }

        public string Resp71
        {
            get { return resp71; }
            set { resp71 = value; }
        }

        public string Preg71
        {
            get { return preg71; }
            set { preg71 = value; }
        }

        public string Resp70
        {
            get { return resp70; }
            set { resp70 = value; }
        }

        public string Preg70
        {
            get { return preg70; }
            set { preg70 = value; }
        }

        public string Resp69
        {
            get { return resp69; }
            set { resp69 = value; }
        }

        public string Preg69
        {
            get { return preg69; }
            set { preg69 = value; }
        }

        public string Resp68
        {
            get { return resp68; }
            set { resp68 = value; }
        }

        public string Preg68
        {
            get { return preg68; }
            set { preg68 = value; }
        }

        public string Resp67
        {
            get { return resp67; }
            set { resp67 = value; }
        }

        public string Preg67
        {
            get { return preg67; }
            set { preg67 = value; }
        }

        public string Resp66
        {
            get { return resp66; }
            set { resp66 = value; }
        }

        public string Preg66
        {
            get { return preg66; }
            set { preg66 = value; }
        }

        public string Resp65
        {
            get { return resp65; }
            set { resp65 = value; }
        }

        public string Preg65
        {
            get { return preg65; }
            set { preg65 = value; }
        }

        public string Resp64
        {
            get { return resp64; }
            set { resp64 = value; }
        }

        public string Preg64
        {
            get { return preg64; }
            set { preg64 = value; }
        }

        public string Resp63
        {
            get { return resp63; }
            set { resp63 = value; }
        }

        public string Preg63
        {
            get { return preg63; }
            set { preg63 = value; }
        }

        public string Resp62
        {
            get { return resp62; }
            set { resp62 = value; }
        }

        public string Preg62
        {
            get { return preg62; }
            set { preg62 = value; }
        }

        public string Resp61
        {
            get { return resp61; }
            set { resp61 = value; }
        }

        public string Preg61
        {
            get { return preg61; }
            set { preg61 = value; }
        }

        public string Resp60
        {
            get { return resp60; }
            set { resp60 = value; }
        }

        public string Preg60
        {
            get { return preg60; }
            set { preg60 = value; }
        }

        public string Resp59
        {
            get { return resp59; }
            set { resp59 = value; }
        }

        public string Preg59
        {
            get { return preg59; }
            set { preg59 = value; }
        }

        public string Resp58
        {
            get { return resp58; }
            set { resp58 = value; }
        }

        public string Preg58
        {
            get { return preg58; }
            set { preg58 = value; }
        }

        public string Resp57
        {
            get { return resp57; }
            set { resp57 = value; }
        }

        public string Preg57
        {
            get { return preg57; }
            set { preg57 = value; }
        }

        public string Resp56
        {
            get { return resp56; }
            set { resp56 = value; }
        }

        public string Preg56
        {
            get { return preg56; }
            set { preg56 = value; }
        }

        public string Resp55
        {
            get { return resp55; }
            set { resp55 = value; }
        }

        public string Preg55
        {
            get { return preg55; }
            set { preg55 = value; }
        }

        public string Resp54
        {
            get { return resp54; }
            set { resp54 = value; }
        }

        public string Preg54
        {
            get { return preg54; }
            set { preg54 = value; }
        }

        public string Resp53
        {
            get { return resp53; }
            set { resp53 = value; }
        }

        public string Preg53
        {
            get { return preg53; }
            set { preg53 = value; }
        }

        public string Resp52
        {
            get { return resp52; }
            set { resp52 = value; }
        }

        public string Preg52
        {
            get { return preg52; }
            set { preg52 = value; }
        }

        public string Resp51
        {
            get { return resp51; }
            set { resp51 = value; }
        }

        public string Preg51
        {
            get { return preg51; }
            set { preg51 = value; }
        }

        public string Resp50
        {
            get { return resp50; }
            set { resp50 = value; }
        }

        public string Preg50
        {
            get { return preg50; }
            set { preg50 = value; }
        }

        public string Resp49
        {
            get { return resp49; }
            set { resp49 = value; }
        }

        public string Preg49
        {
            get { return preg49; }
            set { preg49 = value; }
        }

        public string Resp48
        {
            get { return resp48; }
            set { resp48 = value; }
        }

        public string Preg48
        {
            get { return preg48; }
            set { preg48 = value; }
        }

        public string Resp47
        {
            get { return resp47; }
            set { resp47 = value; }
        }

        public string Preg47
        {
            get { return preg47; }
            set { preg47 = value; }
        }

        public string Resp46
        {
            get { return resp46; }
            set { resp46 = value; }
        }

        public string Preg46
        {
            get { return preg46; }
            set { preg46 = value; }
        }

        public string Resp45
        {
            get { return resp45; }
            set { resp45 = value; }
        }

        public string Preg45
        {
            get { return preg45; }
            set { preg45 = value; }
        }

        public string Resp44
        {
            get { return resp44; }
            set { resp44 = value; }
        }

        public string Preg44
        {
            get { return preg44; }
            set { preg44 = value; }
        }

        public string Resp43
        {
            get { return resp43; }
            set { resp43 = value; }
        }

        public string Preg43
        {
            get { return preg43; }
            set { preg43 = value; }
        }

        public string Resp42
        {
            get { return resp42; }
            set { resp42 = value; }
        }

        public string Preg42
        {
            get { return preg42; }
            set { preg42 = value; }
        }

        public string Resp41
        {
            get { return resp41; }
            set { resp41 = value; }
        }

        public string Preg41
        {
            get { return preg41; }
            set { preg41 = value; }
        }

        public string Resp40
        {
            get { return resp40; }
            set { resp40 = value; }
        }

        public string Preg40
        {
            get { return preg40; }
            set { preg40 = value; }
        }

        public string Resp39
        {
            get { return resp39; }
            set { resp39 = value; }
        }

        public string Preg39
        {
            get { return preg39; }
            set { preg39 = value; }
        }

        public string Resp38
        {
            get { return resp38; }
            set { resp38 = value; }
        }

        public string Preg38
        {
            get { return preg38; }
            set { preg38 = value; }
        }

        public string Resp37
        {
            get { return resp37; }
            set { resp37 = value; }
        }

        public string Preg37
        {
            get { return preg37; }
            set { preg37 = value; }
        }

        public string Resp36
        {
            get { return resp36; }
            set { resp36 = value; }
        }

        public string Preg36
        {
            get { return preg36; }
            set { preg36 = value; }
        }

        public string Resp35
        {
            get { return resp35; }
            set { resp35 = value; }
        }

        public string Preg35
        {
            get { return preg35; }
            set { preg35 = value; }
        }

        public string Resp34
        {
            get { return resp34; }
            set { resp34 = value; }
        }

        public string Preg34
        {
            get { return preg34; }
            set { preg34 = value; }
        }

        public string Resp33
        {
            get { return resp33; }
            set { resp33 = value; }
        }

        public string Preg33
        {
            get { return preg33; }
            set { preg33 = value; }
        }

        public string Resp32
        {
            get { return resp32; }
            set { resp32 = value; }
        }

        public string Preg32
        {
            get { return preg32; }
            set { preg32 = value; }
        }

        public string Resp30
        {
            get { return resp30; }
            set { resp30 = value; }
        }

        public string Preg30
        {
            get { return preg30; }
            set { preg30 = value; }
        }

        public string Resp29
        {
            get { return resp29; }
            set { resp29 = value; }
        }

        public string Preg29
        {
            get { return preg29; }
            set { preg29 = value; }
        }

        public string Resp28
        {
            get { return resp28; }
            set { resp28 = value; }
        }

        public string Preg28
        {
            get { return preg28; }
            set { preg28 = value; }
        }

        public string Resp27
        {
            get { return resp27; }
            set { resp27 = value; }
        }

        public string Preg27
        {
            get { return preg27; }
            set { preg27 = value; }
        }

        public string Resp26
        {
            get { return resp26; }
            set { resp26 = value; }
        }

        public string Preg26
        {
            get { return preg26; }
            set { preg26 = value; }
        }

        public string Resp25
        {
            get { return resp25; }
            set { resp25 = value; }
        }

        public string Preg25
        {
            get { return preg25; }
            set { preg25 = value; }
        }

        public string Resp24
        {
            get { return resp24; }
            set { resp24 = value; }
        }

        public string Preg24
        {
            get { return preg24; }
            set { preg24 = value; }
        }

        public string Resp23
        {
            get { return resp23; }
            set { resp23 = value; }
        }

        public string Preg23
        {
            get { return preg23; }
            set { preg23 = value; }
        }

        public string Resp22
        {
            get { return resp22; }
            set { resp22 = value; }
        }

        public string Preg22
        {
            get { return preg22; }
            set { preg22 = value; }
        }

        public string Resp21
        {
            get { return resp21; }
            set { resp21 = value; }
        }

        public string Preg21
        {
            get { return preg21; }
            set { preg21 = value; }
        }

        public string Resp20
        {
            get { return resp20; }
            set { resp20 = value; }
        }

        public string Preg20
        {
            get { return preg20; }
            set { preg20 = value; }
        }

        public string Resp19
        {
            get { return resp19; }
            set { resp19 = value; }
        }

        public string Preg19
        {
            get { return preg19; }
            set { preg19 = value; }
        }

        public string Resp18
        {
            get { return resp18; }
            set { resp18 = value; }
        }

        public string Preg18
        {
            get { return preg18; }
            set { preg18 = value; }
        }

        public string Resp17
        {
            get { return resp17; }
            set { resp17 = value; }
        }

        public string Preg17
        {
            get { return preg17; }
            set { preg17 = value; }
        }

        public string Resp16
        {
            get { return resp16; }
            set { resp16 = value; }
        }

        public string Preg16
        {
            get { return preg16; }
            set { preg16 = value; }
        }

        public string Resp15
        {
            get { return resp15; }
            set { resp15 = value; }
        }

        public string Preg15
        {
            get { return preg15; }
            set { preg15 = value; }
        }

        public string Resp14
        {
            get { return resp14; }
            set { resp14 = value; }
        }

        public string Preg14
        {
            get { return preg14; }
            set { preg14 = value; }
        }

        public string Resp13
        {
            get { return resp13; }
            set { resp13 = value; }
        }

        public string Preg13
        {
            get { return preg13; }
            set { preg13 = value; }
        }

        public string Resp11
        {
            get { return resp11; }
            set { resp11 = value; }
        }

        public string Preg11
        {
            get { return preg11; }
            set { preg11 = value; }
        }

        public string Resp12
        {
            get { return resp12; }
            set { resp12 = value; }
        }

        public string Preg12
        {
            get { return preg12; }
            set { preg12 = value; }
        }

        public string Resp31
        {
            get { return resp31; }
            set { resp31 = value; }
        }

        public string Preg31
        {
            get { return preg31; }
            set { preg31 = value; }
        }

        public string Resp10
        {
            get { return resp10; }
            set { resp10 = value; }
        }

        public string Preg10
        {
            get { return preg10; }
            set { preg10 = value; }
        }

        public string Preg9
        {
            get { return preg9; }
            set { preg9 = value; }
        }

        public string Resp9
        {
            get { return resp9; }
            set { resp9 = value; }
        }

        public string Resp8
        {
            get { return resp8; }
            set { resp8 = value; }
        }

        public string Preg8
        {
            get { return preg8; }
            set { preg8 = value; }
        }

        public string Resp7
        {
            get { return resp7; }
            set { resp7 = value; }
        }

        public string Preg7
        {
            get { return preg7; }
            set { preg7 = value; }
        }

        public string Resp6
        {
            get { return resp6; }
            set { resp6 = value; }
        }

        public string Preg6
        {
            get { return preg6; }
            set { preg6 = value; }
        }

        public string Resp5
        {
            get { return resp5; }
            set { resp5 = value; }
        }

        public string Preg5
        {
            get { return preg5; }
            set { preg5 = value; }
        }

        public string Resp4
        {
            get { return resp4; }
            set { resp4 = value; }
        }

        public string Preg4
        {
            get { return preg4; }
            set { preg4 = value; }
        }

        public string Resp3
        {
            get { return resp3; }
            set { resp3 = value; }
        }

        public string Preg3
        {
            get { return preg3; }
            set { preg3 = value; }
        }

        public string Resp2
        {
            get { return resp2; }
            set { resp2 = value; }
        }

        public string Preg2
        {
            get { return preg2; }
            set { preg2 = value; }
        }
        public string Resp1
        {
            get { return resp1; }
            set { resp1 = value; }
        }

        public string Preg1
        {
            get { return preg1; }
            set { preg1 = value; }
        }

        public string Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }

        public string Nom_usu1
        {
            get { return Nom_usu; }
            set { Nom_usu = value; }
        }

        string ups = "Ins_Registro";

        public static string nom;
        public static string sec;

        public string Registro()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand(ups, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cnombralum", System.Data.SqlDbType.VarChar).Value = nom;
                    cmd.Parameters.Add("@cseccion", System.Data.SqlDbType.VarChar).Value = sec;
                    cmd.Parameters.Add("@cidpregun1", System.Data.SqlDbType.VarChar).Value = preg1;
                    cmd.Parameters.Add("@cresultad1", System.Data.SqlDbType.VarChar).Value = resp1;
                    cmd.Parameters.Add("@cidpregun2", System.Data.SqlDbType.VarChar).Value = preg2;
                    cmd.Parameters.Add("@cresultad2", System.Data.SqlDbType.VarChar).Value = resp2;
                    cmd.Parameters.Add("@cidpregun3", System.Data.SqlDbType.VarChar).Value = preg3;
                    cmd.Parameters.Add("@cresultad3", System.Data.SqlDbType.VarChar).Value = resp3;
                    cmd.Parameters.Add("@cidpregun4", System.Data.SqlDbType.VarChar).Value = preg4;
                    cmd.Parameters.Add("@cresultad4", System.Data.SqlDbType.VarChar).Value = resp4;
                    cmd.Parameters.Add("@cidpregun5", System.Data.SqlDbType.VarChar).Value = preg5;
                    cmd.Parameters.Add("@cresultad5", System.Data.SqlDbType.VarChar).Value = resp5;
                    cmd.Parameters.Add("@cidpregun6", System.Data.SqlDbType.VarChar).Value = preg6;
                    cmd.Parameters.Add("@cresultad6", System.Data.SqlDbType.VarChar).Value = resp6;
                    cmd.Parameters.Add("@cidpregun7", System.Data.SqlDbType.VarChar).Value = preg7;
                    cmd.Parameters.Add("@cresultad7", System.Data.SqlDbType.VarChar).Value = resp7;
                    cmd.Parameters.Add("@cidpregun8", System.Data.SqlDbType.VarChar).Value = preg8;
                    cmd.Parameters.Add("@cresultad8", System.Data.SqlDbType.VarChar).Value = resp8;
                    cmd.Parameters.Add("@cidpregun9", System.Data.SqlDbType.VarChar).Value = preg9;
                    cmd.Parameters.Add("@cresultad9", System.Data.SqlDbType.VarChar).Value = resp9;
                    cmd.Parameters.Add("@cidpregun10", System.Data.SqlDbType.VarChar).Value = preg10;
                    cmd.Parameters.Add("@cresultad10", System.Data.SqlDbType.VarChar).Value = resp10;
                    cmd.Parameters.Add("@cidpregun11", System.Data.SqlDbType.VarChar).Value = preg11;
                    cmd.Parameters.Add("@cresultad11", System.Data.SqlDbType.VarChar).Value = resp11;
                    cmd.Parameters.Add("@cidpregun12", System.Data.SqlDbType.VarChar).Value = preg12;
                    cmd.Parameters.Add("@cresultad12", System.Data.SqlDbType.VarChar).Value = resp12;
                    cmd.Parameters.Add("@cidpregun13", System.Data.SqlDbType.VarChar).Value = preg13;
                    cmd.Parameters.Add("@cresultad13", System.Data.SqlDbType.VarChar).Value = resp13;
                    cmd.Parameters.Add("@cidpregun14", System.Data.SqlDbType.VarChar).Value = preg14;
                    cmd.Parameters.Add("@cresultad14", System.Data.SqlDbType.VarChar).Value = resp14;
                    cmd.Parameters.Add("@cidpregun15", System.Data.SqlDbType.VarChar).Value = preg15;
                    cmd.Parameters.Add("@cresultad15", System.Data.SqlDbType.VarChar).Value = resp15;
                    cmd.Parameters.Add("@cidpregun16", System.Data.SqlDbType.VarChar).Value = preg16;
                    cmd.Parameters.Add("@cresultad16", System.Data.SqlDbType.VarChar).Value = resp16;
                    cmd.Parameters.Add("@cidpregun17", System.Data.SqlDbType.VarChar).Value = preg17;
                    cmd.Parameters.Add("@cresultad17", System.Data.SqlDbType.VarChar).Value = resp17;
                    cmd.Parameters.Add("@cidpregun18", System.Data.SqlDbType.VarChar).Value = preg18;
                    cmd.Parameters.Add("@cresultad18", System.Data.SqlDbType.VarChar).Value = resp18;
                    cmd.Parameters.Add("@cidpregun19", System.Data.SqlDbType.VarChar).Value = preg19;
                    cmd.Parameters.Add("@cresultad19", System.Data.SqlDbType.VarChar).Value = resp19;
                    cmd.Parameters.Add("@cidpregun20", System.Data.SqlDbType.VarChar).Value = preg20;
                    cmd.Parameters.Add("@cresultad20", System.Data.SqlDbType.VarChar).Value = resp20;
                    cmd.Parameters.Add("@cidpregun21", System.Data.SqlDbType.VarChar).Value = preg21;
                    cmd.Parameters.Add("@cresultad21", System.Data.SqlDbType.VarChar).Value = resp21;
                    cmd.Parameters.Add("@cidpregun22", System.Data.SqlDbType.VarChar).Value = preg22;
                    cmd.Parameters.Add("@cresultad22", System.Data.SqlDbType.VarChar).Value = resp22;
                    cmd.Parameters.Add("@cidpregun23", System.Data.SqlDbType.VarChar).Value = preg23;
                    cmd.Parameters.Add("@cresultad23", System.Data.SqlDbType.VarChar).Value = resp23;
                    cmd.Parameters.Add("@cidpregun24", System.Data.SqlDbType.VarChar).Value = preg24;
                    cmd.Parameters.Add("@cresultad24", System.Data.SqlDbType.VarChar).Value = resp24;
                    cmd.Parameters.Add("@cidpregun25", System.Data.SqlDbType.VarChar).Value = preg25;
                    cmd.Parameters.Add("@cresultad25", System.Data.SqlDbType.VarChar).Value = resp25;
                    cmd.Parameters.Add("@cidpregun26", System.Data.SqlDbType.VarChar).Value = preg26;
                    cmd.Parameters.Add("@cresultad26", System.Data.SqlDbType.VarChar).Value = resp26;
                    cmd.Parameters.Add("@cidpregun27", System.Data.SqlDbType.VarChar).Value = preg27;
                    cmd.Parameters.Add("@cresultad27", System.Data.SqlDbType.VarChar).Value = resp27;
                    cmd.Parameters.Add("@cidpregun28", System.Data.SqlDbType.VarChar).Value = preg28;
                    cmd.Parameters.Add("@cresultad28", System.Data.SqlDbType.VarChar).Value = resp28;
                    cmd.Parameters.Add("@cidpregun29", System.Data.SqlDbType.VarChar).Value = preg29;
                    cmd.Parameters.Add("@cresultad29", System.Data.SqlDbType.VarChar).Value = resp29;
                    cmd.Parameters.Add("@cidpregun30", System.Data.SqlDbType.VarChar).Value = preg30;
                    cmd.Parameters.Add("@cresultad30", System.Data.SqlDbType.VarChar).Value = resp30;
                    cmd.Parameters.Add("@cidpregun31", System.Data.SqlDbType.VarChar).Value = preg31;
                    cmd.Parameters.Add("@cresultad31", System.Data.SqlDbType.VarChar).Value = resp31;
                    cmd.Parameters.Add("@cidpregun32", System.Data.SqlDbType.VarChar).Value = preg32;
                    cmd.Parameters.Add("@cresultad32", System.Data.SqlDbType.VarChar).Value = resp32;
                    cmd.Parameters.Add("@cidpregun33", System.Data.SqlDbType.VarChar).Value = preg33;
                    cmd.Parameters.Add("@cresultad33", System.Data.SqlDbType.VarChar).Value = resp33;
                    cmd.Parameters.Add("@cidpregun34", System.Data.SqlDbType.VarChar).Value = preg34;
                    cmd.Parameters.Add("@cresultad34", System.Data.SqlDbType.VarChar).Value = resp34;
                    cmd.Parameters.Add("@cidpregun35", System.Data.SqlDbType.VarChar).Value = preg35;
                    cmd.Parameters.Add("@cresultad35", System.Data.SqlDbType.VarChar).Value = resp35;
                    cmd.Parameters.Add("@cidpregun36", System.Data.SqlDbType.VarChar).Value = preg36;
                    cmd.Parameters.Add("@cresultad36", System.Data.SqlDbType.VarChar).Value = resp36;
                    cmd.Parameters.Add("@cidpregun37", System.Data.SqlDbType.VarChar).Value = preg37;
                    cmd.Parameters.Add("@cresultad37", System.Data.SqlDbType.VarChar).Value = resp37;
                    cmd.Parameters.Add("@cidpregun38", System.Data.SqlDbType.VarChar).Value = preg38;
                    cmd.Parameters.Add("@cresultad38", System.Data.SqlDbType.VarChar).Value = resp38;
                    cmd.Parameters.Add("@cidpregun39", System.Data.SqlDbType.VarChar).Value = preg39;
                    cmd.Parameters.Add("@cresultad39", System.Data.SqlDbType.VarChar).Value = resp39;
                    cmd.Parameters.Add("@cidpregun40", System.Data.SqlDbType.VarChar).Value = preg40;
                    cmd.Parameters.Add("@cresultad40", System.Data.SqlDbType.VarChar).Value = resp40;
                    cmd.Parameters.Add("@cidpregun41", System.Data.SqlDbType.VarChar).Value = preg41;
                    cmd.Parameters.Add("@cresultad41", System.Data.SqlDbType.VarChar).Value = resp41;
                    cmd.Parameters.Add("@cidpregun42", System.Data.SqlDbType.VarChar).Value = preg42;
                    cmd.Parameters.Add("@cresultad42", System.Data.SqlDbType.VarChar).Value = resp42;
                    cmd.Parameters.Add("@cidpregun43", System.Data.SqlDbType.VarChar).Value = preg43;
                    cmd.Parameters.Add("@cresultad43", System.Data.SqlDbType.VarChar).Value = resp43;
                    cmd.Parameters.Add("@cidpregun44", System.Data.SqlDbType.VarChar).Value = preg44;
                    cmd.Parameters.Add("@cresultad44", System.Data.SqlDbType.VarChar).Value = resp44;
                    cmd.Parameters.Add("@cidpregun45", System.Data.SqlDbType.VarChar).Value = preg45;
                    cmd.Parameters.Add("@cresultad45", System.Data.SqlDbType.VarChar).Value = resp45;
                    cmd.Parameters.Add("@cidpregun46", System.Data.SqlDbType.VarChar).Value = preg46;
                    cmd.Parameters.Add("@cresultad46", System.Data.SqlDbType.VarChar).Value = resp46;
                    cmd.Parameters.Add("@cidpregun47", System.Data.SqlDbType.VarChar).Value = preg47;
                    cmd.Parameters.Add("@cresultad47", System.Data.SqlDbType.VarChar).Value = resp47;
                    cmd.Parameters.Add("@cidpregun48", System.Data.SqlDbType.VarChar).Value = preg48;
                    cmd.Parameters.Add("@cresultad48", System.Data.SqlDbType.VarChar).Value = resp48;
                    cmd.Parameters.Add("@cidpregun49", System.Data.SqlDbType.VarChar).Value = preg49;
                    cmd.Parameters.Add("@cresultad49", System.Data.SqlDbType.VarChar).Value = resp49;
                    cmd.Parameters.Add("@cidpregun50", System.Data.SqlDbType.VarChar).Value = preg50;
                    cmd.Parameters.Add("@cresultad50", System.Data.SqlDbType.VarChar).Value = resp50;
                    cmd.Parameters.Add("@cidpregun51", System.Data.SqlDbType.VarChar).Value = preg51;
                    cmd.Parameters.Add("@cresultad51", System.Data.SqlDbType.VarChar).Value = resp51;
                    cmd.Parameters.Add("@cidpregun52", System.Data.SqlDbType.VarChar).Value = preg52;
                    cmd.Parameters.Add("@cresultad52", System.Data.SqlDbType.VarChar).Value = resp52;
                    cmd.Parameters.Add("@cidpregun53", System.Data.SqlDbType.VarChar).Value = preg53;
                    cmd.Parameters.Add("@cresultad53", System.Data.SqlDbType.VarChar).Value = resp53;
                    cmd.Parameters.Add("@cidpregun54", System.Data.SqlDbType.VarChar).Value = preg54;
                    cmd.Parameters.Add("@cresultad54", System.Data.SqlDbType.VarChar).Value = resp54;
                    cmd.Parameters.Add("@cidpregun55", System.Data.SqlDbType.VarChar).Value = preg55;
                    cmd.Parameters.Add("@cresultad55", System.Data.SqlDbType.VarChar).Value = resp55;
                    cmd.Parameters.Add("@cidpregun56", System.Data.SqlDbType.VarChar).Value = preg56;
                    cmd.Parameters.Add("@cresultad56", System.Data.SqlDbType.VarChar).Value = resp56;
                    cmd.Parameters.Add("@cidpregun57", System.Data.SqlDbType.VarChar).Value = preg57;
                    cmd.Parameters.Add("@cresultad57", System.Data.SqlDbType.VarChar).Value = resp57;
                    cmd.Parameters.Add("@cidpregun58", System.Data.SqlDbType.VarChar).Value = preg58;
                    cmd.Parameters.Add("@cresultad58", System.Data.SqlDbType.VarChar).Value = resp58;
                    cmd.Parameters.Add("@cidpregun59", System.Data.SqlDbType.VarChar).Value = preg59;
                    cmd.Parameters.Add("@cresultad59", System.Data.SqlDbType.VarChar).Value = resp59;
                    cmd.Parameters.Add("@cidpregun60", System.Data.SqlDbType.VarChar).Value = preg60;
                    cmd.Parameters.Add("@cresultad60", System.Data.SqlDbType.VarChar).Value = resp60;
                    cmd.Parameters.Add("@cidpregun61", System.Data.SqlDbType.VarChar).Value = preg61;
                    cmd.Parameters.Add("@cresultad61", System.Data.SqlDbType.VarChar).Value = resp61;
                    cmd.Parameters.Add("@cidpregun62", System.Data.SqlDbType.VarChar).Value = preg62;
                    cmd.Parameters.Add("@cresultad62", System.Data.SqlDbType.VarChar).Value = resp62;
                    cmd.Parameters.Add("@cidpregun63", System.Data.SqlDbType.VarChar).Value = preg63;
                    cmd.Parameters.Add("@cresultad63", System.Data.SqlDbType.VarChar).Value = resp63;
                    cmd.Parameters.Add("@cidpregun64", System.Data.SqlDbType.VarChar).Value = preg64;
                    cmd.Parameters.Add("@cresultad64", System.Data.SqlDbType.VarChar).Value = resp64;
                    cmd.Parameters.Add("@cidpregun65", System.Data.SqlDbType.VarChar).Value = preg65;
                    cmd.Parameters.Add("@cresultad65", System.Data.SqlDbType.VarChar).Value = resp65;
                    cmd.Parameters.Add("@cidpregun66", System.Data.SqlDbType.VarChar).Value = preg66;
                    cmd.Parameters.Add("@cresultad66", System.Data.SqlDbType.VarChar).Value = resp66;
                    cmd.Parameters.Add("@cidpregun67", System.Data.SqlDbType.VarChar).Value = preg67;
                    cmd.Parameters.Add("@cresultad67", System.Data.SqlDbType.VarChar).Value = resp67;
                    cmd.Parameters.Add("@cidpregun68", System.Data.SqlDbType.VarChar).Value = preg68;
                    cmd.Parameters.Add("@cresultad68", System.Data.SqlDbType.VarChar).Value = resp68;
                    cmd.Parameters.Add("@cidpregun69", System.Data.SqlDbType.VarChar).Value = preg69;
                    cmd.Parameters.Add("@cresultad69", System.Data.SqlDbType.VarChar).Value = resp69;
                    cmd.Parameters.Add("@cidpregun70", System.Data.SqlDbType.VarChar).Value = preg70;
                    cmd.Parameters.Add("@cresultad70", System.Data.SqlDbType.VarChar).Value = resp70;
                    cmd.Parameters.Add("@cidpregun71", System.Data.SqlDbType.VarChar).Value = preg71;
                    cmd.Parameters.Add("@cresultad71", System.Data.SqlDbType.VarChar).Value = resp71;
                    cmd.Parameters.Add("@cidpregun72", System.Data.SqlDbType.VarChar).Value = preg72;
                    cmd.Parameters.Add("@cresultad72", System.Data.SqlDbType.VarChar).Value = resp72;
                    cmd.Parameters.Add("@cidpregun73", System.Data.SqlDbType.VarChar).Value = preg73;
                    cmd.Parameters.Add("@cresultad73", System.Data.SqlDbType.VarChar).Value = resp73;
                    cmd.Parameters.Add("@cidpregun74", System.Data.SqlDbType.VarChar).Value = preg74;
                    cmd.Parameters.Add("@cresultad74", System.Data.SqlDbType.VarChar).Value = resp74;
                    cmd.Parameters.Add("@cidpregun75", System.Data.SqlDbType.VarChar).Value = preg75;
                    cmd.Parameters.Add("@cresultad75", System.Data.SqlDbType.VarChar).Value = resp75;
                    cmd.Parameters.Add("@nota", System.Data.SqlDbType.Int).Value = nota;
                    
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

        string ups2 = "Select_filter_usuarios_registro";

        public void JalarUsuarios()
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand(ups2, con))
                {
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@cnombralum", System.Data.SqlDbType.VarChar).Value = Nom_usu;
                        cmd.Parameters.Add("@cseccion", System.Data.SqlDbType.VarChar).Value =  seccion;

                        try
                        {
                            con.Open();

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Nom_usu = reader["cnombralum"].ToString();
                                    seccion = reader["cseccion"].ToString();
                                    resp1 = reader["cresultad1"].ToString();
                                    resp2 = reader["cresultad2"].ToString();  
                                    resp3 = reader["cresultad3"].ToString(); 
                                    resp4 = reader["cresultad4"].ToString();
                                    resp5 = reader["cresultad5"].ToString();
                                    resp6 = reader["cresultad6"].ToString(); 
                                    resp7 = reader["cresultad7"].ToString(); 
                                    resp8 = reader["cresultad8"].ToString(); 
                                    resp9 = reader["cresultad9"].ToString(); 
                                    resp10 = reader["cresultad10"].ToString(); 
                                    resp11 = reader["cresultad11"].ToString(); 
                                    resp12 = reader["cresultad12"].ToString(); 
                                    resp13 = reader["cresultad13"].ToString(); 
                                    resp14 = reader["cresultad14"].ToString();
                                    resp15 = reader["cresultad15"].ToString();
                                    resp16 = reader["cresultad16"].ToString(); 
                                    resp17 = reader["cresultad17"].ToString();
                                    resp18 = reader["cresultad18"].ToString();
                                    resp19 = reader["cresultad19"].ToString(); 
                                    resp20 = reader["cresultad20"].ToString(); 
                                    resp21 = reader["cresultad21"].ToString();
                                    resp22 = reader["cresultad22"].ToString(); 
                                    resp23 = reader["cresultad23"].ToString();
                                    resp24 = reader["cresultad24"].ToString();
                                    resp25 = reader["cresultad25"].ToString();
                                    resp26 = reader["cresultad26"].ToString();
                                    resp27 = reader["cresultad27"].ToString();
                                    resp28 = reader["cresultad28"].ToString();
                                    resp29 = reader["cresultad29"].ToString();
                                    resp30 = reader["cresultad30"].ToString();
                                    resp31 = reader["cresultad31"].ToString();
                                    resp32 = reader["cresultad32"].ToString();
                                    resp33 = reader["cresultad33"].ToString();
                                    resp34 = reader["cresultad34"].ToString();
                                    resp35 = reader["cresultad35"].ToString();
                                    resp36 = reader["cresultad36"].ToString(); 
                                    resp37 = reader["cresultad37"].ToString();
                                    resp38 = reader["cresultad38"].ToString();
                                    resp39 = reader["cresultad39"].ToString();
                                    resp40 = reader["cresultad40"].ToString();
                                    resp41 = reader["cresultad41"].ToString();
                                    resp42 = reader["cresultad42"].ToString(); 
                                    resp43 = reader["cresultad43"].ToString(); 
                                    resp44 = reader["cresultad44"].ToString(); 
                                    resp45 = reader["cresultad45"].ToString(); 
                                    resp46 = reader["cresultad46"].ToString();
                                    resp47 = reader["cresultad47"].ToString(); 
                                    resp48 = reader["cresultad48"].ToString();
                                    resp49 = reader["cresultad49"].ToString(); 
                                    resp50 = reader["cresultad50"].ToString(); 
                                    resp51 = reader["cresultad51"].ToString();
                                    resp52 = reader["cresultad52"].ToString();
                                    resp53 = reader["cresultad53"].ToString();
                                    resp54 = reader["cresultad54"].ToString();
                                    resp55 = reader["cresultad55"].ToString(); 
                                    resp56 = reader["cresultad56"].ToString();
                                    resp57 = reader["cresultad57"].ToString();
                                    resp58 = reader["cresultad58"].ToString(); 
                                    resp59 = reader["cresultad59"].ToString();
                                    resp60 = reader["cresultad60"].ToString(); 
                                    resp61 = reader["cresultad61"].ToString(); 
                                    resp62 = reader["cresultad62"].ToString(); 
                                    resp63 = reader["cresultad63"].ToString(); 
                                    resp64 = reader["cresultad64"].ToString();
                                    resp65 = reader["cresultad65"].ToString(); 
                                    resp66 = reader["cresultad66"].ToString(); 
                                    resp67 = reader["cresultad67"].ToString();
                                    resp68 = reader["cresultad68"].ToString(); 
                                    resp69 = reader["cresultad69"].ToString(); 
                                    resp70 = reader["cresultad70"].ToString(); 
                                    resp71 = reader["cresultad71"].ToString(); 
                                    resp72 = reader["cresultad72"].ToString();
                                    resp73 = reader["cresultad73"].ToString(); 
                                    resp74 = reader["cresultad74"].ToString(); 
                                    resp75 = reader["cresultad75"].ToString(); 
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