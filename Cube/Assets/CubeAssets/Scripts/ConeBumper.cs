using UnityEngine;
using System.Collections;

public class ConeBumper : MonoBehaviour {

    [SerializeField] Rigidbody m_cone;
    [SerializeField] float m_force = 1000.0f;
	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cone"))
        {
            m_cone.AddForce(transform.forward* m_force* 1.3f, ForceMode.Acceleration);

            GetComponent<Rigidbody>().AddForce(-transform.forward * m_force * .5f, ForceMode.VelocityChange);
        }
    }




	// Update is called once per frame
	void Update () {
	


	}
}
