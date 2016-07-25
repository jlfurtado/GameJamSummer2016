using UnityEngine;
using System.Collections;

public class TurnUprightCube : MonoBehaviour {

	// Use this for initialization
	
    [SerializeField]
    GameObject cube;
    [SerializeField]
    GameObject cubeWinsText;
    [SerializeField]
    GameObject returnToMain;
    [SerializeField]
    float waitTime = .5f;

    float time;

    bool startTime = false;

    // Use this for initialization

    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {

            startTime = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime)
        {
            time += Time.deltaTime;
        }

        if (time >= waitTime)
        {
            Vector3 temp = transform.position;
            temp.y = .5f * 2.089339f;
            Instantiate(returnToMain);
            Instantiate(cubeWinsText);
            Instantiate(cube, temp, new Quaternion());
            Destroy(gameObject);
        }

    }
}
