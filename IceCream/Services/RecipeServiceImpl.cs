using IceCream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Services
{
    public class RecipeServiceImpl : RecipeService
    {
        public DatabaseContext db;
        public RecipeServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<Formula> FindAllFormula()
        {
            return db.Formulas.ToList();
        }

        public List<Formula> FindAllNewFormula()
        {
            return db.Formulas.OrderByDescending(f => f.ForId).Take(6).ToList();
        }
    }
}
