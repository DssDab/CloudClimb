using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScripts : MonoBehaviour
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
        if(collision.gameObject.tag =="Player")
        {
            Player.GetComponent<PlayerMoveController>().PlayerLife -= 1.0f;
        }
        Destroy(this.gameObject);
    }

}
