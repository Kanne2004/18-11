using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AbstractClassExample : MonoBehaviour
{
    private void Start()
    {
        Spell fireballSpell = new Fireball();
        Spell healSpell = new Heal();

        fireballSpell.Cast();
        healSpell.Cast();
    }

}


