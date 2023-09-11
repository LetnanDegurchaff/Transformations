using System.Collections.Generic;
using UnityEngine;

public class LoopingScalingFigure : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _maxScale = 1.5f;

    private List<Vector3> _targetScales = new List<Vector3>();

    private int _currentTargetIndex = 0;

    private void Awake()
    {
        Vector3 startScale = transform.localScale;

        _targetScales.Add(new Vector3
            (startScale.x, startScale.y, startScale.z));

        _targetScales.Add(new Vector3
            (startScale.x * _maxScale, startScale.y * _maxScale, startScale.z * _maxScale));
    }

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards
            (transform.localScale, _targetScales[_currentTargetIndex],
            _speed * Time.deltaTime);

        if (transform.localScale == _targetScales[_currentTargetIndex])
            SetNextTarget();
    }

    private void SetNextTarget()
    {
        _currentTargetIndex++;

        if (_currentTargetIndex >= _targetScales.Count)
            _currentTargetIndex = 0;
    }
}