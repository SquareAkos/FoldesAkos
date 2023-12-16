using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;

    float currentHealth;

    void Start()
    {
        currentHealth = startHealth;    
    }

    public void AddDamage(float damage)
    {
        startHealth -= damage;
        if (startHealth < 0)
            startHealth = 0;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))        
            currentHealth = startHealth;             
    }
}
