using System;
using System.Data.Linq.Mapping;

namespace ChessShopDatabase.Database.Users
{

    public class UserModel
    {

        [Column(Name = "id")]
        public int Id;

        [Column(Name = "user_type_id")]
        public int UserTypeId;

        [Column(Name = "create_date")]
        public DateTime CreateDate;

        [Column(Name = "user_login")]
        public string UserLogin;

        [Column(Name = "is_banned")]
        public bool IsBanned;

        [Column(Name = "ban_cause")]
        public string BanCause;

    }

}