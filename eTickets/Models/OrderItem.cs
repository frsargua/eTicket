using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
	public class OrderItem
	{
        [Key]
        public int Id { set; get; }
        public int amount { set; get; }
        public double price { set; get; }

        public int MovieId { set; get; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { set; get; }

        public int OrderId { set; get; }
        [ForeignKey("OrderId")]
        public virtual Order Order { set; get; }
    }
}

