using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Player
{
    protected override void  FillValues() {
        this.life = 5;
        this.damage = 10;
        this.speed = 7;
        this.color = Color.green;
    }
    protected override void TakeDamage(int takenDamage) {
        this.life -= takenDamage;
    }
}
