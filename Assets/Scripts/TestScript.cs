using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{


    [SerializeField] private int count;
    [SerializeField] private int step = 100;
    [SerializeField] private int first, second;

    private bool isActiveTrain = true;
    private bool anotherTrain;

    private Rigidbody _rigidbody;

    private float positionX = 1.5f;
    [SerializeField] private float _speed = 5f;

    private void Start()
    {
        //print(count);
        //print(step);

        //print(anotherTrain);

        //anotherTrain = true;

        //print(anotherTrain);
        //print(isActiveTrain);


        var pose = transform.position;
        transform.position = pose;

        _rigidbody = GetComponent<Rigidbody>();

        if(first > second) {
            print($"{first} больше {second}");
        }

        else
        {
            print($"{second} больше {first}");
        }
        

    }


    private void OnEnable()
    {


        if (first > second)
        {
            print($"{first} больше {second}");
        }

        else if (first == second)
        {
            print($"{second} равно {first}");
        }

        else
        {
            print($"{second} больше {first}");
        }

        
    }

    private void Update()
    {
        var direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction = direction * _speed;
        transform.Translate(direction * Time.deltaTime);
        _rigidbody.AddForce(direction);
        
    }
}
