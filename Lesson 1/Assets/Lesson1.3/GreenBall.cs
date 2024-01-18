using UnityEngine;

namespace Lesson1_3
{
    sealed class GreenBall : MonoBehaviour, IBall
    {
        private void OnMouseDown()
        {
            Debug.Log("Green ball explosed");
            this.gameObject.SetActive(false);
            BallsList.BallExplosed(this);
        }
    }
}