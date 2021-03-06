using System;
using UnityEngine;

public class Door : MonoBehaviour
{
    public enum Direction
    {
        left,
        right
    };

    public Direction direction;
    
    private bool _isOpening = false;
    private bool _isClosing = false;
    private Vector3 _openPos;
    private Vector3 _origin;

    private void Start()
    {
        _origin = transform.position;
        _openPos = direction == Direction.left ? _origin + transform.forward * 3.5f: _origin - transform.forward * 3.5f;
    }

    public void Open()
    {
        _isOpening = true;
        _isClosing = false;
    }

    public void Close()
    {
        _isClosing = true;
        _isOpening = false;
    }
    
    private void Update()
    {
        if (_isOpening)
            transform.position = Vector3.Lerp(transform.position, _openPos, 10 * Time.deltaTime);
        if (_isClosing)
            transform.position = Vector3.Lerp(transform.position, _origin, 10 * Time.deltaTime);
    }
}
