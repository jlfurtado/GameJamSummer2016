using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WhoWon : MonoBehaviour {

    [SerializeField]
    ScoreManager m_scoreManager;
    [SerializeField]
    private int m_pointsForDefeatingCone;
    private bool m_methodCalled = false;
    
    // Use this for initialization
    void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (!m_methodCalled)
        {
            if (other.CompareTag("Cone"))
            {
                m_methodCalled = true;
                m_scoreManager.AddScore(m_scoreManager.GetMultiplier() * m_pointsForDefeatingCone);
                Destroy(other.gameObject);
                SceneManager.LoadScene("LevelYellow");
            }
            else if (other.CompareTag("Cube"))
            {
                m_methodCalled = true;
                Destroy(other.gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }


    }
        // Update is called once per frame
        void Update () {
	
	}
}
