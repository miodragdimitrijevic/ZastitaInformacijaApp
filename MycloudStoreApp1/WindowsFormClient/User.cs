using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClient
{
    public class User
    {

        private string ime;
        private string pass;

        public User()
        {

        }
        public User(string ime, string pass)
        {
            this.ime = ime;
            this.pass = pass;

        }
        public string Ime
        {
            get
            {
                return this.ime;
            }
            set
            {
                this.ime = value;
            }
        }
        public string Pass
        {
            get
            {
                return this.pass;

            }
            set
            {
                this.pass = value;
            }
        }
    }
}
