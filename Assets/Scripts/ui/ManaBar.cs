using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    Image manaBar;
    float manaRegen=0f;
    float maxMana = 100f;
    public static float mana;
    // Start is called before the first frame update
    void Start()
    {
        manaBar = GetComponent<Image>();
        mana = maxMana;
        
    }

    // Update is called once per frame
   

    void Update()
    {
        manaRegen += Time.deltaTime;
        mana += manaRegen;
        manaRegen = 0f;
        if (Input.GetKeyDown(KeyCode.G))
        {
            mana += 25;
        }
            manaBar.fillAmount = mana / maxMana;
    }
}
