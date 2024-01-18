using UnityEngine;

namespace Lesson1_2
{
    sealed class DealerArmor : Dealer, IDealer
    {
        public void GetMessage() => Debug.Log("Armor selling");
    }
}