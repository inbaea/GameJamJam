using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector2 inputVec;
    RectTransform rect;

    Rigidbody2D map_rigid;
    RectTransform map_rect;

    public float speed;
    public bool CanMove = true;

    public GameObject map;
    Animator anim;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        map_rigid = map.GetComponent<Rigidbody2D>();
        map_rect = map.GetComponent<RectTransform>();
        anim = GetComponent<Animator>();
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
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime * -1;
        map_rigid.MovePosition(map_rigid.position + nextVec);
    }

    private void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);
        if(inputVec.x < 0)
        {
            rect.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (inputVec.x > 0)
        {
            rect.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.name);
        if (coll.gameObject.name == "Wall")
        {
            StartCoroutine(MovingWall());
        }

        if (coll.gameObject.name == "BBQ")
        {
            Vector2 vec = new Vector2(0, 0);
            map_rect.anchoredPosition = new Vector2(0, 0);
        }
    }

    IEnumerator MovingWall()
    {
        CanMove = false;
        inputVec.x = inputVec.x * -1f;
        inputVec.y = inputVec.y * -1f;
        yield return new WaitForSeconds(0.1f);

        CanMove = true;
    }
}