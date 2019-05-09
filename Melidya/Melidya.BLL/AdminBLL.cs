using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public static class AdminBLL
    {
        static DataContext datacontext = new DataContext();
        public static Admin getAdmin(string User)
        {
            return datacontext.Admin.FirstOrDefault(x => x.AUser == User);
        }
        
    }
}
