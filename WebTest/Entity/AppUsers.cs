using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Entity
{
	public class AppUsers : IdentityUser<Guid>
	{
		public int Code { get; set; }
	}
}
