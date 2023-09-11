using UnityEngine;

public class RotatingFigure : MonoBehaviour
{
    [SerializeField] protected float _rotateSpeed;

    protected Vector3 _rotationDirection;

    private void Awake()
    {
        _rotationDirection = Vector3.up;
    }

    private void Update()
    {
        transform.Rotate(_rotationDirection * _rotateSpeed * Time.deltaTime);
    }
}