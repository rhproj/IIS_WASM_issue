using Microsoft.EntityFrameworkCore;

namespace BzrIIStest.Server.Repo
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly AppDbContext _appDbContext;
        public ValuesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<string>> GetCatName()
        {
            return await _appDbContext.CatNames.Select(x => x.Name).ToListAsync();
        }
    }
}
