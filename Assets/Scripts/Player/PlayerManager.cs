using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    [SerializeField] private PlayerLevelController _playerLevelController;
    [SerializeField] private PlayerHealthController _playerHealthController;
    [SerializeField] private PlayerScoreController _playerScoreController;

    public PlayerLevelController PlayerLevelController => _playerLevelController;
    public PlayerHealthController PlayerHealthController => _playerHealthController;
    public PlayerScoreController PlayerScoreController => _playerScoreController;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
