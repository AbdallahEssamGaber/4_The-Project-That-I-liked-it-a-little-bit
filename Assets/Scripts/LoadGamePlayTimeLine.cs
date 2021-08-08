using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LoadGamePlayTimeLine : MonoBehaviour
{

    public PlayableDirector timeline;


    void Start()
    {

        timeline = GetComponent<PlayableDirector>();

        timeline.Stop();

    }

    void Update()
    {
        if (IntroController.introController.gameObject.tag == "IntroEnd" && Input.anyKey) 
        {
              timeline.Play();
              IntroController.introController.gameObject.tag = "Untagged";
        }
        
    }
}
