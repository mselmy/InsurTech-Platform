using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;
using insurtech.Models;

namespace insurtech.Authorization.Users
{
    //Asmaa
    public enum UserType
    {
        Admin,
        Customer,
        Company
    }//
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

       

        public ICollection<Request> Requests { get; set; }=new List<Request>();
        public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();


        //=================

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
