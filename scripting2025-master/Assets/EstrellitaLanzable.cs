using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrellitaLanzable : MonoBehaviour
{
    private GameObject objetoLanzablePrefab;
    public Transform puntoDisparo;

    private int cantidadBalas = 0;
    private float ultimaPosX;
    private float direccion = 1f; // 1 = derecha, -1 = izquierda

    void Start()
    {
        objetoLanzablePrefab = Resources.Load<GameObject>("LanzablePrefab");
        if (objetoLanzablePrefab == null)
        {
            Debug.LogWarning("No se encontró el prefab 'LanzablePrefab' en la carpeta Resources.");
        }
        ultimaPosX = transform.position.x;
    }

    void Update()
    {
        // Detecta la dirección del movimiento
        float posX = transform.position.x;
        if (posX > ultimaPosX)
            direccion = 1f;
        else if (posX < ultimaPosX)
            direccion = -1f;
        ultimaPosX = posX;

        if (Input.GetKeyDown(KeyCode.E) && cantidadBalas > 0)
        {
            LanzarObjeto();
            cantidadBalas--;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bala"))
        {
            cantidadBalas++;
            Destroy(other.gameObject);
        }
    }

    void LanzarObjeto()
    {
        if (objetoLanzablePrefab != null && puntoDisparo != null)
        {
            // Determina la rotación según la dirección
            Quaternion rotacion = (direccion == -1f)
                ? Quaternion.Euler(0, 180, 0)
                : Quaternion.identity;

            GameObject obj = Instantiate(objetoLanzablePrefab, puntoDisparo.position, rotacion);
            ObjetoLanzado lanzado = obj.GetComponent<ObjetoLanzado>();
            if (lanzado != null)
            {
                lanzado.SetDireccion(direccion);
            }
        }
    }
}
