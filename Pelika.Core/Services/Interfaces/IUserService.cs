using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pelika.Core.DTOs;
using Pelika.DataLayer.Entities.User;
using Pelika.DataLayer.Entities.Wallet;

namespace Pelika.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserById(int userId);
        User GetUserByActiveCode(string activeCode);
        User GetUserBuUserName(string username);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);
        int GetUserIdByUserName(string username);
        void DeleteUser(int userId);

        #region UserPanel

        InformationUserViewModel GetUserInformation(string username);
        InformationUserViewModel GetUserInformation(int userid);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void EditProfile(string username, EditProfileViewModel profile);
        bool CompareOldPassword(string OldPassword, string username);
        void ChangeUserPassword(string username, string newPassword);

        #endregion

        #region Wallet

        int BalanceUserWallet(string username);
        List<WalletViewMOdel> GetWalletUser(string username);
        int ChargeWallet(string userName, int amount,string description ,bool isPay = false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);
   

        #endregion

        #region Admin Panel

        UserForAdminViewModel GetUsers(int pagrId = 1, string filterEmail = "", string filterUsername = "");
        UserForAdminViewModel GetDeleteUsers(int pagrId = 1, string filterEmail = "", string filterUsername = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);

        #endregion

        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
