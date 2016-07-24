using UnityEngine;
using System.Collections;

public class DiamondBob : MonoBehaviour {
    [SerializeField]
    private float m_changeDirTime = 5.0f;
    [SerializeField]
    private float m_bobSpeed = .50f;

    private float m_time = 0;

    private Vector3 m_bobDir = new Vector3(0, 1.0f, 0);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        m_time += Time.deltaTime;
        if (m_time >= m_changeDirTime)
        {
            m_bobSpeed = -m_bobSpeed;
            m_time = 0;
        }
        transform.Translate(m_bobDir * m_bobSpeed * Time.deltaTime);
    }
}
