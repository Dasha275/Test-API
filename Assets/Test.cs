using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
   
    public Text text;

    void GetFact()
    {
        UnityWebRequest fact = UnityWebRequest.Get("https://catfact.ninja/fact");
        print(fact);
        text.text = fact.ToString();
    }

    
}
