using System.ComponentModel.DataAnnotations;

namespace _430testmvc.Models;

    public class Book
    {
        [Key]
        public int book_ID { get; set; }
        [Required]
        public char book_name { get; set; }
        public char ISBN { get; set; }
        public char author { get; set; }
        public char publicsh { get; set; }
        public int book_borrow_ID { get; set; }
        public int  user_ID { get; set; }
    }

