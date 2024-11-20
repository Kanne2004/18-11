using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
        public int health = 100;
        public void TakeDamage(int amount)
        {
        health -= amount;
        Debug.Log("Player took damage, health: " + health);
        }   
}