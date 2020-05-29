using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blawasm.Models
{
    public class TodoItemModel
    {
        public Guid SystemId { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime CompletedTime { get; set; }
        public bool Completed { get; set; } = false;

        [StringLength(maximumLength: 20, MinimumLength = 1, ErrorMessage = "Title must be 1-20 characters long")]
        public string Title { get; set; } = "";
        [StringLength(maximumLength: 100, MinimumLength = 0, ErrorMessage = "Description must be 0-20 characters long")]
        public string Description { get; set; } = "";




    }
}
