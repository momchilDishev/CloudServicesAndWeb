namespace BugTracker.RestServices.Controllers
{
    using System.Linq;
    using BugTracker.Data;
    using System.Web.Http;
    using BugTracker.RestServices.DataModels;
    using BugTracker.Data.Models;
    using BugTracker.RestServices.BindingModels;
    using System;
    using System.Net;

    public class BugsController : BaseApiController
    {
        [HttpGet]
        public IHttpActionResult GetBugs()
        {
            var bugs = this.Data.Bugs
                .OrderByDescending(x => x.DateCreated)
                .Select(BugDataModel.DataModel);

            return this.Ok(bugs);
        }

        [HttpGet]
        public IHttpActionResult GetBugById(int id)
        {
            var bug = this.Data.Bugs
                .Select(BugDataModelWithDetails.DataModel)
                .FirstOrDefault(x => x.Id == id);

            if (bug == null)
            {
                return this.NotFound();
            }

            return this.Ok(bug);

        }

        [HttpPost]
        public IHttpActionResult PostBug(BugBindingModel model)
        {
            if (model == null || !this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var bug = new Bug
            {
                Title = model.Title,
                Description = (model.Description != null) ? model.Description : null,
                StatusType = Status.Open,
                DateCreated = DateTime.Now,
            };

            this.Data.Bugs.Add(bug);
            this.Data.SaveChanges();

            return this.CreatedAtRoute("DefaultApi", new { id = bug.Id }, bug);
        }

        [HttpPatch]
        public IHttpActionResult PatchBug(int id, BugPatchModel model)
        {
            if (model == null || !this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var bug = this.Data.Bugs.FirstOrDefault(x => x.Id == id);
            if (bug == null)
            {
                return this.NotFound();
            }

            if (model.Description != null)
            {
                bug.Description = model.Description;
            }
            if (model.Title != null)
            {
                bug.Title = model.Title;
            }
            if (model.Status != null)
            {
                bug.StatusType = model.Status;
            }
            this.Data.SaveChanges();

            return this.Ok(new
            {
                Messages = string.Format("Bug #{0} patched.", bug.Id)

            });
        }

        [HttpDelete]
        public IHttpActionResult DeleteBugById(int id)
        {
            var bug = this.Data.Bugs.Find(id);
            if (bug == null)
            {
                return this.NotFound();
            }

            this.Data.Bugs.Remove(bug);
            this.Data.SaveChanges();

            return this.Ok(new
            {
                Messages = string.Format("Bug #{0} deleted.", bug.Id)

            });
        }

    }

}