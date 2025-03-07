using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.GetComponent<Player>() != null || collision.GetComponent<LedgeDetection>() != null)
            AudioManager.instance.PlaySFX(0);       //index in the SFX array
            GameManager.instance.coins++;
            Destroy(gameObject);
    }
}
