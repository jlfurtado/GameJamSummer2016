using UnityEngine;
using System.Collections;

public class PressKeyToStartFlash : MonoBehaviour {

    [SerializeField]
    float m_flashDuration = 1.0f;

    float m_currentTime = 0.0f;
    bool m_isOn = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        m_currentTime += Time.deltaTime;
        if (m_currentTime >= m_flashDuration)
        {
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
            m_currentTime = 0.0f;
        }
	}
}
