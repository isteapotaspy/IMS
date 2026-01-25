using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum FoodType { 
    Viand,
    Rice, 
    Desert,
}

namespace IMS.Domain.Models
{
    internal class FoodClass
    {
        [Key]
        Guid FoodID { get; set; }

        String FoodName { get; set; }

        decimal FoodPrice { get; set; }

        // Blob or PNG of the food or something
        // CRITICAL: Make sure that this can be NULLABLE.
        // Don't fetch it if it's already CACHED or not NEEDED
        // To reduce memory issues.

        FoodType TypeOfFood { get; set; }

        bool isAlaCarte { get; set; }
        bool isAvailable { get; set; }
    }

    internal class Menu
    {
        [Key]
        Guid MenuID { get; set; }
        String MenuName { get; set; }
        List<FoodClass> FoodsInMenu { get; set; }
    }

    internal class MealOrder
    {
        [Key]
        Guid MealOrderID { get; set; }

        // CRITICAL: Make sure that this order is 

        DateTime OrderDate { get; set; }
        List<FoodClass> FoodsOrdered { get; set; }
        
        decimal? TotalPrice { get; set; }      

        // CHORE: evaluate this ONLY WHEN NEEDED, NOT NOW
        //{ 
        //    get 
        //    {
        //        decimal total = 0;
        //        foreach (var food in FoodsOrdered)
        //        {
        //            total += food.FoodPrice;
        //        }
        //        return total;
        //    }
        //}
    }

    internal class MealPackage
    {
        [Key]
        Guid MealPackageID { get; set; }
        String PackageName { get; set; }
        List<FoodClass> FoodsInPackage { get; set; }
        decimal PackagePrice { get; set; }
    }

}
