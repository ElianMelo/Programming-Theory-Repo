using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player
{
    protected override void  FillValues() {
        this.life = 2;
        this.damage = 15;
        this.speed = 6;
        this.color = Color.blue;
    }
    protected override void TakeDamage(int takenDamage) {
        this.life -= takenDamage;
    }
}
