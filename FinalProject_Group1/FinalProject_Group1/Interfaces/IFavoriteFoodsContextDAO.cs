using FinalProject_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Group1.Interfaces
{
    public interface IFavoriteFoodsContextDAO
    {
        List<FavoriteFoods> GetAllFavoriteFoodss();
        object GetFavoriteFoodsByID(int id);
    }
}
