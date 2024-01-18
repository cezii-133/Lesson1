using UnityEngine;

namespace Lesson1_1
{
    sealed class StandardGun : IShooting
    {
        private int _bulletsAmount = 5;
        private GameObject _bullet;
        public void Shoot()
        {
            if (_bulletsAmount > 0)
            {
                Debug.Log("Standard gun shooted");
                GameObject.Instantiate(_bullet);
                _bulletsAmount--;
                Debug.Log($"Lefted {_bulletsAmount}");
            }
            else
            {
                Debug.Log("Bullets amount equals to zero");
            }
        }
        public void GunChoosed()
        {
            Debug.Log("Standard gun choosed");
            _bullet = Resources.Load("Bullet") as GameObject;
        }
    }
}