using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismExample : MonoBehaviour
{
    void Start()
    {
        Enemy orc = new Orc();
        Enemy troll = new Troll();

        orc.Attack();
        troll.Attack();
    }
}
