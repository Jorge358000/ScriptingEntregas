using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class key : MonoBehaviour
{
    public Teleporter door; // Asigna la puerta desde el inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (door != null)
            {
                door.isLocked = false; // Desbloquea la puerta
            }
            Destroy(gameObject); // Destruye la llave al recogerla
        }
    }
}
