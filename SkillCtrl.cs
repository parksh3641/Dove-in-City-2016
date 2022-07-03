using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SkillCtrl : MonoBehaviour
{
    private float CoolTime;

    private int ItemNumber =0; //0은 사용햇을시 1=하트/2=?
    private Transform Player;

    private int Dove;
    private int Magnet;
    private int SmallPotion;
    private int Hacking;
    private int Timing;
    private int disco;
    private int Car;

    private int A = 0;
    private float MagnetTime;
    private float SmallTime;
    private float HackingTime;
    private float FuckHackingTime;
    private float TimingTime;
    private float FuckTimingTime;
    private float DiscoTime;
    private float CarTime;

    private int Fillter = 0;
    private int FillterA = 0; // 0 은 1번 ,1은 2번
    private int FillterB = 0;
    public GameObject ItemFilterA;
    public UISprite ItemFilterspA;
    public UISprite ItemFiltertimeA;
    public GameObject ItemFilterB;
    public UISprite ItemFilterspB;
    public UISprite ItemFiltertimeB;

    public UISprite NowItem;
    public UISprite NextItem;

    private int MainSkillNumber;

    public GameObject MainSkillA;
    public GameObject MainSkillB;

    public BoxCollider MainItem;

    public BoxCollider MainSkilla;
    public BoxCollider MainSkillb;

    public UISprite MainskillA;
    public UISprite MainskillB;

    public UISprite skillFilter;
    public UILabel coolTimeCounter;
    public UISprite itemFilter;
    public UILabel itemTimeCounter;

    private float currentCoolTime = 10;
    private float ResetTime = 10;
    private float ItemDelayTime;

    private bool Timeover = false;
    private bool canUseSkill = true;
    private bool canUseItem = true;

    public GameObject NotionItem;
    //
    string Astring = "003_heart";
    string Bstring = "자석 ui";
    string Cstring = "미니 포션 ui";
    string Dstring = "1회용 해킹툴 ui";
    string Estring = "시간의 모래시계 ui";
    string Fstring = "디스코 뮤직박스 ui";
    string Gstring = "초능력 기압계 ui";
    string Hstring = "중국산 엔진오일 ui";

    string Kstring = "영구 해킹툴ui";
    //
    private int Asave = 0;
    private int Bsave = 0;
    private int Csave = 0;
    private int Dsave = 0;
    private int Esave = 0;

    private int Itemcheck = 0;

    private int InfoSkill;
    private int InfoItem;

    //시간되돌리기
    public List<GameObject> PosPool = new List<GameObject>();
    public GameObject Which;
    public GameObject[] WhichObject = new GameObject[] { };

    private AudioSource source;
    public AudioClip Click;

    public delegate void Skillctrl();
    public static event Skillctrl SkillUse , Heart , Small ,FuckSmall, Hack,FuckHack,fuck 
        ,fuckfuck, Timeslip , weather , Disco ,weatherdie , ItemUse;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        //MainSkillB.SetActive(false);
        ItemFilterA.SetActive(false);
        ItemFilterB.SetActive(false);
        skillFilter.enabled = false;
        itemFilter.enabled = false;
        Magnet = 0;
        PlayerPrefs.SetInt("Magnet", Magnet);
        Car = 0;
        PlayerPrefs.SetInt("Car", 0);

        MainSkillNumber = PlayerPrefs.GetInt("MainSkillNumber", 0);
        if(MainSkillNumber == 0)
        {
            MainSkillA.SetActive(true);
            MainSkillB.SetActive(false);
        }
        else
        {
            MainSkillA.SetActive(false);
            MainSkillB.SetActive(true);
        }

        InfoSkill = PlayerPrefs.GetInt("InfoSkill", 0);
        InfoItem = PlayerPrefs.GetInt("InfoItem", 0);

        Asave = PlayerPrefs.GetInt("Asave", 0);
        Bsave = PlayerPrefs.GetInt("Bsave", 0);
        Csave = PlayerPrefs.GetInt("Csave", 0);
        Dsave = PlayerPrefs.GetInt("Dsave", 0);
        Esave = PlayerPrefs.GetInt("Esave", 0);

        ItemCheckA(NowItem, Asave);
        ItemCheckB(NextItem, Bsave);

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

        //for (int i = 0; i < 20; i++)
        //{
        //    GameObject which = Instantiate(Which);
        //    which.name = "which _" + i.ToString();
        //    which.SetActive(false);
        //    PosPool.Add(which);
        //}
        //StartCoroutine(PosCheck());
    }
    void Start()
    {
        SmallTime = GameManager.SmallTime;
        MagnetTime = GameManager.MagnetTime;
        HackingTime = GameManager.HackingTime;
        FuckHackingTime = HackingTime * 0.5f;
        CoolTime = GameManager.SkillTime;
        TimingTime = GameManager.TimingTime;
        FuckTimingTime = TimingTime;
        ItemDelayTime = TimingTime;
        DiscoTime = GameManager.DiscoTime;
        CarTime = GameManager.CarTime;

        //if (ItemNumber == 5)
        //{
        //    Timing = 1;
        //    itemFilter.enabled = true;
        //    itemFilter.fillAmount = 1;
        //     StartCoroutine(DelayTime());
        //    StartCoroutine(DelayTimeCounter());
        //}
    }

    public void ItemCheckA(UISprite A, int B)
    {
        if (B == 0)
        {
            A.enabled = false;
        }
        else if (B == 1)
        {
            A.spriteName = Astring;
            ItemNumber = B;
        }
        else if (B == 2)
        {
            A.spriteName = Bstring;
            ItemNumber = B;
        }
        else if (B == 3)
        {
            A.spriteName = Cstring;
            ItemNumber = B;
        }
        else if (B == 4)
        {
            A.spriteName = Dstring;
            ItemNumber = B;
        }
        else if (B == 5)
        {
            A.spriteName = Estring;
            ItemNumber = B;            
        }
        else if (B == 6)
        {
            A.spriteName = Fstring;
            ItemNumber = B;
        }
        else if (B == 7)
        {
            A.spriteName = Gstring;
            ItemNumber = B;
        }
        else if (B == 8)
        {
            A.spriteName = Hstring;
            ItemNumber = B;
        }
        else if (B == 11)
        {
            A.spriteName = Kstring;
            ItemNumber = B;
        }
    }
    public void ItemCheckB(UISprite A, int B)
    {
        if (B == 0)
        {
            A.enabled = false;
        }
        else if (B == 1)
        {
            A.spriteName = Astring;
        }
        else if (B == 2)
        {
            A.spriteName = Bstring;
        }
        else if (B == 3)
        {
            A.spriteName = Cstring;
        }
        else if (B == 4)
        {
            A.spriteName = Dstring;
        }
        else if (B == 5)
        {
            A.spriteName = Estring;
        }
        else if (B == 6)
        {
            A.spriteName = Fstring;
        }
        else if (B == 7)
        {
            A.spriteName = Gstring;
        }
        else if (B == 8)
        {
            A.spriteName = Hstring;
        }
        else if (B == 11)
        {
            A.spriteName = Kstring;
        }
    }

    //IEnumerator PosCheck() //타임아이템
    //{
    //    foreach (GameObject which in PosPool)
    //    {
    //        if (!which.activeSelf)
    //        {
    //            if (Timeover == false)
    //            {
    //                which.transform.position = Player.position;
    //                which.SetActive(true);
    //            }
    //            break;
    //        }
    //    }
    //    yield return new WaitForSeconds(1f);
    //    StartCoroutine(PosCheck());
    //}

    void OnEnable()
    {
        GodCtrl.TalkStart += TalkStart;
        GameManager.TalkStart += TalkStart;
        Talk.TalkEnd += TalkEnd;
        Talk.UnderWorld += OliveTreeIn;
        PlayerCtrl.UnderOut += OliveTreeOut;

        PlayerCtrl.OliveTreeIn += OliveTreeIn;
        PlayerCtrl.OliveTreeOut += OliveTreeOut;
        PlayerCtrl.CastleIn += OliveTreeIn;
        PlayerCtrl.CastleOut += OliveTreeOut;
        //PlayerCtrl.TimeslipEnd += TimeEnd;
        GameManager.PlayerDie += PlayerDie;
        GameManager.PlayerLive += PlayerLive;
    }
    void OnDisable()
    {
        GodCtrl.TalkStart -= TalkStart;
        GameManager.TalkStart -= TalkStart;
        Talk.TalkEnd -= TalkEnd;
        PlayerCtrl.UnderOut += OliveTreeOut;

        PlayerCtrl.OliveTreeIn -= OliveTreeIn;
        PlayerCtrl.OliveTreeOut -= OliveTreeOut;
        PlayerCtrl.CastleIn -= OliveTreeIn;
        PlayerCtrl.CastleOut -= CastleOut;
        //PlayerCtrl.TimeslipEnd -= TimeEnd;
        GameManager.PlayerDie -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;
    }

    void PlayerDie()
    {
        StopAllCoroutines();
        PlayerPrefs.SetInt("Skill", 0);
        Timeover = true;
        //스킬초기화
        skillFilter.enabled = false;
        itemFilter.enabled = false;
        canUseSkill = false;
        canUseItem = false;
        skillFilter.fillAmount = 1;
        itemFilter.fillAmount = 1;
        coolTimeCounter.text = " ";
        itemTimeCounter.text = " ";
        //아이템사용중인상태 초기화
        Magnet = 0;
        PlayerPrefs.SetInt("Magnet", 0);
        Car = 0;
        PlayerPrefs.SetInt("Car", 0);
        SmallPotion = 0;
        Hacking = 0;
        disco = 0;
        //아이템상태 초기화
        Fillter = 0;
        FillterA = 0;
        FillterB = 0;
        ItemFilterA.SetActive(false);
        ItemFilterB.SetActive(false);
    }
    void PlayerLive()
    {
        Timeover = false;
        canUseSkill = true;
        canUseItem = true;
    }

    void TalkStart()
    {
        Timeover = true;
    }
    void TalkEnd()
    {
        Timeover = false;
    }

    //void TimeEnd()
    //{
    //    Timeover = false;
    //    NotSkill = false;
    //
    //    if (ItemNumber == 5)
    //    {
    //        Timing = 1;
    //        itemFilter.enabled = true;
    //        itemFilter.fillAmount = 1;
    //        StartCoroutine(DelayTime());
    //        StartCoroutine(DelayTimeCounter());
    //    }
    //}

    void OliveTreeIn()
    {
        MainSkilla.enabled = false;
        MainSkillb.enabled = false;
        MainItem.enabled = false;
        MainskillA.color = new Color(MainskillA.color.r, MainskillA.color.g, MainskillA.color.b, 0.5f);
        MainskillB.color = new Color(MainskillB.color.r, MainskillB.color.g, MainskillB.color.b, 0.5f);
    }
    void OliveTreeOut()
    {
        MainSkilla.enabled = true;
        MainSkillb.enabled = true;
        MainItem.enabled = true;
        MainskillA.color = new Color(MainskillA.color.r, MainskillA.color.g, MainskillA.color.b, 1.0f);
        MainskillB.color = new Color(MainskillB.color.r, MainskillB.color.g, MainskillB.color.b, 1.0f);
    }

    IEnumerator Castletime()
    {
        yield return new WaitForSeconds(3f);
        MainSkilla.enabled = true;
        MainskillA.color = new Color(MainskillA.color.r, MainskillA.color.g, MainskillA.color.b, 1.0f);
    }
    void CastleOut()
    {
        StartCoroutine(Castletime());
    }

    IEnumerator Cooltime()
    {
        while (skillFilter.fillAmount > 0)
        {
            skillFilter.fillAmount -= 1 * Time.smoothDeltaTime / CoolTime;

            yield return null;
        }
        PlayerPrefs.SetInt("Skill", 0);
        currentCoolTime = GameManager.SkillCoolTime;
        ResetTime = GameManager.SkillCoolTime;
        StartCoroutine(SkillReset());
        StartCoroutine(CoolTimeCounter());
        yield break;
    }
    IEnumerator MagnetCooltime()
    {
        if(FillterA ==0)
        {
            Fillter += 1;
            FillterA = 1;
            ItemFiltertimeA.fillAmount = 1;
            ItemFilterspA.spriteName = "자석 ui";
            ItemFilterA.SetActive(true);
            ItemFiltertimeA.enabled = true;
            while (ItemFiltertimeA.fillAmount > 0)
            {
                ItemFiltertimeA.fillAmount -= 1 * Time.smoothDeltaTime / MagnetTime;

                yield return null;
            }
            Fillter -= 1;
            FillterA = 0;
            ItemFilterA.SetActive(false);
        }
        else if(FillterA == 1)
        {
            if(FillterB ==0)
            {
                Fillter += 1;
                FillterB = 1;
                ItemFiltertimeB.fillAmount = 1;
                ItemFilterspB.spriteName = "자석 ui";
                ItemFilterB.SetActive(true);
                ItemFiltertimeB.enabled = true;
                while (ItemFiltertimeB.fillAmount > 0)
                {
                    ItemFiltertimeB.fillAmount -= 1 * Time.smoothDeltaTime / MagnetTime;

                    yield return null;
                }
                Fillter -= 1;
                FillterB = 0;
                ItemFilterB.SetActive(false);
            }
        }
    }
    IEnumerator SmallCooltime()
    {
        if(FillterA ==0)
        {
            Fillter += 1;
            FillterA = 1;
            ItemFiltertimeA.fillAmount = 1;
            ItemFilterspA.spriteName = "미니 포션 ui";
            ItemFilterA.SetActive(true);
            ItemFiltertimeA.enabled = true;
            while (ItemFiltertimeA.fillAmount > 0)
            {
                ItemFiltertimeA.fillAmount -= 1 * Time.smoothDeltaTime / SmallTime;

                yield return null;
            }
            Fillter -= 1;
            FillterA = 0;
            ItemFilterA.SetActive(false);
        }
        else if(FillterA ==1)
        {
            if(FillterB ==0)
            {
                Fillter += 1;
                FillterB = 1;
                ItemFiltertimeB.fillAmount = 1;
                ItemFilterspB.spriteName = "미니 포션 ui";
                ItemFilterB.SetActive(true);
                ItemFiltertimeB.enabled = true;
                while (ItemFiltertimeB.fillAmount > 0)
                {
                    ItemFiltertimeB.fillAmount -= 1 * Time.smoothDeltaTime / SmallTime;

                    yield return null;
                }
                Fillter -= 1;
                FillterB = 0;
                ItemFilterB.SetActive(false);
            }
        }
    }

    IEnumerator HackingCooltime()
    {
        if (FillterA == 0)
        {
            Fillter += 1;
            FillterA = 1;
            ItemFiltertimeA.fillAmount = 1;
            ItemFilterspA.spriteName = "1회용 해킹툴 ui";
            ItemFilterA.SetActive(true);
            ItemFiltertimeA.enabled = true;
            while (ItemFiltertimeA.fillAmount > 0)
            {
                ItemFiltertimeA.fillAmount -= 1 * Time.smoothDeltaTime / HackingTime;

                yield return null;
            }
            Fillter -= 1;
            FillterA = 0;
            ItemFilterA.SetActive(false);
        }
        else if (FillterA == 1)
        {
            if (FillterB == 0)
            {
                Fillter += 1;
                FillterB = 1;
                ItemFiltertimeB.fillAmount = 1;
                ItemFilterspB.spriteName = "1회용 해킹툴 ui";
                ItemFilterB.SetActive(true);
                ItemFiltertimeB.enabled = true;
                while (ItemFiltertimeB.fillAmount > 0)
                {
                    ItemFiltertimeB.fillAmount -= 1 * Time.smoothDeltaTime / HackingTime;

                    yield return null;
                }
                Fillter -= 1;
                FillterB = 0;
                ItemFilterB.SetActive(false);
            }
        }
    }
    IEnumerator FuckHackingCooltime()
    {
        if (FillterA == 0)
        {
            Fillter += 1;
            FillterA = 1;
            ItemFiltertimeA.fillAmount = 1;
            ItemFilterspA.spriteName = "1회용 해킹툴 ui";
            ItemFilterA.SetActive(true);
            ItemFiltertimeA.enabled = true;
            while (ItemFiltertimeA.fillAmount > 0)
            {
                ItemFiltertimeA.fillAmount -= 1 * Time.smoothDeltaTime / FuckHackingTime;

                yield return null;
            }
            Fillter -= 1;
            FillterA = 0;
            ItemFilterA.SetActive(false);
        }
        else if (FillterA == 1)
        {
            if (FillterB == 0)
            {
                Fillter += 1;
                FillterB = 1;
                ItemFiltertimeB.fillAmount = 1;
                ItemFilterspB.spriteName = "1회용 해킹툴 ui";
                ItemFilterB.SetActive(true);
                ItemFiltertimeB.enabled = true;
                while (ItemFiltertimeB.fillAmount > 0)
                {
                    ItemFiltertimeB.fillAmount -= 1 * Time.smoothDeltaTime / FuckHackingTime;

                    yield return null;
                }
                Fillter -= 1;
                FillterB = 0;
                ItemFilterB.SetActive(false);
            }
        }
    }
    
    IEnumerator DiscoCooltime()
    {
        if (FillterA == 0)
        {
            Fillter += 1;
            FillterA = 1;
            ItemFiltertimeA.fillAmount = 1;
            ItemFilterspA.spriteName = "디스코 뮤직박스 ui";
            ItemFilterA.SetActive(true);
            ItemFiltertimeA.enabled = true;
            while (ItemFiltertimeA.fillAmount > 0)
            {
                ItemFiltertimeA.fillAmount -= 1 * Time.smoothDeltaTime / DiscoTime;

                yield return null;
            }
            Fillter -= 1;
            FillterA = 0;
            ItemFilterA.SetActive(false);
        }
        else if (FillterA == 1)
        {
            if(FillterB ==0)
            {
                Fillter += 1;
                FillterB = 1;
                ItemFiltertimeB.fillAmount = 1;
                ItemFilterspB.spriteName = "디스코 뮤직박스 ui";
                ItemFilterB.SetActive(true);
                ItemFiltertimeB.enabled = true;
                while (ItemFiltertimeB.fillAmount > 0)
                {
                    ItemFiltertimeB.fillAmount -= 1 * Time.smoothDeltaTime / DiscoTime;

                    yield return null;
                }
                Fillter -= 1;
                FillterB = 0;
                ItemFilterB.SetActive(false);
            }
        }
    }

    IEnumerator CarCooltime()
    {
        if (FillterA == 0)
        {
            Fillter += 1;
            FillterA = 1;
            ItemFiltertimeA.fillAmount = 1;
            ItemFilterspA.spriteName = Hstring;
            ItemFilterA.SetActive(true);
            ItemFiltertimeA.enabled = true;
            while (ItemFiltertimeA.fillAmount > 0)
            {
                ItemFiltertimeA.fillAmount -= 1 * Time.smoothDeltaTime / CarTime;

                yield return null;
            }
            Fillter -= 1;
            FillterA = 0;
            ItemFilterA.SetActive(false);
        }
        else if (FillterA == 1)
        {
            if (FillterB == 0)
            {
                Fillter += 1;
                FillterB = 1;
                ItemFiltertimeB.fillAmount = 1;
                ItemFilterspB.spriteName = Hstring;
                ItemFilterB.SetActive(true);
                ItemFiltertimeB.enabled = true;
                while (ItemFiltertimeB.fillAmount > 0)
                {
                    ItemFiltertimeB.fillAmount -= 1 * Time.smoothDeltaTime / CarTime;

                    yield return null;
                }
                Fillter -= 1;
                FillterB = 0;
                ItemFilterB.SetActive(false);
            }
        }
    }

    IEnumerator SkillReset()
    {
        while (skillFilter.fillAmount < 1)
        {
            skillFilter.fillAmount += 1 * Time.smoothDeltaTime / ResetTime;

            yield return null;

        }
        canUseSkill = true;
        skillFilter.enabled = false;
    }
    IEnumerator CoolTimeCounter()
    {
        if (currentCoolTime > 0)
        {
            currentCoolTime -= 1;
            coolTimeCounter.text = currentCoolTime.ToString();

            yield return new WaitForSeconds(1f);
            StartCoroutine(CoolTimeCounter());
        }
        else
        {
            coolTimeCounter.text = " ";
            StopCoroutine(CoolTimeCounter());
        }
    }

    public void UseSkill()
    {
        if (canUseSkill == true)
        {
            SkillUse();
            skillFilter.enabled = true;
            skillFilter.fillAmount = 1; //스킬 버튼을 가림
            StartCoroutine(Cooltime());
            canUseSkill = false; //스킬을 사용하면 사용할 수 없는 상태로 바꿈

            PlayerPrefs.SetInt("Skill", 1);

            InfoSkill += 1;
            PlayerPrefs.SetInt("InfoSkill", InfoSkill);
        }
        else
        {
            //Debug.Log("아직 스킬을 사용할 수 없습니다.");
        }
    }

    public void UseItem()
    {
        source.PlayOneShot(Click, 0.75f);
        if (canUseItem == true)
        {
            if(Fillter < 2)
            {
                if (ItemNumber == 1)
                {
                    Heart();
                    Itemcheck += 1;
                    NextItemCheck();
                }
                else if (ItemNumber == 2)
                {
                    if (Magnet == 0)
                    {
                        StartCoroutine(MagnetUse());
                        Itemcheck += 1;
                        NextItemCheck();
                    }
                }
                else if (ItemNumber == 3)
                {
                    if (SmallPotion == 0)
                    {
                        StartCoroutine(SmallUse());
                        Itemcheck += 1;
                        NextItemCheck();
                    }
                }
                else if (ItemNumber == 4)
                {
                    if (Hacking == 0)
                    {
                        StartCoroutine(HackingUse());
                        Itemcheck += 1;
                        NextItemCheck();
                    }
                }
                //else if (ItemNumber == 5)
                //{
                //    if (Timing == 0)
                //    {
                //       Timing = 1;
                //        TimeUse();
                //        Timeslip();
                //        Itemcheck += 1;
                //        NextItemCheck();
                //    }
                //}
                else if (ItemNumber == 6)
                {
                    if (disco == 0)
                    {
                        StartCoroutine(DiscoUse());
                        Itemcheck += 1;
                        NextItemCheck();
                    }
                }

                else if (ItemNumber == 7)
                {
                    WeatherUse();
                    Itemcheck += 1;
                    NextItemCheck();
                }
                else if (ItemNumber == 8)
                {
                    if (Car == 0)
                    {
                        StartCoroutine(CarUse());
                        Itemcheck += 1;
                        NextItemCheck();
                    }
                }

                else if (ItemNumber == 11) // 영구해킹툴
                {
                    if (Hacking == 0)
                    {
                        PlayerPrefs.SetInt("KLockNum", 1);
                        StartCoroutine(HackingUse());
                        Itemcheck += 1;
                        NextItemCheck();
                    }
                }
            }
            else
            {
                NotionItem.SetActive(false);
                NotionItem.SetActive(true);
            }
        }           
    }

    void NextItemCheck()
    {
        ItemUse();
        InfoItem += 1;
        PlayerPrefs.SetInt("InfoItem", InfoItem);
        ItemNumber = 0;
        if(Itemcheck ==1)
        {
            Asave = 0;
            PlayerPrefs.SetInt("Asave", Asave);
            ItemCheckA(NowItem, Bsave);
            ItemCheckB(NextItem, Csave);
        }
        else if(Itemcheck ==2)
        {
            Bsave = 0;
            PlayerPrefs.SetInt("Bsave", Bsave);
            ItemCheckA(NowItem, Csave);
            ItemCheckB(NextItem, Dsave);
        }
        else if (Itemcheck == 3)
        {
            Csave = 0;
            PlayerPrefs.SetInt("Csave", Csave);
            ItemCheckA(NowItem, Dsave);
            ItemCheckB(NextItem, Esave);
        }
        else if (Itemcheck == 4)
        {
            Dsave = 0;
            PlayerPrefs.SetInt("Dsave", Dsave);
            ItemCheckA(NowItem, Esave);
            NextItem.enabled = false;
        }
        else if (Itemcheck == 5)
        {
            Esave = 0;
            PlayerPrefs.SetInt("Esave", Esave);
            NowItem.enabled = false;
        }

        if (Timeover == false)
        {
            if (ItemNumber == 5)
            {
                Timing = 1;
                itemFilter.enabled = true;
                itemFilter.fillAmount = 1;
                StartCoroutine(DelayTime());
                StartCoroutine(DelayTimeCounter());
            }
        }
    }

    IEnumerator DelayTime()
    {
        while (itemFilter.fillAmount > 0)
        {
            itemFilter.fillAmount -= 1 * Time.smoothDeltaTime / TimingTime;

            yield return null;
        }
        Timing = 0;
        itemFilter.enabled = false;
    }
    IEnumerator DelayTimeCounter()
    {
        if (ItemDelayTime > 0)
        {
            ItemDelayTime -= 1;
            itemTimeCounter.text = ItemDelayTime.ToString();

            yield return new WaitForSeconds(1f);
            StartCoroutine(DelayTimeCounter());
        }
        else
        {
            ItemDelayTime = GameManager.TimingTime;
            itemTimeCounter.text = " ";
            StopCoroutine(DelayTimeCounter());
        }
    }

    IEnumerator MagnetUse()
    {
        StartCoroutine(MagnetCooltime());
        float Z = Random.Range(0, 10);
        if (Z < 9)
        {
            Magnet = 1;
            PlayerPrefs.SetInt("Magnet", Magnet);
        }
        else
        {
            Magnet = 2;
            PlayerPrefs.SetInt("Magnet", Magnet);
            fuck();
        }
        yield return new WaitForSeconds(MagnetTime);
        Magnet = 0;
        PlayerPrefs.SetInt("Magnet", Magnet);
    }
    IEnumerator SmallUse()
    {
        StartCoroutine(SmallCooltime());
        float Z = Random.Range(0, 10);
        if (Z < 9)
        {
            Small();
        }
        else
        {
            FuckSmall();
            fuck();
        }
        SmallPotion = 1; 
        yield return new WaitForSeconds(SmallTime);
        SmallPotion = 0;
    }
    IEnumerator HackingUse()
    {
        float Z = Random.Range(0, 10);
        if (Z < 9)
        {
            Hack();
            StartCoroutine(HackingCooltime());
        }
        else
        {
            FuckHack();
            StartCoroutine(FuckHackingCooltime());
            fuck();
        }
        Hacking = 1;
        yield return new WaitForSeconds(HackingTime);
        Hacking = 0;
    }
    IEnumerator DiscoUse()
    {
        Disco();
        StartCoroutine(DiscoCooltime());
        disco = 1;
        yield return new WaitForSeconds(DiscoTime);
        disco = 0;
    }
    void WeatherUse()
    {
        float Z = Random.Range(0, 10);
        if (Z < 9)
        {
            weather();
        }
        else
        {
            weatherdie();
            fuckfuck();
        }
    }
    IEnumerator CarUse()
    {
        StartCoroutine(CarCooltime());
        float Z = Random.Range(0, 10);
        if (Z < 9)
        {
            Car = 1;
            PlayerPrefs.SetInt("Car", Car);
        }
        else
        {
            Car = 2;
            PlayerPrefs.SetInt("Car", Car);
            fuck();
        }
        yield return new WaitForSeconds(CarTime);
        Car = 0;
        PlayerPrefs.SetInt("Car", Car);
    }
    //void TimeUse()
    //{
    //    Timeover = true;
    //    NotSkill = true;
    //    WhichObject = GameObject.FindGameObjectsWithTag("Pos");
    //    for (int i = 0; i < WhichObject.Length; i++)
    //    {
    //        WhichObject[i].SetActive(false);
    //    }
    //}

    //public void SkillChange()
    //{
    //    source.PlayOneShot(Click, 0.75f);
    //    if (A ==0)
    //    {
    //        A = 1;
    //        MainSkillA.SetActive(false);
    //        MainSkillB.SetActive(true);
    //    }
    //    else if(A ==1)
    //    {
    //        A = 0;
    //        MainSkillA.SetActive(true);
    //        MainSkillB.SetActive(false);
    //    }
    //}
}

