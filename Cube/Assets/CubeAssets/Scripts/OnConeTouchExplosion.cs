using UnityEngine;
using System.Collections;

public class OnConeTouchExplosion : MonoBehaviour {

    [SerializeField] GameObject m_explosion;


	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cone"))
        {
            Instantiate(m_explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }


	// Update is called once per frame
	void Update () {
	    
	}
}
