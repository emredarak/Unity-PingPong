using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject 
{
    private List<Observer> observers = new List<Observer>();
    private string difficult;
    private float voice;

    private static Subject instance = new Subject();

    private Subject() { }

    public static Subject getInstance()
    {
        return instance;
    }


    public string getDifficult()
    {
        return difficult;
    }


    public float getVoice()
    {
        return voice;
    }

    public void setDifficultAndVoice(string difficult, float voice)
    {
        this.difficult = difficult;
        this.voice = voice;
        notifyAllObservers();
    }

    public void attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void notifyAllObservers()
    {
        foreach (Observer observer in observers)        
            observer.update();
        
    }
}
