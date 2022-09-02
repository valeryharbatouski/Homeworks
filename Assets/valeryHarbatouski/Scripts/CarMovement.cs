using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    private Rigidbody _rigidbody;

    [SerializeField] private float _speed = 30f;
    [SerializeField] public Color _color;


    private void Start()
    {

        var pose = transform.position;
        transform.position = pose;

        _rigidbody = GetComponent<Rigidbody>();
        _color = Color.white;
        name = "Машинка";

    }


    private void FixedUpdate()
    {
        var direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction = direction * _speed;
        _rigidbody.AddForce(direction);
        
        
    }

}
