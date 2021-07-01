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

        public Formula CreateFormula(Formula formula)
        {
            db.Formulas.Add(formula);
            db.SaveChanges();
            return formula;
        }

        public PhotoFormula CreateFormulaListPhoTo(PhotoFormula photoFormula)
        {
            db.PhotoFormulas.Add(photoFormula);
            db.SaveChanges();
            return photoFormula;
        }

        public List<Formula> FindAllFormula()
        {
            return db.Formulas.Where(f => f.ForStatus == 1).ToList();

        }

        public List<Formula> FindAllNewFormula()
        {
            return db.Formulas.OrderByDescending(f => f.ForId).Take(6).ToList();
        }

        public List<Formula> Search(string keyword)
        {
            return db.Formulas.Where(a => a.ForName.ToLower().Contains(keyword.ToLower())).ToList(); 

        }
    }
}
