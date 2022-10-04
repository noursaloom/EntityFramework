using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class Book
    {
        #region --Properties
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int BookAuthorId { get; set; }
        #endregion
        #region Navigation Properties
        public BookAuthor BookAuthor { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<BookPicture> BookPictures { get; set; }
        #endregion
    }
}