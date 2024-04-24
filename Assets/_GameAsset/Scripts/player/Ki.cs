using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ki : MonoBehaviour
{

    public GameObject fuegoPrefab;
    public Transform puntoDisparo;
    public float fuerzaDisparo;
    [Range(0, 2)]
    public float incrementoAltitud = 0.25f;
    public AudioClip sonidoDisparo;
    private bool armaConfigurada = false;
    // Start is called before the first frame update
    void Start()
    {
        if (fuegoPrefab && puntoDisparo)
        {
            armaConfigurada = true;
        }
        else
        {
            Debug.LogError("El script DisparadorPlayer no est� correctamente configurado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform != RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.X) || Input.GetButtonDown("Fire2"))
            {
                Disparo();
            }
        }
    }
    public void Disparo()
    {
        if (!armaConfigurada) return;
        if (sonidoDisparo)
        {
            AudioSource.PlayClipAtPoint(sonidoDisparo, puntoDisparo.position);
        }
        GameObject proyectil = Instantiate(fuegoPrefab, puntoDisparo.transform.position, puntoDisparo.transform.rotation);
        float direccion = GetComponent<SpriteRenderer>().flipX ? -1 : 1;
        proyectil.GetComponent<Rigidbody2D>().AddForce(new Vector2(direccion, incrementoAltitud) * fuerzaDisparo);
    }
}
