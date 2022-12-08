using HW_14__InventoryAPI.Models;
using System.Globalization;
using static System.Net.WebRequestMethods;

namespace HW_14__InventoryAPI.Services
{
    public class ActionWithProductService
    {
        InventoryService inventoryService;
        public ActionWithProductService(InventoryService inventory)
        {
            this.inventoryService = inventory;
        }

        public List<ProductModel> SortByType(string type)
        {
            List<ProductModel> SortedProducts = new List<ProductModel>();
            for (int i = 0; i < inventoryService.products.Count; i++)
            {
                if (inventoryService.products[i].Type == type)
                    SortedProducts.Add(inventoryService.products[i]);
            }
            return SortedProducts;

        }

        public string CountInvSum()
        {
            decimal InvSum = 0M;
            for (int i = 0; i < inventoryService.products.Count; i++)
            {
                InvSum += inventoryService.products[i].Amount * inventoryService.products[i].Price;
            }

            return $"Complete inventory price is: {InvSum.ToString("C2", CultureInfo.CurrentCulture)}";
        }

        public void AddProductToList(ProductModel product)
        {
            inventoryService.products.Add(product);
        }

        public List<ProductModel> ViewAllProducts()
        {
            return inventoryService.products;
        }
    }
}
