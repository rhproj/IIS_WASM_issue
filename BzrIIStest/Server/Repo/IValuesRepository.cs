namespace BzrIIStest.Server.Repo
{
    public interface IValuesRepository
    {
        Task<IEnumerable<string>> GetCatName();
    }
}