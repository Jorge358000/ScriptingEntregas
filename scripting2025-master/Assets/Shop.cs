using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Shop : PickableItem
{
    public static Shop Instancia;

    [SerializeField] private GameObject ventanaTienda;
    [SerializeField] private Button botonItem1;
    [SerializeField] private Button botonItem2;

    private string prefab1;
    private string prefab2;
    private Vector3 spawnPosition;
    private ShopTrigger tiendaActual; // Referencia al ShopTrigger que abrió la tienda

    private void Awake()
    {
        Instancia = this;
        ventanaTienda.SetActive(false);
    }

    private void Start()
    {
        botonItem1.onClick.AddListener(() => SeleccionarItem(prefab1));
        botonItem2.onClick.AddListener(() => SeleccionarItem(prefab2));
    }

    public void AbrirTienda(string nombrePrefab1, string nombrePrefab2, Vector3 posicion, ShopTrigger quienLlamo)
    {
        prefab1 = nombrePrefab1;
        prefab2 = nombrePrefab2;
        spawnPosition = posicion;
        tiendaActual = quienLlamo;
        ventanaTienda.SetActive(true);
    }

    private void SeleccionarItem(string nombrePrefab)
    {
        GameObject nuevoPickable = Resources.Load<GameObject>(nombrePrefab);
        if (nuevoPickable != null)
        {
            Instantiate(nuevoPickable, spawnPosition, Quaternion.identity);
        }
        ventanaTienda.SetActive(false);

        // Aquí se destruye el objeto de tienda que abrió la ventana
        if (tiendaActual != null)
        {
            Destroy(tiendaActual.gameObject);
            tiendaActual = null;
        }
    }
}
