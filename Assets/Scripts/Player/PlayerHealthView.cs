using TMPro;
using UnityEngine;

public class PlayerHealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _health;

    private void Start()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerHealthController.HealthUpdated += UpdateView;

        UpdateView();
    }

    private void UpdateView()
    {
        if (PlayerManager.Instance)
            _health.text = $"Health: {Mathf.CeilToInt(PlayerManager.Instance.PlayerHealthController.CurrentHealth)}";
    }

    private void OnDestroy()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerHealthController.HealthUpdated -= UpdateView;
    }
}
