using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour {
    GameObject gb;
    void Start()
    {
        gb = GameObject.Find("Cube");
    }

    public void hideButtonClicked() {
        if (gb.active == true)
        {
            gb.SetActive(false);

        }
        else if (gb.active == false)
        {
            gb.SetActive(true);
        }
    }
}
