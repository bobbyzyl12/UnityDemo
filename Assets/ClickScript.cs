using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickScript : MonoBehaviour {

    public void Clicked() {
        Debug.Log("clicked");
        string passwordInput = GameObject.Find("LonInput").GetComponent<InputField>().text;
        Debug.Log(passwordInput);
    }
}
