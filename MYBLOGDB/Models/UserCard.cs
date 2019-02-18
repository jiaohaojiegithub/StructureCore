using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class UserCard
    {
        public int UserCardId { get; set; }
        public DateTime UserCardBirthday { get; set; }
        public string UserCardChatHeadImg { get; set; }
        public DateTime UserCardCreatDt { get; set; }
        public int UserCardGmLevel { get; set; }
        public string UserCardMobilPhone { get; set; }
        public string UserCardNickname { get; set; }
        public string UserCardRemark { get; set; }
        public string UserCardSex { get; set; }
        public int UserLoginId { get; set; }

        public virtual UserLogin UserLogin { get; set; }
    }
}
