using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace CompoundInterestCalculatorAdds_In
{
    public class database
    {
        public OleDbConnection connection;
        public database()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\40722\Desktop\C# VSTO proiect\pension.accdb";
        }
        public bool insert_data_into_table(string nume, float investitie_initiala,
            float dobanda, float varsta_pensionare, float investitie_lunara,
            float dobanda_acumulata, float investitie_totala)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT into data (Nume, Investitie_initiala, Dobanda, Varsta_pensionare," +
                " Investitie_lunara, Dobanda_acumulata, Investitie_totala) Values" +
                "" +
                "(@nume, @investitie_initiala,@dobanda,@varsta_pensionare" +
                ",@investitie_lunara,@dobanda_acumulata,@investitie_totala)");
            cmd.Connection = connection;
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@nume", OleDbType.VarChar).Value = nume;
                cmd.Parameters.Add("@investitie_initiala", OleDbType.Double).Value = investitie_initiala;
                cmd.Parameters.Add("@dobanda", OleDbType.Double).Value = dobanda;
                cmd.Parameters.Add("@varsta_pensionare", OleDbType.Double).Value = varsta_pensionare;
                cmd.Parameters.Add("@investitie_lunara", OleDbType.Double).Value = investitie_lunara;
                cmd.Parameters.Add("@dobanda_acumulata", OleDbType.Double).Value = dobanda_acumulata;
                cmd.Parameters.Add("@investitie_totala", OleDbType.Double).Value = investitie_totala;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pensia clientului " + nume + " a fost adaugata cu succes");
                    connection.Close();
                    return true;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Conexiunea a esuat");
                return false;
            }
        }

    }
}
