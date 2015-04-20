namespace BugTracker.RestServices.Controllers
{
    using BugTracker.Data;
    using System.Web.Http;
    public abstract class BaseApiController : ApiController
    {
        private BugTrackerDbContext data;

        protected BaseApiController()
            : this(new BugTrackerDbContext())
        {
        }

        protected BaseApiController(BugTrackerDbContext data)
        {
            this.Data = data;
        }

        protected BugTrackerDbContext Data
        {
            get
            {
                return this.data;
            }
            private set
            {
                this.data = value;
            }
        }
    }
}