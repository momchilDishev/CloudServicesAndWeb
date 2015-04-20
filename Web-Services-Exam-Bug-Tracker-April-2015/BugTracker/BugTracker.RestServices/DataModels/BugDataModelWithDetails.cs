

namespace BugTracker.RestServices.DataModels
{
    using BugTracker.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    public class BugDataModelWithDetails
    {
        public static Expression<Func<Bug, BugDataModelWithDetails>> DataModel
        {
            get
            {
                return x => new BugDataModelWithDetails()
                {

                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Status = x.StatusType,
                    Author = x.Author,
                    DateCreated = x.DateCreated,
                    Comments = x.Comments
                };
            }
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public virtual User Author { get; set; }

        public DateTime DateCreated { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}