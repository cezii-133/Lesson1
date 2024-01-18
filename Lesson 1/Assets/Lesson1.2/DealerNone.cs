using UnityEngine;

namespace Lesson1_2
{
    sealed class DealerNone : Dealer, IDealer
    {
        public void GetMessage() => Debug.Log("Nothing to sell");
    }
}