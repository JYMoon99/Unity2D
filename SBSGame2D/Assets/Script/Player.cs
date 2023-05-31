using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Profiling;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Rigidbody2D rigid;
    private Animator animator;

    private bool jumpCheck = false;
    private bool jumpchance = false;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Input.GetButtonDown("Jump") && jumpchance == true)
        {
            jumpCheck = true;
            animator.Play("Jump");
            SoundManager.instance.Sound(SoundManager.SOUND_TYPE.JUMP);
        }
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if (jumpCheck == true)
        {
            rigid.AddForce(Vector2.up * 4.5f, ForceMode2D.Impulse);
            //rigid.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            jumpCheck = false;
            jumpchance = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpchance = true;
    }

}
