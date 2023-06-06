using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Platform : MonoBehaviour
{
    private float speed = 2.8f;
    [SerializeField] GameObject[] cherry;


    private void Start()
    {
        for (int i = 0; i < cherry.Length; i++)
        {
            int rand = Random.Range(0, 2);

            if(rand == 1)
                cherry[i].SetActive(true);
            else
                cherry[i].SetActive(false);
        }
    }

    void Update()
    {
        //speed = Time.deltaTime;

        //transform.position = new Vector2(transform.position.x - speed, -0.65f);

        transform.Translate(new Vector2(-speed, 0) * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroy Zone"))
        {
            Destroy(gameObject);
        }
    }


}
