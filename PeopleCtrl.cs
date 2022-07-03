using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PeopleCtrl : MonoBehaviour {
    private Transform Player;
    private Transform DrawWhich;
    private Transform pos;
    private BoxCollider2D box;

    public GameObject Stone;
    public GameObject ManDu;

    public int Value = 0; //0이면 어린아이 1이면 어른

    private SpriteRenderer My;

    private float speed;

    public int Which = 3; //위 왼쪽 오른쪽 아래 1234
    private int which = 0; //부딫힌 위치 입력
    private float Cooltime = 0;
    private float cooltime = 3f;
    private int Count = 3;
    private float Counttime = 0.6f;

    private int Dove;
    private float distance;
    private int Olive;
    private bool olive;
    private bool Drop = false;
    private bool dori = false;
    private int Dori = 0;

    private bool AIstart = false;
    private bool AImove = false;
    private bool AIend = false;
    private int A = 0;
    private int B = 0;
    private int C = 0;
    private int D = 0;
    private float X;
    private float Y;
    private bool Alive= false;

    private int Acount = 0; //위아래
    private int Bcount = 0; //좌우

    private bool Die = false;
    private int Skill;
    private bool skill = false; //스킬사용여부
    private bool Rain = false;
    private bool wait = false;

    private bool BuildWait = false;

    private bool Eagle = false;

    private Animator animator;

    public List<GameObject> ManDuPool = new List<GameObject>();
    public List<GameObject> StonePool = new List<GameObject>();

    public delegate void Peoplectrl();
    public static event Peoplectrl Candy , Hit;

    void Awake()
    {
        DrawWhich = transform.Find("DrawWhich").GetComponent<Transform>();
        My = GetComponent<SpriteRenderer>();
        My.sortingOrder = -10;
        animator = GetComponent<Animator>();

        box = GetComponent<BoxCollider2D>();
        box.offset = new Vector2(-0.06f, -0.5f);
        box.size = new Vector3(4.5f, 11.5f);

        X = transform.position.x;
        Y = transform.position.y;

        for (int i = 0; i < 2; i++)
        {
            GameObject stone = Instantiate(Stone);
            stone.name = "Stone _" + i.ToString();
            stone.SetActive(false);
            StonePool.Add(stone);
        }
        for (int i = 0; i < 2; i++)
        {
            GameObject mandu = Instantiate(ManDu);
            mandu.name = "ManDu _" + i.ToString();
            mandu.SetActive(false);
            ManDuPool.Add(mandu);
        }
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
            Player = GameObject.FindWithTag("Eagle").GetComponent<Transform>();
            Eagle = true;
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindWithTag("Dori").GetComponent<Transform>();
        }
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        Alive = true;
    }

    void OnEnable()
    {
        speed = GameManager.bgspeed * 0.35f;
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        GameUI.RainStart += RainStart;
        GameUI.RainStop += RainStop;

        if (Dove == 0)
        {
            StartCoroutine("ModeCheck");
        }
        else if (Dove == 1)
        {
            StartCoroutine("ModeCheck");
        }
        else if (Dove == 2)
        {
            StartCoroutine("ModeCheck");
            Eagle = true;
        }
        else if (Dove == 3)
        {
            StartCoroutine("DoriCheck");
        }

        StartCoroutine("Check");
        StartCoroutine("RandomVector");
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        GameUI.RainStart -= RainStart;
        GameUI.RainStop -= RainStop;

        transform.position = new Vector3(X, Y, transform.position.z);

        animator.enabled = true;
        Die = false;
        olive = false;
        skill = false;
        Rain = false;
        speed = 0.15f;
        StopAllCoroutines();
    }

    void RainStart()
    {
        Rain = true;
    }
    void RainStop()
    {
        Rain = false;
        if(Dove ==2)
        {
            Eagle = true;
        }
    }

    void PlayerDie()
    {
        animator.enabled = false;
        olive = false;
        Die = true;
        skill = false;
        Rain = false;
        speed = 0;
        StopCoroutine("ModeCheck");
        StopCoroutine("DoriCheck");
    }
    void PlayerLive()
    {
        animator.enabled = true;
        Die = false;
        speed = GameManager.bgspeed * 0.35f;
        if (gameObject.activeInHierarchy == true)
        {
            if (Dove == 0)
            {
                StartCoroutine("ModeCheck");
            }
            else if (Dove == 1)
            {
                StartCoroutine("ModeCheck");
            }
            else if (Dove == 2)
            {
                StartCoroutine("ModeCheck");
                Eagle = true;
            }
            else if (Dove == 3)
            {
                StartCoroutine("DoriCheck");
            }
        }
    }

    IEnumerator Check()
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
        Olive = PlayerPrefs.GetInt("Olive", 0);
        if (Olive == 1)
        {
            olive = true;
        }
        else
        {
            olive = false;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(Check());
    }

    IEnumerator candy()
    {
        if(Value ==0)
        {
            Candy();
            speed = 0;
            animator.SetTrigger("Candy");
            yield return new WaitForSeconds(0.5f);
            animator.enabled = false;
            yield return new WaitForSeconds(5f);
            speed = 0.15f;
            animator.enabled = true;
        }
    }

    void Update()
    {
        if (AImove == false)
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
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pos.position, speed * Time.deltaTime);
            if (transform.position == pos.position)
            {
                AImove = false;
                StartCoroutine(moveCheck());
            }
        }
    }

    IEnumerator RandomVector()
    {
        if(Die == false)
        {
            if (AIstart == false)
            {
                Cooltime = Random.Range(4, 6);
                if(wait == false)
                {
                    D = Random.Range(0, 3);
                    if(D == 0)
                    {
                        Which = Random.Range(1, 9);
                    }
                    else
                    {
                        Which = Random.Range(1, 5);
                    }
                    AnimCheck();
                }
            }
        }
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(RandomVector());

    }

    IEnumerator DoriCheck() //도라전용
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if(olive == false)
        {
            if (distance < 1.05f)
            {
                if (dori == false)
                {
                    dori = true;
                    Dori = 0;
                    StartCoroutine(DoriDrawing());
                }
            }
        }
        else
        {
            if (distance < 1.05f)
            {
                if (dori == false)
                {
                    dori = true;
                    Dori = 1;
                    StartCoroutine(DoriDrawing());
                }
            }
        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(DoriCheck());
    }
    IEnumerator DoriDrawing()
    {
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);
        if (Dori == 0)
        {
            foreach (GameObject mandu in ManDuPool)
            {
                if (!mandu.activeSelf)
                {
                    float A = Random.Range(0, 10);
                    //Debug.Log(A.ToString());
                    if (A < 3)
                    {
                        Anim();
                        speed = 0;
                        yield return new WaitForSeconds(0.5f);
                        mandu.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                        mandu.SetActive(true);
                        yield return new WaitForSeconds(0.5f);
                        speed = 0.15f;
                    }
                    yield return new WaitForSeconds(2f);
                    dori = false;
                    break;
                }
            }
        }
        else
        {
            foreach (GameObject mandu in ManDuPool)
            {
                if (!mandu.activeSelf)
                {
                    Anim();
                    speed = 0;
                    yield return new WaitForSeconds(0.5f);
                    mandu.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                    mandu.SetActive(true);
                    yield return new WaitForSeconds(0.5f);
                    speed = 0.15f;
                    yield return new WaitForSeconds(2f);
                    dori = false;
                    break;
                }
            }
        }
    }

    IEnumerator EagleDrawing()
    {
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);
        foreach (GameObject stone in StonePool)
        {
            if (!stone.activeSelf)
            {
                Anim();
                speed = 0;
                yield return new WaitForSeconds(0.5f);
                stone.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                stone.SetActive(true);
                yield return new WaitForSeconds(0.5f);
                speed = 0.15f;
                yield return new WaitForSeconds(3f);
                break;
            }
        }
    }

    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (olive == true)
        {
            if (distance < 1.05f)
            {
                if (Drop == false)
                {
                    Drop = true;
                    StartCoroutine(Drawing());
                }
            }
        }

        if(Rain == true)
        {
            if (distance < 1.1f)
            {
                if (Eagle == true)
                {
                    Eagle = false;
                    StartCoroutine(EagleDrawing());
                }
            }
        }

        if (transform.position.y < Player.position.y - 1f)
        {
            if (Alive == true)
            {
                gameObject.SetActive(false);
            }
        }

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(ModeCheck());
    } //기본
    IEnumerator Drawing()
    {
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);
        if (Dove == 0)
        {
            foreach (GameObject stone in StonePool)
            {
                if (!stone.activeSelf)
                {
                    C = Random.Range(0, 10);
                    if (C < 3)
                    {
                        Anim();
                        speed = 0;
                        yield return new WaitForSeconds(0.5f);
                        stone.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                        stone.SetActive(true);
                        yield return new WaitForSeconds(0.5f);
                        speed = 0.15f;
                    }
                    yield return new WaitForSeconds(3f);
                    Drop = false;
                    break;
                }
            }
        }
        else if (Dove == 1)
        {
            B = Random.Range(0, 10);
            if (B == 0)
            {
                foreach (GameObject stone in StonePool)
                {
                    if (!stone.activeSelf)
                    {
                        Anim();
                        speed = 0;
                        yield return new WaitForSeconds(0.5f);
                        stone.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                        stone.SetActive(true);
                        yield return new WaitForSeconds(0.5f);
                        speed = 0.15f;
                        yield return new WaitForSeconds(3f);
                        Drop = false;
                        break;
                    }
                }
            }
            else
            {
                foreach (GameObject mandu in ManDuPool)
                {
                    if (!mandu.activeSelf)
                    {
                        Anim();
                        speed = 0;
                        yield return new WaitForSeconds(0.5f);
                        mandu.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                        mandu.SetActive(true);
                        yield return new WaitForSeconds(0.5f);
                        speed = 0.15f;
                        yield return new WaitForSeconds(3f);
                        Drop = false;
                        break;
                    }
                }
            }
        }
        else if (Dove == 2)
        {
            foreach (GameObject stone in StonePool)
            {
                if (!stone.activeSelf)
                {
                    Anim();
                    speed = 0;
                    yield return new WaitForSeconds(0.5f);
                    stone.transform.position = DrawWhich.position + new Vector3(C, D, 0); ;
                    stone.SetActive(true);
                    yield return new WaitForSeconds(0.5f);
                    speed = 0.15f;
                    yield return new WaitForSeconds(3f);
                    Drop = false;
                    break;

                }
            }
        }
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
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("left", false);
            animator.SetBool("right", true);
        }
        else if (Which == 6)
        {
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("left", false);
            animator.SetBool("right", true);
        }
        else if (Which == 7)
        {
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("left", true);
            animator.SetBool("right", false);
        }
        else if (Which == 8)
        {
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("left", true);
            animator.SetBool("right", false);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Road")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "SeaStart")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "SeaEnd")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Trash")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Olivetree")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "CastleIn")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Building")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Black")
        {
            if (skill == false)
            {
                if (Value == 0)
                {
                    StartCoroutine(candy());
                }
                else
                {
                    if (Rain == false)
                    {
                        Hit();
                    }
                }
            }
        }

        if(AIend == false)
        {
            if (coll.gameObject.name == "Curve1")
            {
                pos = coll.GetComponent<Transform>();

                which = 1;
                move();
            }
            else if (coll.gameObject.name == "Curve2")
            {
                pos = coll.GetComponent<Transform>();

                which = 2;
                move();
            }
            else if(coll.gameObject.name == "Curve3")
            {
                pos = coll.GetComponent<Transform>();

                which = 3;
                move();
            }
            else if(coll.gameObject.name == "Curve4")
            {
                pos = coll.GetComponent<Transform>();

                move();
                which = 4;
            }
            else if(coll.gameObject.name == "Curve5")
            {
                pos = coll.GetComponent<Transform>();

                which = 5;
                move();
            }
            else if (coll.gameObject.name == "Curve6")
            {
                pos = coll.GetComponent<Transform>();

                which = 6;
                move();
            }
            else if (coll.gameObject.name == "Curve7") //5랑동일
            {
                pos = coll.GetComponent<Transform>();

                which = 5;
                move();
            }
            else if (coll.gameObject.name == "Curve8")
            {
                pos = coll.GetComponent<Transform>();

                which = 8;
                move();
            }
            else if (coll.gameObject.name == "Curve9") //4랑 동일
            {
                pos = coll.GetComponent<Transform>();

                which = 4;
                move();
            }
            else if (coll.gameObject.name == "Curve10") //5랑동일
            {
                pos = coll.GetComponent<Transform>();

                which = 5;
                move();
            }
            else if (coll.gameObject.name == "Curve11") //5랑동일
            {
                pos = coll.GetComponent<Transform>();

                which = 5;
                move();
            }
            else if (coll.gameObject.name == "Curve12") //8이랑 동일
            {
                pos = coll.GetComponent<Transform>();

                which = 8;
                move();
            }
            else if (coll.gameObject.name == "Curve13") //4랑 동일
            {
                pos = coll.GetComponent<Transform>();

                which = 4;
                move();
            }
            else if (coll.gameObject.name == "Curve14") //5랑동일
            {
                pos = coll.GetComponent<Transform>();

                which = 5;
                move();
            }
            else if (coll.gameObject.name == "Curve15") //6이랑동일
            {
                pos = coll.GetComponent<Transform>();

                which = 6;
                move();
            }
            else if (coll.gameObject.name == "Curve16") //5랑동일
            {
                pos = coll.GetComponent<Transform>();

                which = 5;
                move();
            }
            else if (coll.gameObject.name == "Curve17") //8이랑 동일
            {
                pos = coll.GetComponent<Transform>();

                which = 8;
                move();
            }
            else if (coll.gameObject.name == "Curve18")
            {
                pos = coll.GetComponent<Transform>();

                which = 18;
                move();
            }
            else if (coll.gameObject.name == "Curve19")
            {
                pos = coll.GetComponent<Transform>();

                which = 19;
                move();
            }
            else if (coll.gameObject.name == "Curve20")
            {
                pos = coll.GetComponent<Transform>();

                which = 20;
                move();
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "SeaStart")
        {
            which = 4;
            AnimCheck();
        }
        if (coll.gameObject.tag == "SeaEnd")
        {
            which = 1;
            AnimCheck();
        }
        if (coll.gameObject.tag == "Building")
        {
            Trigger();
            if(BuildWait == false)
            {
                BuildWait = true;
                StartCoroutine(BuildingWait());
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Building")
        {
            if(BuildWait == true)
            {
                BuildWait = false;
            }
        }
    }
    IEnumerator BuildingWait()
    {
        yield return new WaitForSeconds(3f);
        if(BuildWait == true)
        {
            gameObject.SetActive(false);
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
        StopCoroutine("WaitTime");
        StartCoroutine("WaitTime");
    } //반대방향으로 밀어내기

    //ai 길찾기
    void move()
    {
        AIstart = true;
        AIend = true;
        AImove = true;
        StopAllCoroutines();
    }

    IEnumerator moveCheck()
    {
        if (which == 1)
        {
            A = Random.Range(0, 2);
            if (A == 0)
            {
                Which = 4;
                AnimCheck();
            }
            else
            {
                Which = 3;
                AnimCheck();
            }
        }
        else if (which == 2)
        {
            A = Random.Range(0, 3);
            if (A == 0)
            {
                Which = 2;
                AnimCheck();
            }
            else if (A == 1)
            {
                Which = 3;
                AnimCheck();
            }
            else if (A == 2)
            {
                Which = 4;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
        }
        else if (which == 3)
        {
            A = Random.Range(0, 2);
            if (A == 0)
            {
                Which = 4;
                AnimCheck();
            }
            else
            {
                Which = 2;
                AnimCheck();
            }
        }
        else if (which == 4)
        {
            A = Random.Range(0, 3);
            if (A == 0)
            {
                Which = 1;
                AnimCheck();
            }
            else if(A ==1)
            {
                Which = 4;
                AnimCheck();
            }
            else if (A == 2)
            {
                Which = 3;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
        }
        else if (which == 5)
        {
            A = Random.Range(0, 2);
            if (A == 0)
            {
                Which = 2;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
            else
            {
                Which = 3;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
        }
        else if (which == 6)
        {
            A = Random.Range(0, 2);
            if (A == 0)
            {
                Which = 1;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
            else
            {
                Which = 4;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
        }
        else if (which == 8)
        {
            A = Random.Range(0, 3);
            if (A == 0)
            {
                Which = 1;
                AnimCheck();
            }
            else if (A == 1)
            {
                Which = 4;
                AnimCheck();
            }
            else if (A == 2)
            {
                Which = 2;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
        }
        else if (which == 18)
        {
            A = Random.Range(0, 2);
            if (A == 0)
            {
                Which = 1;
                AnimCheck();
            }
            else
            {
                Which = 3;
                AnimCheck();
            }
        }
        else if (which == 19)
        {
            A = Random.Range(0, 3);
            if (A == 0)
            {
                Which = 2;
                AnimCheck();
            }
            else if (A == 1)
            {
                Which = 3;
                AnimCheck();
            }
            else if (A == 2)
            {
                Which = 1;
                AnimCheck();
                yield return new WaitForSeconds(cooltime);
                AIstart = false;
                AIend = false;
            }
        }
        else if (which == 20)
        {
            A = Random.Range(0, 2);
            if (A == 0)
            {
                Which = 1;
                AnimCheck();
            }
            else
            {
                Which = 2;
                AnimCheck();
            }
        }
    }
    IEnumerator WaitTime()
    {
        wait = true;
        yield return new WaitForSeconds(0.7f);
        wait = false;
    }
}
