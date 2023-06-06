using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public enum SOUND_TYPE
    {
        JUMP,
        SCORE,
        GAMEOVER
    }

   

    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioClip;

    public static SoundManager instance; // 전역으로 해야하기 때문에 static을 함

    private void Awake()
    {   // 싱글톤
        if(instance == null) 
        {
            instance = this;
        }
    }



    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    public void Sound(SOUND_TYPE soundType)
    {
        audioSource.PlayOneShot(audioClip[(int)soundType]);
    }
    
}
