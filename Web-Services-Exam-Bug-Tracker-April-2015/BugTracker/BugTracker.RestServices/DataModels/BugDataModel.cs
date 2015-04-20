namespace BugTracker.RestServices.DataModels
{
    using BugTracker.Data.Models;
    using System;
    using System.Linq.Expressions;
    public class BugDataModel
    {
        public static Expression<Func<Bug, BugDataModel>> DataModel
        {
            get
            {
                return x => new BugDataModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Status = (Status)x.StatusType,
                    Author = x.Author.UserName,
                    DateCreated = x.DateCreated
                };
            }
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Status Status { get; set; }

        public string Author { get; set; }

        public DateTime DateCreated { get; set; }
    }
}