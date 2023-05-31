using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, IItem
{
    
    public void Use()
    {
        gameObject.SetActive(false);
        Debug.Log("∫∏ºÆ¿ª »πµÊ«ﬂ¥Ÿ!");
    }

}
