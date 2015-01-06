using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseSupport;

namespace DatabaseSupport
{
    public class DatabaseWriter
    {
        public String addTownToDatabase(String townName)
        {
            String message = null;
            DatabaseConnection myConnection = DatabaseConnection.Instance;
            try
            {
                myConnection.Connect.Open();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection.Connect;
                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                myCommand.CommandText = "AddTown";
                myCommand.Parameters.Add(new SqlParameter("nazwa", townName));

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                myConnection.Connect.Close();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public String addCarToDatabase(string brand, string model, double cost, DateTime dateOfProduction, DateTime dateOfPurchase, string registrationNumber)
        {
            String message = null;
            DatabaseConnection myConnection = DatabaseConnection.Instance;
            try
            {
                myConnection.Connect.Open();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection.Connect;
                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                myCommand.CommandText = "AddCars";
                myCommand.Parameters.Add(new SqlParameter("marka", brand));
                myCommand.Parameters.Add(new SqlParameter("model", model));
                myCommand.Parameters.Add(new SqlParameter("koszt_zakupu", cost));
                myCommand.Parameters.Add(new SqlParameter("rok_produkcji", dateOfProduction));
                myCommand.Parameters.Add(new SqlParameter("rok_zakupu", dateOfPurchase));
                myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                myConnection.Connect.Close();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public String addRepairsToDatabase(string registrationNumber, double cost, DateTime dateOfRepair, String specification)
        {
            String message = null;
            DatabaseConnection myConnection = DatabaseConnection.Instance;
            try
            {
                myConnection.Connect.Open();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection.Connect;
                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                myCommand.CommandText = "AddRepairs";
                myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
                myCommand.Parameters.Add(new SqlParameter("koszt", cost));
                myCommand.Parameters.Add(new SqlParameter("data_naprawy", dateOfRepair));
                myCommand.Parameters.Add(new SqlParameter("opis", specification));

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                myConnection.Connect.Close();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public String addAdditionalCostsToDatabase(string pesel, string registrationNumber, double additionalCost, String specification)
        {
            String message = null;
            DatabaseConnection myConnection = DatabaseConnection.Instance;
            try
            {
                myConnection.Connect.Open();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection.Connect;
                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                myCommand.CommandText = "AddAdditionalCosts";
                myCommand.Parameters.Add(new SqlParameter("pesel", pesel));
                myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
                myCommand.Parameters.Add(new SqlParameter("koszt_dodatkowy", additionalCost));
                myCommand.Parameters.Add(new SqlParameter("opis", specification));

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            try
            {
                myConnection.Connect.Close();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }
    }
}
