using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    class User
    {
        private string sifre;
        private string kadi;

        public void setUserName(string uName)
        {
            kadi = uName;
        }
        public string getUserName()
        {
            return kadi;

        }
        public void setPassword(string pwd)
        {
            sifre = pwd;
        }
        public string getPassword()
        {
            return sifre;
        }
    }
}
