using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; } // ID is a number therefore int, ID is the name we are calling the prop
		
		[Required]
		public string Name { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
	}
}
