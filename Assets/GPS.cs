using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GPS : MonoBehaviour {

    public float lat;
    public float lon;
    // Use this for initialization    
    void Start()
    {
        Input.location.Start();
    }

    void Update()
    {
        //Do nothing if location services are not available
        if (Input.location.isEnabledByUser)
        {
            lat = Input.location.lastData.latitude;
            lon = Input.location.lastData.longitude;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 500, 500, 80), "纬度:" + lat);
        GUI.Label(new Rect(50, 600, 500, 80), "经度:" + lon);
    }

}
