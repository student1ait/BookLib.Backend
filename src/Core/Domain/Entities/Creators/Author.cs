﻿using Domain.Entities.Relationships;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
	public class Author : Entity
	{
		public string Name { get; set; }

		public string LastName { get; set; }

		public DateOnly DateBirth { get; set; }

		public DateOnly DateDeath { get; set; }

		public string Description { get; set; }


		// Navigations links
		public IList<BookAuthor> BookAuthors { get; set; }
	}
}
