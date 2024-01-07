using TMPro;
using UnityEngine;

class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;
    //[SerializeField] Color maxHealthColor = Color.green;
    //[SerializeField] Color minHealthColor = Color.red;
    //[SerializeField] AnimationCurve colorInterpolation;

    [SerializeField] Gradient healthGradient;
    [SerializeField] TMP_Text textComponent;
    [SerializeField] Behaviour disableOnDeath;
    [SerializeField] GameObject enableOnDeath;

    float currentHealth;

    void Start()
    {
        currentHealth = startHealth;
        UpdateUI();
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            if (disableOnDeath != null)
            {
                disableOnDeath.enabled = false;
                
            }
            if (enableOnDeath != null)
            {
                enableOnDeath.SetActive(true);
            }

        }

        UpdateUI();
    }

    void UpdateUI()
    {

        int intValue = Mathf.RoundToInt(currentHealth);
        textComponent.text = "HP: " + intValue.ToString();

        float rate = currentHealth / startHealth;

        // float t = colorInterpolation.Evaluate(rate);
        // textComponent.color = Color.Lerp(minHealthColor, maxHealthColor, t);
        textComponent.color = healthGradient.Evaluate(rate);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentHealth = startHealth;
            UpdateUI();
        }
    }
}