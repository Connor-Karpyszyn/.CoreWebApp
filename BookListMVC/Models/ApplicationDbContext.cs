﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // Used to inherit DbContext
		{

		}

		//Adding Book to DB
		public DbSet <Book> Books { get; set; } // Name is Book as this is the model
	}
}
