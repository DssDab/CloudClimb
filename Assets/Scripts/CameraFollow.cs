using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = Player.transform.position;

        transform.position = new Vector3(
            this.transform.position.x,
            PlayerPos.y,
            this.transform.position.z);
    }
}
