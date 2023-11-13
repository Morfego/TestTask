using TMPro;
using UnityEngine;

public class PlayerScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;

    private void Start()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerScoreController.ScoreUpdated += UpdateView;

        UpdateView();
    }

    private void UpdateView()
    {
        if (PlayerManager.Instance)
            _score.text = $"Score: {Mathf.CeilToInt(PlayerManager.Instance.PlayerScoreController.Score)}";
    }

    private void OnDestroy()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerScoreController.ScoreUpdated -= UpdateView;
    }
}
