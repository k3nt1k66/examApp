using WebApplication2.Dtos
using System;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace WebApplication2.AsyncDataServices
{
	public async Task<IEnumerable<PersonEmailDto>> GetPeopleWithEmailsAsync()
	{
		using (var context = new ApplicationDbContext())
		{
			var people = await context.People
				.Join(context.EmailAddresses,
					p => p.PersonId,
					e => e.PersonId,
					(p, e) => new PersonEmailDto
					{
						PersonId = p.PersonId,
						FirstName = p.FirstName,
						LastName = p.LastName,
						Email = e.Email
					})
				.ToListAsync();

			return people;
		}
	}
}