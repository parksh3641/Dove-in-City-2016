using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour
{
    public UILabel bd;
    public UILabel unit;
    public UILabel Nowscore;
    public UILabel Nowscoreplus;
    public UILabel Lastscore;
    public UILabel unitplus;
    public UILabel bdplus;
    public UILabel Coinscore;
    public UILabel Coinplustxt;
    public UILabel Timescore;
    public UILabel Continuetxt;

    private int BD;
    private int UNIT;
    private int DORI;
    private int CoinAds;
    private int SkinAA;
    private int SkinAB;
    private int SkinAC;
    private int SkinAD;
    private int dia;
    private int Hard;
    private int HEART;
    private int ContinueNum = 10;

    //스킨효과
    private int HeartPlus = 0;
    private int ScorePlus = 0;
    private int CoinPlus = 0;

    private float UNITf = 0;
    private int UNITi = 0;
    //private float UNITf2 = 0; // 타이틀효과로 추가점수
    private int UNITi2 = 0;

    private int NowScore;
    private int NowScorePlus;
    private int LastScore;
    private int Score;
    private int Dove;
    private int Rank;
    private float timescoreA =0;
    private float timescoreB =0;

    private int Mmute = 0;
    private int Emute = 0;
    private int Hand = 0; //핸들 기본 꺼짐
    public UIToggle handon;
    public UIToggle handoff;
    //private int TITLE = 0;
    private int screen = 0;
    private int Level = 1;
    private int A = 0;
    private int B = 0; //들어오고 나갈때 잠시 무적 + 하트정지
    private int Diecheck = 0;
    private int olive = 0;
    private int Hacking = 0;
    private int Die =0;

    //private int SongValueA = 0;
    private int SongValueB = 0;
    private int SongValueC = 0;
    private float CoinNum =0;
    private int SetActive;
    
    //정보창
    private int InfoBird;
    private int InfoBuild;
    private int InfoStone;
    private int InfoCar;
    private int InfoLevel;
    private int InfoHidden;
    private int InfoUFO;
    private int InfoTrash;
    private int InfoFuck;

    private int MAGNET;

    public static float Hp = 50;
    private float MaxHp;
    private float maxhp;
    public UISprite Hpbar;

    public static float speed = 0.017f; //방향키속도
    public static float Speed = 0.8f; //터치속도
    public static float bgspeed = 0.7f; //이동속도
    public static float Hitcooltime = 2.1f;
    public static float movelimitx = 3.815f;
    public static float movelimity = 99.0f;
    public static float Distance = 8.0f;
    public static float DistanceTime = 0.2f;
    public static float HpTime = 1.5f;

    public static float SkillTime = 10.0f;
    public static float SkillCoolTime = 10.0f;
    public static float OliveTime = 5.0f;
    public static float MagnetTime = 15.0f;
    public static float SmallTime = 15.0f;
    public static float HackingTime = 20.0f;
    public static float FuckHackingTime = 10.0f;
    public static float EagleTime = 5.0f;
    public static float TimingTime = 5.0f;
    public static float DiscoTime = 28.0f;
    public static float CarTime = 15.0f;

    public static float BirdspeedA = 0.5f;
    public static float BirdspeedB = 0.7f;

    public static float EaglespeedA = 0.7f;
    public static float EaglespeedB = 0.9f;

    public static float CarRandom = 60;
    //강화
    private int HeartNumber;
    private int SkillNumber;
    private int HitNumber;
    private int CoinNumber;
    private int ContinueNumber;
    private int CoinPlusNumber;

    public UILabel txtlevel;

    public GameObject GameOver;
    public GameObject UFOGameOver;
    public GameObject Result;
    public GameObject NewRecord;
    public GameObject TitlePlus;
    public GameObject OutGame;
    public GameObject PauseGame;

    public GameObject HungryDie; //굶어뒤짐
    public GameObject HitDie; //쳐맞아뒤짐
    public GameObject WhatDie; //의문사
    public GameObject WeatherDie; //고막이터짐

    public GameObject UFODie;
    public GameObject NextStage;
    public GameObject NotionHidden;

    private AudioSource source;
    public AudioSource MainSong;
    public AudioSource UnderSong;
    public AudioSource DiscoSong;
    public AudioSource Boast;
    public AudioSource Sea;

    public GameObject Mainsong;
    public GameObject Undersong;
    public GameObject Discosong;
    public GameObject boast;
    public GameObject sea;

    public AudioClip Click;
    public AudioClip Hit;
    public AudioClip Coin;
    public AudioClip Bang;
    public AudioClip Over;
    public AudioClip Skill;
    public AudioClip HeartUp;
    public AudioClip Small;
    public AudioClip OliveHit;
    public AudioClip castlein;
    public AudioClip castleout;
    public AudioClip ufo;
    public AudioClip Hidden;
    public AudioClip Oha;

    public AudioClip Main15;
    public AudioClip Main2;

    private Transform ScoreObject;
    private Transform AttackObject;
    private Transform Player;
    //
    public GameObject EagleUI;
    public GameObject CloudUI;
    public GameObject HpUI;
    public GameObject Coin2X;
    //프리팹
    public GameObject ItemUse;
    public GameObject Fuck; //부작용
    public GameObject Scorefifty;
    public GameObject Scorex2;
    public GameObject Scorex10;
    public GameObject ScoreBuild;
    public GameObject smallhit;
    public GameObject HeartUP;
    public GameObject Black;
    public GameObject White;
    public GameObject Eagle;

    public GameObject candy;
    public GameObject Egg;
    public GameObject COIN;

    public GameObject Three;
    public GameObject Two;
    public GameObject One;
    public GameObject Go;

    //점수1000점이상시 보상
    public GameObject BDReward;
    public GameObject ABCReward;
    public UILabel ABCtxt;
    public UILabel abctxt;

    private int ABC;

    //올리브
    public GameObject Olive;
    public UILabel OliveLabel;
    private bool C = false; //올리브 숫자 위치 이동 여부
    //
    public Transform[] points;
    public Transform[] Eaglepoints;

    public List<GameObject> ScorePool = new List<GameObject>();
    public List<GameObject> Score2Pool = new List<GameObject>();
    public List<GameObject> Score3Pool = new List<GameObject>();

    public List<GameObject> BuildPool = new List<GameObject>();
    public List<GameObject> HeartPool = new List<GameObject>();
    public List<GameObject> FuckPool = new List<GameObject>(); //부작용

    public List<GameObject> CandyPool = new List<GameObject>();
    public List<GameObject> monsterPool = new List<GameObject>();
    public List<GameObject> EaglePool = new List<GameObject>();

    public List<GameObject> CoinPool = new List<GameObject>();
    public List<GameObject> EggPool = new List<GameObject>();

    public List<GameObject> UsePool = new List<GameObject>(); //아이템사용시 뜨는 거

    public GameObject[] PeopleObject = new GameObject[] { };

    private float createTime = 1.5f;
    private float EaglecreateTime = 10.0f;
    private float CoinctreateTime = 1.5f;
    private bool isGameOver = false;
    private bool SkillUseValue = false;
    private bool Castle = false;
    private bool talk = false;
    private bool Levelwait = false;

    private bool HitCount = false;

    public delegate void Gamemanager();
    public static event Gamemanager PlayerDie, PlayerLive, GameExit, ScoreValueA, ScoreValueB, ScoreValueC,
        MapChange , CastleFast , EagleFast, TalkStart ,HeartHit , GamePause , FollowHit;

    void Awake()
    {
        Time.timeScale = 1;
        source = GetComponent<AudioSource>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        Level = 1;
        Speed = 0.8f;
        bgspeed = 0.75f;

        HpTime = 1.2f;

        createTime = 1.0f;
        EaglecreateTime = 10.0f;
        CoinctreateTime = 1.2f;

        BirdspeedA = 0.4f;
        BirdspeedB = 0.6f;

        EaglespeedA = 0.6f;
        EaglespeedB = 0.8f;

        CarRandom = 60;

        screen = 0;
        Die = 0;
        Diecheck = 0;

        isGameOver = false;
        SkillUseValue = false;
        Castle = false;
        talk = false;
        HitCount = false;

        MAGNET = PlayerPrefs.GetInt("MAGNET", 0);
        MagnetTime = MagnetTime + (1 * MAGNET);

        CoinAds = PlayerPrefs.GetInt("CoinAds", 0);

        Rank = PlayerPrefs.GetInt("Rank", 0);
        //강화

        SkillNumber = PlayerPrefs.GetInt("SkillNumber", 0);
        SkillTime = 10.0f+((SkillNumber * 0.5f)-0.5f) ;

        HitNumber = PlayerPrefs.GetInt("HitNumber", 0);
        Hitcooltime = 2.1f + ((HitNumber * 0.15f) - 0.15f);

        CoinNumber = PlayerPrefs.GetInt("CoinNumber", 0);
        CoinPlusNumber = PlayerPrefs.GetInt("CoinPlusNumber", 0); ;

        ContinueNumber = PlayerPrefs.GetInt("ContinueNumber", 0);
        ContinueNum += (ContinueNumber - 1);
        Continuetxt.text = "남은횟수 : " + ContinueNum.ToString();

        PlayerPrefs.SetInt("Eagletouch", 0);
        PlayerPrefs.SetInt("Olive", 0);

        Hard = PlayerPrefs.GetInt("Hard", 0);
        if(Hard ==1)
        {
            StartCoroutine(LevelWait());
        }
        else
        {
            Levelwait = true;
        }

        InfoBird = PlayerPrefs.GetInt("InfoBird", 0);
        InfoBuild = PlayerPrefs.GetInt("InfoBuild", 0);
        InfoStone = PlayerPrefs.GetInt("InfoStone", 0);
        InfoCar = PlayerPrefs.GetInt("InfoCar", 0);
        InfoLevel = PlayerPrefs.GetInt("InfoLevel", 0);
        InfoHidden = PlayerPrefs.GetInt("InfoHidden", 0);
        InfoUFO = PlayerPrefs.GetInt("InfoUFO", 0);
        InfoTrash = PlayerPrefs.GetInt("InfoTrash", 0);
        InfoFuck = PlayerPrefs.GetInt("InfoFuck", 0);

        Hand = PlayerPrefs.GetInt("Hand", 0);

        HEART = PlayerPrefs.GetInt("HEART", 0);

        UnderSong.enabled =false;
        DiscoSong.enabled = false;
        Sea.enabled = false;
        Boast.enabled = false;

        Mmute = PlayerPrefs.GetInt("Mmute", 0);
        Emute = PlayerPrefs.GetInt("Emute", 0);
        if (Mmute == 1)
        {
            Mainsong.SetActive(false);
            Undersong.SetActive(false);
            Discosong.SetActive(false);
            sea.SetActive(false);
            boast.SetActive(false);
        }
        else
        {
            Mainsong.SetActive(true);
            Undersong.SetActive(true);
            Discosong.SetActive(true);
            sea.SetActive(true);
            boast.SetActive(true);
        }
        if (Emute == 1)
        {
            source.enabled = false;
        }
        else
        {
            source.enabled = true;
        }

        HungryDie.SetActive(false);
        HitDie.SetActive(false);
        WhatDie.SetActive(false);
        NextStage.SetActive(false);
        WeatherDie.SetActive(false);
        NotionHidden.SetActive(false);

        EagleUI.SetActive(false);
        CloudUI.SetActive(false);
        HpUI.SetActive(false);

        Three.SetActive(false);
        Two.SetActive(false);
        One.SetActive(false);
        Go.SetActive(false);
        Olive.SetActive(false);

        GameOver.SetActive(false);
        UFOGameOver.SetActive(false);
        Result.SetActive(false);
        NewRecord.SetActive(false);
        OutGame.SetActive(false);
        TitlePlus.SetActive(false);
        PauseGame.SetActive(false);

        Dove = PlayerPrefs.GetInt("Dove", 0);
        SkinAA = PlayerPrefs.GetInt("SkinAA", 0);
        SkinAB = PlayerPrefs.GetInt("SkinAB", 0);
        SkinAC = PlayerPrefs.GetInt("SkinAC", 0);
        SkinAD = PlayerPrefs.GetInt("SkinAD", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindWithTag("Black").GetComponent<Transform>();
            if (SkinAA == 1)
            {
                HeartPlus = 1;
            }
            else if (SkinAA == 2)
            {
                ScorePlus = 1;
            }
            else if (SkinAA == 3)
            {
                CoinPlus = 1;
            }
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindWithTag("White").GetComponent<Transform>();
            if (SkinAB == 1)
            {
                HeartPlus = 1;
            }
            else if (SkinAB == 2)
            {
                ScorePlus = 1;
            }
            else if (SkinAB == 3)
            {
                CoinPlus = 1;
            }
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindWithTag("Eagle").GetComponent<Transform>();
            if (SkinAC == 1)
            {
                HeartPlus = 1;
            }
            else if (SkinAC == 2)
            {
                ScorePlus = 1;
            }
            else if (SkinAC == 3)
            {
                CoinPlus = 1;
            }
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindWithTag("Dori").GetComponent<Transform>();
            createTime = createTime * 0.7f;
            if (SkinAD == 1)
            {
                HeartPlus = 1;
            }
            else if (SkinAD == 2)
            {
                ScorePlus = 1;
            }
            else if (SkinAD == 3)
            {
                CoinPlus = 1;
            }
        }

        //체력설정
        HeartNumber = PlayerPrefs.GetInt("HeartNumber", 0);
        Hp = (50 + ((HeartNumber * 5) - 5)) + ((50 + ((HeartNumber * 5) - 5))* 0.1f * HeartPlus);
        MaxHp = Hp;
        maxhp = 1 / MaxHp;

        for (int i = 0; i < 20; i++)
        {
            if (Dove == 0)
            {
                GameObject monster = Instantiate(White);
                monster.name = "Monster _" + i.ToString();
                monster.SetActive(false);
                monsterPool.Add(monster);
            }
            else if (Dove == 1)
            {
                GameObject monster = Instantiate(Black);
                monster.name = "Monster _" + i.ToString();
                monster.SetActive(false);
                monsterPool.Add(monster);
            }
            else if (Dove == 2)
            {
                GameObject monster = Instantiate(White);
                monster.name = "Monster _" + i.ToString();
                monster.SetActive(false);
                monsterPool.Add(monster);
            }
            else if (Dove == 3)
            {
                GameObject monster = Instantiate(Black);
                monster.name = "Monster _" + i.ToString();
                monster.SetActive(false);
                monsterPool.Add(monster);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            GameObject item = Instantiate(ItemUse);
            item.name = "Item _" + i.ToString();
            item.SetActive(false);
            UsePool.Add(item);
        }
        for (int i = 0; i < 2; i++)
        {
            GameObject fuck = Instantiate(Fuck);
            fuck.name = "Fuck _" + i.ToString();
            fuck.SetActive(false);
            FuckPool.Add(fuck);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject score = Instantiate(Scorefifty);
            score.name = "Score10 _" + i.ToString();
            score.SetActive(false);
            ScorePool.Add(score);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject score = Instantiate(Scorex2);
            score.name = "Score10x2 _" + i.ToString();
            score.SetActive(false);
            Score2Pool.Add(score);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject score = Instantiate(Scorex10);
            score.name = "Score10x10 _" + i.ToString();
            score.SetActive(false);
            Score3Pool.Add(score);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject score = Instantiate(ScoreBuild);
            score.name = "Score20 _" + i.ToString();
            score.SetActive(false);
            BuildPool.Add(score);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject Candy = Instantiate(candy);
            Candy.name = "Candy _" + i.ToString();
            Candy.SetActive(false);
            CandyPool.Add(Candy);
        }

        for (int i = 0; i < 5; i++)
        {
            GameObject eagle = Instantiate(Eagle);
            eagle.name = "Eagle _" + i.ToString();
            eagle.SetActive(false);
            EaglePool.Add(eagle);
        }
        //알
        for (int i = 0; i < 8; i++)
        {
            GameObject egg = Instantiate(Egg);
            egg.name = "Egg _" + i.ToString();
            egg.SetActive(false);
            EggPool.Add(egg);
        }
        //코인
        for (int i = 0; i < 50; i++)
        {
            GameObject coin = Instantiate(COIN);
            coin.name = "Coin _" + i.ToString();
            coin.SetActive(false);
            CoinPool.Add(coin);
        }
        StopAllCoroutines();
    }
    void Start()
    {
        PeopleObject = GameObject.FindGameObjectsWithTag("People");

        ScoreObject = GameObject.Find("ScoreObject").GetComponent<Transform>();
        AttackObject = GameObject.Find("AttackObject").GetComponent<Transform>();
        points = GameObject.Find("SpawnPoints").GetComponentsInChildren<Transform>();
        Eaglepoints = GameObject.Find("EaglePoints").GetComponentsInChildren<Transform>();

        StartCoroutine(CreateMonster());
        StartCoroutine(CreateEagle());
        StartCoroutine(CreateCoin());
        StartCoroutine(HpCheck());
    }
    void OnApplicationPause(bool pause) //나가졋을시 멈춤창 뜨는거
    {
        if(pause)
        {
            Pause();
        }
        else
        {
            
        }
    }
    void Update()
    {      
        Hpbar.fillAmount = Hp * maxhp;

        if (Hp < 1)
        {
            if(Die ==0)
            {
                Die = 1;
                StopAllCoroutines();
                StartCoroutine(DieCheck());
            }
        }

        if (Die ==0)
        {
            timescoreA += Time.deltaTime;
            if(timescoreA >= 60)
            {
                timescoreA -= 60;
                timescoreB += 1;
            }
        }
        if (screen == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }
        }
        if (C == true)
        {
            if (Player.position.x >= 3.35f)
            {
                olive = 1;
            }
            else if (Player.position.x <= -3.35f)
            {
                olive = 2;
            }
            else
            {
                olive = 0;
            }

            if (Player.position.x > 0)
            {
                if (olive == 0)
                {
                    Olive.transform.localPosition = new Vector3(0, -20, 0);
                }
                else if (olive == 1)
                {
                    Olive.transform.localPosition = new Vector3((Player.position.x - 3.35f) * 315, -20, 0);
                }
            }
            else
            {
                if (olive == 0)
                {
                    Olive.transform.localPosition = new Vector3(0, -20, 0);
                }
                else if(olive == 2)
                {
                    Olive.transform.localPosition = new Vector3((Player.position.x + 3.35f) * 315, -20, 0);
                }
            }
        }
    }

    //외부에서 오는 입력 받는곳
    void OnEnable()
    {
        PlayerCtrl.HeartMinus += HeartMinus;
        PlayerCtrl.ManDuPlus += ManDuPlus;
        PlayerCtrl.StoneMinus += StoneMinus;

        PlayerCtrl.Score50 += Score50;
        PlayerCtrl.Score100 += Score100;

        BirdCtrl.Score50 += Score50;
        EagleCtrl.Score100 += Score100;

        PlayerCtrl.OliveTreeIn += OliveTreeIn;
        PlayerCtrl.OliveTreeOut += OliveTreeOut;

        PlayerCtrl.CastleIn += CastleIn;
        PlayerCtrl.CastleOut += CastleOut;
        PlayerCtrl.LevelUp += LevelUp;
        PlayerCtrl.EagleTouch += EagleTouch;
        PlayerCtrl.SeaStart += SeaStart;
        PlayerCtrl.SeaEnd += SeaEnd;
        PlayerCtrl.Coin += coin;
        PlayerCtrl.CoinDel += CoinDel;
        PlayerCtrl.UFO += UFO;
        PlayerCtrl.Car += Car;
        //캔디
        PeopleCtrl.Candy += Candy;
        //쓰레기통
        TrashCtrl.TrashCan += TrashCan;
        //사람
        PeopleCtrl.Hit += PeopleHit;
        //정보
        PlayerCtrl.BirdPlus += BirdPlus;
        PlayerCtrl.BirdMinus += BirdMinus;
        PlayerCtrl.BuildPlus += BuildPlus;
        PlayerCtrl.BuildMinus += BuildMinus;
        //부작용
        SkillCtrl.fuck += fuck;
        SkillCtrl.fuckfuck += fuckfuck;
        SkillCtrl.Disco += Disco;
        SkillCtrl.Hack += Hack;
        SkillCtrl.FuckHack += FuckHack;
        SkillCtrl.weatherdie += Weatherdie;

        GodCtrl.TalkStart += Talkstart;
        Talk.TalkEnd += TalkEnd;
        Talk.DoriFeather += DoriFeather;
        Talk.HitDie += Hitdie;
        Talk.WhatDie += Whatdie;

        Talk.UnderWorld += UnderWorld;
        PlayerCtrl.UnderOut += UnderOut;

        SkillCtrl.SkillUse += SkillUse;
        SkillCtrl.Heart += HeartUse; //하트아이템사용
        SkillCtrl.Small += SmallPotion; //미니포션아이템사용
        SkillCtrl.ItemUse += Itemuse;

        UnityAdsHelper.Continue += AdsContinue;

        GameUI.RainStart += RainStart;
        GameUI.RainStop += RainStop;
    }
    void OnDisable()
    {
        PlayerCtrl.HeartMinus -= HeartMinus;
        PlayerCtrl.ManDuPlus -= ManDuPlus;
        PlayerCtrl.StoneMinus -= StoneMinus;

        PlayerCtrl.Score50 -= Score50;
        PlayerCtrl.Score100 -= Score100;

        BirdCtrl.Score50 -= Score50;
        EagleCtrl.Score100 -= Score100;

        PlayerCtrl.OliveTreeIn -= OliveTreeIn;
        PlayerCtrl.OliveTreeOut -= OliveTreeOut;

        PlayerCtrl.CastleIn -= CastleIn;
        PlayerCtrl.CastleOut -= CastleOut;
        PlayerCtrl.EagleTouch -= EagleTouch;
        PlayerCtrl.LevelUp -= LevelUp;
        PlayerCtrl.SeaStart -= SeaStart;
        PlayerCtrl.SeaEnd -= SeaEnd;
        PlayerCtrl.Coin -= coin;
        PlayerCtrl.CoinDel -= CoinDel;
        PlayerCtrl.UFO -= UFO;
        PlayerCtrl.Car -= Car;
        //캔디
        PeopleCtrl.Candy -= Candy;
        //쓰레기통
        TrashCtrl.TrashCan -= TrashCan;
        //사람
        PeopleCtrl.Hit -= PeopleHit;
        //정보
        PlayerCtrl.BirdPlus -= BirdPlus;
        PlayerCtrl.BirdMinus -= BirdMinus;
        PlayerCtrl.BuildPlus -= BuildPlus;
        PlayerCtrl.BuildMinus -= BuildMinus;
        //부작용
        SkillCtrl.fuck -= fuck;
        SkillCtrl.fuckfuck += fuckfuck;
        SkillCtrl.Disco -= Disco;
        SkillCtrl.Hack -= Hack;
        SkillCtrl.FuckHack -= FuckHack;
        SkillCtrl.weatherdie -= Weatherdie;

        GodCtrl.TalkStart -= Talkstart;
        Talk.TalkEnd -= TalkEnd;
        Talk.DoriFeather -= DoriFeather;
        Talk.HitDie -= Hitdie;
        Talk.WhatDie -= Whatdie;

        Talk.UnderWorld -= UnderWorld;
        PlayerCtrl.UnderOut += UnderOut;

        SkillCtrl.SkillUse -= SkillUse;
        SkillCtrl.Heart -= HeartUse;
        SkillCtrl.Small -= SmallPotion;
        SkillCtrl.ItemUse -= Itemuse;

        UnityAdsHelper.Continue -= AdsContinue;

        GameUI.RainStart -= RainStart;
        GameUI.RainStop -= RainStop;
    }

    IEnumerator HpCheck()
    {
        if (screen == 0)
        {
            if(talk == false)
            {
                Hp -= 1;
            }
        }

        if (Hp >= MaxHp * 0.3f)
        {
            Hpbar.spriteName = "006_gage_blue";
            HpUI.SetActive(false);
        }
        else
        {
            Hpbar.spriteName = "005_gage_red";
            HpUI.SetActive(true);
        }
        yield return new WaitForSeconds(HpTime);
        StartCoroutine(HpCheck());
    }
    IEnumerator Hpcheck()
    {
        yield return new WaitForSeconds(3.5f);
        source.Stop();
        SongValueB = 0;
        MainSong.enabled = true;
        UnderSong.enabled = false;
        DiscoSong.enabled = false;
        Castle = false;
        StartCoroutine(HitCooltime());
        StartCoroutine(CreateCoin());
    }//숭례문 들어갈때 나올때

    IEnumerator DieCheck()
    {
        PlayerDie();
        screen = 1;

        MainSong.enabled = false;
        UnderSong.enabled = false;
        DiscoSong.enabled = false;
        Boast.enabled = false;
        Sea.Pause();
        SongValueC = 0;

        Hacking = 0;
        C = false;
        PlayerPrefs.SetInt("Olive", 0);
        Olive.SetActive(false);
        PlayerPrefs.SetInt("Eagletouch", 0);
        EagleUI.SetActive(false);

        SkillUseValue = false;
        CloudUI.SetActive(false);
        HpUI.SetActive(false);

        if (Hp >= 0)
        {
            source.PlayOneShot(Over, 0.75f);
            HungryDie.SetActive(true);
        }
        else if (Hp >= -20)
        {
            source.PlayOneShot(Over, 0.75f);
            HitDie.SetActive(true);
        }
        else if (Hp >= -30)
        {
            source.PlayOneShot(Over, 0.75f);
            WhatDie.SetActive(true);
        }
        else if (Hp >= -40)
        {
            source.PlayOneShot(Over, 0.75f);
            WeatherDie.SetActive(true);
        }
        else if(Hp >= - 100)
        {
            source.PlayOneShot(ufo, 0.75f);
            UFODie.SetActive(true);
        }
        yield return new WaitForSeconds(1.0f);
        if (Diecheck == 0)
        {
            GameOver.SetActive(true);
            BD = PlayerPrefs.GetInt("BD", 0);
            bd.text = BD.ToString();
            ContinueNumber = PlayerPrefs.GetInt("ContinueNumber", 0);
            Continuetxt.text = "남은횟수 : " + ContinueNum.ToString();
        }
        else
        {
            UFOGameOver.SetActive(true);
        }
    }
    IEnumerator WaitforTime()
    {
        GameOver.SetActive(false);
        Three.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Three.SetActive(false);
        Two.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Two.SetActive(false);
        One.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        One.SetActive(false);
        Go.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Go.SetActive(false);

        Hp = MaxHp;
        Hpbar.spriteName = "006_gage_blue";
        Die = 0;
        screen = 0;
        PlayerLive();

        if (SongValueB == 1)
        {
            UnderSong.enabled = true;
        }
        else
        {
            MainSong.enabled = true;
        }
        Sea.UnPause();

        if (Castle == false)
        {
            StartCoroutine(HpCheck());
            StartCoroutine(CreateMonster());
            StartCoroutine(CreateEagle());
            StartCoroutine(CreateCoin());
        }
    }//이어하기

    public void ResultAndExit()
    {
        source.PlayOneShot(Click, 0.75f);
        PlayerDie();
        GameOver.SetActive(false);
        UFOGameOver.SetActive(false);
        Result.SetActive(true);

        NowScore = PlayerPrefs.GetInt("TOT_Score", 0);
        LastScore = PlayerPrefs.GetInt("TOT_High", 0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);

        if (Rank == 0)
        {
            if(ScorePlus ==0)
            {
                Nowscoreplus.text = " ";
            }
            else
            {
                Nowscoreplus.text = "+10%";
            }
        }
        else if (Rank == 1)
        {
            if (ScorePlus == 0)
            {
                Nowscoreplus.text = "+3%";
            }
            else
            {
                Nowscoreplus.text = "+13%";
            }
            float plus = NowScore;
            plus = (plus * 0.03f);
            int Plus = (int)plus;
            NowScore += Plus;
        }
        else if(Rank == 2)
        {
            if (ScorePlus == 0)
            {
                Nowscoreplus.text = "+6%";
            }
            else
            {
                Nowscoreplus.text = "+16%";
            }
            float plus = NowScore;
            plus = (plus * 0.06f);
            int Plus = (int)plus;
            NowScore += Plus;
        }
        else if (Rank == 3)
        {
            if (ScorePlus == 0)
            {
                Nowscoreplus.text = "+9%";
            }
            else
            {
                Nowscoreplus.text = "+19%";
            }
            float plus = NowScore;
            plus = (plus * 0.09f);
            int Plus = (int)plus;
            NowScore += Plus;
        }
        else if (Rank == 4)
        {
            if (ScorePlus == 0)
            {
                Nowscoreplus.text = "+12%";
            }
            else
            {
                Nowscoreplus.text = "+22%";
            }
            float plus = NowScore;
            plus = (plus * 0.12f);
            int Plus = (int)plus;
            NowScore += Plus;
        }
        else if (Rank == 5)
        {
            if (ScorePlus == 0)
            {
                Nowscoreplus.text = "+15%";
            }
            else
            {
                Nowscoreplus.text = "+25%";
            }
            float plus = NowScore;
            plus = (plus * 0.15f);
            int Plus = (int)plus;
            NowScore += Plus;
        }
        else if (Rank == 6)
        {
            if (ScorePlus == 0)
            {
                Nowscoreplus.text = "+18%";
            }
            else
            {
                Nowscoreplus.text = "+28%";
            }
            float plus = NowScore;
            plus = (plus * 0.18f);
            int Plus = (int)plus;
            NowScore += Plus;
        }

        NowScore = (int)(NowScore + (NowScore * 0.1f * ScorePlus));

        if(CoinPlus == 1)
        {
            if(CoinNum >= 1)
            {
                Coinplustxt.text = "+10%";
            }
            else
            {
                Coinplustxt.text = " ";
            }
        }
        else
        {
            Coinplustxt.text = " ";
        }

        UNITf = NowScore;
        UNITf = UNITf * (0.5f + ((CoinNumber * 0.05f) - 0.05f));
        Math.Round(UNITf);
        UNITi += (int)UNITf;

        CoinNum = CoinNum + (CoinNum * 0.1f * CoinPlus);

        unitplus.text = "추가코인 +" + CoinNum.ToString();

        if (CoinNum == 0)
        {
            unitplus.text = " ";
        }
        txtlevel.text = Level.ToString() + " 단계";
        bdplus.text = "0";

        if(CoinAds == 0)
        {
            UNIT += (UNITi + (int)CoinNum); //코인획득
            Coin2X.SetActive(false);
        }
        else
        {
            UNIT += ((UNITi + (int)CoinNum) * 2); //코인획득2배
            Coin2X.SetActive(true);
        }

        PlayerPrefs.SetInt("UNIT", UNIT);

        unit.text = UNITi.ToString();
        Nowscore.text = NowScore.ToString() + " 점";
        Lastscore.text = LastScore.ToString() + " 점";
        Timescore.text = string.Format("{0:F0}", timescoreB) + "분 " + string.Format("{0:F0}", timescoreA) + "초";

        if(Hard ==0)
        {
            if (NowScore >= 500)
            {
                ResultPlus();
            }
            else
            {
                BDReward.SetActive(false);
                ABCReward.SetActive(false);
            }
        }
        else
        {
            if (NowScore >= 1000)
            {
                ResultPlus();
            }
            else
            {
                BDReward.SetActive(false);
                ABCReward.SetActive(false);
            }
        }
        int A = PlayerPrefs.GetInt("TOT_Black", 0);
        int B = PlayerPrefs.GetInt("TOT_White", 0);

        if (NowScore > LastScore) //현재최고점수가 더 높을경우
        {
            PlayerPrefs.SetInt("TOT_High", NowScore);

            if (Dove == 0)
            {
                if (A < NowScore)
                {
                    PlayerPrefs.SetInt("TOT_Black", NowScore);
                }
            }
            else if (Dove == 1)
            {
                if (B < NowScore)
                {
                    PlayerPrefs.SetInt("TOT_White", NowScore);
                }
            }
            Score = 0;
            StartCoroutine(ScoreClear());
        }
        else
        {
            PlayerPrefs.SetInt("TOT_High", LastScore); //여기서 불러온값하고 받은값을 비교 더 높으면 저장 아니면 그만
            if (Dove == 0)
            {
                if (A < LastScore)
                {
                    PlayerPrefs.SetInt("TOT_Black", LastScore);
                }
            }
            else if (Dove == 1)
            {
                if (B < LastScore)
                {
                    PlayerPrefs.SetInt("TOT_White", LastScore);
                }
            }
            Score = 1;
            StartCoroutine(ScoreClear());
        }
    }
    void ResultPlus()
    {
        float X = UnityEngine.Random.Range(0, 2);
        if (X == 0)
        {
            BDReward.SetActive(true);
            ABCReward.SetActive(false);
            if(Rank <= 2)
            {
                dia = UnityEngine.Random.Range(3, 6);
            }
            else if(Rank <= 4)
            {
                dia = UnityEngine.Random.Range(6, 12);
            }
            else
            {
                dia = UnityEngine.Random.Range(12, 18);
            }
            BD += dia;
            PlayerPrefs.SetInt("BD", BD);
            bdplus.text = dia.ToString();
        }
        else
        {
            BDReward.SetActive(false);
            ABCReward.SetActive(true);
            int Z = UnityEngine.Random.Range(0, 12);
            if (Z == 0)
            {
                ABC = PlayerPrefs.GetInt("A", 0);
                ABC += 1;
                PlayerPrefs.SetInt("A", ABC);
                ABCtxt.text = "A";
                abctxt.text = "알파벳 A";
            }
            else if (Z == 1)
            {
                ABC = PlayerPrefs.GetInt("B", 0);
                ABC += 1;
                PlayerPrefs.SetInt("B", ABC);
                ABCtxt.text = "B";
                abctxt.text = "알파벳 B";
            }
            else if (Z == 2)
            {
                ABC = PlayerPrefs.GetInt("D", 0);
                ABC += 1;
                PlayerPrefs.SetInt("D", ABC);
                ABCtxt.text = "D";
                abctxt.text = "알파벳 D";
            }
            else if (Z == 3)
            {
                ABC = PlayerPrefs.GetInt("G", 0);
                ABC += 1;
                PlayerPrefs.SetInt("G", ABC);
                ABCtxt.text = "G";
                abctxt.text = "알파벳 G";
            }
            else if (Z == 4)
            {
                ABC = PlayerPrefs.GetInt("I", 0);
                ABC += 1;
                PlayerPrefs.SetInt("I", ABC);
                ABCtxt.text = "I";
                abctxt.text = "알파벳 I";
            }
            else if (Z == 5)
            {
                ABC = PlayerPrefs.GetInt("L", 0);
                ABC += 1;
                PlayerPrefs.SetInt("L", ABC);
                ABCtxt.text = "L";
                abctxt.text = "알파벳 L";
            }
            else if (Z == 6)
            {
                ABC = PlayerPrefs.GetInt("M", 0);
                ABC += 1;
                PlayerPrefs.SetInt("M", ABC);
                ABCtxt.text = "M";
                abctxt.text = "알파벳 M";
            }
            else if (Z == 7)
            {
                ABC = PlayerPrefs.GetInt("N", 0);
                ABC += 1;
                PlayerPrefs.SetInt("N", ABC);
                ABCtxt.text = "N";
                abctxt.text = "알파벳 N";
            }
            else if (Z == 8)
            {
                ABC = PlayerPrefs.GetInt("O", 0);
                ABC += 1;
                PlayerPrefs.SetInt("O", ABC);
                ABCtxt.text = "O";
                abctxt.text = "알파벳 O";
            }
            else if (Z == 9)
            {
                ABC = PlayerPrefs.GetInt("R", 0);
                ABC += 1;
                PlayerPrefs.SetInt("R", ABC);
                ABCtxt.text = "R";
                abctxt.text = "알파벳 R";
            }
            else if (Z == 10)
            {
                ABC = PlayerPrefs.GetInt("T", 0);
                ABC += 1;
                PlayerPrefs.SetInt("T", ABC);
                ABCtxt.text = "T";
                abctxt.text = "알파벳 T";
            }
            else if (Z == 11)
            {
                ABC = PlayerPrefs.GetInt("U", 0);
                ABC += 1;
                PlayerPrefs.SetInt("U", ABC);
                ABCtxt.text = "U";
                abctxt.text = "알파벳 U";
            }
        }
    }

    public void Continue()
    {
        source.PlayOneShot(Click, 0.75f);
        if (ContinueNum >= 1)
        {
            if (BD >= 3)
            {
                BD -= 3;
                PlayerPrefs.SetInt("BD", BD);
                ContinueNum -= 1;
                StartCoroutine(WaitforTime());
                //Time.timeScale = 1;
            }
        }
    }
    void AdsContinue()
    {
        StartCoroutine(WaitforTime());
    }

    //스테이지 업
    void LevelUp()
    {
        float z = 0;
        NextStage.SetActive(true);
        Level += 1;
        z += 1;
        if(z == 2)
        {
            z = 0;
            for (int i = 0; i < PeopleObject.Length; i++)
            {
                PeopleObject[i].SetActive(true);
            }
        }
        if(Level == 5)
        {
            MainSong.clip = Main15;
            MainSong.enabled = false;
            MainSong.enabled = true;
        }
        else if(Level == 12)
        {
            MainSong.clip = Main2;
            MainSong.enabled = false;
            MainSong.enabled = true;
        }

        if (bgspeed < 1.2f)
        {
            bgspeed = bgspeed + (bgspeed * 0.06f);
        }

        if(createTime > 0.5f)
        {
            createTime -= 0.2f;
        }
        if(EaglecreateTime > 4.0f)
        {
            EaglecreateTime -= 0.75f;
        }
        if(CoinctreateTime > 0.2f)
        {
            CoinctreateTime -= 0.05f;
        }
        if(HpTime > 0.5f)
        {
            HpTime -= 0.75f;
        }

        BirdspeedA = BirdspeedA + (BirdspeedA * 0.06f);
        BirdspeedB = BirdspeedB + (BirdspeedB * 0.06f);

        EaglespeedA = EaglespeedA + (EaglespeedA * 0.06f);
        EaglespeedB = EaglespeedB + (EaglespeedB * 0.06f);

        if(CarRandom <= 100)
        {
            CarRandom += 2.5f;
        }

        if(Levelwait == true)
        {
            InfoLevel += 1;
            PlayerPrefs.SetInt("InfoLevel", InfoLevel);
        }
    }
    IEnumerator LevelWait()
    {
        yield return new WaitForSeconds(5f);
        Levelwait = true;
    }
    //대화
    void Talkstart()
    {
        talk = true;
    }
    void TalkEnd()
    {
        talk = false;
    }

    //음악
    void UnderWorld()
    {
        SongValueB = 1;
        SongValueC = 0;
        MainSong.enabled = false;
        UnderSong.enabled = true;
        DiscoSong.enabled = false;
        InfoHidden += 1;
        PlayerPrefs.SetInt("InfoHidden", InfoHidden);
        Castle = true;
        StopAllCoroutines();
    }
    void UnderOut()
    {
        StartCoroutine(HpCheck());
        StartCoroutine(Hpcheck());
        StartCoroutine(CreateMonster());
        StartCoroutine(CreateEagle());
        StartCoroutine(CreateCoin());
    }

    void Disco()
    {
        StartCoroutine(DiscoMusic());
    }
    IEnumerator DiscoMusic()
    {
        SongValueC = 1;
        MainSong.enabled = false;
        UnderSong.enabled = false;
        DiscoSong.enabled = true;
        yield return new WaitForSeconds(28f);
        SongValueC = 0;
        DiscoSong.enabled = false;
        if (SongValueB ==1)
        {
            UnderSong.enabled = true;
        }
        else
        {
            MainSong.enabled = true;
        }
    }

    void DoriFeather()
    {
        if(DORI < 999)
        {
            DORI += 1;
            PlayerPrefs.SetInt("DORI", DORI);
        }
        else
        {
            DORI = 999;
            PlayerPrefs.SetInt("DORI", DORI);
        }
    }

    void Hitdie()
    {
        Hp = -15;
        StopAllCoroutines();
        StartCoroutine(DieCheck());
    } //팔콘킥
    void Whatdie() //의문사
    {
        Hp = -25;
        StopAllCoroutines();
        StartCoroutine(DieCheck());
    }
    void Weatherdie()
    {
        Hp = -35;
        StopAllCoroutines();
        StartCoroutine(DieCheck());
    }

    //충돌정리
    void BirdPlus()
    {
        InfoBird += 1;
        PlayerPrefs.SetInt("InfoBird", InfoBird);

        source.PlayOneShot(HeartUp, 0.75f);
        if (Hp <= MaxHp - 15)
        {
            Hp += 15;
        }
        else
        {
            Hp = MaxHp;
        }
    }
    void BirdMinus()
    {
        if (Hand == 1)
        {
            Handheld.Vibrate();
        }
        source.PlayOneShot(Hit, 0.75f);
        Hp -= 5;
        FollowHit();
    }
    void BuildMinus()
    {
        if (Hand == 1)
        {
            Handheld.Vibrate();
        }
        source.PlayOneShot(Hit, 0.75f);
        Hp -= 15;
        FollowHit();
    }
    void BuildPlus() //아슬점수
    {
        InfoBuild += 1;
        PlayerPrefs.SetInt("InfoBuild", InfoBuild);
    }

    void StoneMinus() // 돌
    {
        InfoStone += 1;
        PlayerPrefs.SetInt("InfoStone", InfoStone);

        if (Hand == 1)
        {
            Handheld.Vibrate();
        }

        source.PlayOneShot(Hit, 0.75f);
        Hp -= 10;
        FollowHit();
    }
    void Car()
    {
        InfoCar += 1;
        PlayerPrefs.SetInt("InfoCar", InfoCar);

        if (Hand == 1)
        {
            Handheld.Vibrate();
        }
        source.PlayOneShot(Hit, 0.75f);
        Hp -= 10;
        FollowHit();
    }

    void coin()
    {
        source.PlayOneShot(Coin, 0.75f);
        CoinNum += (30 + (3 * (CoinPlusNumber - 1)));
        Coinscore.text = CoinNum.ToString();
    }
    void CoinDel()
    {
        source.PlayOneShot(Coin, 0.75f);

        if(CoinNum >= 200)
        {
            CoinNum -= 200;
        }
        else
        {
            CoinNum = 0;
        }
        Coinscore.text = CoinNum.ToString();
        FollowHit();
    }
    void Candy()
    {
        source.PlayOneShot(HeartUp, 0.75f);
        if (Hp <= MaxHp - 5)
        {
            Hp += 5;
        }
        else
        {
            Hp = MaxHp;
        }

        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);

        foreach (GameObject Candy in CandyPool)
        {
            if (!Candy.activeSelf)
            {
                Candy.transform.position = ScoreObject.position + new Vector3(C, D, 0);
                Candy.SetActive(true);
                if (SkillUseValue == false)
                {
                    ScoreValueA();
                }
                else
                {
                    ScoreValueB();
                }
                break;
            }
        }
    }
    void TrashCan()
    {
        source.PlayOneShot(HeartUp, 0.75f);
        if (Hp <= MaxHp - 10)
        {
            Hp += 10;
        }
        else
        {
            Hp = MaxHp;
        }

        InfoTrash += 1;
        PlayerPrefs.SetInt("InfoTrash", InfoTrash);
    }

    void HeartUse() //하트아이템사용시
    {
        float Z = UnityEngine.Random.Range(0, 10);
        if (Z < 9)
        {
            source.PlayOneShot(HeartUp, 0.75f);
            if(HEART ==0)
            {
                if (Hp <= MaxHp * 0.4f)
                {
                    Hp += (int)(MaxHp * 0.4f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else if(HEART ==1)
            {
                if (Hp <= MaxHp * 0.45f)
                {
                    Hp += (int)(MaxHp * 0.45f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else if(HEART == 2)
            {
                if (Hp <= MaxHp * 0.5f)
                {
                    Hp += (int)(MaxHp * 0.5f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else if (HEART == 3)
            {
                if (Hp <= MaxHp * 0.55f)
                {
                    Hp += (int)(MaxHp * 0.55f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else if (HEART == 4)
            {
                if (Hp <= MaxHp * 6f)
                {
                    Hp += (int)(MaxHp * 6f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else if (HEART == 5)
            {
                if (Hp <= MaxHp * 0.65f)
                {
                    Hp += (int)(MaxHp * 0.65f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else if (HEART == 6)
            {
                if (Hp <= MaxHp * 0.7f)
                {
                    Hp += (int)(MaxHp * 0.7f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
            else
            {
                if (Hp <= MaxHp * 0.5f)
                {
                    Hp += (int)(MaxHp * 0.5f);
                }
                else
                {
                    Hp = MaxHp;
                }
            }
        }
        else
        {
            source.PlayOneShot(Hit, 0.75f);
            HeartHit();
            fuck();
            if (Hp > MaxHp * 0.5f)
            {
                Hp -= (int)(MaxHp * 0.5f);
            }
            else
            {
                Hp = 0;
            }
        }
    }

    void ManDuPlus() //만두 먹을시 
    {
        source.PlayOneShot(HeartUp, 0.75f);
        if (Hp <= MaxHp - 10)
        {
            Hp += 10;
        }
        else
        {
            Hp = MaxHp;
        }
    }

    void HeartMinus() //모든어택이 여기서 오는데...
    {
        if (HitCount == false)
        {
            if (Hand == 1)
            {
                Handheld.Vibrate();
            }
            if (Hp > 0)
            {
                source.PlayOneShot(Hit, 0.75f);
                Hp -= 5;
                HitCount = true;
                StartCoroutine(HitCooltime());
            }
        }
    } //건물 비둘기 독수리 산신령 술주정뱅이
    IEnumerator HitCooltime()
    {
        yield return new WaitForSeconds(Hitcooltime);
        HitCount = false;
    }
    void EagleTouch()
    {
        if (Hand == 1)
        {
            Handheld.Vibrate();
        }
        source.PlayOneShot(Hit, 0.75f);
        Hp -= 15;
        FollowHit();
        StartCoroutine(Eagletouch());
    }

    void UFO()
    {
        Hp = -100;
        Diecheck = 1;
        StopAllCoroutines();
        StartCoroutine(DieCheck());

        InfoUFO += 1;
        PlayerPrefs.SetInt("InfoUFO", InfoUFO);
    }
    void PeopleHit()
    {
        if (HitCount == false)
        {
            if (Hand == 1)
            {
                Handheld.Vibrate();
            }
            if (Hp > 0)
            {
                source.PlayOneShot(Hit, 0.75f);
                Hp -= 5;
                HitCount = true;
                StartCoroutine(HitCooltime());
                FollowHit();
            }
        }
    }
    //바다
    void SeaStart()
    {
        Sea.enabled = true;
    }
    void SeaEnd()
    {
        Sea.enabled = false;
    }
    //부작용
    void fuck()
    {
        InfoFuck += 1;
        PlayerPrefs.SetInt("InfoFuck", InfoFuck);
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);

        foreach (GameObject fuck in FuckPool)
        {
            if (!fuck.activeSelf)
            {
                fuck.transform.position = ScoreObject.position + new Vector3(C, D, 0);

                fuck.SetActive(true);
                if (SkillUseValue == false)
                {
                    ScoreValueA();
                }
                else
                {
                    ScoreValueB();
                }

                break;
            }
        }
    }
    void fuckfuck()
    {
        InfoFuck += 1;
        PlayerPrefs.SetInt("InfoFuck", InfoFuck);
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);

        foreach (GameObject fuck in FuckPool)
        {
            if (!fuck.activeSelf)
            {
                fuck.transform.position = ScoreObject.position + new Vector3(C, D, 0);

                fuck.SetActive(true);
                ScoreValueC();

                break;
            }
        }
    }

    void SmallPotion()
    {
        source.PlayOneShot(Small, 0.75f);
    }

    void RainStart()
    {
        CloudUI.SetActive(true);
    }
    void RainStop()
    {
        CloudUI.SetActive(false);
    }

    void OliveTreeIn()
    {
        source.PlayOneShot(OliveHit, 0.6f);
    }
    void OliveTreeOut()
    {
        if(C == false)
        {
            StartCoroutine(Oliveuse());
        }
    }

    void CastleIn() //올리브 해제말고 또 뭐잇지?
    {
        source.PlayOneShot(castlein, 0.75f);
        source.PlayOneShot(Hidden, 1.0f);

        NotionHidden.SetActive(true);

        SongValueB = 0;
        SongValueC = 0;
        MainSong.enabled = false;
        UnderSong.enabled = false;
        DiscoSong.enabled = false;

        C = false;
        Olive.SetActive(false);
        PlayerPrefs.SetInt("Olive", 0);

        SkillUseValue = false;
        Hacking = 0;

        Castle = true;

        InfoHidden += 1;
        PlayerPrefs.SetInt("InfoHidden", InfoHidden);
        StopAllCoroutines();
    }
    void CastleOut()
    {
        source.PlayOneShot(castleout, 0.75f);
        StartCoroutine(HpCheck());
        StartCoroutine(Hpcheck());
        StartCoroutine(CreateMonster());
        StartCoroutine(CreateEagle());
        StartCoroutine(CreateCoin());
    }

    void Hack()
    {
        Hacking = 1;
        StartCoroutine(hackingtime());
    }
    void FuckHack()
    {
        Hacking = 2;
        StartCoroutine(Fuckhackingtime());
    }
    IEnumerator hackingtime()
    {
        yield return new WaitForSeconds(HackingTime);
        Hacking = 0;
    }
    IEnumerator Fuckhackingtime()
    {
        yield return new WaitForSeconds(FuckHackingTime);
        Hacking = 0;
    }

    void Itemuse()
    {
        source.PlayOneShot(Coin, 0.75f);
        foreach (GameObject item in UsePool)
        {
            if (!item.activeSelf)
            {
                item.transform.position = ScoreObject.position + new Vector3(0, 0.05f, 0);
                item.SetActive(true);
                if (SkillUseValue == false)
                {
                    ScoreValueA();
                }
                else
                {
                    ScoreValueB();
                }
                break;
            }
        }
    }
    void Score50()
    {
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);
        source.PlayOneShot(Coin, 0.75f);
        if (isGameOver == false)
        {
            if(Hacking ==0)
            {
                foreach (GameObject score in ScorePool)
                {
                    if (!score.activeSelf)
                    {
                        score.transform.position = ScoreObject.position + new Vector3(C, D, 0);;
                                                                                                
                        score.SetActive(true);
                        if (SkillUseValue == false)
                        {
                            ScoreValueA();
                        }
                        else
                        {
                            ScoreValueB();
                        }
                        break;
                    }
                }
            }
            else if(Hacking ==1)
            {
                foreach (GameObject score in Score2Pool)
                {
                    if (!score.activeSelf)
                    {
                        score.transform.position = ScoreObject.position + new Vector3(C, D, 0);
                        score.SetActive(true);
                        if (SkillUseValue == false)
                        {
                            ScoreValueA();
                        }
                        else
                        {
                            ScoreValueB();
                        }
                        break;
                    }
                }
            }
            else if (Hacking == 2)
            {
                foreach (GameObject score in Score3Pool)
                {
                    if (!score.activeSelf)
                    {
                        score.transform.position = ScoreObject.position + new Vector3(C, D, 0);
                        score.SetActive(true);
                        if (SkillUseValue == false)
                        {
                            ScoreValueA();
                        }
                        else
                        {
                            ScoreValueB();
                        }
                        break;
                    }
                }
            }
        }
    }
    void Score100()
    {
        float C = UnityEngine.Random.Range(0, 0.05f);
        float D = UnityEngine.Random.Range(0, 0.05f);
        source.PlayOneShot(Coin, 0.75f);
        if (isGameOver == false)
        {
            foreach (GameObject score in BuildPool)
            {
                if (!score.activeSelf)
                {
                    score.transform.position = ScoreObject.position + new Vector3(C, D, 0); //+ new Vector3(0,0.075f,0);
                    //Debug.Log(ScoreObject.position.y.ToString());
                    score.SetActive(true);
                    if (SkillUseValue == false)
                    {
                        ScoreValueA();
                    }
                    else
                    {
                        ScoreValueB();
                    }
                    break;
                }
            }
        }
    } //아슬점수
    void SkillUse()
    {
        StartCoroutine(Skilluse());
    }

    IEnumerator Skilluse()
    {
        source.PlayOneShot(Skill, 0.75f);
        SkillUseValue = true;
        yield return new WaitForSeconds(1.5f);
        Boast.enabled = true;
        yield return new WaitForSeconds(SkillTime - 1.5f);
        Boast.enabled = false;
        SkillUseValue = false;
    }
    IEnumerator Oliveuse()
    {
        C = true;
        PlayerPrefs.SetInt("Olive", 1);
        Olive.SetActive(true);
        OliveLabel.text = "5";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "4";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "3";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "2";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "1";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "0";
        yield return new WaitForSeconds(0.1f);
        Olive.SetActive(false);
        PlayerPrefs.SetInt("Olive", 0);
        yield return new WaitForSeconds(0.5f);
        C = false;
    }

    IEnumerator ScoreClear()
    {
        if (Score == 0)
        {
            yield return new WaitForSeconds(0.5f);
            source.PlayOneShot(Bang, 1.0f);
            NewRecord.SetActive(true);
            yield return new WaitForSeconds(1f);
            OutGame.SetActive(true);
        }
        else //실패소리 추가해야됨
        {
            yield return new WaitForSeconds(1f);
            OutGame.SetActive(true);
        }
    } //최고점수일시 효과설정
    public void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    IEnumerator CreateMonster()
    {
        foreach (GameObject monster in monsterPool)
        {
            if (!monster.activeSelf)
            {
                int idx = UnityEngine.Random.Range(1, points.Length);

                monster.transform.position = points[idx].position;
                monster.SetActive(true);
                break;
            }
        }
        yield return new WaitForSeconds(createTime);
        StartCoroutine(CreateMonster());
    }
    IEnumerator CreateEagle()
    {
        foreach (GameObject eagle in EaglePool)
        {
            if (!eagle.activeSelf)
            {
                //Debug.Log("AA");
                int idx = UnityEngine.Random.Range(1, Eaglepoints.Length);

                eagle.transform.position = Eaglepoints[idx].position;
                eagle.SetActive(true);

                break;
            }
        }
        yield return new WaitForSeconds(EaglecreateTime);
        StartCoroutine(CreateEagle());
    }
    IEnumerator CreateCoin()
    {
        foreach (GameObject coin in CoinPool)
        {
            if (!coin.activeSelf)
            {
                int idx = UnityEngine.Random.Range(1, Eaglepoints.Length);

                coin.transform.position = Eaglepoints[idx].position;
                coin.SetActive(true);

                break;
            }
        }
        yield return new WaitForSeconds(CoinctreateTime);
        StartCoroutine(CreateCoin());
    }

    IEnumerator Eagletouch()
    {
        PlayerPrefs.SetInt("Eagletouch", 1);
        EagleUI.SetActive(true);
        yield return new WaitForSeconds(EagleTime);
        PlayerPrefs.SetInt("Eagletouch", 0);
        EagleUI.SetActive(false);
    }

    //일시정지 기능
    public void Pause()
    {
        if (screen == 0)
        {
            Time.timeScale = 0;
            PauseGame.SetActive(true);
            MainSong.Pause();
            UnderSong.Pause();
            DiscoSong.Pause();
            source.PlayOneShot(Click, 0.75f);
            screen = 1;
            if (Hand == 0)
            {
                handon.value = false;
                handoff.value = true;
            }
            else
            {
                handon.value = true;
                handoff.value = false;
            }
        }
    }
    public void ReGame()
    {
        SceneManager.LoadScene(7);
    }
    public void UnPause()
    {
        source.PlayOneShot(Click, 0.75f);
        PauseGame.SetActive(false);
        MainSong.UnPause();
        UnderSong.UnPause();
        DiscoSong.UnPause();
        Time.timeScale = 1;
        screen = 0;
    }

    public void HandOn()
    {
        Hand = 1;
        PlayerPrefs.SetInt("Hand", Hand);
    }
    public void HandOff()
    {
        Hand = 0;
        PlayerPrefs.SetInt("Hand", Hand);
    }

    //개발자콘솔기능
    public void StopGame()
    {
        Hp = 0;
        StopAllCoroutines();
        StartCoroutine(DieCheck());
    }// X 표시 ㅋㅋ
    public void Levelup()
    {
        MapChange();
    }
    public void Castlefast()
    {
        CastleFast();
    }
    public void Eaglefast()
    {
        EagleFast();
    }
    public void Talkfast()
    {
        TalkStart();
        Talkstart(); //임시
    }
    public void Hpdown()
    {
        Hp = 1;
    }

    public void EggAttack()
    {
        if (screen == 0)
        {
            source.PlayOneShot(Oha, 0.4f);
            foreach (GameObject egg in EggPool)
            {
                if (!egg.activeSelf)
                {
                    egg.transform.position = ScoreObject.position;
                    egg.SetActive(true);
                    break;
                }
            }
        }
    }
}
