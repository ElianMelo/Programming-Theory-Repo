using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ABSTRACTION
public abstract class Player : MonoBehaviour
{
    protected int life;
    protected int damage;
    protected int speed;
    protected Color color;
    private Rigidbody playerRb;
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        FillValues();
        SetColor();
    }

    private void Update()
    {
        MovePlayer();
    }

    public virtual void MovePlayer() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.up * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    public virtual void SetColor() {
        gameObject.GetComponent<Renderer>().material.color = this.color;
    }

    protected abstract void TakeDamage(int takenDamage);
    protected abstract void FillValues();
}
