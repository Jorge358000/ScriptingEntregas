using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject ventanaTienda; // Panel de la tienda
    [SerializeField] private Button botonItem1;
    [SerializeField] private Button botonItem2;
    [SerializeField] private Transform spawnPoint; // Dónde aparecerá el pickable
    [SerializeField] private GameObject pickableActual; // Referencia al pickable actual en la escena

    private void Start()
    {
        ventanaTienda.SetActive(false);

        botonItem1.onClick.AddListener(() => SeleccionarItem("Pickable1"));
        botonItem2.onClick.AddListener(() => SeleccionarItem("Pickable2"));
    }

    private void Update()
    {
        // Abrir la tienda con la tecla T
        if (Input.GetKeyDown(KeyCode.T))
        {
            ventanaTienda.SetActive(!ventanaTienda.activeSelf);
        }
    }

    private void SeleccionarItem(string nombrePrefab)
    {
        // Elimina el pickable actual si existe
        if (pickableActual != null)
        {
            Destroy(pickableActual);
        }

        // Carga el nuevo pickable desde Resources
        GameObject nuevoPickable = Resources.Load<GameObject>(nombrePrefab);
        if (nuevoPickable != null)
        {
            pickableActual = Instantiate(nuevoPickable, transform.position, Quaternion.identity);
        }

        ventanaTienda.SetActive(false); // Cierra la tienda

        // Desactiva el objeto de la tienda
        gameObject.SetActive(false);
    }
}
