using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTarget : MonoBehaviour
{
    private Animator animator;
    private int hit = 0;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(hit == 2)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            hit++;
            animator.SetTrigger("Eratic");
        }
    }
}
