using UnityEngine;
using System.Collections;

public class LightOnOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Light>().enabled = false;
        GetComponent<Light>().enabled = true;
    }
	
	
}
