using UnityEngine;
using System.Collections;

public class HighScoreSystem : MonoBehaviour {




	// Use this for initialization
	void Start () {
        int curRank = 0;
        int tempScore = PlayerPrefs.GetInt("PlayerScore");
        int tempScore2;
        bool exists = false;

        while (!exists && curRank < 10)
        {
            curRank++;
            Debug.Log("Loop " + curRank);
           
            if (PlayerPrefs.HasKey("HighScore" + curRank))
            {
                Debug.Log("HighScoreSystem HasKey HighScore" + curRank);
                if (tempScore > PlayerPrefs.GetInt("HighScore" + curRank))
                {
                    tempScore2 = PlayerPrefs.GetInt("HighScore"+curRank);
                    PlayerPrefs.SetInt("HighScore" + curRank, tempScore);
                    tempScore = tempScore2;
                    Debug.Log("Added: " + curRank);
                    continue;
                }
                Debug.Log("Exists = false: " + curRank);
                exists = false;
            }
            else
            {
                Debug.Log("HighScoreSystem Added HighScore" + curRank);
                PlayerPrefs.SetInt("HighScore" + curRank, PlayerPrefs.GetInt("PlayerScore"));
                exists = true;
            }


        }

        
    }
	
}
