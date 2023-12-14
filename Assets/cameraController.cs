using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car; // El objeto del carro
    private Vector3 offset; // La distancia entre la cámara y el carro

    void Start()
    {
        offset = transform.position - car.transform.position;
    }

    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}

