using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class DetectCube : MonoBehaviour {

    [SerializeField]
    AICharacterControl m_coneAi;
    [SerializeField]
    NavMeshAgent m_coneAgent;
    [SerializeField]
    Transform coneTrans;
    [SerializeField]
    ConeExpand m_coneExpand;

    bool m_called = false;
    void OnTriggerEnter(Collider other)
    {
        if (!m_called)
        {
            if (other.CompareTag("Cube"))
            {
                m_coneAi.enabled = true;
                m_coneAgent.enabled = true;
                m_coneExpand.StartExpanding();

                m_called = false;
            }
        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
