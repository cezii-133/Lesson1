using UnityEngine;

namespace Lesson1_2
{
    public class Dealer : MonoBehaviour , IDealer
    {
        private IDealer dealer;
        private void Awake() => dealer = new DealerNone();
        private void Update()
        {
            if (Input.GetKeyDown("1"))
                dealer = new DealerNone();

            if (Input.GetKeyDown("2"))
                dealer = new DealerArmor();

            if (Input.GetKeyDown("3"))
                dealer = new DealerFruits();
        }
        public void GetMessage()
        {
            Debug.Log("Player hit dealer");
            dealer.GetMessage();
        }
    }
}