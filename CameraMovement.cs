using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform _playerPos;

    private float _minCamPosX = 0f;
    private float _maxCamPosX = 6f;


    private void OnEnable()
    {
        _playerPos = FindObjectOfType<Player>().transform;
    }

    private void LateUpdate()
    {
        Vector3 _cameraPos = new Vector3(_playerPos.position.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(_cameraPos.x, _minCamPosX, _maxCamPosX), _cameraPos.y, _cameraPos.z);
    }
}
