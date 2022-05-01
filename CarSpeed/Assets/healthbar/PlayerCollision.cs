using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollision : PlayerMovement
{
    public int maxHealth = 100;
    public int currentHealth;


    //
    public HealthBar healthBar;
    //

    void Start()
    {
        currentHealth = maxHealth;
        //
        healthBar.SetMaxHealth(maxHealth);
        //
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //
        healthBar.SetHealth(currentHealth);
        //
    }


    //public Collider _collider;
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "collision")
        {
            TakeDamage(20);
        }
    }
}
