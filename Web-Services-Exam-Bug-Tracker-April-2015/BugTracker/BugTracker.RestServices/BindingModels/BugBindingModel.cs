namespace BugTracker.RestServices.BindingModels
{
    using BugTracker.Data.Models;
    using System.ComponentModel.DataAnnotations;
    public class BugBindingModel
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

    }
}