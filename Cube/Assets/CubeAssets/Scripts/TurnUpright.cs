using UnityEngine;
using System.Collections;

public class TurnUpright : MonoBehaviour {
    [SerializeField] GameObject cone;
    [SerializeField]
    GameObject coneWinsText;
    [SerializeField]
    GameObject toMain;
    [SerializeField] float waitTime = .5f;

    float time;

    bool startTime = false;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {

            startTime = true;
        }
    }

    // Update is called once per frame
    void Update () {
       if(startTime)
        {
            time += Time.deltaTime;
        }

        if (time >= waitTime) {
            Vector3 temp = transform.position;
            temp.y = 0;
            Instantiate(toMain);
            Instantiate(coneWinsText);
            Instantiate(cone, temp, new Quaternion());
            Destroy(gameObject);
        }


    }
}
