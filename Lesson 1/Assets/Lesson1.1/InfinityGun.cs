using UnityEngine;
namespace Lesson1_1
{
    sealed class InfinityGun : IShooting
    {
        private GameObject _bullet;
        public void Shoot()
        {
            Debug.Log("Infinity gun shooted");
            GameObject.Instantiate(_bullet);
        }
        public void GunChoosed()
        {
            Debug.Log("Infinity gun choosed");
            _bullet = Resources.Load("Bullet") as GameObject;
        }
    }
}