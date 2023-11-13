using TMPro;
using UnityEngine;

public class BulletShootControllerView : MonoBehaviour
{
    [SerializeField] private BulletShootController _bulletShootController;
    [SerializeField] private TextMeshProUGUI _cooldownText;

    private void Update()
    {
        float currentCooldown = _bulletShootController.CurrentCooldown;
        _cooldownText.text = currentCooldown > 0 ? $"Skill on cooldown ({Mathf.CeilToInt(currentCooldown)})" : $"Press Y to use skill";
    }
}
