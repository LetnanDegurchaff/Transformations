using UnityEngine;

public class LoopingMovingSpinningFigure : SpinningFigure
{
    [SerializeField] private float _moveSpeed;

    private Vector3 _moveDirection;

    private void Start()
    {
        _moveDirection = Vector3.forward;
    }

    private void Update()
    {
        transform.Rotate(_rotationDirection * _rotateSpeed * Time.deltaTime);
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime);
    }
}