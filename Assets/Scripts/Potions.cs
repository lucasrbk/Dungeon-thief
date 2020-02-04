using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    

   
    // Update is called once per frame
    void speedUp()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                Destroy(this.gameObject);

                break;
        }
    }
}
