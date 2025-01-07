using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector2 inputVec;
    public Vector2 curr;
    RectTransform rect;
    Rigidbody2D rigid;

    Rigidbody2D map_rigid;
    RectTransform map_rect;

    public float speed;
    public bool CanMove = false;
    public bool InStore = false;
    public bool CanInside = true;

    public RectTransform BBQPos;
    public RectTransform BHCPos;
    public RectTransform NENEPos;
    public RectTransform MOMSTOUCHPos;
    public RectTransform MAXICANAPos;
    public RectTransform PURADAKPos;
    public RectTransform JADAMPos;
    public RectTransform TANGTANGPos;
    public RectTransform GCOVAPos;
    public RectTransform GOOBNEPos;
    public RectTransform KYOCHONPos;
    public RectTransform NORANGPos;
    public RectTransform KIMPos;

    RectTransform curr_a;

    public GameObject map;
    Animator anim;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        rigid = GetComponent<Rigidbody2D>();
        map_rigid = map.GetComponent<Rigidbody2D>();
        map_rect = map.GetComponent<RectTransform>();
        anim = GetComponent<Animator>();
        StartCoroutine(MoveStart());
    }

    IEnumerator MoveStart()
    {
        yield return new WaitForSeconds(4f);
        CanMove = true;
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
        if (!InStore)
        {
            Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime * -1;
            map_rigid.MovePosition(map_rigid.position + nextVec);
        }

        if (InStore)
        {
            Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
            rigid.MovePosition(rigid.position + nextVec);
        }

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
            if (CanInside)
            {
                curr_a = BBQPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                BBQPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            } 
        }

        if (coll.gameObject.name == "BHC")
        {
            if (CanInside)
            {
                curr_a = BHCPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                BHCPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "NENE")
        {
            if (CanInside)
            {curr_a = NENEPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                NENEPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "MOMSTOUCH")
        {
            if (CanInside)
            {curr_a = MOMSTOUCHPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                MOMSTOUCHPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "MAXICANA")
        {
            if (CanInside)
            {curr_a = MAXICANAPos; 
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                MAXICANAPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "PURADAK")
        {
            if (CanInside)
            {curr_a = PURADAKPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                PURADAKPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "JADAM")
        {
            if (CanInside)
            {curr_a = JADAMPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                JADAMPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "KIM")
        {
            if (CanInside)
            {
                curr_a = KIMPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                KIMPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "TANGTANG")
        {
            if (CanInside)
            {curr_a = TANGTANGPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                TANGTANGPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "GCOVA")
        {
            if (CanInside)
            {curr_a = GCOVAPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                GCOVAPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "GOOBNE")
        {
            if (CanInside)
            {curr_a = GOOBNEPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                GOOBNEPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "KYOCHON")
        {
            if (CanInside)
            {curr_a = KYOCHONPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                KYOCHONPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "NORANG")
        {
            if (CanInside)
            {curr_a = NORANGPos;
                curr = map_rect.anchoredPosition;
                map_rect.anchoredPosition = new Vector2(0, 0);
                rect.anchoredPosition = new Vector2(0, -50);
                NORANGPos.anchoredPosition = new Vector2(0, 0);
                InStore = true;
            }
        }

        if (coll.gameObject.name == "Exit")
        {
            map_rect.anchoredPosition = curr;
            rect.anchoredPosition = new Vector2(0, 0);
            InStore = false;
            CanInside = false;
            curr_a.anchoredPosition = new Vector2(0, 4000);
            StartCoroutine(InsideTime());
        }
    }
    IEnumerator InsideTime()
    {
        yield return new WaitForSeconds(1f);

        CanInside = true;
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