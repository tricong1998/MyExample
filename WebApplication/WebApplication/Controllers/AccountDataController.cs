using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;
using MySql.Data.MySqlClient;
namespace WebApplication.Controllers
{
    public class AccountDataController : ApiController
    {
        MySqlConnection mscn = new MySqlConnection(@"Data Source=localhost;Database=Account;User Id=root; Password=''");
        List<AccountData> list = new List<AccountData>();
        public void iniData()
        {
            string query = "SELECT * FROM ACCOUNT";
            MySqlCommand cmd = new MySqlCommand(query, mscn);
            mscn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AccountData accountData = new AccountData();
                accountData.ID = (int)reader["ID"];
                accountData.IDCart = (int)reader["IDCart"];
                accountData.Account = (string)reader["Account"];
                accountData.DateOfBirth = (DateTime)reader["DateOfBirth"];
                accountData.FullName = (string)reader["FullName"];
                accountData.HomeTown = (string)reader["HomeTown"];
                accountData.Religion = (string)reader["Religion"];
                accountData.Nation = (string)reader["Nation"];
                accountData.Password = (string)reader["Password"];
                list.Add(accountData);
            }
        }
        public List<AccountData> GetAccountDatas()
        {
            iniData();
            return list;
        }
        public AccountData GetAccount(String account)
        {
            iniData();
            return list.FirstOrDefault(e => e.Account == account);
        }
    }
}
