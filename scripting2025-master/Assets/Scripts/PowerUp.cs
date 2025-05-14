using System.Collections;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


namespace MoreMountains.CorgiEngine
{
    public class PowerUp : PickableItem
    {
        public float duracion = 5f;

        protected override void Pick(GameObject picker)
        {
            Character character = picker.GetComponent<Character>();
            if (character != null && character.CharacterHealth != null)
            {
                character.StartCoroutine(DarInmunidad(character.CharacterHealth));
            }

            Destroy(gameObject);
        }

        private IEnumerator DarInmunidad(Health health)
        {
            bool originalInvulnerable = health.Invulnerable;
            health.Invulnerable = true;

            yield return new WaitForSeconds(duracion);

            health.Invulnerable = originalInvulnerable;
        }
    }
}

