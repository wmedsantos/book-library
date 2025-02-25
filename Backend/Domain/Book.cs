using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryService.Domain
{
    public class Book
    {
        [Required]
         public string Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Author { get; set; }
        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
    }
}