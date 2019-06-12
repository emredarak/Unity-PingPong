using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observerDifficultAI : Observer
{
    public static string difficultState;
    public static bool observerState = false;

    public observerDifficultAI(Subject subject)
    {        
        base.subject = subject;
        base.subject.attach(this);
        observerState = true;
    }

    public override void update()
    {
        difficultState = subject.getDifficult();
    }
}
