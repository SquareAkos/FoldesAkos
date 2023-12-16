using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;
    [SerializeField] TMP_Text textComponent;

    float currentHealth;

    void Start()
    {
        currentHealth = startHealth;
        UpdateUi();
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
            currentHealth = 0;
        UpdateUi();

    }

    void UpdateUi()
    {
        textComponent.text = "HP: " + Mathf.RoundToInt(currentHealth) .ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))        
            currentHealth = startHealth;             
    }


}
