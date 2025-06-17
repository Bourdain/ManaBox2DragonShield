namespace Mana2DragonShield.DataObjects
{
    [Serializable]
    public class ManaboxCsvDTO
    {
        public string? FolderName { get; set; }
        public string? Quantity { get; set; }
        public string? TradeQuantity { get; set; }
        public string? CardName { get; set; }
        public string? SetCode { get; set; }
        public string? SetName { get; set; }
        public string? CardNumber { get; set; }
        public string? Condition { get; set; }
        public string? Printing { get; set; }
        public string? Language { get; set; }
        public string? PriceBought { get; set; }
        public string? DateBought { get; set; }
    }
}
