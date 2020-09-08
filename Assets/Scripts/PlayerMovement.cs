using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;


    [SerializeField] GameObject Bullet;
    [SerializeField] Transform FireDrection;
    float speed = 5f;
    [SerializeField] GameObject Gameover;
    [SerializeField] GameObject[] Heart;


    public Animator animator;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    private int HealthValue = 3;


    private void Start()
    {
        
        
        for (int i = 0; i < HealthValue; i++)
        {
            Heart[i].SetActive(true);
        }



    }
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (horizontalMove != 0)
        {
            animator.SetBool("IsManWalking", true);

        }
        else
            animator.SetBool("IsManWalking", false);


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

            animator.SetBool("IsManJump", true);
        }
        else

            animator.SetBool("IsManJump", false);


        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("IsManFire", true);
            Instantiate(Bullet, FireDrection.position, FireDrection.rotation);
        }
        else
            animator.SetBool("IsManFire", false);



    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    public void TakeDamage()
    {

        //animator.SetBool("IsManDie", true);
        if (HealthValue > 1)
            Heart[--HealthValue].SetActive(false);
        else
            Die();

    }

    public void TakeHealth()
    {

        //animator.SetBool("IsManDie", true);
        if (HealthValue < 3)
            Heart[HealthValue++].SetActive(true);
       
    }
    public void Die()
    {

        animator.SetBool("IsManDie", true);
        StartCoroutine(WaitAndPrint());
    }

    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(0.25f);
        Gameover.SetActive(true);
        Time.timeScale = 0;

    }

}
