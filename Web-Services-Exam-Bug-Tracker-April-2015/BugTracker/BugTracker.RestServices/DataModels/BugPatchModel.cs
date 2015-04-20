using BugTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.RestServices.DataModels
{
    public class BugPatchModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }
    }
}