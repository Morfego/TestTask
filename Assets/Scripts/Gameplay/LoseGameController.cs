using UnityEngine;

public class LoseGameController : MonoBehaviour
{
    [SerializeField] private LoseGameView _loseGameView;

    private bool _gameLost;

    private void Start()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerHealthController.HealthUpdated += TryFinishGame;
    }

    private void TryFinishGame()
    {
        if (!_gameLost && PlayerManager.Instance.PlayerHealthController.CurrentHealth <= 0)
            FinishGame();
    }

    private void FinishGame()
    {
        _gameLost = true;
        _loseGameView.DisplayView();
    }

    private void OnDestroy()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerHealthController.HealthUpdated -= TryFinishGame;
    }
}
