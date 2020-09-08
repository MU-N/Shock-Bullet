using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameObject Exeplosion;
    
    public float thrust = 20f;
    Vector3 vector3Direction;
    int Health = 100; 
    // Start is called before the first frame update
    void Start()
    {
        vector3Direction = -transform.right;
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = vector3Direction * thrust;
        if (Input.GetKeyDown(KeyCode.Q))
            Flip();
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.

        vector3Direction = - vector3Direction;
        transform.Rotate(0, 180, 0);
    }
    public void takeDamge (int damage)
    {
        if (Health > damage)
            Health -= damage;
        else
        {
            GameObject temp = Instantiate(Exeplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(temp, 1f);
        }
            
    }
        
}
