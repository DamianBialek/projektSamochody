using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace projektSamochody.Classes
{
    class DB
    {
        static string connectionString = "Server=localhost;Database=projektSamochody;Trusted_Connection=true";

        public static DataSet pobierzWszystkieRekordy(string nazwaTabeli, string kolumny = "*")
        {
            string query = "SELECT " + kolumny + " FROM " + nazwaTabeli;
            DataSet dataSet = new DataSet();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                 SqlDataAdapter dataAdapter = new SqlDataAdapter();
                 dataAdapter.SelectCommand = new SqlCommand(query, conn);
                dataAdapter.Fill(dataSet);

                return dataSet;
            }
        }

        public static void wstawDane(string nazwaTabeli, List<Samochod> listaSamochodow)
        {
            string query = "INSERT INTO "+nazwaTabeli+"([samochody_marka],[samochody_model],[samochody_rocznik],[samochody_predkosc],[samochody_iloscPaliwaWBaku],[samochody_pojemnoscBaku],[samochody_srednieSpalanie],[samochody_silnikWlaczony],[samochody_predkoscMaksymalna])VALUES(@marka, @model, @rocznik, @predkosc, @iloscPaliwaWBaku, @pojemnoscBaku, @srednieSpalanie, @silnikWlaczony, @predkoscMaksymalna)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand deleteAllCommand = new SqlCommand("DELETE FROM " + nazwaTabeli, conn);
                deleteAllCommand.ExecuteNonQuery();


                foreach (Samochod samochod in listaSamochodow)
                {
                    SqlCommand insertCommand = new SqlCommand(query, conn);

                    insertCommand.Parameters.Add(new SqlParameter("marka", samochod.pobierzMarke()));
                    insertCommand.Parameters.Add(new SqlParameter("model", samochod.pobierzModel()));
                    insertCommand.Parameters.Add(new SqlParameter("rocznik", samochod.pobierzRocznik()));
                    insertCommand.Parameters.Add(new SqlParameter("predkosc", samochod.pobierzPredkosc()));
                    insertCommand.Parameters.Add(new SqlParameter("iloscPaliwaWBaku", samochod.pobierzStanBaku()));
                    insertCommand.Parameters.Add(new SqlParameter("pojemnoscBaku", samochod.pobierzPojemnoscBaku()));
                    insertCommand.Parameters.Add(new SqlParameter("srednieSpalanie", samochod.pobierzSrednieSpalanie()));
                    insertCommand.Parameters.Add(new SqlParameter("silnikWlaczony", samochod.pobierzStanSilnika()));
                    insertCommand.Parameters.Add(new SqlParameter("predkoscMaksymalna", samochod.pobierzPredkoscMaksymalna()));

                    Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());

                }
            }
        }
    }
}
