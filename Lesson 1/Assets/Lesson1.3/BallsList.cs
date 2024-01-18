using UnityEngine;
using System.Collections.Generic;
using System.Linq;
namespace Lesson1_3
{
    sealed class BallsList : MonoBehaviour
    {
        internal static event System.Action<IBall> OnBallExposed;
        internal GameType gameType;

        [SerializeField] private List<RedBall> _redBalls = new List<RedBall>();
        [SerializeField] private List<WhiteBall> _whiteBalls = new List<WhiteBall>();
        [SerializeField] private List<GreenBall> _greenBalls = new List<GreenBall>();
        private List<IBall> _balls = new List<IBall>();

        private void Start()
        {
            _balls.AddRange(_redBalls);
            _balls.AddRange(_whiteBalls);
            _balls.AddRange(_greenBalls);
            OnBallExposed += SubstractBall;
        }
        private void OnApplicationQuit() => OnBallExposed -= SubstractBall;
        internal static void BallExplosed(IBall ball) => OnBallExposed?.Invoke(ball);
        internal void SubstractBall(IBall ball)
        {
            _balls.Remove(ball);
            RemoveBall(ball);
            Debug.Log($"Removed ball {ball}");
        }
        private void RemoveBall(IBall ball)
        {
            switch (ball)
            {
                case RedBall:
                    _redBalls.Remove(_redBalls.Last());
                    break;

                case WhiteBall:
                    _whiteBalls.Remove(_whiteBalls.Last());
                    break;

                case GreenBall:
                    _greenBalls.Remove(_greenBalls.Last());
                    break;
            }
            CheckWin();
        }
        private void CheckWin()
        {
            switch (gameType)
            {
                case GameType.AllBalls:
                    if (_balls.Count == 0)
                        Debug.LogError("Game end");
                    break;

                case GameType.RedBalls:
                    if (_redBalls.Count == 0)
                        Debug.LogError("Game end");
                    break;

                case GameType.GreenBalls:
                    if (_greenBalls.Count == 0)
                        Debug.LogError("Game end");
                    break;

                case GameType.WhiteBalls:
                    if (_whiteBalls.Count == 0)
                        Debug.LogError("Game end");
                    break;
            }
        }
    }
}