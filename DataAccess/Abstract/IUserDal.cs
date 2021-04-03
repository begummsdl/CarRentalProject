using Core.DataAccesss;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        //joinleyerek kullanıcının claimleri çekilcek
        List<OperationClaim> GetClaims(User user);
    }
}
