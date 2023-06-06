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

    public static SoundManager instance; // �������� �ؾ��ϱ� ������ static�� ��

    private void Awake()
    {   // �̱���
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
