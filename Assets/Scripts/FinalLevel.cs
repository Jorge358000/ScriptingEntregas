using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class FinalLevel : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    static public int puntos = 0;
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Coin coin = e.PickedItem.GetComponent<Coin>();
        if(coin != null)
        {            
            puntos += coin.PointsToAdd;
            if(puntos == 40)
            {
                MMSceneLoadingManager.LoadScene("Instrucciones");
            }
        }    
    }
}
