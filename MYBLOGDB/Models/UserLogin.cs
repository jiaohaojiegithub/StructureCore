using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class UserLogin
    {
        public UserLogin()
        {
            UserCard = new HashSet<UserCard>();
        }

        public int UserLoginId { get; set; }
        public DateTime UserLoginCreatDt { get; set; }
        public Guid UserLoginGuid { get; set; }
        public string UserLoginName { get; set; }
        public string UserLoginPassWord { get; set; }
        public bool UserLoginState { get; set; }

        public virtual ICollection<UserCard> UserCard { get; set; }
    }
}
