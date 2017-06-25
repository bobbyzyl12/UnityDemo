using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acceleratorController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float temp = Input.acceleration.x;
        transform.Translate(0.1f*temp, 0, 0);
	}
}
