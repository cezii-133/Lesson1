using UnityEngine;

namespace Lesson1_1
{
    sealed class Player : MonoBehaviour
    {
        private Gun _gun;

        private void Start()
        {
            _gun = new Gun();
            _gun.ChooseGun(new StandardGun());
        }
        private void Update()
        {
            if (Input.GetKeyDown("1"))
                _gun.ChooseGun(new StandardGun());

            if (Input.GetKeyDown("2"))
                _gun.ChooseGun(new InfinityGun());

            if (Input.GetKeyDown("3"))
                _gun.ChooseGun(new MultiGun());

            if (Input.GetMouseButtonDown(0))
                _gun.Shoot();
        }
    }
}