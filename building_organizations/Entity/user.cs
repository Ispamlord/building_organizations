using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_organizations.Entity
{
    public class user
    {
        public int id {  get; set; }
        public string username {  get; set; }
        public string password{  get; set; }
        public string role{  get; set; }
        public user(int id, string username, string password, string role) {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public user()
        {

        }



    }
}
