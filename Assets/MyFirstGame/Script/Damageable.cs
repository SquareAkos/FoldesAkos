using System;
using System.Collections;
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
    [SerializeField] GameObject enableOnDeath; // Új

    [Space]
    [SerializeField] float invincibilityTime = 2;
    [SerializeField] float flickTime = 0.1f;
    [SerializeField] new Collider collider;

    float currentHealth;
    void Start()
    {
        currentHealth = startHealth;
        UpdateUI();
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;

        StartCoroutine(HandleInvincibility());

        if (currentHealth <= 0)
        {
            // Most haltunk meg: 
            currentHealth = 0;
            if (disableOnDeath != null)
                disableOnDeath.enabled = false;

            if (enableOnDeath != null)
                enableOnDeath.SetActive(true);
        }

        UpdateUI();
    }

    IEnumerator HandleInvincibility()
    {
        collider.enabled = false;

        float startTime = Time.time;
        bool renderersEnabled = true;
        while (Time.time - startTime < invincibilityTime)
        {
            renderersEnabled = !renderersEnabled;
            SetRendererEnabled(renderersEnabled);

            yield return new WaitForSeconds(flickTime);
        }

        SetRendererEnabled(true);
        collider.enabled = true;
    }

    void SetRendererEnabled(bool enabled)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = enabled;
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

    /*
    void OnDrawGizmos()
    {
        Collider coll = GetComponent<Collider>();
        Bounds bounds = coll.bounds;

        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
    */
}