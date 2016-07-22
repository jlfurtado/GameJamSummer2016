using UnityEngine;
using System.Collections;

public class QuoteManager : MonoBehaviour {
    [SerializeField]
    private string[] m_quotes;
    private int m_numQuotes;

    private float m_time = 0;
    [SerializeField]
    private float m_displayDuration = 5;
    private bool  m_displaying;
    [SerializeField]
    Vector2 m_initialLocalPos;

    // Use this for initialization
    void Start () {
        transform.localPosition = m_initialLocalPos;
        m_numQuotes = m_quotes.Length;
    }
	
	// Update is called once per frame
	void Update () {
	
        if(m_displaying)
        {
            m_time += Time.deltaTime;
            if(m_time >= m_displayDuration)
            {
                GetComponent<TextMesh>().text = "";
                m_displaying = false;
            }

        }

	}
    //Convenience
    public void DisplayQuote(int quoteIndex)
    {
        DisplayQuote(quoteIndex, m_displayDuration);
    }

    //Displays a quote[quoteIndex] for <m_displayDuration>(member variable) seconds
    public void DisplayQuote(int quoteIndex, float duration)
    {
        
        if (quoteIndex >= m_numQuotes || quoteIndex < 0)
        {
            Debug.Log("ERROR: QuoteManager.DisplayQuote(): quoteIndex [" + quoteIndex + "] is out of bounds! Max val:[" + (m_numQuotes - 1) + "]\n");
        }
        else {
            m_displaying = true;
            m_displayDuration = duration;
            m_time = 0;
            GetComponent<TextMesh>().text = m_quotes[quoteIndex];
            
        }


    }
    public void SetLocalPosition(Vector2 pos)
    {
        transform.localPosition = pos;
    }

    public void SetPosition(Vector2 pos)
    {
        transform.position = pos;
    }



}
