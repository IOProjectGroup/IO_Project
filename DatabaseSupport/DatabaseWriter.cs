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
        //public String AddTownToDatabase(String townName)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddTown";
        //        myCommand.Parameters.Add(new SqlParameter("nazwa", townName));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddCarToDatabase(string brand, string model, double cost, DateTime dateOfProduction, DateTime dateOfPurchase, string registrationNumber)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddCars";
        //        myCommand.Parameters.Add(new SqlParameter("marka", brand));
        //        myCommand.Parameters.Add(new SqlParameter("model", model));
        //        myCommand.Parameters.Add(new SqlParameter("koszt_zakupu", cost));
        //        myCommand.Parameters.Add(new SqlParameter("rok_produkcji", dateOfProduction));
        //        myCommand.Parameters.Add(new SqlParameter("rok_zakupu", dateOfPurchase));
        //        myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddRepairsToDatabase(string registrationNumber, double cost, DateTime dateOfRepair, String specification)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddRepairs";
        //        myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
        //        myCommand.Parameters.Add(new SqlParameter("koszt", cost));
        //        myCommand.Parameters.Add(new SqlParameter("data_naprawy", dateOfRepair));
        //        myCommand.Parameters.Add(new SqlParameter("opis", specification));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddAdditionalCostsToDatabase(string pesel, string registrationNumber, double additionalCost, String specification)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddAdditionalCosts";
        //        myCommand.Parameters.Add(new SqlParameter("pesel", pesel));
        //        myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
        //        myCommand.Parameters.Add(new SqlParameter("koszt_dodatkowy", additionalCost));
        //        myCommand.Parameters.Add(new SqlParameter("opis", specification));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddDriverToDatabase(string name, string surname, string pesel)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddDriver";
        //        myCommand.Parameters.Add(new SqlParameter("imie", name));
        //        myCommand.Parameters.Add(new SqlParameter("nazwisko", surname));
        //        myCommand.Parameters.Add(new SqlParameter("pesel", pesel));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddRefuelToDatabase(string registrationNumber, double cost, double fuel)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddRefuel";
        //        myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
        //        myCommand.Parameters.Add(new SqlParameter("koszt", cost));
        //        myCommand.Parameters.Add(new SqlParameter("paliwo", fuel));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddInsuranceToDatabase(string registrationNumber, double cost, DateTime dateOfPurchase, DateTime dateOfExpiry)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddInsurance";
        //        myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
        //        myCommand.Parameters.Add(new SqlParameter("koszt", cost));
        //        myCommand.Parameters.Add(new SqlParameter("data_zakupu", dateOfPurchase));
        //        myCommand.Parameters.Add(new SqlParameter("data_waznosci", dateOfExpiry));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}

        //public String AddRouteToDatabase(string pesel, string registrationNumber, double mileageCounterStart, double mileageCounterEnd, String startTown, String endTown)
        //{
        //    String message = "";
        //    DatabaseConnection myConnection = DatabaseConnection.Instance;
        //    message += myConnection.OpenConnection();

        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection.Connect;
        //        myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        myCommand.CommandText = "AddRoute";
        //        myCommand.Parameters.Add(new SqlParameter("pesel", pesel));
        //        myCommand.Parameters.Add(new SqlParameter("nr_rejestracyjny", registrationNumber));
        //        myCommand.Parameters.Add(new SqlParameter("stan_licznika_przed", mileageCounterStart));
        //        myCommand.Parameters.Add(new SqlParameter("stan_licznika_po", mileageCounterEnd));
        //        myCommand.Parameters.Add(new SqlParameter("miasto_poczatkowe", startTown));
        //        myCommand.Parameters.Add(new SqlParameter("miasto_koncowe", endTown));

        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        message += e.Message;
        //    }

        //    message += myConnection.CloseConnection();
        //    return message;
        //}
    }
}
