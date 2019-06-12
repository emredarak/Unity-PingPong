using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    Subject subject;
    private string diff;
    private float voi;

    private void Start()
    {
        
        subject = Subject.getInstance();

        if (!observerDifficultAI.observerState && !observerVoice.observerState)
        {
            new observerDifficultAI(subject);
            new observerVoice(subject);
        }

        if (!File.Exists(Application.persistentDataPath +"save.binary"))
        {
            SettingData data = new SettingData(.5f, "MID");

            SaveLoadSystem.Save(data);

            diff = "MID";
            voi = .5f;
            
        }
        else
        {
            diff = SaveLoadSystem.Load().difficult;
            voi = SaveLoadSystem.Load().voice;
        }

        subject.setDifficultAndVoice(diff, voi);

    }

    public void GoToScene(int index)
    {
        SceneManager.LoadScene(index);

    }
}
