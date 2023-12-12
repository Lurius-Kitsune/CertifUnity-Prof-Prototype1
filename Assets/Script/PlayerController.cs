using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SpeedOfVehicle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Log Time.deltaTime
        transform.Translate(Vector3.forward * Time.deltaTime * this.SpeedOfVehicle);
    }
}
