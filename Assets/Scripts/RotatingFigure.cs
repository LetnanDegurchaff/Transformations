using UnityEngine;

public class RotatingFigure : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private Vector3 _rotation;

    private void Awake()
    {
        _rotation = Vector3.up;
    }

    private void Update()
    {
        transform.Rotate(_rotation * _rotateSpeed * Time.deltaTime);
    }
}