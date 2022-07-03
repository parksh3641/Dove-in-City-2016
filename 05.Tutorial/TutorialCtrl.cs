using UnityEngine;
using System.Collections;

public class TutorialCtrl : MonoBehaviour {
    public float speed = 0.018f;
    public float Speed = 0.7f;
    public int Value = 0;
    public float Which = 6.3f;

    private bool start = false;
    private bool skill = false;

    public float movelimitx;
    public float movelimity;

    public GameObject Tree;
    private SpriteRenderer sp;
    public SpriteRenderer ssp;
    public Sprite BlackSkill;
    public Sprite WhiteSkill;
    private Animator animator;
    public Animator sanimator;

    public delegate void tutorialctrl();
    public static event tutorialctrl ManDu , OliveTreeIn ,OliveTreeOut, OliveSkill,PeopleSkill;

    void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        if(Value ==1)
        {
            Tree.SetActive(false);
        }
    }

    void OnEnable()
    {
        TutorialManager.go += GameStart;
        TutorialManager.stop += GameStop;
        TutorialManager.SkillUse += SkillUse;
    }
    void OnDisable()
    {
        TutorialManager.go -= GameStart;
        TutorialManager.stop -= GameStop;
        TutorialManager.SkillUse -= SkillUse;
    }

    void GameStart()
    {
        start = true;
    }
    void GameStop()
    {
        start = false;
    }
    void SkillUse()
    {
        StartCoroutine(Skilluse());
    }
    IEnumerator Skilluse()
    {
        skill = true;
        animator.enabled = false;
        sanimator.enabled = false;
        sp.sortingOrder = -0;
        ssp.sortingOrder = -1;
        if (Value ==0)
        {
            sp.sprite = BlackSkill;
            ssp.sprite = BlackSkill;
        }
        else
        {
            sp.sprite = WhiteSkill;
            ssp.sprite = WhiteSkill;
        }
        yield return new WaitForSeconds(10f);
        sp.sortingOrder = -2;
        ssp.sortingOrder = -3;
        animator.enabled = true;
        sanimator.enabled = true;
        skill = false;
    }
	void Update () {
        if(start == true)
        {
            if(skill == false)
            {
                transform.Translate(0, Speed * Time.deltaTime, 0);
            }
            else
            {
                transform.Translate(0, Speed* 1.5f * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, speed, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -speed, 0);
            }

            if(transform.position.y > Which)
            {
                transform.position = new Vector3(transform.position.x, -2, transform.position.z);
            }

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -movelimitx, movelimitx)
                , Mathf.Clamp(transform.position.y, -movelimity, movelimity), 0);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "People")
        {
            if (skill == false)
            {
                if (Value == 0)
                {

                }
            }
            else
            {
                if(Value ==0)
                {
                    PeopleSkill();
                }
            }
        }
        if (coll.gameObject.tag == "Oliveleaf")
        {
            if (skill == false)
            {
                if (Value == 1)
                {
                    Tree.SetActive(true);
                    OliveTreeIn();
                }
            }

            else
            {
                if(Value ==1)
                {
                    OliveSkill();
                }
            }
        }

        if (coll.gameObject.tag == "ManDu")
        {
            if (Value == 1)
            {
                coll.gameObject.SetActive(false);
                ManDu();
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Oliveleaf")
        {
            if (skill == false)
            {
                if (Value == 1)
                {
                    OliveTreeOut();
                    StartCoroutine(Olivetree());
                }
            }
        }
    }
    IEnumerator Olivetree()
    {
        yield return new WaitForSeconds(5);
        Tree.SetActive(false);
    }
}
