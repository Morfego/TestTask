using UnityEngine;

public class RandomColorController : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private void OnEnable()
    {
        var color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        _renderer.material.color = color;
    }
}
