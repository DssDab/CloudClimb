using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
