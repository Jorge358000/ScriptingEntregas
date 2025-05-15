using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoDisparoSeguidor : MonoBehaviour
{
    [SerializeField] private Transform personaje; // Asigna el transform del personaje
    [SerializeField] private float offsetX = 1f;  // Distancia a la derecha/izquierda

    private Vector3 posicionInicialLocal;

    void Start()
    {
        if (personaje == null)
        {
            Debug.LogWarning("No se asignó el personaje al PuntoDisparoSeguidor.");
            enabled = false;
            return;
        }
        posicionInicialLocal = transform.localPosition;
    }

    void Update()
    {
        float direccion = personaje.localScale.x > 0 ? 1f : -1f;
        transform.localPosition = new Vector3(
            posicionInicialLocal.x * direccion,
            posicionInicialLocal.y,
            posicionInicialLocal.z
        );
    }
}
