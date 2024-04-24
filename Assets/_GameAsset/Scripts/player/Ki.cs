using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ki : MonoBehaviour
{
    public Transform spawner;
    public GameObject fuegoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Disparo(){
        Instantiate(fuegoPrefab,spawner.position,spawner.rotation);
    }
}
