using System;
using System.Collections.Generic;
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
        #endregion
        #region Navigation Properties
        public BookAuthor BookAuthor { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<BookPicture> BookPictures { get; set; }
        #endregion
    }
}