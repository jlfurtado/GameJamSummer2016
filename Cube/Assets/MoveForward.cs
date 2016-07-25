using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    [SerializeField]
    float lifetime = 1.0f;

    float cur_time = 0;

   
    [SerializeField]
    float exploSpeed = 50;
    [SerializeField]
    Transform m_exploPos;


    // Use this for initialization
    void Start () {
        //m_instances = instances - 1;
        GetComponent<Rigidbody>().AddExplosionForce(exploSpeed, m_exploPos.position, 10);
    }
	
	// Update is called once per frame
	void Update () {


        

        cur_time += Time.deltaTime;

        if (cur_time >= lifetime)
        {
            Destroy(gameObject);
        }

	}
}
