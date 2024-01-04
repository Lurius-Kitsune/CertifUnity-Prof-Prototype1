using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject backCam;
    private bool cameraToogle;
    public Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 backCamPos;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
        backCamPos = backCam.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cameraToogle = Input.GetButton("Fire1");
        switch (cameraToogle)
        {
            case false:
                backCam.SetActive(false);
                break;
            case true:
                backCam.SetActive(true);
                break;
        }
        transform.position = player.transform.position + this.offset;
        backCam.transform.position = player.transform.position + this.backCamPos;
    }
}
