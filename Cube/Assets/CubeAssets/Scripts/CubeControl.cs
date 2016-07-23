using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class CubeControl : MonoBehaviour {


    Vector3 m_up;

	// Use this for initialization
	void Start () {
        m_up = new Vector3(0, 1.0f, 0);

    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(m_up, CrossPlatformInputManager.GetAxis("Horizontal"));


	}
}
