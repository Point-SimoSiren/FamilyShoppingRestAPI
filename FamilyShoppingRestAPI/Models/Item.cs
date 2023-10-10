using System;
using System.Collections.Generic;

namespace FamilyShoppingRestAPI.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = null!;
        public int Pieces { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
