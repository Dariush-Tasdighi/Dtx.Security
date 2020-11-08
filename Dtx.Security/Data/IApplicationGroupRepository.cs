using Models;
using System;
using System.Collections.Generic;

namespace Data
{
	public interface IApplicationGroupRepository
	{
		IList<Membership> GetMemberships(Guid id);
	}
}