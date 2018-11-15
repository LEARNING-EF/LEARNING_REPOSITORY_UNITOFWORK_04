namespace Dal
{
	public interface IUnitOfWork : System.IDisposable
	{
		// **********
		IUserRepository UserRepository { get; }
		// **********

		void Save();
	}
}
