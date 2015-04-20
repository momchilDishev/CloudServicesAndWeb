﻿namespace BugTracker.RestServices.DataModels
{
    using BugTracker.Data.Models;
    using System;
    using System.Linq.Expressions;

    public class CommentViewModel
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Author { get; set; }

        public DateTime DateCreated { get; set; }
    }
}