

using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    /*     [ApiController]
        [Route("[controller]")] */
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext context;

        public ActivitiesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet] // /api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await this.context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] // api/activities/{id}
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await this.context.Activities.FindAsync(id);
        }
    }
}