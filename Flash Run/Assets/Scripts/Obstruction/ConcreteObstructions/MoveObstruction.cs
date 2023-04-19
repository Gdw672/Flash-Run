using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstruction : MonoBehaviour
{
   [SerializeField] private float _speed;
   [SerializeField] private float _distance;
   [SerializeField] private bool _isVertical;
    private float _passed;

    private Rigidbody _rigidbody;

    private bool firsrLoop = true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(_passed) < Mathf.Abs(_distance))
        {
            if (!_isVertical)
                _rigidbody.transform.Translate(_speed, 0, 0);
            else
                _rigidbody.transform.Translate(0, _speed, 0);
            _passed += _speed;
        }
        else
        {
            _speed = -_speed;
            _passed = 0;
            if(firsrLoop)
            {
                firsrLoop = false;
                _distance *= 2;
            }
        }
    }
}
