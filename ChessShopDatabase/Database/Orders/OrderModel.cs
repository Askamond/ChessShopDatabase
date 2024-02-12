using System.Data.Linq.Mapping;

namespace ChessShopDatabase.Database.Orders
{

    public class OrderModel
    {

        [Column(Name = "row_id")]
        public int RowId;

        [Column(Name = "order_id")]
        public int OrderId;
            
        [Column(Name = "user_id")]
        public int UserId;
            
        [Column(Name = "good_id")]
        public int GoodId;
            
        [Column(Name = "count")]
        public int Count;

        [Column(Name = "closed")]
        public bool Closed;

    }

}