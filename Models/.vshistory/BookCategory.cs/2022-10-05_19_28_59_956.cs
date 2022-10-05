using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class BookCategory
    {
        #region --Properties
        public int Id { get; set; }
        [ForeignKey("Book")]
        public string BookId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        #endregion
        #region Navigation Properties
        public Book Book { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}