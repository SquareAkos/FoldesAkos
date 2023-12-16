using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] float damage = 10;
    void OnTriggerEnter(Collider other)
    {
        Damageable damageable = other.GetComponent<Damageable>();
        
        
        if (damageable != null)
        {
            damageable.AddDamage(1);
            Debug.Log("Damage: " + other.name);
            
        }
        
    }
    

}
