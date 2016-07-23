using UnityEngine;
using System.Collections;

public class DiamondSpin : MonoBehaviour {

    [SerializeField]
    private int m_rotateSpeed = 60; // rotate speed in degrees
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    transform.Rotate(0, m_rotateSpeed * Time.deltaTime, 0);
	}
}
