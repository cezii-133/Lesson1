using UnityEngine;

namespace Lesson1_2
{
    sealed class DealerFruits : Dealer, IDealer
    {
        public void GetMessage() => Debug.Log("Fruits selling");
    }
}