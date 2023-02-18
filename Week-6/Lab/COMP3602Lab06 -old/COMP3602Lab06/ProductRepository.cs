using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class ProductRepository
    {
        private const string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433; 
                                                      Initial Catalog=TigerDB;
                                                      User ID=tiger;
                                                      Password=T1gerM@ster;
                                                      Encrypt=True;
                                                      TrustServerCertificate=True;
                                                      Connection Timeout=30;";

        private const string productTableName = "ProductDemo";
    }
}
