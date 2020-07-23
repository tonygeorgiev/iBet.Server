namespace iBet.Server.Services.Identity.Services
{
    public interface ICurrentUserService
    {
        string GetUserName();
        string GetId();
    }
}