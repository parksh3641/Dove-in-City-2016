using UnityEngine;
using System.Collections;

public class BirdCtrl : MonoBehaviour
{
    public float speed;
    public Transform shadow;
    private BoxCollider2D box;
    private Animator animator;
    public Animator shadowanimator;

    private int Dove;
    private float cooltime = 3f;
    public float gradiant;
    private float BirdspeedA;
    private float BirdspeedB;
    private float distance;
    private int Eagletouch;
    private int LevelUp;

    private Transform Player;
    public bool Right = false;
    public bool Left = false;
    private bool Die = false;
    private bool eagle = false;
    private bool level = false;
    private bool Level = false;

    private int Hp = 10;
    //private bool level = false; //스테이지 넘어갈시

    public delegate void birdctrl();
    public static event birdctrl Score50;
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();

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
    }
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        BirdspeedA = GameManager.BirdspeedA;
        BirdspeedB = GameManager.BirdspeedB;

        Hp = 10;

        if (transform.position.x >= Player.position.x)
        {
            Right = true;
            Left = false;
            shadow.transform.localPosition = new Vector3(-1f, shadow.localPosition.y, shadow.localPosition.z);
        }
        if (transform.position.x <= Player.position.x)
        {
            Right = false;
            Left = true;
            shadow.transform.localPosition = new Vector3(1f, shadow.localPosition.y, shadow.localPosition.z);
        }
        RandomSpeed();
        StartCoroutine(modeCheck());
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        Die = false;
        animator.enabled = true;
        shadowanimator.enabled = true;
        box.enabled = true;

        eagle = false;
        StopAllCoroutines();
    }

    void PlayerDie()
    {
        Die = true;
        animator.enabled = false;
        shadowanimator.enabled = false;
    }
    void PlayerLive()
    {
        Die = false;
        animator.enabled = true;
        shadowanimator.enabled = true;
    }

    void RandomSpeed()
    {
        speed = Random.Range(BirdspeedA, BirdspeedB);
        StartCoroutine(RandomMove());
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (distance > 4f)
        {
            transform.rotation = Quaternion.identity;
            gameObject.SetActive(false);
        }

        if (transform.position.y < Player.position.y - 1f)
        {
            transform.rotation = Quaternion.identity;
            gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator modeCheck()
    {
        Eagletouch = PlayerPrefs.GetInt("Eagletouch", 0);
        if(Eagletouch ==1)
        {
            eagle = true;
        }
        else
        {
            eagle = false;
        }

        LevelUp = PlayerPrefs.GetInt("LevelUp", 0);
        if(LevelUp == 0)
        {
            level = false;
            if(Level == false)
            {
                Level = true;
                LevelCheck();
            }
        }
        else if(LevelUp ==1)
        {
            level = true;
            if(Level == true)
            {
                Level = false;
                LevelCheck();
            }
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(modeCheck());
    }
    void LevelCheck()
    {
        gradiant = Random.Range(50, 150);
        if (transform.position.x < Player.position.x)
        {
            transform.Rotate(new Vector3(0, 0, gradiant));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, -gradiant));
        }
    }
    IEnumerator RandomMove()
    {
        transform.rotation = Quaternion.identity;
        if(Die == false)
        {
            gradiant = Random.Range(10, 170);
        }
        if (Right == true)
        {
            transform.Rotate(new Vector3(0, 0, gradiant));

        }
        if (Left == true)
        {
            transform.Rotate(new Vector3(0, 0, -gradiant));

        }
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(RandomMove());
    }
    void Update()
    {
        if (Die == false)
        {
            if(level == false)
            {
                if (eagle == false)
                {
                    transform.Translate(0, speed * Time.deltaTime, 0);
                }
                else
                {
                    transform.Translate(0, speed * 1.75f * Time.deltaTime, 0);
                }
            }
            else
            {
                transform.Translate(0, speed * 4f * Time.deltaTime, 0);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Egg")
        {
            coll.gameObject.SetActive(false);
            Hp -= 10;
            if (Hp == 0)
            {
                Score50();
                transform.rotation = Quaternion.identity;
                gameObject.SetActive(false);
            }
        }
    }
}
