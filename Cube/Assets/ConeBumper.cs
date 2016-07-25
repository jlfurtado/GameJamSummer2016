using UnityEngine;
using System.Collections;

public class ConeBumper : MonoBehaviour {

    [SerializeField] CubeControl m_cube;
    [SerializeField] float m_force = 1000.0f;
	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cube"))
        {
            m_cube.Bump(transform.forward, m_force*10);

            GetComponent<Rigidbody>().AddForce(-transform.forward * m_force * .4f, ForceMode.Acceleration);
        }
    }




	// Update is called once per frame
	void Update () {
	


	}
}
