using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class muro : MonoBehaviour
{
    public GameObject objetoAObservar; // Aquí va el jefe
    public GameObject muross; // Aquí va la pared

    private float vidaAnterior = -1;

    void Update()
    {
        if (objetoAObservar != null)
        {
            // Busca el componente de vida (ajusta el nombre si es diferente)
            var health = objetoAObservar.GetComponent<Health>();
            if (health.CurrentHealth == 0)
            {
               
                        Destroy(muross);
                        muross = null;
                    
                
            }
        }
    }
}
