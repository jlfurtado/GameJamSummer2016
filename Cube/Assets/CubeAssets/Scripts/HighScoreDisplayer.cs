using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HighScoreDisplayer : MonoBehaviour
{
    [SerializeField] Text[] m_texts;
    [SerializeField] bool clear = false;

    void Start()
    {
        int sizeOfArray = m_texts.Length;

        int curRank = 1;

        bool exists = true;

        if (clear)
        {

            while (curRank < sizeOfArray)
            {

                PlayerPrefs.SetInt("HighScore" + curRank, 0);

                curRank++;
            }
            curRank = 1;

        }

            while (exists && curRank < sizeOfArray) 
        {
            
            if (PlayerPrefs.HasKey("HighScore" + curRank))
            {
                Debug.Log("Has highscore: [" + curRank + "] val: [" + PlayerPrefs.GetInt("HighScore" + curRank));
                m_texts[curRank].text = PlayerPrefs.GetInt("HighScore" + curRank) + " ";
            }
            else
            {
                exists = false;
            }
            curRank++;
        }


        while (curRank < sizeOfArray)
        {

            PlayerPrefs.SetInt("HighScore" + curRank, 0);

            curRank++;
        }
     

    }

}
