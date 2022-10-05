using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class BookCategory
    {
        #region --Properties
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        #endregion
        #region Navigation Properties
        public Book Book { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}