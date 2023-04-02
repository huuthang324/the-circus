using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForce : MonoBehaviour
{
    [SerializeField] private float force;
    private Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D other) {
        rb = other.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}
