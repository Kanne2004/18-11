using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour, IDamageable
{
    public int health = 50;
    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Enemy took damage, health: " + health);
    }
}
