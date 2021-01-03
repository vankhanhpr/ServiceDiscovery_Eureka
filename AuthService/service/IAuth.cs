using ModelClassLibrary.area.respond;
using ModelClassLibrary.area.user;

namespace AuthServer.service
{
    public interface IAuth
    {
        DataRespond login(Users user,string lang);
        Users getUser(Users user);
    }
}
