using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Walk : MonoBehaviour
{
    float speed = 10;
    bool asd;
    private Animator animator;
    private GameObject gameManager;

    void Start()
    {
        Invoke("Walking", Random.Range(0, 5));

        animator = GetComponent<Animator>();
        gameManager = GameObject.Find("GameManager");
    }

    void Update()
    {
        if (asd)
        {

            if (transform.position.x < 25)
            {
                animator.SetBool("walk", true);
                transform.Translate(transform.right*-1 * Time.deltaTime * speed);
            }
            else
            {
                animator.SetBool("walk", false);
            }
        }
    }

    void Walking()
    {
        asd = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameManager.GetComponent<GameManager>().endgame();
    }
}
