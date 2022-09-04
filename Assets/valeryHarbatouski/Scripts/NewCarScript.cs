using UnityEngine;
using TMPro;

public class NewCarScript : MonoBehaviour
    
{
    [SerializeField] private WheelCollider[] _wheels;

    [SerializeField] private float maxMotorTorque = 10f;
    [SerializeField] private float maxSteeringAngle = 10f;
    [SerializeField] private Transform _centerOfMass;

    public TextMeshProUGUI coinsText;
    private int coinsCounter = 0;
    private GameObject coin;


    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = _centerOfMass.position;
        coinsText.text = "0";
        gameObject.tag = "coin";
    }


    void FixedUpdate()
    {
        for (int i = 0; i <_wheels.Length; i++)
        {
            var wheel = _wheels[i];
            wheel.motorTorque = Input.GetAxis("Vertical") * maxMotorTorque;
            wheel.steerAngle = Input.GetAxis("Horizontal") * maxSteeringAngle;

            if (Input.GetKey(KeyCode.Space) == true)
            {
                wheel.brakeTorque = Mathf.Pow(maxMotorTorque, 3);
                
            }

            else
            {
                wheel.brakeTorque = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        coinsCounter = coinsCounter + 5;
        coinsText.text = coinsCounter.ToString();
        Debug.Log("collected");
        

    }
}
