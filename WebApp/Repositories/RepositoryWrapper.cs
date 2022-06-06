using WebApp.Data;

namespace WebApp.Repositories
{
    public class RepositoryWrapper
    {
        private readonly WebAppContext _context;
        private IUserRepository _user;
        public RepositoryWrapper(WebAppContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;

            }
        }
    }
}
