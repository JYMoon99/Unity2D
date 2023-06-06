using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour, IItem
{
    private Player player;

    public void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }
    public void Use()
    {
        Time.timeScale = 0.0f;
        player.GetComponent<Animator>().Play("Death");
        StartCoroutine(Fall());
    }

    IEnumerator Fall()
    {
        while (true)
        {
            player.gameObject.transform.position -= new Vector3(0, 0.001f, 0) * Time.unscaledTime; // unscaledTime : 
            yield return null;
        }
    }

}
