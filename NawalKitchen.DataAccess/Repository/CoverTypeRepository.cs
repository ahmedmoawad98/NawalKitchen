using NawalKitchen.DataAccess.Repository.IRepository;
using NawalKitchen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawalKitchen.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        

        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
