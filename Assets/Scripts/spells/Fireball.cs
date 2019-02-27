using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fireball : MonoBehaviour
{
    
    public bool enoughmana = true;
    public Rigidbody2D fireballPrefab;
    public Transform fireballSpawn;
    public bool fireballed = false;
   // float canuseFireballtimer = 0;
   // bool startCooldown = false;
 
    void Update()
    {


       // if (startCooldown)
      //  {
            // fireball.GetComponent<UsedAbilities>().value = false;
       //     canuseFireballtimer += Time.deltaTime;

        //    if (canuseFireballtimer >= 5)
        //    {
                //       UsedAbilities.canFireballnow = true;
      //      }
     //   }
        if (ManaBar.mana <= 0)
        {
            enoughmana = false;
        }
        if (ManaBar.mana > 0)
        {
            enoughmana = true;
        }
            if (Input.GetKeyDown(KeyCode.Q) && enoughmana)
        {
            
    //    startCooldown = true;
            ManaBar.mana -= 10f;
            Instantiate(fireballPrefab, fireballSpawn.position, fireballSpawn.rotation);
            fireballed = true;
        }
            
    }
}

