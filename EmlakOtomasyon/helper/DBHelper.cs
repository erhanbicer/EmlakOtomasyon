using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using EmlakOtomasyon.model;
using System;

namespace EmlakOtomasyon.helper
{
    class DBHelper
    {
        private static DBHelper instance = null;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private DataTable dt;

        private DBHelper()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            cmd = new SqlCommand("", con);
            dt = new DataTable();
        }

        public static DBHelper getInstance()
        {
            if (instance == null)
            {
                instance = new DBHelper();
            }

            return instance;
        }

        public bool isLogin(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            bool login = cmd.ExecuteReader().Read();
            con.Close();

            return login;
        }

        // bağlantı kapandığı için geriye ExecuteReader döndüremiyor
        public SqlDataReader executeReader(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
         
            con.Close();

            return dr;
        }

        public Emlak executeSingleGayrimenkulRowReader(string sqlStatement)
        {
            var emlak = new Emlak();

            con.Open();
            cmd.CommandText = sqlStatement;
            
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Enums.HomeTypeEnum tipi;
                    Enums.TypeOfHeating isitma_turu;
                    Enums.HomeStatus durumu;

                    Enum.TryParse(reader.GetString("tipi"), out tipi);
                    Enum.TryParse(reader.GetString("isitma_turu"), out isitma_turu);
                    Enum.TryParse(reader.GetString("durumu"), out durumu);
                    int oda = reader.GetInt32("oda_sayisi");
                    int salon = reader.GetInt32("salon_sayisi");
                    string fiyat = reader.GetString("fiyat");
                    int Id = reader.GetInt32("Id");

                    switch(tipi)
                    {
                        case Enums.HomeTypeEnum.Apartman:
                            int kat = reader.GetInt32("kat");
                            bool balkon = reader.GetBoolean("is_balkon");
                            emlak = new ApartmanDairesi(oda, salon, isitma_turu, durumu, Id, fiyat, tipi, kat, balkon);

                            break;
                        case Enums.HomeTypeEnum.Müstakil:
                            bool garaj = reader.GetBoolean("is_garaj");
                            bool bahce = reader.GetBoolean("is_balkon");
                            emlak = new MustakilEv(oda, salon, isitma_turu, durumu, Id, fiyat, tipi, bahce, garaj);
                            break;
                        case Enums.HomeTypeEnum.Yazlık:
                            bool havuz = reader.GetBoolean("is_havuz");
                            Enums.Manzara manzara;

                            Enum.TryParse(reader.GetString("manzara"), out manzara);
                            emlak = new YazlikEv(oda, salon, isitma_turu, durumu, Id, fiyat, tipi, havuz, manzara);
                            break;
                    }
                }
            }

            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            con.Close();

            return emlak;
        }

        public int executeNonQuery(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            int result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        public object executeScalar(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            object obj = cmd.ExecuteScalar();
            con.Close();

            return obj;
        }

        public DataTable executeDataTable(string sqlStatement)
        {
            con.Open();
            cmd.CommandText = sqlStatement;
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            con.Close();

            return dt.Copy();
        }
    }
}
