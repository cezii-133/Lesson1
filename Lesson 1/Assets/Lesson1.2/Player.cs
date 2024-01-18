using UnityEngine;

namespace Lesson1_2
{
    public class Player : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IDealer dealer))
            {
                CheckDealerStatus(dealer);
            }
        }
        private void CheckDealerStatus(IDealer dealer) => dealer.GetMessage();
    }
}