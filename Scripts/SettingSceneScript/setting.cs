using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    Subject subject;
    [Tooltip("This area determine volume at background in the game scene ")]
    public Scrollbar voiceScrollBar;
    [Tooltip("This area determine the difficulty level of game")]
    public Toggle[] toggles = new Toggle[3];
    private string diff;
    private float voi;

    void Start()
    {
        subject = Subject.getInstance();

        diff = SaveLoadSystem.Load().difficult;
        voi = SaveLoadSystem.Load().voice;
        
        toggles[0].isOn = false;
        toggles[1].isOn = false;
        toggles[2].isOn = false;

        if (diff.Equals("EASY"))
            toggles[0].isOn = true;
        else if (diff.Equals("MID"))
            toggles[1].isOn = true;
        else
            toggles[2].isOn = true;

        voiceScrollBar.value = voi;
    }
    
    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void saveSetting()
    {
        if (toggles[0].isOn)
            diff = "EASY";
        else if (toggles[1].isOn)
            diff = "MID";
        else
            diff = "HARD";

        voi = voiceScrollBar.value;

        SettingData settingData = new SettingData(voi, diff);
        SaveLoadSystem.Save(settingData);

        subject.setDifficultAndVoice(diff, voi);
    }

    public void resetSetting()
    {
        toggles[0].isOn = true;
        toggles[1].isOn = false;
        toggles[2].isOn = false;
        voi = voiceScrollBar.value = .5f;
        diff = "EASY";

        SettingData settingData = new SettingData(voi, diff);
        SaveLoadSystem.Save(settingData);

        subject.setDifficultAndVoice(diff, voi);
    }
}
