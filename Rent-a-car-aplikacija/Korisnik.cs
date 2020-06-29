using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car_aplikacija
{
    [Serializable]
    class Korisnik
    {
        protected string username;
        protected string password;

        public bool daLiJeSifraTacna(string unos, string lozinka) {
            if (unos.Equals(lozinka))
            {
                return true;
            }
            else
                return false;
        }

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
    }

}
