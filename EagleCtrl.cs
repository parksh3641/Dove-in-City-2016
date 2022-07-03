using UnityEngine;
using System.Collections;

public class EagleCtrl : MonoBehaviour {
    public float speed;

    private int Dove;
    private float EaglespeedA;
    private float EaglespeedB;
    private float distance;
    private bool Die = false;
    private bool level = false;
    private int LevelUp;

    private Animator animator;
    public Animator shadowanimator;

    private Transform Player;

    private int Hp;

    public delegate void eaglectrl();
    public static event eaglectrl Score100;

    void Awake()
    {
        EaglespeedA = GameManager.EaglespeedA;
        EaglespeedB = GameManager.EaglespeedB;
        animator = GetComponent<Animator>();

        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindGameObjectWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindGameObjectWithTag("Dori").GetComponent<Transform>();
        }
    }

    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        Hp = 20;

        RandomSpeed();
        StartCoroutine(DeadCheck());
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        Die = false;
        level = false;
        animator.enabled = true;
        shadowanimator.enabled = true;
        StopAllCoroutines();
    }

    void PlayerDie()
    {
        Die = true;
        level = false;
        animator.enabled = false;
        shadowanimator.enabled = false;
        StopAllCoroutines();
    }
    void PlayerLive()
    {
        Die = false;
        animator.enabled = true;
        shadowanimator.enabled = true;
        if(gameObject.activeInHierarchy == true)
        {
            StartCoroutine(DeadCheck());
        }
    }

    void RandomSpeed()
    {
        speed = Random.Range(EaglespeedA, EaglespeedB);
    }
    IEnumerator ModeCheck()
    {
        LevelUp = PlayerPrefs.GetInt("LevelUp", 0);
        if (LevelUp == 0)
        {
            level = false;

        }
        else if (LevelUp == 1)
        {
            level = true;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator DeadCheck()
    {
        yield return new WaitForSeconds(4f);
        if(transform.position.y < Player.position.y -2.0f)
        {
            gameObject.SetActive(false);
        }
        else
        {
            StartCoroutine(DeadCheck());
        }
    }

    void Update()
    {
        if(Die == false)
        {
            if (level == false)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
            else
            {
                transform.Translate(0, speed * 2 * Time.deltaTime, 0);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Egg")
        {
            coll.gameObject.SetActive(false);
            Hp -= 10;
            if (Hp == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
