using System.Collections;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class PowerUp : PickableItem
{
    public float velocidad = 1.5f;
    public float duracion = 5f;
    
    protected override void Pick(GameObject picker)
    {
        Character character = picker.GetComponent<Character>();
        if (character != null)
        {
            CharacterHorizontalMovement movement = character.GetComponent<CharacterHorizontalMovement>();
            if (movement != null)
            {
                character.StartCoroutine(BuffVelocidad(movement)); 
            }
        }

        Destroy(gameObject); 
    } 

    private IEnumerator BuffVelocidad(CharacterHorizontalMovement movement)
    {
        float originalMultiplier = movement.MovementSpeedMultiplier; 
        movement.MovementSpeedMultiplier = originalMultiplier * velocidad; 
        
        yield return new WaitForSeconds(duracion); 
        
        movement.MovementSpeedMultiplier = originalMultiplier; 
    }
}
