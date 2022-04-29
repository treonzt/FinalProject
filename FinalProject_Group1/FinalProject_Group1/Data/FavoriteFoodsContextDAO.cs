using FinalProject_Group1.Interfaces;
using FinalProject_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Data
{
    public class FavoriteFoodsContextDAO : IFavoriteFoodsContextDAO
    {
        private FavoriteFoodsContext _context;
        public FavoriteFoodsContextDAO(FavoriteFoodsContext context)
        {
            _context = context;
        }

        public List<FavoriteFoods> GetAllFavoriteFoodss()
        {
            return _context.FavoriteFoods.ToList();
        }

        public object GetFavoriteFoodsByID(int id)
        {
            return _context.FavoriteFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

    }
}
