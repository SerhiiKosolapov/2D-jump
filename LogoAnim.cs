using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogoAnim : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!StartGame.isStart)   
        {
            animator.SetBool("logoJump", true);
            animator.SetBool("gameStart", false);
        }   
    }
}
