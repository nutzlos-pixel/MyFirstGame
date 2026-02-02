using UnityEngine;
using UnityEngine.Rendering;

public class PlayerControler : MonoBehaviour
{
    private float speedVehicle = 15.0f;
    private float turnSpeed = 35.0f;
    private float verticalInput;
    private float horizontalInput;

    void Start()
    {
        
    }
    
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speedVehicle * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
