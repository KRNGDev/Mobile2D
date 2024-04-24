using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorPlayer : MonoBehaviour
{
    public float velocidadDesplazamiento;
    public float velocidadSalto;
    public AudioClip sonidoSalto;

    private float horizontal;

    private Rigidbody2D playerRB2D;
    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Math.Abs(playerRB2D.velocity.y) < 0.01f)
            {
                playerRB2D.velocity =
                    new Vector2(horizontal * velocidadDesplazamiento, velocidadSalto);
                AudioSource.PlayClipAtPoint(sonidoSalto, playerRB2D.position);
            }
        }
        else
        {
            playerRB2D.velocity =
                new Vector2(horizontal * velocidadDesplazamiento, playerRB2D.velocity.y);
        }

    }
}
