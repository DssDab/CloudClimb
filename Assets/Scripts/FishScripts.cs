using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishScripts : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("cat");
        if (Player == null)
            return;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player.GetComponent<PlayerMoveController>().PlayerLife += 0.5f;
    
            if (Player.GetComponent<PlayerMoveController>().PlayerLife >= 3.0f)
                Player.GetComponent<PlayerMoveController>().PlayerLife = 3.0f;
        }
        
            Destroy(this.gameObject);
            
    }
}
