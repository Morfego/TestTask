using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private KeyCode _moveLeftInput;
    [SerializeField] private KeyCode _moveRightInput;

    private void Update()
    {
        if (Input.GetKey(_moveLeftInput))
            Move(-1);
        else if (Input.GetKey(_moveRightInput))
            Move(1);
    }

    private void Move(int direction)
    {
        float positionX = Mathf.Clamp(transform.position.x + _playerData.PlayerMoveSpeed * Time.deltaTime * direction, _playerData.PlayerMinPositionX, _playerData.PlayerMaxPositionX);
        transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
    }
}
