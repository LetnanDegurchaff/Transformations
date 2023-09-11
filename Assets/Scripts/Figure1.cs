using System.Collections.Generic;
using UnityEngine;

public class Figure1 : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _maxPositionZ = 2;
    private float _minPositionZ = -2;

    private List<Vector3> _targetPositions = new List<Vector3>();

    private int _currentTargetIndex = 0;

    private void Awake()
    {
        Vector3 startPosition = transform.position;

        _targetPositions.Add(new Vector3
            (startPosition.x, startPosition.y , startPosition.z + _maxPositionZ));

        _targetPositions.Add(new Vector3
            (startPosition.x, startPosition.y , startPosition.z + _minPositionZ));
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards
            (transform.position, _targetPositions[_currentTargetIndex],
            _speed * Time.deltaTime);

        if (transform.position == _targetPositions[_currentTargetIndex])
            SetNextTarget();
    }

    private void SetNextTarget()
    {
        _currentTargetIndex++;

        if (_currentTargetIndex >= _targetPositions.Count)
            _currentTargetIndex = 0;
    }
}