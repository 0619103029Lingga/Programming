using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawab : MonoBehaviour{
    public GameObject feed_benar, feed_salah;
    // Start is called before the first frame update
    void Start(){
    
    }
     public void jawaban(bool Jawab){
         if (Jawab) {
            feed_benar.SetActive (false);
            feed_benar.SetActive (true);
            int Poin = PlayerPrefs.GetInt ("Poin") + 10;
            PlayerPrefs.SetInt ("Poin", Poin);
         } else {
            feed_salah.SetActive (false);
            feed_salah.SetActive (true);
         }
         gameObject.SetActive (false);
         transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive (true);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

