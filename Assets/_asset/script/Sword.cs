using UnityEngine;

public class Sword : Weapon
{
    private int damage;

    public Sword(int damage)
    {
        this.damage = damage;
    }

    public override void Attack()
    {
        Debug.Log("Sword attack deals " + damage + "damage!");
    }
}
