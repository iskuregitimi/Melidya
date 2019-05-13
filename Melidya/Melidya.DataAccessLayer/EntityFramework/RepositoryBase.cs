using Melidya.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugunNeYesem.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        protected static DataContext context;
        private static object _lock = new object();

        protected RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (context == null)
            {
                lock (_lock)
                {
                    if (context == null)
                    {
                        context = new DataContext();
                    }
                }
            }
        }
    }
}
