using UnityEngine;

namespace Lesson1_1
{
    sealed class MultiGun : IShooting
    {
        private GameObject _bullet;
        private int _bulletsAmount = 15;
        public void Shoot()
        {
            if (_bulletsAmount > 3)
            {
                Debug.Log("Multi gun shooted");
                for (int i = 0; i < 3; i++)
                    GameObject.Instantiate(_bullet);
                _bulletsAmount -= 3;
                Debug.Log($"Lefted {_bulletsAmount}");
            }
            else
            {
                Debug.Log("Bullets amount equals to zero");
            }
        }
        public void GunChoosed()
        {
            _bullet = Resources.Load("Bullet") as GameObject;
            Debug.Log("Multi gun choosed");
        }
    }
}