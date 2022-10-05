using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class Book
    {
        #region --Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("BookAuthor")]
        public int BookAuthorId { get; set; } 
        
        [ForeignKey("BookCategory")]
        public int  CategoryId { get; set; }

        #endregion
        #region Navigation Properties
        public BookAuthor BookAuthor { get; set; }
        public Category BookCategory { get; set; }
        #endregion
    }
}