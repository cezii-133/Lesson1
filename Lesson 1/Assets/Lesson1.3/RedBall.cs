using UnityEngine;

namespace Lesson1_3
{
    sealed class RedBall : MonoBehaviour, IBall
    {
        private void OnMouseDown()
        {
            Debug.Log("Red ball explosed");
            this.gameObject.SetActive(false);
            BallsList.BallExplosed(this);
        }
    }
}