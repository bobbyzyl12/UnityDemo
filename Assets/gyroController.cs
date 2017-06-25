using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroController : MonoBehaviour {

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;         //record 

    // Use this for initialization
    private void Start()
    {
        //create a game object named camera container
        cameraContainer = new GameObject("Camera Container");
        //move the camera container to where the camera is
        cameraContainer.transform.position = transform.position;
        //set camera as the children of camera container
        transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro();

    }

    //Check if the device can use gyro
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            //rot = new Quaternion(0, 0, 1, 0);
            rot = new Quaternion(0, 0, 1, 0);
            return true;
        }
        return false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "x:"+transform.localRotation.eulerAngles.x.ToString()+
                                             "y:" + transform.localRotation.eulerAngles.y.ToString()+
                                             "z:" + transform.localRotation.eulerAngles.y.ToString()
                );
    }
}
