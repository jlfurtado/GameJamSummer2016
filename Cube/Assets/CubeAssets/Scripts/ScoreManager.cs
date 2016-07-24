using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {


    private int m_multiplier = 1;
    CubeControl m_cc; // CubeControl var
    Text  m_text; // score
    [SerializeField]
    private int m_score = 0; // score for collecting diamonds for now i guess :) thanks
    private int m_scoreMultiplier = 1;
    [SerializeField]
    private Text m_multText;      
    // Use this for initialization
    void Start () {
        m_cc = GetComponentInParent<CubeControl>();
        m_text = GetComponent<Text>();

        m_scoreMultiplier = PlayerPrefs.GetInt("PlayerMult", 0);
        m_score = PlayerPrefs.GetInt("PlayerScore", 0);
        m_multText.text = "x" + m_scoreMultiplier;
        m_text.text = m_score.ToString();


      
    }

    
	
    public void AddScore(int score)
    {
        Debug.Log("Added score");
        m_score = m_score + (score * m_scoreMultiplier);// = m_cc.GetScore().ToString();
        PlayerPrefs.SetInt("PlayerScore",m_score);
        m_text.text = m_score.ToString();
    }

    public void AddMultiplier(int multipler)
    {
        m_scoreMultiplier = m_scoreMultiplier + multipler;
        PlayerPrefs.SetInt("PlayerMult", m_scoreMultiplier);
        m_multText.text = "x" + m_scoreMultiplier;
        
    }

	// Update is called once per frame
	void Update () {
       
    }
}
