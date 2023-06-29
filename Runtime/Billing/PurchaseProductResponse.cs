using System;
using UnityEngine.Scripting;

namespace Charix.YandexGames
{
    [Serializable]
    public class PurchaseProductResponse
    {
        [field: Preserve]
        public PurchasedProduct purchaseData;
        [field: Preserve]
        public string signature;
    }
}
