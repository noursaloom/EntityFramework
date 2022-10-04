using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CrudDemo.Models
{
    public class BookPicture
    {
        #region --Properties
        public int Id { get; set; }
        public string PicturePath { get; set; }
        public string PictureName { get; set; }
        public string BookId { get; set; }
        #endregion
        #region Navigation Properties
        public Book Book { get; set; }
        #endregion

    }
}