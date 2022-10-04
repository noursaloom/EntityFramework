using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class BookAuthor
    {
        #region --Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        #region Navigation Properties
        public ICollection<Book> Books { get; set; }
        #endregion  
    }
}