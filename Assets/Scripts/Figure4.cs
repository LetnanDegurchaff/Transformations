using UnityEngine;

public class Figure4 : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _moveSpeed;

    private Vector3 _rotationDirection;
    private Vector3 _moveDirection;

    private void Awake()
    {
        _rotationDirection = Vector3.up;
        _moveDirection = Vector3.forward;
    }

    private void Update()
    {
        transform.Rotate(_rotationDirection * _rotateSpeed * Time.deltaTime);
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime);
    }
}