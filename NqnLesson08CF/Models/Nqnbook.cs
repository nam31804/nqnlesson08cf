using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NqnLesson08CF.Models
{
    /// <summary>
    /// Tao ra cau truc bang book
    /// </summary>
    public class Nqnbook
    {
        [Key]
        public int NqnbookId { get; set; }
        public string NqnTitle { get; set; }
        public string NqnAuthor { get; set; }
        public int NqnYear { get; set; }
        public string NqnPicture { get; set; }
        public int NqnCategoryId { get; set; }
        // thuoc tinh quan he
        public virtual NqnCategory NqnCategory { get; set; }
    }
}