using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.DataAccess
{
    public class BookShopInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
    }
}