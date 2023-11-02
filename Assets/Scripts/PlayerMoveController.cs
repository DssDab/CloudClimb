using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rigid2D;
    float JumpForce = 580.0f;
    float MoveForce = 30.0f;
    float MaxMoveSpeed = 2.0f;
    [HideInInspector]public float PlayerLife = 3.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
        anim = GetComponent<Animator>();
        rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.gravityScale = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerLife <= 0)
            return;

        if(Input.GetButtonDown("Jump") && rigid2D.velocity.y ==0)
        {
            anim.SetTrigger("JumpTrigger");
            rigid2D.AddForce(transform.up * JumpForce);
        }
        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;

        if (key != 0)
            rigid2D.transform.localScale = new Vector3(key, 1, 1);

        float SpeedX = Mathf.Abs(rigid2D.velocity.x);

        if (SpeedX < MaxMoveSpeed)
            rigid2D.AddForce(transform.right * key * MoveForce);

        if (rigid2D.velocity.y == 0)
            anim.speed = SpeedX / 2.0f;

        else
            anim.speed = 1.0f;

        if (rigid2D.transform.position.x <-3.1f)
            rigid2D.transform.position = new Vector3(-3.1f,this.transform.position.y,this.transform.position.z);
        if(rigid2D.transform.position.x >3.1f)
            rigid2D.transform.position = new Vector3(3.1f,this.transform.position.y, this.transform.position.z);

    }

}
