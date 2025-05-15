using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DañoProyectil : MonoBehaviour
{
    [SerializeField] private int daño = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("lanzable"))
        {
            var health = GetComponent<MoreMountains.CorgiEngine.Health>();
            if (health != null)
            {
                health.Damage(daño, this.gameObject, 0.0f, 0.0f, Vector3.zero);
            }
            Destroy(other.gameObject);
        }
    }
}
