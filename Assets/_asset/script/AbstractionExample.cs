using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractionExample : MonoBehaviour
{
    void Start()
    {
        Weapon sword = new Sword(10);
        Weapon bow = new Bow(8, 15);
    }
}
