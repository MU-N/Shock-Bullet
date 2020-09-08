using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    // public GameObject textScore;
    private float thrust = 10.0f;
    public int Damege = 35;
    // string defultscore = "Score : ";

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * thrust;
        //textScore.GetComponent<Text>().text = defultscore + score;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        FlyingEnemy enime = collision.GetComponent<FlyingEnemy>();
        if (enime != null)
        {
            enime.takeDamge(Damege);
            
        }
        /*
        Bullet1 bullet1 = collision.GetComponent<Bullet1>();
        if (bullet1 != null)
        {
            bullet1.Destroy();
            Debug.Log("Damage ");
        }*/

        
        
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
