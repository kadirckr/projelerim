using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3.Data.Repositories
{
   public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(denemeEntities dbContext)
            : base(dbContext)
        {

        }
        
        public UserRepository(denemeEntities dbContext)
            :base(dbContext)
        {

        }
    }
}
