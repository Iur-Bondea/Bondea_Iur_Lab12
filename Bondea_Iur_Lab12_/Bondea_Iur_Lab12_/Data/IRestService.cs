using System;
using System.Collections.Generic;
using System.Text;

namespace Bondea_Iur_Lab12_.Data
{
    interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
