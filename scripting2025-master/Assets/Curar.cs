using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Curar : MonoBehaviour
{
    public int cantidadCurar = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponentInParent<Health>();
        if (health != null)
        {
            health.CurrentHealth = Mathf.Min(health.CurrentHealth + cantidadCurar, health.MaximumHealth);
            
            Destroy(gameObject);
        }
    }
}
