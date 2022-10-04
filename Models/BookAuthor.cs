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
        public string BookId { get; set; }
        public int CategoryId { get; set; }
        #endregion
        #region Navigation Properties
        public Book Book { get; set; }
        public Category Category { get; set; }

        #endregion  
    }
}