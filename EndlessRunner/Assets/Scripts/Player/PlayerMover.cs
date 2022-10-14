using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _rotationAngle;

    private Vector3 _targetPosition;
    private Tween _tween;
    private void Start()
    {
        _targetPosition = transform.position;
        
        _tween = transform.DOMove(new Vector3(-15, transform.position.y, transform.position.z), 1).From().SetEase(Ease.OutSine);
    }

    private void Update()
    {
        if(transform.position != _targetPosition && !_tween.active)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, Time.deltaTime * _speed);
            
    }
    public void TryMoveUp()
    {
        if(_targetPosition.y < _maxHeight && !_tween.active)
            MadeMove(_stepSize, _rotationAngle);
    }
    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight && !_tween.active)
            MadeMove(-_stepSize, -_rotationAngle);
    }

    private void MadeMove(float stepSize, float rotationAngle)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
        transform.DORotate(new Vector3(0, 0, rotationAngle), 0.2f).SetEase(Ease.OutSine);
        transform.DORotate(new Vector3(0, 0, 0), 0.2f).SetDelay(0.2f).SetEase(Ease.InSine);
    }
}
