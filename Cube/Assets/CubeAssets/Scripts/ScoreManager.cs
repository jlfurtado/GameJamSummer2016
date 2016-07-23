using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {


    private int m_multiplier = 1;
    CubeControl m_cc; // CubeControl var
    Text  m_text; // score
    [SerializeField]
    private int m_score = 0; // score for collecting diamonds for now i guess :) thanks
                             // Use this for initialization
    void Start () {
        m_cc = GetComponentInParent<CubeControl>();
        m_text = GetComponent<Text>();
    }
	
    public void AddScore(int score)
    {
       m_score = m_score + score;// = m_cc.GetScore().ToString();
        m_text.text = m_score.ToString();
    }


	// Update is called once per frame
	void Update () {
       
    }
}
