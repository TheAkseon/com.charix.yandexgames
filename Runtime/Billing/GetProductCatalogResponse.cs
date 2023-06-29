using System;
using UnityEngine.Scripting;

namespace Charix.YandexGames
{
    [Serializable]
    public class GetProductCatalogResponse
    {
        [field: Preserve]
        public CatalogProduct[] products;
    }
}
