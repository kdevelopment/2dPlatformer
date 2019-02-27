using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    float healthRegen = 0f;
    float maxHealth = 100f;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        healthRegen += Time.deltaTime;
        health += healthRegen;
        healthRegen = 0f;

        if (health<=0)
        {
            Application.Quit();
            Debug.Log("dead will quit in exported mode");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            health += 25;
        }
        healthBar.fillAmount = health / maxHealth;
    }
}
