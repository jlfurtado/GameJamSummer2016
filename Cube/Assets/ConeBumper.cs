using UnityEngine;
using System.Collections;

public class ConeBumper : MonoBehaviour {

    [SerializeField] CubeControl m_cube;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cube"))
        {
            m_cube.Bump(transform.forward, 1000.0f);

            GetComponent<Rigidbody>().AddForce(-transform.forward * 1000.0f);
        }
    }




	// Update is called once per frame
	void Update () {
	


	}
}
