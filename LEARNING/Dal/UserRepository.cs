using System.Linq;

namespace Dal
{
	public class UserRepository : Repository<Models.User>, IUserRepository
	{
		internal UserRepository(Models.DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public System.Collections.Generic.IList<Models.User> GetActiveUsers()
		{
			var result =
				Get()
				.Where(current => current.IsActive)
				.ToList()
				;

			return result;
		}
	}
}
