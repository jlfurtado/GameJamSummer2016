using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WhoWon : MonoBehaviour {

    [SerializeField]
    ScoreManager m_scoreManager;
    [SerializeField]
    private int m_pointsForDefeatingCone;
    [SerializeField]
    
    // Use this for initialization
    void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cone"))
        {
            m_scoreManager.AddScore(m_scoreManager.GetMultiplier() * m_pointsForDefeatingCone);
            SceneManager.LoadScene("LevelYellow");
        }
        else if(other.CompareTag("Cube"))
        {
            SceneManager.LoadScene("GameOver");
        }

    }
        // Update is called once per frame
        void Update () {
	
	}
}
