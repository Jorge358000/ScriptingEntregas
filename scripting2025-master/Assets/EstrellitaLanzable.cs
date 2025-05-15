using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrellitaLanzable : MonoBehaviour
{
    private GameObject objetoLanzablePrefab; // Prefab del objeto que se lanza
    private Transform puntoDisparo; // Punto de origen del disparo

    private int cantidadBalas = 0;

    void Start()
    {
        // Cargar el prefab desde Resources
        objetoLanzablePrefab = Resources.Load<GameObject>("LanzablePrefab"); // Usa el nombre exacto del prefab SIN extensión

        if (objetoLanzablePrefab == null)
        {
            Debug.LogWarning("No se encontró el prefab 'LanzablePrefab' en la carpeta Resources.");
        }

        // Buscar el punto de disparo por tag en la escena
        GameObject puntoObj = GameObject.FindGameObjectWithTag("Punto");
        if (puntoObj != null)
        {
            puntoDisparo = puntoObj.transform;
        }
        else
        {
            Debug.LogWarning("No se encontró un objeto con el tag 'Punto'.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && cantidadBalas > 0)
        {
            Debug.Log(cantidadBalas);
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
        Debug.Log("entra");
        if (objetoLanzablePrefab != null && puntoDisparo != null)
        {
            Debug.Log("Instanciando en: " + puntoDisparo.position);
            GameObject obj = Instantiate(objetoLanzablePrefab, puntoDisparo.position, puntoDisparo.rotation);
            Debug.Log("Instanciado: " + obj.name);
        }
        else
        {
            Debug.LogWarning("Falta asignar el prefab o el punto de disparo");
        }
    }
}
