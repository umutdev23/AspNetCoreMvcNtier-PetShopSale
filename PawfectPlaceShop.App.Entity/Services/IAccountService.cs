using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Services
{
    public interface IAccountService
    {
        Task<string> CreateUserAsync(RegisterViewModel model);
        Task<string> FindByNameAsync(LoginViewModel model);
        Task<UserViewModel> Find(string username);
        Task<string> CreateRoleAsync(RoleViewModel model);
        Task<List<RoleViewModel>> GetAllRoles();
        Task<List<UserViewModel>> GetAllUsers();
        Task<UsersInOrOutViewModel> GetAllUsersWithRole(string id);
        Task<RoleViewModel> FindRoleByIdAsync(string id);

        Task<string> EditRoleListAsync(EditRoleViewModel model);

        Task SignOutAsync();
    }
}
