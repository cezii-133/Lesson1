namespace Lesson1_1
{
    sealed class Gun
    {
        private IShooting _shooting;
        internal void ChooseGun(IShooting _shooting)
        {
            this._shooting = _shooting;
            _shooting.GunChoosed();
        }
        internal void Shoot() => _shooting.Shoot();
    }
}