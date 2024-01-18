using UnityEngine;

namespace Lesson1_3
{
    sealed class GameMain : MonoBehaviour
    {
        [SerializeField] private GameObject _ballList;
        [SerializeField] private GameObject _canvas;
        public void ExplosiveAllBalls()
        {
            _ballList.GetComponent<BallsList>().gameType = GameType.AllBalls;
            StartGame();
        }
        public void ExplosiveRedBalls()
        {
            _ballList.GetComponent<BallsList>().gameType = GameType.RedBalls;
            StartGame();
        }
        public void ExplosiveGreenBalls()
        {
            _ballList.GetComponent<BallsList>().gameType = GameType.GreenBalls;
            StartGame();
        }
        public void ExplosiveWhiteBalls()
        {
            _ballList.GetComponent<BallsList>().gameType = GameType.WhiteBalls;
            StartGame();
        }
        private void StartGame()
        {
            _ballList.SetActive(true);
            _canvas.SetActive(false);
        }
    }
    internal enum GameType{
       AllBalls,
       RedBalls,
       GreenBalls,
       WhiteBalls,
    }
}