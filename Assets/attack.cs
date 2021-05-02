using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
    //Stats for our player ill keep 'em simple
    private int attack = 6;
    private int maximumHealth = 100;
    private int hitRange = 1;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //so far this is just being used to detect if we hit mouse button one unity has special inputs called buttons if you go to edit project setting then to input manager you'll see what button i set for the Fire 1 input
    {
        if (Input.GetButtonDown("Fire 1"))
        {
            Attack(); // this calls the new attack void that is made underneath this updated void
        }
    }

    void Attack() //this will be the script for attacking.
    {
        RaycastHit hit; // i found this out recently raycast is literally just what most fast hit boxes are so basically in counter strike when you fire a bullet from the AWP the bullet is not a fast moving hitbox its a ray that follows the bullet so basically if you are in the ray it counts as getting hit.
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 origin = transform.position;

        if (Physics.Raycast(origin, forward, hitRange, out hit))
        {
            if (hit.transform.gameObject.tag == "Enemy")
            {
                hit.transform.gameObject.SendMessage("TakeDamage", 30);
            }
        }


    }

    private int enemyHealth;

    void TakeDamage(int damageAmount)
    {
    enemyHealth = enemyHealth - damageAmount;

  
    }

   }
