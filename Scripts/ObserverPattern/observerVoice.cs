using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observerVoice : Observer
{
    public static float voiceLevel;
    public static bool observerState = false;

    public observerVoice(Subject subject)
    {
        base.subject = subject;
        base.subject.attach(this);
        observerState = true;
    }

    public override void update()
    {
        
        voiceLevel = subject.getVoice();
       

    }


}
