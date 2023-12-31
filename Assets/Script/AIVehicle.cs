using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVehicle : MonoBehaviour
{
    private float SpeedOfVehicle = 20.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Mives the car forward based on vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * this.SpeedOfVehicle);
        // If there is vertical Input we can rotate
        // the car based on Horizontal Input
    }
}
