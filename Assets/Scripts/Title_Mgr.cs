using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

float blinkTime =0.0f;
public Text TitleText;
public class Title_Mgr : MonoBehaviour
{
    public Text GameStartText;
    // Update is called once per frame
    void Update()
    {
     TitleText.text = "시작하려면 아무키나 누르세요";
     if(blinkTime >=0.5f)
     {
     
     }
     blinkTime += Time.deltaTime;
     if
        if (Input.anyKeyDown)
            SceneManager.LoadScene("GameScene");
            
    }
    
}
