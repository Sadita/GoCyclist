using System;
using System.ComponentModel.DataAnnotations;

namespace GoCyclist.Models
{
    public class Comment
    {

        public int Id { get; set; }

        public string CommentText { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CommentedAt { get; set; }

        public int ReviewId { get; set; }
        public Review Review { get; set; }

    }

}