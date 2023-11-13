using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseGameView : MonoBehaviour
{
    [SerializeField] private GameObject _view;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private Button _restartButton;

    public void DisplayView()
    {
        if (_view.activeSelf)
            return;

        _view.SetActive(true);
        _scoreText.text = $"Score: {PlayerManager.Instance.PlayerScoreController.Score}";
    }

    private void Awake()
    {
        _view.SetActive(false);
        _restartButton.onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
