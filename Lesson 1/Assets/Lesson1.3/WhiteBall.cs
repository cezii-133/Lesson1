using UnityEngine;

namespace Lesson1_3
{
    sealed class WhiteBall : MonoBehaviour, IBall
    {
        private void OnMouseDown()
        {
            Debug.Log("White ball explosed");
            this.gameObject.SetActive(false);
            BallsList.BallExplosed(this);
        }
    }
}