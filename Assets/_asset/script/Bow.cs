using UnityEngine;

public class Bow : Weapon
{
    private int damage;
    private int range;

    public Bow(int damage, int range)
    {
        this.damage = damage;
        this.range = range;
    }

    public override void Attack()
    {
        Debug.Log("Bow attack deals " + damage + " damage from " + range + " meters away!");
    }
}