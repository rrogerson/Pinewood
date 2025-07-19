using RacingDigital.Models;
using RacingDigital.Services.Interfaces;
using System.Data.SqlClient;
using Dapper;


namespace RacingDigital.Services
{
    public class RacesService : IRacesService
    {
        //public void AddCustomer(Race customer)
        //{
        //    var maxId = CustomerData.CustomerList.Max(x => x.Id);
        //    customer.Id = maxId + 1;
        //    CustomerData.CustomerList.Add(customer);
        //}

        public IEnumerable<RaceResult> GetRaces()
        {
     
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ruth_\\source\\repos\\RacingDigital\\RacingDigital.Services\\RacingDigitalDatabase.mdf;Integrated Security=True";

            // Replace with your actual SQL query
         
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var races = connection.Query<RaceResult>("SELECT * FROM dbo.Races");


            return races;
           
        }

        //public void UpdateCustomer(Race customer)
        //{
        //    var originalCustomer = CustomerData.CustomerList.FirstOrDefault(x => x.Id == customer.Id);
        //    if (originalCustomer != null)
        //    {
        //        var indexOf = CustomerData.CustomerList.IndexOf(CustomerData.CustomerList.Find(p => p.Id == customer.Id));
        //        CustomerData.CustomerList[indexOf] = customer;
        //    }
        //}
    }
}
