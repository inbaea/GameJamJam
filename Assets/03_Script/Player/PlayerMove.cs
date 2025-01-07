using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector2 inputVec;
    Rigidbody2D rigid;
    public float speed = 250;
    RectTransform rect;
    public bool CanMove = true;
    public GameObject manager;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rect = GetComponent<RectTransform>();
        manager = GameObject.Find("GameManager");
    }

    void Update()
    {
        if (CanMove)
        {
            inputVec.x = Input.GetAxisRaw("Horizontal");
            inputVec.y = Input.GetAxisRaw("Vertical");
        }
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

    public void MapMove()
    {

    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Top")
        {
            manager.GetComponent<GameManager>().Map = manager.GetComponent<GameManager>().Map - 3;
            rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, -425f);
        }

        if (coll.gameObject.name == "Right")
        {
            manager.GetComponent<GameManager>().Map = manager.GetComponent<GameManager>().Map + 1;
            rect.anchoredPosition = new Vector2(-875f, rect.anchoredPosition.y);
        }

        if (coll.gameObject.name == "Left")
        {
            manager.GetComponent<GameManager>().Map = manager.GetComponent<GameManager>().Map - 1;
            rect.anchoredPosition = new Vector2(875f, rect.anchoredPosition.y);
        }

        if (coll.gameObject.name == "Bottom")
        {
            manager.GetComponent<GameManager>().Map = manager.GetComponent<GameManager>().Map + 3;
            rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, 425f);
        }
    }
}