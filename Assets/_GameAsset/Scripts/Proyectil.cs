using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int damage;
    public float speed;
    private Rigidbody2D rb2D;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(transform.forward * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Instantiate(explosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
