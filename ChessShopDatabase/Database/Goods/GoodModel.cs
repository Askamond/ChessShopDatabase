using System.Data.Linq.Mapping;

namespace ChessShopDatabase.Database.Goods
{

    public class GoodModel
    {

        [Column(Name = "id")]
        public int Id;

        [Column(Name = "good_type_id")]
        public int GoodTypeId;

        [Column(Name = "good_type_name")]
        public string GoodTypeName;

        [Column(Name = "name")]
        public string Name;

        [Column(Name = "description")]
        public string Description;

        [Column(Name = "value")]
        public decimal Value;

        [Column(Name = "left_in_stock")]
        public int LeftInStock;

        [Column(Name = "image")]
        public byte[] ImageBytes;

        [Column(Name = "user_id")]
        public int UserId;

    }

}