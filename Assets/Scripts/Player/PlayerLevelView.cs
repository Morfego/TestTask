using TMPro;
using UnityEngine;

public class PlayerLevelView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _exp;

    private void Start()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerLevelController.ExpUpdated += UpdateView;

        UpdateView();
    }

    private void UpdateView()
    {
        if (!PlayerManager.Instance)
            return;

        var expController = PlayerManager.Instance.PlayerLevelController;

        if (expController.MaxLevel)
            _exp.text = "Max Level";
        else
            _exp.text = $"Level: {expController.LevelToDisplay} \nExp: {Mathf.CeilToInt(expController.Exp)}/{Mathf.CeilToInt(expController.ExpRequired)}";
    }

    private void OnDestroy()
    {
        if (PlayerManager.Instance)
            PlayerManager.Instance.PlayerLevelController.ExpUpdated -= UpdateView;
    }
}
