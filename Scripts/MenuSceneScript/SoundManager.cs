using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    static SoundManager soundManager;


    void Start()
    {
        if (soundManager==null)
        {
            soundManager = this;
        }

        else if(soundManager !=this)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(soundManager); 
    }

    private void Update()
    {
        GetComponent<AudioSource>().volume = observerVoice.voiceLevel;
    }


}
