using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystem.DAL.Gateway;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.BLL
{
    
    public class ItemManager
    {
        ItemGateway itemGateway=new ItemGateway();

        public string Save(Item item)
        {
            if (itemGateway.IsNameExists(item.Name))
            {
                return "Item Name Exists";
            }
            int rowAffected = itemGateway.Save(item);
            if (rowAffected > 0)
                return "Item Saved Successfully";
            return "Item Saved failed";
        }
    }
}