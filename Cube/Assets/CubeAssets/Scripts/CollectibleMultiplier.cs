using UnityEngine;
using System.Collections;

public class CollectibleMultiplier : MonoBehaviour {

    ScoreManager m_scoreManager;

    [SerializeField]
    private GameObject m_objWithScoreManager;
    [SerializeField]
    private int m_multiplier;

    [SerializeField]
    private AudioSource m_objWithSound;
    // Use this for initialization
    void Start () {
        m_scoreManager = m_objWithScoreManager.GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Multiplier"))
        {
            Destroy(other.gameObject);
            m_scoreManager.AddMultiplier(m_multiplier);
            m_objWithSound.Play();
            //Debug.Log("Score: " + m_score + "\n");
        }

    }
}
