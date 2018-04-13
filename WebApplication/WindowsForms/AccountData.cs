using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net;

namespace WindowsForms
{
    public class AccountData
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string  IDCart { set; get; }
        public string HomeTown { set; get; }
        public string Nation { set; get; }
        public string Religion { set; get; }
        public string DateOfBirth { get; set; }
        public string FullName { set; get; }
        public void GetData(String account)
        {
            AccountData accountData = new AccountData();
            HttpClient client = new HttpClient();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62591/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/AccountData?Account=" + account).Result;

            if (response.IsSuccessStatusCode)
            {
                accountData = response.Content.ReadAsAsync<AccountData>().Result;

            }
            this.ID = accountData.ID;
            this.IDCart = accountData.IDCart;
            this.HomeTown = accountData.HomeTown;
            this.Account = accountData.Account;
            this.DateOfBirth = accountData.DateOfBirth;
            this.FullName = accountData.FullName;
            this.Nation = accountData.Nation;
            this.Religion = accountData.Religion;
            this.Password = accountData.Password;
        }
    }
  
}
