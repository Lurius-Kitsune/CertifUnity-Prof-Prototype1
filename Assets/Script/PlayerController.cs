using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float SpeedOfVehicle = 20.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float verticalInput;
    public bool player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (player2)
        {
            case true:
                horizontalInput = Input.GetAxis("Horizontal2");
                verticalInput = Input.GetAxis("Vertical2");
                break;

            case false:
                horizontalInput = Input.GetAxis("Horizontal");
                verticalInput = Input.GetAxis("Vertical");
            break;
        }

        // Mives the car forward based on vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * this.SpeedOfVehicle * verticalInput);
        // If there is vertical Input we can rotate
        // the car based on Horizontal Input
        if (verticalInput != 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * this.turnSpeed * horizontalInput);
        }
    }
}
