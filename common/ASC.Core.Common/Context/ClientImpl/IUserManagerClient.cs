using System;
using ASC.Core.Users;

namespace ASC.Core
{
    public interface IUserManagerClient
    {
        #region Users

        UserInfo[] GetUsers();

        UserInfo GetUsers(Guid userID);

        UserInfo GetUsers(int tenant, string login, string password);

        UserInfo SaveUserInfo(UserInfo userInfo);

        void DeleteUser(Guid userID);

        void SaveUserPhoto(Guid userID, Guid moduleID, byte[] photo);

        byte[] GetUserPhoto(Guid userID, Guid moduleID);

        bool UserExists(Guid userID);

        UserInfo[] GetUsers(EmployeeStatus status);

        string[] GetUserNames(EmployeeStatus status);

        UserInfo GetUserByUserName(string userName);

        bool IsUserNameExists(string userName);

        UserInfo GetUserByEmail(string email);

        UserInfo[] Search(string text, EmployeeStatus status);

        UserInfo[] Search(string text, EmployeeStatus status, Guid groupId);


        GroupInfo[] GetUserGroups(Guid userID);

        GroupInfo[] GetUserGroups(Guid userID, IncludeType includeType);

        GroupInfo[] GetUserGroups(Guid userID, Guid categoryID);

        UserInfo[] GetUsersByGroup(Guid groupID);

        bool IsUserInGroup(Guid userID, Guid groupID);

        void AddUserIntoGroup(Guid userID, Guid groupID);

        void RemoveUserFromGroup(Guid userID, Guid groupID);

        #endregion


        #region Company

        UserInfo GetCompanyCEO();

        void SetCompanyCEO(Guid userId);

        GroupInfo[] GetDepartments();

        Guid GetDepartmentManager(Guid deparmentID);

        void SetDepartmentManager(Guid deparmentID, Guid userID);

        #endregion
    }
}