namespace ChessShopDatabase.Helpers
{

    public sealed class UserInfo
    {

        private static UserInfo _instance;

        private UserInfo()
        {
            
        }

        public static UserInfo Instance =>
            _instance ?? (_instance = new UserInfo());

        public int Id
        {
            get;

            set;
        }

        public UserTypes UserType
        {
            get;

            set;
        }

    }

}