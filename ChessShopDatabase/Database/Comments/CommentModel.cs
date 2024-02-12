using System;

namespace ChessShopDatabase.Database.Comments
{

    public class CommentModel
    {
        
        public int Id;
        
        public int UserId;
        
        public int GoodId;

        public string Content;

        public DateTime CreateDate;

    }

}