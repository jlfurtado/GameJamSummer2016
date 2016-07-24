using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelEnd : MonoBehaviour {

    private float m_animationTimer = 0.0f;
    private bool m_animating = false;
    [SerializeField]
    private string m_nextLevelString = "";
    [SerializeField]
    private float m_totalAnimationTime = 3.0f;
    [SerializeField]
    private float m_riseSpeed = 1.0f;

    private GameObject m_cube;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (m_animating)
        {
            m_animationTimer += Time.deltaTime;
            m_cube.transform.Translate(new Vector3(0.0f, m_riseSpeed * Time.deltaTime, 0.0f));
            if (m_animationTimer > m_totalAnimationTime)
            {
                LoadNextLevel();
            }
        }   
	}

    void LoadNextLevel()
    {
        if (!m_nextLevelString.Equals(""))
        {
            SceneManager.LoadScene(m_nextLevelString);
        }
        else
        {
            Debug.Log("Warning: You touched a goal that was not set up to load the next level!\n");
        }

        m_animating = false;
        m_animationTimer = 0.0f;
    }

    void OnTriggerEnter(Collider other)
    {
        // if colliding with CUBE
        if (other.CompareTag("Player"))
        {
            m_cube = other.gameObject;
            m_animating = true;
            m_animationTimer = 0.0f;
        }
    }
}
