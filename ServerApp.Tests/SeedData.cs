using ServerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp.Tests
{
    internal static class SeedData
    {
        public static void Init(ApplicationDbContext context)
        {

            context.SaveChanges();
        }
    }
}
