using DevExpress.Xpo;
using DevExpressXpoDemo.Xdb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressXpoDemo
{
    public static class Sabitler
    {
        public static UnitOfWork uow = new UnitOfWork();
        public static Oturumlar oturumlars = null;
        public static string userName, userPassword;
        public static string adminName, adminPassword;
        public static int userId, adminId;
        public static bool IsAdmin;

        public static string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var item in host.AddressList)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    item.ToString();
                }
            }
            return "Ağ kartı bulunmamaktadır";
        }

        public static void SessionAdmin()
        {
            oturumlars = new Oturumlar(Sabitler.uow)
            {
                UserName = adminName,
                MachineName = Environment.MachineName,
                WinUsername = Environment.UserName,
                IP = GetIP(),
                LoginDate = DateTime.Now,
                IsAdmin = IsAdmin,
            };
        }
        public static void SessionUser()
        {
            oturumlars = new Oturumlar(Sabitler.uow)
            {
                UserName = userName,
                MachineName = Environment.MachineName,
                WinUsername = Environment.UserName,
                IP = GetIP(),
                LoginDate = DateTime.Now,
                IsAdmin = IsAdmin,
            };
        }
    }
}
