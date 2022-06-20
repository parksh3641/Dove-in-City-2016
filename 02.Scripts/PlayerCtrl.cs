using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour
{
    public Transform pos;
    //Dove 종류 0은 구구 1은 루루;
    public float DoveState;
    private float Dove;

    private int SkinAA;
    private int SkinAB;
    private int SkinAC;
    private int SkinAD;

    private int olive;
    private int Hard;

    public RuntimeAnimatorController Hskin;
    public RuntimeAnimatorController Cskin;
    public RuntimeAnimatorController Wskin;

    private float speed;
    //private float minispeed;
    private float bgspeed;
    private float bgSpeed;
    private float movelimitx;
    private float movelimity;

    private float scale = 0.03f;
    private float alpha = 1.0f;
    private float shadowalpha = 0.5f;
    private float SkillTime;
    private float OliveTime;
    private float SmallTime;
    private float HitCooltime;

    private bool talk = false;
    private bool DoHit = false; //무적시간
    private bool A = false; //스킬사용여부
    private bool B = false; //미니포션사용여부
    //private bool C = false; //스테이지이동여부
    private bool Die = false; //플레이어사망여부
    private bool Power = false;

    private bool Under = false;
    private int under = 0;
    private bool Castle = false;
    private int castle = 0;
    private bool time = false;

    private bool level = false;
    private int Level = 0;

    private bool pause = false;

    private int Hp;

    private int ChangeNumber = 0;

    private float x;
    private float y;

    public Sprite BlackSkill;
    public Sprite BlackDie;
    public Sprite WhiteSkill;
    public Sprite WhiteDie;
    public Sprite EagleSkill;
    public Sprite EagleDie;
    public Sprite DoriSkill;
    public Sprite DoriDie;

    public Sprite HskinSkill;
    public Sprite HskinDie;

    public Sprite CskinSkill;
    public Sprite CskinDie;

    public Sprite WskinSkill;
    public Sprite WskinDie;

    public GameObject Tree;
    private BoxCollider2D Collider;

    private SpriteRenderer Sprite;
    private Animator animator;
    private Animator shadow;
    private SpriteRenderer Shadow;
    public SpriteRenderer tree;

    public delegate void Playerctrl();
    public static event Playerctrl HeartMinus, HeartPlus, StoneMinus, Score50, Score100, OliveTreeIn, OliveTreeOut,
        CastleIn, CastleOut, LevelUp, EagleTouch, SeaStart, SeaEnd, BirdPlus, BuildPlus, TimeslipEnd, Coin
        , UFO, UnderOut, Car, BuildMinus, ManDuPlus, BirdMinus, CoinDel;

    void Awake()
    {
        Tree.SetActive(false);
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            if (DoveState == 0)
            {
                Power = false;
                shadow = GameObject.Find("BlackShadow").GetComponent<Animator>();
                Shadow = GameObject.Find("BlackShadow").GetComponent<SpriteRenderer>();
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (Dove == 1)
        {
            if (DoveState == 1)
            {
                Power = true;
                shadow = GameObject.Find("WhiteShadow").GetComponent<Animator>();
                Shadow = GameObject.Find("WhiteShadow").GetComponent<SpriteRenderer>();
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (Dove == 2)
        {
            if (DoveState == 2)
            {
                Power = true;
                shadow = GameObject.Find("Eagleshadow").GetComponent<Animator>();
                Shadow = GameObject.Find("Eagleshadow").GetComponent<SpriteRenderer>();
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (Dove == 3)
        {
            if (DoveState == 3)
            {
                Power = false;
                shadow = GameObject.Find("DoriShadow").GetComponent<Animator>();
                Shadow = GameObject.Find("DoriShadow").GetComponent<SpriteRenderer>();
            }
            else
            {
                gameObject.SetActive(false);
            }
        }

    }
    void Start()
    {
        animator = GetComponent<Animator>();
        Collider = GetComponent<BoxCollider2D>();
        Sprite = GetComponent<SpriteRenderer>();

        speed = GameManager.speed;
        bgspeed = GameManager.bgspeed;
        movelimitx = GameManager.movelimitx;
        movelimity = GameManager.movelimity;
        OliveTime = GameManager.OliveTime;
        SmallTime = GameManager.SmallTime;

        SkillTime = GameManager.SkillTime;
        HitCooltime = GameManager.Hitcooltime;

        Hard = PlayerPrefs.GetInt("Hard", 0);
        if (Hard == 1)
        {
            LevelUp();
            LevelUp();
            LevelUp();
            LevelUp();
            LevelUp();
            LevelUp();
            LevelUp();
            LevelUp();
            LevelCheck();
        }

        SkinAA = PlayerPrefs.GetInt("SkinAA", 0);
        SkinAB = PlayerPrefs.GetInt("SkinAB", 0);
        SkinAC = PlayerPrefs.GetInt("SkinAC", 0);
        SkinAD = PlayerPrefs.GetInt("SkinAD", 0);
        if (Dove == 0)
        {
            if (SkinAA == 1)
            {
                animator.runtimeAnimatorController = Hskin;
                shadow.runtimeAnimatorController = Hskin;
            }
            else if (SkinAA == 2)
            {
                animator.runtimeAnimatorController = Cskin;
                shadow.runtimeAnimatorController = Cskin;
            }
            else if (SkinAA == 3)
            {
                animator.runtimeAnimatorController = Wskin;
                shadow.runtimeAnimatorController = Wskin;
            }
        }
        else if (Dove == 1)
        {
            if (SkinAB == 1)
            {
                animator.runtimeAnimatorController = Hskin;
                shadow.runtimeAnimatorController = Hskin;
            }
            else if (SkinAB == 2)
            {
                animator.runtimeAnimatorController = Cskin;
                shadow.runtimeAnimatorController = Cskin;
            }
            else if (SkinAB == 3)
            {
                animator.runtimeAnimatorController = Wskin;
                shadow.runtimeAnimatorController = Wskin;
            }
        }
        else if (Dove == 2)
        {
            if (SkinAC == 1)
            {
                animator.runtimeAnimatorController = Hskin;
                shadow.runtimeAnimatorController = Hskin;
            }
            else if (SkinAC == 2)
            {
                animator.runtimeAnimatorController = Cskin;
                shadow.runtimeAnimatorController = Cskin;
            }
            else if (SkinAC == 3)
            {
                animator.runtimeAnimatorController = Wskin;
                shadow.runtimeAnimatorController = Wskin;
            }
        }
        else if (Dove == 3)
        {
            if (SkinAD == 1)
            {
                animator.runtimeAnimatorController = Hskin;
                shadow.runtimeAnimatorController = Hskin;
            }
            else if (SkinAD == 2)
            {
                animator.runtimeAnimatorController = Cskin;
                shadow.runtimeAnimatorController = Cskin;
            }
            else if (SkinAD == 3)
            {
                animator.runtimeAnimatorController = Wskin;
                shadow.runtimeAnimatorController = Wskin;
            }
        }
    }
    void Update()
    {
        Sprite.color = new Color(Sprite.color.r, Sprite.color.g, Sprite.color.b, alpha);
        Shadow.color = new Color(Shadow.color.r, Shadow.color.g, Shadow.color.b, shadowalpha);
        transform.localScale = new Vector3(scale, scale, 0);
        if (Die == false)
        {
            if (talk == false)
            {
                if (time == false)
                {
                    if (A == false)
                    {
                        if (Castle == false)
                        {
                            if (Under == false)
                            {
                                transform.Translate(0, bgspeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                transform.Translate(0, 0.6f * Time.deltaTime, 0);
                            }
                        }
                        else
                        {
                            transform.Translate(0, 0.7f * Time.deltaTime, 0);
                        }
                    }
                    else
                    {
                        transform.Translate(0, bgspeed * 1.5f * Time.deltaTime, 0);
                    }
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, pos.position, speed * 1.5f);
                }
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }

        if (Under == false)
        {
            if (Castle == false)
            {
                movelimitx = GameManager.movelimitx;
                if (gameObject.transform.position.x > movelimitx)
                {
                    gameObject.transform.position = new Vector3(movelimitx, gameObject.transform.position.y, 0);
                }
                if (gameObject.transform.position.x < -movelimitx)
                {
                    gameObject.transform.position = new Vector3(-movelimitx, gameObject.transform.position.y, 0);
                }
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -movelimitx, movelimitx), Mathf.Clamp(transform.position.y, -movelimity, movelimity), 0);
            }
            else
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -31.07f, -28.93f), Mathf.Clamp(transform.position.y, -movelimity, movelimity), 0);
            }
        }
        else
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -47.6f, -42.4f), Mathf.Clamp(transform.position.y, -movelimity, movelimity), 0);
        }

        if (transform.position.y >= 40)
        {
            if (level == false)
            {
                if (Level == 0)
                {
                    Level = 1;
                    level = true;
                    LevelUp();
                    LevelCheck();
                }
            }
        }

        if (transform.position.y >= 90) //스테이지 넘어가는 지점
        {
            if (level == true)
            {
                if (Level == 1)
                {
                    Level = 0;
                    PlayerPrefs.SetInt("LevelUp", 1);
                    LevelUp();
                    LevelCheck();
                    StartCoroutine(Levelup());
                }
            }
        }

        if (transform.position.y >= 4.6f)
        {
            if (castle == 1)
            {
                castle = 0;
                CastleOut();
                StartCoroutine(CastleSetting());
            }
        }
        if (transform.position.y >= 3.3f)
        {
            if (under == 1)
            {
                under = 0;
                UnderOut();
                StartCoroutine(UnderSetting());
            }
        }
    }

    void LevelCheck()
    {
        speed = GameManager.speed;
        bgspeed = GameManager.bgspeed;
    }
    IEnumerator Levelup()
    {
        yield return new WaitForSeconds(2f);
        PlayerPrefs.SetInt("LevelUp", 0);
        transform.position = new Vector3(transform.position.x, -11.5f, transform.position.z);
        level = false;
    }
    //외부에서 오는 입력 받는곳
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += GamePause;
        GameManager.PlayerLive += PlayerLive;

        GameManager.CastleFast += CastleFast;
        GameManager.EagleFast += EagleFast;
        GameManager.HeartHit += Hit;

        PeopleCtrl.Hit += hit;

        GodCtrl.TalkStart += TalkStart;
        GameManager.TalkStart += TalkStart;
        Talk.TalkEnd += TalkEnd;
        Talk.UnderWorld += UnderWorld;

        GameUI.RainStart += RainStart;
        GameUI.RainStop += RainStop;
        SkillCtrl.SkillUse += SkillUse;
        //미니포션
        SkillCtrl.Small += Small;
        SkillCtrl.FuckSmall += FuckSmall;
        //타임슬림
        SkillCtrl.Timeslip += TimeSlip;
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= GamePause;
        GameManager.PlayerLive -= PlayerLive;

        GameManager.CastleFast -= CastleFast;
        GameManager.EagleFast -= EagleFast;
        GameManager.HeartHit -= Hit;

        PeopleCtrl.Hit -= hit;

        GodCtrl.TalkStart -= TalkStart;
        GameManager.TalkStart -= TalkStart;
        Talk.TalkEnd -= TalkEnd;
        Talk.UnderWorld -= UnderWorld;

        GameUI.RainStart -= RainStart;
        GameUI.RainStop -= RainStop;
        SkillCtrl.SkillUse -= SkillUse;
        //미니포션
        SkillCtrl.Small -= Small;
        SkillCtrl.FuckSmall -= FuckSmall;
        SkillCtrl.Timeslip -= TimeSlip;
    }

    void TalkStart()
    {
        Collider.enabled = false;
        talk = true;
        time = false;
    }
    void TalkEnd()
    {
        talk = false;
        StartCoroutine(TalkWait());
        StartCoroutine(Wait());
    }
    IEnumerator TalkWait()
    {
        yield return new WaitForSeconds(1.5f);
        Collider.enabled = true;
    }
    void UnderWorld()
    {
        x = transform.position.x;
        y = transform.position.y;
        Under = true;
        under = 1;
        transform.position = new Vector3(-45.2f, -3.4f, 0);
    }

    void hit()
    {
        if (DoHit == false)
        {
            StartCoroutine(Wait());
        }
    }
    //아이템부작용
    void Hit()
    {
        StartCoroutine(Wait());
    }

    void SkillUse()
    {
        StartCoroutine(Skilluse());
    }

    void Small()
    {
        StartCoroutine(SmallPotion());
    }
    void FuckSmall()
    {
        StartCoroutine(FuckSmallPotion());
    }

    void TimeSlip()
    {
        time = true;
        DoHit = true;
    }

    void GamePause()
    {
        Die = true;
        shadow.enabled = false;
        animator.enabled = false;
        pause = true;
    }

    void PlayerDie()
    {
        Die = true;
        shadow.enabled = false;
        Shadow.enabled = false;
        animator.enabled = false;
        Tree.SetActive(false);
        Collider.enabled = true;
        //스킬초기화
        alpha = 1;
        shadowalpha = 0.5f;
        Sprite.sortingOrder = -2;
        Shadow.sortingOrder = -3;
        tree.sortingOrder = -3;
        A = false;

        olive = 0;
        DoHit = false;

        if (Dove == 0)
        {
            if (SkinAA == 1)
            {
                Sprite.sprite = HskinDie;
            }
            else if (SkinAA == 2)
            {
                Sprite.sprite = CskinDie;
            }
            else if (SkinAA == 3)
            {
                Sprite.sprite = WskinDie;
            }
            else
            {
                Sprite.sprite = BlackDie;
            }
        }
        else if (Dove == 1)
        {
            if (SkinAB == 1)
            {
                Sprite.sprite = HskinDie;
            }
            else if (SkinAB == 2)
            {
                Sprite.sprite = CskinDie;
            }
            else if (SkinAB == 3)
            {
                Sprite.sprite = WskinDie;
            }
            else
            {
                Sprite.sprite = WhiteDie;
            }
        }
        else if (Dove == 2)
        {
            if (SkinAC == 1)
            {
                Sprite.sprite = HskinDie;
            }
            else if (SkinAC == 2)
            {
                Sprite.sprite = CskinDie;
            }
            else if (SkinAC == 3)
            {
                Sprite.sprite = WskinDie;
            }
            else
            {
                Sprite.sprite = EagleDie;
            }
        }
        else if (Dove == 3)
        {
            if (SkinAD == 1)
            {
                Sprite.sprite = HskinDie;
            }
            else if (SkinAD == 2)
            {
                Sprite.sprite = CskinDie;
            }
            else if (SkinAD == 3)
            {
                Sprite.sprite = WskinDie;
            }
            else
            {
                Sprite.sprite = DoriDie;
            }
        }
    }
    void PlayerLive()
    {
        Die = false;
        shadow.enabled = true;
        Shadow.enabled = true;
        animator.enabled = true;

        if (Dove == 0)
        {
            Power = false;
        }
        else if (Dove == 1)
        {
            Power = true;
        }
        else if (Dove == 2)
        {
            Power = true;
        }
        else if (Dove == 3)
        {
            Power = false;
        }

        if (pause == false)
        {
            StartCoroutine(BigWait());
        }
        LevelCheck();
        pause = false;
    }

    void RainStart()
    {
        ChangeNumber = 0;
        StartCoroutine(RainChange());
    }
    void RainStop()
    {
        ChangeNumber = 1;
        StartCoroutine(RainChange());
    }

    IEnumerator Skilluse()
    {
        A = true;
        animator.enabled = false;
        shadow.enabled = false;
        Sprite.sortingOrder = 0;
        Shadow.sortingOrder = -1;
        tree.sortingOrder = -1;
        if (Dove == 0)
        {
            Sprite.sprite = BlackSkill;
            Shadow.sprite = BlackSkill;
            if (SkinAA == 1)
            {
                Sprite.sprite = HskinSkill;
                Shadow.sprite = HskinSkill;
            }
            else if (SkinAA == 2)
            {
                Sprite.sprite = CskinSkill;
                Shadow.sprite = CskinSkill;
            }
            else if (SkinAA == 3)
            {
                Sprite.sprite = WskinSkill;
                Shadow.sprite = WskinSkill;
            }
        }
        else if (Dove == 1)
        {
            Sprite.sprite = WhiteSkill;
            Shadow.sprite = WhiteSkill;
            if (SkinAB == 1)
            {
                Sprite.sprite = HskinSkill;
                Shadow.sprite = HskinSkill;
            }
            else if (SkinAB == 2)
            {
                Sprite.sprite = CskinSkill;
                Shadow.sprite = CskinSkill;
            }
            else if (SkinAB == 3)
            {
                Sprite.sprite = WskinSkill;
                Shadow.sprite = WskinSkill;
            }
        }
        else if (Dove == 2)
        {
            Sprite.sprite = EagleSkill;
            Shadow.sprite = EagleSkill;
            if (SkinAC == 1)
            {
                Sprite.sprite = HskinSkill;
                Shadow.sprite = HskinSkill;
            }
            else if (SkinAC == 2)
            {
                Sprite.sprite = CskinSkill;
                Shadow.sprite = CskinSkill;
            }
            else if (SkinAC == 3)
            {
                Sprite.sprite = WskinSkill;
                Shadow.sprite = WskinSkill;
            }
        }
        else if (Dove == 3)
        {
            Sprite.sprite = DoriSkill;
            Shadow.sprite = DoriSkill;
            if (SkinAD == 1)
            {
                Sprite.sprite = HskinSkill;
                Shadow.sprite = HskinSkill;
            }
            else if (SkinAD == 2)
            {
                Sprite.sprite = CskinSkill;
                Shadow.sprite = CskinSkill;
            }
            else if (SkinAD == 3)
            {
                Sprite.sprite = WskinSkill;
                Shadow.sprite = WskinSkill;
            }
        }
        yield return new WaitForSeconds(SkillTime);
        Sprite.sortingOrder = -2;
        Shadow.sortingOrder = -3;
        tree.sortingOrder = -3;
        A = false;
        shadow.enabled = true;
        animator.enabled = true;
    }

    IEnumerator SmallPotion()
    {
        B = true;
        StartCoroutine("Smalling");
        yield return new WaitForSeconds(SmallTime - 1f);
        B = false;
    }
    IEnumerator FuckSmallPotion()
    {
        B = true;
        StartCoroutine("FuckSmalling");
        yield return new WaitForSeconds(SmallTime - 1f);
        B = false;
    }

    IEnumerator Smalling()
    {
        if (Die == false)
        {
            if (B == true)
            {
                if (scale > 0.015f)
                {
                    scale -= 0.00125f;
                }
                else
                {
                    scale = 0.015f;
                }
            }
            else
            {
                if (scale < 0.03f)
                {
                    scale += 0.00125f;
                }
                else
                {
                    scale = 0.03f;
                    StopCoroutine("Smalling");
                }
            }
        }
        else
        {
            if (scale < 0.03f)
            {
                scale += 0.0025f;
            }
            else
            {
                scale = 0.03f;
                StopCoroutine("Smalling");
            }
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine("Smalling");
    }
    IEnumerator FuckSmalling()
    {
        if (Die == false)
        {
            if (B == true)
            {
                if (scale < 0.09f)
                {
                    scale += 0.0025f;
                }
                else
                {
                    scale = 0.09f;
                }
            }
            else
            {
                if (scale > 0.03f)
                {
                    scale -= 0.00125f;
                }
                else
                {
                    scale = 0.03f;
                    StopCoroutine("FuckSmalling");
                }
            }
        }
        else
        {
            if (scale > 0.03f)
            {
                scale -= 0.005f;
            }
            else
            {
                scale = 0.03f;
                StopCoroutine("FuckSmalling");
            }
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine("FuckSmalling");
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "SeaStart")
        {
            SeaStart();
        }
        if (coll.gameObject.tag == "SeaEnd")
        {
            SeaEnd();
        }
        if (coll.gameObject.tag == "Coin")
        {
            Coin();
            coll.gameObject.SetActive(false);
        }
        if (Die == false)
        {
            if (coll.gameObject.tag == "CoinDel")
            {
                if (DoHit == false)
                {
                    CoinDel();
                    StartCoroutine(Wait());
                }
            }
            if (coll.gameObject.tag == "Beam")
            {
                UFO();
            }
            if (coll.gameObject.tag == "ManDu")
            {
                ManDuPlus();
                Score50();
                coll.gameObject.SetActive(false);
            }
            if (coll.gameObject.tag == "Stone")
            {
                if (DoHit == false)
                {
                    StoneMinus();
                    StartCoroutine(Wait());
                }
            }
            if (coll.gameObject.tag == "UFO")
            {
                if (A == false)
                {
                    if (DoHit == false)
                    {
                        BuildMinus();
                        StartCoroutine(Wait());
                    }
                }
            }
            if (coll.gameObject.tag == "Oliveleaf")
            {
                if (A == false)
                {
                    Tree.SetActive(true);
                    OliveTreeIn();
                }
            }
            if (coll.gameObject.tag == "eagle")
            {
                if (DoHit == false)
                {
                    EagleTouch();
                    StartCoroutine(Wait());
                }
            }
            if (coll.gameObject.tag == "Bird")
            {
                if (Power == false)
                {
                    if (DoHit == false)
                    {
                        BirdMinus();
                        StartCoroutine(Wait());
                    }
                }
                else
                {
                    BirdPlus();
                    Score50();
                    coll.gameObject.SetActive(false);
                }
            }

            if (coll.gameObject.tag == "Car")
            {
                if (A == false)
                {
                    if (DoHit == false)
                    {
                        if (DoveState == 2)
                        {
                            //독수리는 면역
                        }
                        else
                        {
                            Car();
                            StartCoroutine(Wait());
                        }
                    }
                }
            }
            if (coll.gameObject.tag == "Building")
            {
                if (A == false)
                {
                    if (DoHit == false)
                    {
                        BuildMinus();
                        StartCoroutine(Wait());
                    }
                }
            }
            if (coll.gameObject.tag == "Build") //아슬점수
            {
                if (A == false)
                {
                    Score100();
                    BuildPlus();
                    coll.gameObject.SetActive(false);
                }
            }
            if (coll.gameObject.tag == "Castle")
            {
                if (A == false)
                {
                    if(DoHit == false)
                    {
                        if(castle ==0)
                        {
                            pos = coll.GetComponent<Transform>();
                            castle = 1;
                            CastleIn();
                            Castle = true;
                            transform.position = new Vector3(-30, -2.5f, 0);
                        }
                    }
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (Die == false)
        {
            if (coll.gameObject.tag == "Oliveleaf")
            {
                if (A == false)
                {
                    if (olive == 0)
                    {
                        DoHit = true;
                    }
                }
            }
            if (coll.gameObject.tag == "Building")
            {
                if (A == false)
                {
                    if (DoHit == false)
                    {
                        HeartMinus();
                        StartCoroutine(Wait());
                    }
                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (Die == false)
        {
            if (coll.gameObject.tag == "Oliveleaf")
            {
                if (A == false)
                {
                    if (olive == 0)
                    {
                        olive = 1;
                        DoHit = false;
                        OliveTreeOut();
                        StartCoroutine(Olivetree());
                    }
                }
            }
        }
    }

    IEnumerator CastleSetting()
    {
        yield return new WaitForSeconds(3.5f);
        Castle = false;
        transform.position = pos.position + new Vector3(0, 0.3f, 0);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Wait());
    }
    IEnumerator UnderSetting()
    {
        yield return new WaitForSeconds(3f);
        Under = false;
        transform.position = new Vector3(x, y, 0);
        StartCoroutine(Wait());
    }

    IEnumerator Wait() //2.1초 ++
    {
        DoHit = true;
        StartCoroutine("HitWait");
        yield return new WaitForSeconds(HitCooltime);
        StopCoroutine("HitWait");
        alpha = 1;
        shadowalpha = 0.5f;
        DoHit = false;
    }
    IEnumerator HitWait()
    {
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        StartCoroutine("HitWait");
    }
    IEnumerator BigWait() //4.2초
    {
        DoHit = true;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        yield return new WaitForSeconds(0.15f);
        alpha = 0.5f;
        shadowalpha = 0.25f;
        yield return new WaitForSeconds(0.15f);
        alpha = 1;
        shadowalpha = 0.5f;
        DoHit = false;
    }
    IEnumerator RainChange()
    {
        if (ChangeNumber == 0) //비가옴
        {
            yield return new WaitForSeconds(0.5f);
            if (Dove == 0)
            {
                Power = true;
            }
            else if (Dove == 1)
            {
                Power = false;
            }
            else if (Dove == 2)
            {
                Power = true;
            }
            else if (Dove == 3)
            {
                Power = false;
            }
        }
        else
        {
            yield return new WaitForSeconds(0.5f);
            if (Dove == 0)
            {
                Power = false;
            }
            else if (Dove == 1)
            {
                Power = true;
            }
            else if (Dove == 2)
            {
                Power = true;
            }
            else if (Dove == 3)
            {
                Power = false;
            }
        }
    }
    IEnumerator Olivetree()
    {
        yield return new WaitForSeconds(OliveTime + 1.5f);
        olive = 0;
        Tree.SetActive(false);
    }
    //
    void CastleFast()
    {
        castle = 1;
        CastleIn();
        Castle = true;
        transform.position = new Vector3(-30, -2, 0);
    }
    void EagleFast()
    {
        EagleTouch();
    }
}