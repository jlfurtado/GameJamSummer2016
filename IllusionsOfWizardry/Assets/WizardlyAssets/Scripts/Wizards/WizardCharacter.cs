using UnityEngine;
using System.Collections;

public class WizardCharacter : MonoBehaviour {
    [SerializeField] private QuoteManager quotes;
    


    // Use this for initialization
    void Start()
    {
       
        //GetComponentInChildren<TextMesh>().text = m_quotes[0];
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            quotes.DisplayQuote(1);
        }
       
    }


    //private void SayQuote()



}
