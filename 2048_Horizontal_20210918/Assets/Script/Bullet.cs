using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float attack;

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag.Equals(gameObject.tag)) return;
        Destroy(gameObject);
    }
}
