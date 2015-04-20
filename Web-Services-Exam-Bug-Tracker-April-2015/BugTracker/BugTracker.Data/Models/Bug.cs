
namespace BugTracker.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Bug
    {
        private ICollection<Comment> comments;
        public Bug()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        [Index(IsUnique = true)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }

        [EnumDataType(typeof(Status))]
        public virtual Status StatusType { get; set; }
        public virtual User Author { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }
}
