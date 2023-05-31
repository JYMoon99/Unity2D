using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Cherry : MonoBehaviour, IItem
{
    public void Use()
    {

        GameManager.instance.Score++;

        gameObject.SetActive(false);

}


    
}
