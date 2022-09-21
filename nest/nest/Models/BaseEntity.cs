using System;
namespace nest.Models
{
	public class BaseEntity
	{
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Modified { get; set; }
    }
}

