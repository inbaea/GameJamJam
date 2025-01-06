using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector2 inputVec;
    Rigidbody2D rigid;
    public float speed = 250;
    RectTransform rect;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }

    private void LateUpdate()
    {
        if(inputVec.x < 0)
        {
            rect.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (inputVec.x > 0)
        {
            rect.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}