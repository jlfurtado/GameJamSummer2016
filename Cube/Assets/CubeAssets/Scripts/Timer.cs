using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
    [SerializeField]
    private int m_totalSeconds = 30;
    private int m_secondsRemaining = 0;
    private float m_secondTimer = 0.0f;

    [SerializeField]
    Text m_timeRemainingText;

	// Use this for initialization
	void Start () {
        m_secondsRemaining = m_totalSeconds;
	}
	
    public int GetSecondsRemaining()
    {
        return m_secondsRemaining;
    }

	// Update is called once per frame
	void Update () {
        m_secondTimer += Time.deltaTime;

        if (m_secondTimer > 1.0f)
        {
            m_secondTimer -= 1.0f;
            m_secondsRemaining -= 1;
        }

        m_timeRemainingText.text = "Time Remaining: " + m_secondsRemaining.ToString() + "s!";
        if (m_secondsRemaining <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
	}
}
