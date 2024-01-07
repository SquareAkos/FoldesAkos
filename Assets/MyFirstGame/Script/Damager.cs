using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] float damage = 50f;
    void OnTriggerEnter(Collider other)
    {
        Damageable damageable = other.GetComponent<Damageable>();
        
        
        if (damageable != null)
        {
            damageable.AddDamage(damage);
            Debug.Log("Damage: " + other.name);
            
        }
        
    }
    

}
