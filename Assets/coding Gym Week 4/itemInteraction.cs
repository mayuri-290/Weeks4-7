using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemInteraction : MonoBehaviour
{

    public int health = 10;

    void OnMouseDown()
    {
        TakeDamage(1);
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
