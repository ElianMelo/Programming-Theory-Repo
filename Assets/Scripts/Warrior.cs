using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class Warrior : Player
{
    // ENCAPSULATION
    private int armor { get; set; }

    protected override void FillValues() {
        this.armor = 2;
        this.life = 10;
        this.damage = 5;
        this.speed = 4;
        this.color = Color.red;
    }

    // POLYMORPHISM
    protected override void TakeDamage(int takenDamage) {
        var totalDamage = takenDamage - armor;
        if(totalDamage <= 0) {
            totalDamage = 0;
        }
        this.life -= takenDamage - armor;
    }
}
