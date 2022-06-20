using UnityEngine;
using System.Collections;

public class GodCtrl : MonoBehaviour
{
    private Transform Player;
    private BoxCollider2D box;

    public GameObject Vector;

    public int Value = 0; //0은 산신령 1은 두더지

    private float speed;
    private int Dove;
    private float distance;
    private int talk = 0;

    private int Skill;
    private bool skill = false;
    private bool Come = false;
    private bool Go = false;
    private bool Going = false;
    private bool Die = false;

    private Animator animator;

    public delegate void god();
    public static event god TalkStart, GodTalk , MoleTalk;

    void Awake()
    {
        Vector.SetActive(true);
        animator = GetComponent<Animator>();

        if (Value ==0)
        {
            box = GetComponent<BoxCollider2D>();
            box.enabled = false;
        }
    }
    IEnumerator modeCheck()
    {
        Skill = PlayerPrefs.GetInt("Skill", 0);
        if (Skill == 1)
        {
            skill = true;
        }
        else
        {
            skill = false;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(modeCheck());
    }
    void OnEnable()
    {
        speed = GameManager.bgspeed * 2.5f;
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        Talk.TalkEnd += TalkEnd;
        Talk.Talking += Talking;

        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindGameObjectWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindGameObjectWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindGameObjectWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindGameObjectWithTag("Dori").GetComponent<Transform>();
        }

        StartCoroutine(ModeCheck());
        StartCoroutine(modeCheck());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        Talk.TalkEnd -= TalkEnd;
        Talk.Talking -= Talking;

        skill = false;
        Die = false;
        Come = false;

        Vector.SetActive(true);
        StopAllCoroutines();

    }

    void Talking()
    {
        if(talk ==0)
        {
            Die = true;
            Go = true;
            Come = true;
        }
    }
    void TalkEnd()
    {
        if (talk == 0)
        {
            Die = false;
            Go = false;
            Come = false;
        }
        else if(talk == 1)
        {
            gameObject.SetActive(false);
        }
    }

    void PlayerDie()
    {
        skill = false;
        Die = true;
        Come = true;
        StopAllCoroutines();
    }
    void PlayerLive()
    {
        Die = false;
        Come = false;
        StartCoroutine(ModeCheck());
        StartCoroutine(modeCheck());
    }

    void Update()
    {
        if(Going == true)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (Die == false)
        {
            if(skill == false)
            {
                if (distance < 1.05f)
                {
                    if (Come == false)
                    {
                        Come = true;
                        if (Value == 0)
                        {
                            ComingA();
                        }
                        else if (Value == 1)
                        {
                            ComingB();
                        }
                        //Debug.Log("접근완료");
                        Vector.SetActive(false);
                    }
                }
            }
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
    void ComingA()
    {
        float A = Random.Range(0, 2);
        if(A ==0)
        {
            animator.SetBool("Come", true);
            StartCoroutine(DeadTime());
            //Debug.Log("돌진");
        }
        else
        {
            float B = Random.Range(0, 2);
            if(B ==0)
            {
                animator.SetBool("Come", true);
                StartCoroutine(TalkTime());
                //Debug.Log("산신령 대화");
            }
            else
            {
                //Debug.Log("산신령 아무일도 일어나지않았다.");
            }
        }
    }
    void ComingB()
    {
        float A = Random.Range(0, 2);
        if (A == 0)
        {
            animator.SetBool("Up", true);
            StartCoroutine(TalkTime());
            //Debug.Log("두더지 대화");
        }
        else
        {
            //Debug.Log("두더지 아무일도 일어나지않았다.");
        }
    }
    IEnumerator TalkTime()
    {
        yield return new WaitForSeconds(0.7f);
        if (Die == false)
        {
            TalkStart();
            if (Value == 0)
            {
                talk = 1;
                GodTalk();
            }
            else if (Value == 1)
            {
                talk = 1;
                MoleTalk();
            }
            yield return new WaitForSeconds(1.0f);
            animator.enabled = false;
        }
    }
    IEnumerator DeadTime()
    {
        yield return new WaitForSeconds(1.0f);
        if(Go == false)
        {
            box.enabled = true;
            animator.enabled = false;
            Vector2 relativePos = (Player.transform.position + new Vector3(0, 0.2f, 0)) - transform.position;
            float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
            transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
            Going = true;
        }
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
}