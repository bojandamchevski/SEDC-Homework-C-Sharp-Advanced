using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void AddUser(T user);
        int LogIn();
        void Register();
        void Track(T user);
        T ChangePassword(T user);
        int LogOut();
        T ChangeFristAndLastName(T user);
        T DeactivateAccount(T user);
    }
}
