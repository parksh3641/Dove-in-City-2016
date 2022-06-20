using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TutorialPeople : MonoBehaviour
{
    private float speed = 0.15f;

    private int Dove;
    public Transform DrawWhich;
    public Transform Player;
    private float distance;
    private bool olive;

    public int Which = 0;
    private float Cooltime = 0;

    private Animator animator;
    private int A = 0;
    private int D = 0;

    public GameObject ManDu;
    public List<GameObject> ManDuPool = new List<GameObject>();

    public delegate void tutorialpeople();
    public static event tutorialpeople Candy;

    private bool start = false;
    private int TutorialSkill = 0;
    private bool Skill = false;
    private bool Drop = false;

    void Awake()
    {
        animator = GetComponent<Animator>();

        for (int i = 0; i < 1; i++)
        {
            GameObject mandu = Instantiate(ManDu);
            mandu.name = "ManDu _" + i.ToString();
            mandu.SetActive(false);
            ManDuPool.Add(mandu);
        }
    }
    void OnEnable()
    {
        TutorialManager.go += GameStart;
        TutorialCtrl.OliveTreeOut += OliveTreeOut;

    }
    void OnDisable()
    {
        TutorialManager.go -= GameStart;
        TutorialCtrl.OliveTreeOut -= OliveTreeOut;
    }
    void GameStart()
    {
        start = true;
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
        StartCoroutine(RandomVector());
        StartCoroutine(ModeCheck());
    }
    void OliveTreeOut()
    {
        StartCoroutine(Oliveuse());
    }
    void Update()
    {
        if (start == true)
        {
            if (Which == 1)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
            else if (Which == 2)
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            else if (Which == 3)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            else if (Which == 4)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
            else if (Which == 5)
            {
                transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
            }
            else if (Which == 6)
            {
                transform.Translate(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
            }
            else if (Which == 7)
            {
                transform.Translate(-speed * Time.deltaTime, speed * Time.deltaTime, 0);
            }
            else if (Which == 8)
            {
                transform.Translate(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);
            }
        }
    }
    IEnumerator Oliveuse()
    {
        olive = true;
        yield return new WaitForSeconds(5f);
        olive = false;
    }
    IEnumerator RandomVector()
    {
        Cooltime = Random.Range(4, 6);
        D = Random.Range(0, 3);
        if (D == 0)
        {
            Which = Random.Range(1, 9);
        }
        else
        {
            Which = Random.Range(1, 5);
        }
        AnimCheck();
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(RandomVector());

    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (olive == true)
        {
            if (distance < 1.3f)
            {
                if(Drop == false)
                {
                    Drop = true;
                    StartCoroutine(Drawing());
                }
            }
        }
        TutorialSkill = PlayerPrefs.GetInt("TutorialSkill", 0);
        if(TutorialSkill ==0)
        {
            Skill = false;
        }
        else
        {
            Skill = true;
        }

        yield return new WaitForSeconds(0.3f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator Drawing()
    {
        foreach (GameObject mandu in ManDuPool)
        {
            if (!mandu.activeSelf)
            {
                Anim();
                speed = 0;
                yield return new WaitForSeconds(0.5f);
                mandu.transform.position = DrawWhich.position;
                mandu.SetActive(true);
                yield return new WaitForSeconds(0.5f);
                speed = 0.15f;
                yield return new WaitForSeconds(3f);
                Drop = false;
                break;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "People")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Olivetree")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Road")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Black")
        {
            if(Skill == false)
            {
                if (A == 0)
                {
                    StopAllCoroutines();
                    StartCoroutine(candy());
                }
            }
        }
    }
    void Trigger()
    {
        if (Which == 1)
        {
            Which = 4;
        }
        else if (Which == 2)
        {
            Which = 3;
        }
        else if (Which == 3)
        {
            Which = 2;
        }
        else if (Which == 4)
        {
            Which = 1;
        }
        else if (Which == 5)
        {
            Which = 8;
        }
        else if (Which == 6)
        {
            Which = 7;
        }
        else if (Which == 7)
        {
            Which = 6;
        }
        else if (Which == 8)
        {
            Which = 5;
        }
        AnimCheck();
    }
    void Anim()
    {
        if (gameObject.transform.position.x < Player.position.x) //오른쪽
        {
            if (gameObject.transform.position.x + 0.5f < Player.position.x) //오른쪽
            {
                A = 1;
                animator.SetTrigger("rightdraw");
                DrawWhich.localPosition = new Vector3(3.5f, 1, 0);
            }
            else
            {
                if (gameObject.transform.position.y < Player.position.y)
                {
                    A = 1;
                    animator.SetTrigger("backdraw");
                    DrawWhich.localPosition = new Vector3(2, 2, 0);
                }
                else
                {
                    A = 1;
                    animator.SetTrigger("frontdraw");
                    DrawWhich.localPosition = new Vector3(-2, 1.75f, 0);
                }
            }
        }
        else if (gameObject.transform.position.x > Player.position.x) //왼쪽
        {
            if (gameObject.transform.position.x - 0.5f > Player.position.x) //오른쪽
            {
                A = 1;
                animator.SetTrigger("leftdraw");
                DrawWhich.localPosition = new Vector3(-3.5f, 1, 0);
            }
            else
            {
                if (gameObject.transform.position.y < Player.position.y)
                {
                    A = 1;
                    animator.SetTrigger("backdraw");
                    DrawWhich.localPosition = new Vector3(2, 2, 0);
                }
                else
                {
                    A = 1;
                    animator.SetTrigger("frontdraw");
                    DrawWhich.localPosition = new Vector3(-2, 1.75f, 0);
                }
            }
        }
    }
    void AnimCheck()
    {
        if (Which == 1)
        {
            animator.SetBool("back", true);
            animator.SetBool("front", false);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
        else if (Which == 2)
        {
            animator.SetBool("left", true);
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("right", false);
        }
        else if (Which == 3)
        {
            animator.SetBool("right", true);
            animator.SetBool("front", false);
            animator.SetBool("left", false);
            animator.SetBool("back", false);
        }
        else if (Which == 4)
        {
            animator.SetBool("front", true);
            animator.SetBool("back", false);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
        else if (Which == 5)
        {
            animator.SetBool("right", true);
            animator.SetBool("front", false);
            animator.SetBool("left", false);
            animator.SetBool("back", false);
        }
        else if (Which == 6)
        {
            animator.SetBool("right", true);
            animator.SetBool("front", false);
            animator.SetBool("left", false);
            animator.SetBool("back", false);
        }
        else if (Which == 7)
        {
            animator.SetBool("left", true);
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("right", false);
        }
        else if (Which == 8)
        {
            animator.SetBool("left", true);
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("right", false);
        }
    }
    IEnumerator candy()
    {
        Candy();
        A = 1;
        speed = 0;
        animator.SetTrigger("Candy");
        yield return new WaitForSeconds(0.5f);
        animator.enabled = false;
        yield return new WaitForSeconds(4f);
        A = 0;
        speed = 0.15f;
        animator.enabled = true;
        StartCoroutine(RandomVector());
        StartCoroutine(ModeCheck());
    }

}