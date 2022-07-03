using UnityEngine;
using System.Collections;

public class TrashCtrl : MonoBehaviour {
    private SpriteRenderer sp;

    public Sprite Trash1;
    public Sprite Trash2;

    public Sprite Trash3;
    public Sprite Trash4;

    public int Value = 0;

    private int Skill;
    private int Olive;

    private bool A = false; //스킬
    private bool B = false; //올리브
    private int C;

    public delegate void trashctrl();
    public static event trashctrl TrashCan;

    void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }
    IEnumerator ModeCheck()
    {
        Skill = PlayerPrefs.GetInt("Skill", 0);
        if(Skill == 1)
        {
            A = true;
        }
        else
        {
            A = false;
        }

        Olive = PlayerPrefs.GetInt("Olive", 0);
        if(Olive == 1)
        {
            B = true;
        }
        else
        {
            B = false;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        C = Random.Range(0, 2);
        if (C == 0)
        {
            sp.sprite = Trash1;
            Value = 0;
        }
        else
        {
            sp.sprite = Trash3;
            Value = 1;
        }
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        StopAllCoroutines();
        A = false;
        B = false;
    }
    void PlayerDie()
    {
        StopAllCoroutines();
        A = false;
        B = false;
    }
    void PlayerLive()
    {
        StartCoroutine(ModeCheck());
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Black")
        {
            if (A == false)
            {
                Blank();
                TrashCan();
            }
        }
        if (coll.gameObject.tag == "White")
        {
            if (A == false)
            {
                Blank();
                TrashCan();
            }
        }
    }
    void Blank()
    {
        if(Value ==0)
        {
            sp.sprite = Trash2;
        }
        else
        {
            sp.sprite = Trash4;
        }
    }
}
