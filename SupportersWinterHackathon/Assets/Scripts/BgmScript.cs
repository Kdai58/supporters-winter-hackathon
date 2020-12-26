using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmScript : MonoBehaviour
{
    public AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void bgmc(){
        if(source.isPlaying){
            source.Pause();
            Debug.Log("pause");
        }else{
            source.Play();
            Debug.Log("continue");
        }
    }
}
