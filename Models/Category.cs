using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}