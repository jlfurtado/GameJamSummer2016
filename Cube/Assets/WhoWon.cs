using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WhoWon : MonoBehaviour {

   
    


	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cone"))
        {

            SceneManager.LoadScene("LevelYellow");
            //enabled = false;
        }
        else if(other.CompareTag("Cube"))
        {
            SceneManager.LoadScene("GameOver");
        }

    }
        // Update is called once per frame
        void Update () {
	
	}
}
