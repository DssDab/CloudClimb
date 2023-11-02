using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Mgr : MonoBehaviour
{
    public Text GameStartText;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            SceneManager.LoadScene("GameScene");
    }
}
