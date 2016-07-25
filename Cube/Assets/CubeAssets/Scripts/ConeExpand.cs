using UnityEngine;
using System.Collections;

public class ConeExpand : MonoBehaviour {


    [SerializeField]
    float endX;
    [SerializeField]
    float endY;
    [SerializeField]
    float endZ;

    float time = 0;
    float maxTime = 2.0f;


    bool isExpanding = false;

	// Use this for initialization
	void Start () {
	
	}
	
    public void StartExpanding()
    {
        isExpanding = true;
    }

	// Update is called once per frame
	void Update () {


        if (isExpanding)
        {
            time += Time.deltaTime;
            float dX = transform.localScale.x + (endX  * Time.deltaTime);
            float dY = transform.localScale.y + (endY * Time.deltaTime);
            float dZ = transform.localScale.z + (endZ * Time.deltaTime);

            transform.localScale = new Vector3(dX,dY,dZ);

            if(time >= maxTime)
            {
                isExpanding = false;
            }
        }
	}
}
