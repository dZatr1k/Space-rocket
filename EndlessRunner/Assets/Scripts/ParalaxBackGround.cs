using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class ParalaxBackGround : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _ratioLerp;

    private RawImage _image;
    private float _imagePositionX;
    private float _startSpeed;

    private void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePositionX = _image.uvRect.x;
    }
    private void Update()
    {
        _imagePositionX += _startSpeed * Time.deltaTime;
        _startSpeed = Mathf.Lerp(_startSpeed, _speed ,Time.deltaTime * _ratioLerp);

        if (_imagePositionX > 1)
            _imagePositionX = 0;

        _image.uvRect = new Rect(_imagePositionX, _image.uvRect.y, _image.uvRect.width, _image.uvRect.height);
    }
}
