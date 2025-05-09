using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _transformCenter;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _transformCenter.position;
    }
    private void Update()
    {
        transform.position = _transformCenter.position + _offset;
        transform.RotateAround(_transformCenter.position,Vector3.up, _speed* Time.deltaTime);
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
        _offset = transform.position - _transformCenter.position;
    }
}
