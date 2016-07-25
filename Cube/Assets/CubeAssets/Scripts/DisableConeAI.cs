using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class DisableConeAI : MonoBehaviour
{

    [SerializeField]
    AICharacterControl m_coneAi;
    [SerializeField]
    NavMeshAgent m_coneAgent;
    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cone"))
        {
            m_coneAi.enabled = false;
            m_coneAgent.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
