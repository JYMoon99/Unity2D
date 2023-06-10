using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public void Ready()
    {
        var player = GameObject.Find("Player").GetComponent<Animator>();
        player.GetComponent<Animator>().updateMode = AnimatorUpdateMode.UnscaledTime;

        Time.timeScale = 1.0f;


    }
}
