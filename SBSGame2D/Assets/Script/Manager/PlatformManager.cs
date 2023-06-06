using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformManager : MonoBehaviour
{
    public GameObject platform;

    void Start()
    {
        //Instantiate(platform/*, new Vector3(-5.0f, -0.65f, 0f), Quaternion.identity*/);
        //platform.transform.position = new Vector3(-3.0f, -0.65f, 0f);


        StartCoroutine(Create());

    }


   private IEnumerator Create()
    {
        while (true)
        {


                GameObject go = Instantiate(platform);
                go.transform.position = new Vector2(-2.5f, -0.65f);

                GameObject go2 = Instantiate(platform);
                go2.transform.position = new Vector2(0.3f, -0.65f);

                yield return new WaitForSeconds(2.3f);
        }
    }


}
