using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OutroLoad : MonoBehaviour
{
    public GameObject gameobject;
    public AnimationCurve animationCurve;

    void Update()
    {
        if (gameobject.activeSelf)
        {
            animationCurve.AddKey(1.0f, 65.0f);
        }
        
    }



}
