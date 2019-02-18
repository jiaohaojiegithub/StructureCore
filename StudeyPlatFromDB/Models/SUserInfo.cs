using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SUserInfo
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Openid { get; set; }
        public string Username { get; set; }
        public string Nickname { get; set; }
        public string Headimgurl { get; set; }
        public int? Sex { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string Depotid { get; set; }
        public string Depotname { get; set; }
        public string Position { get; set; }
        public int? RealIntegral { get; set; }
        public int? AllIntegral { get; set; }
        public int? Grade { get; set; }
        public string Unionid { get; set; }
        public int? Usertype { get; set; }
        public int? Isreg { get; set; }
        public DateTime? Regdate { get; set; }
        public int? Commentnum { get; set; }
        public int? Replynum { get; set; }
        public int? Feedbacknum { get; set; }
        public DateTime? Crdate { get; set; }
        public string Upuid { get; set; }
        public int? Status { get; set; }
    }
}
