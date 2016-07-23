using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {


    CubeControl m_cc; // CubeControl var
    TextMesh m_text; // score
	// Use this for initialization
	void Start () {
        m_cc = GetComponentInParent<CubeControl>();
        m_text = GetComponentInParent<TextMesh>();
    }
	
	// Update is called once per frame
	void Update () {
        m_text.text = m_cc.GetScore().ToString();
    }
}
