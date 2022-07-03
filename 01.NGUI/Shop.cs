using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour {

    public UILabel bd;
    public UILabel unit;
    public UILabel dori;
    public UILabel Information;
    public UILabel EggInfo;
    //파티클
    public GameObject OpenEffect;
    public GameObject OneEffect;
    public GameObject TwoEffect;
    public GameObject ThreeEffect;

    //1
    public GameObject OneCheck;
    public GameObject TwoCheck;
    public GameObject ThreeCheck;
    public GameObject FourCheck;
    public UISprite OneMainSprite;
    public UILabel OneBuyA;
    public UILabel OneBuyB;
    public UILabel OneBuyC;
    public UILabel OneBuyD;
    public UILabel OneBuyE; //도라
    public UILabel OneBuyF;
    //알
    public UISprite OneMainEgg;
    public UISprite OneMainEgg2;
    public UILabel OneEggA;
    //알보상
    public UISprite OneEggItem; //아이템 그림
    public UISprite OneEggItem2;
    public UISprite OneEggEagle;
    public UISprite OneEggDori;
    public UILabel OneEggName; //아이템 이름
    public UILabel OneEggGet; //아이템 갯수
    public UILabel OneEggType; //아이템 종류
    public UILabel OneEggNumber; //아이템 보유 갯수(여기다가 더하기)
    //코인보상
    public UILabel OneCoinGet;
    public UILabel OneCoinNumber;
    //2
    public UILabel TwoBuyA;
    public UILabel TwoBuyB;
    public UILabel TwoBuyC;

    //3
    public UISprite ThreeMainSprite;
    public UISprite ThreeMainSprite2;
    public UILabel ThreeBuyNumber; //아이템 보유갯수
    public UILabel ThreeBuyA;
    public UILabel ThreeBuyB;
    public UILabel ThreeBuyC;
    public UILabel ThreeBuyD;
    public UILabel ThreeBuyE;
    //4
    public GameObject FourMainSprite;
    public GameObject FourMainSprite2;
    public GameObject FourMainSprite3;
    public UILabel FourBuyNumber; //마일리지표시
    public UILabel FourBuyA;
    public UILabel FourBuyB;
    public UILabel FourBuyC;

    public GameObject OneBtn;
    public GameObject TwoBtn;
    public GameObject ThreeBtn;
    public GameObject FourBtn;

    public GameObject One;
    public GameObject OneBuyBtn;
    public GameObject OneBuyWindow;
    public GameObject OneBuyWindowA;
    public GameObject OneBuyWindowB;
    //알
    public GameObject EggWindow;
    public GameObject EggBackground;

    //마일리지
    public UISprite EggMileage; //마일리지에 따른 스프라이트
    private int Mileage; //최대10까지보관
    private int MileageX; //10이상시 1로 전환

    public UILabel Mileagetxt; //마일리지 증가량
    public UILabel MileageXtxt; //마일리지 x9 표시

    public UILabel Mileagetxt2; //마일리지상점에 표시될 부분
    public UISprite EggMileage2;
    //알보상
    public GameObject RewardCoin;
    public GameObject RewardItem;

    public GameObject Two;
    public GameObject TwoBuyWindow;

    public GameObject Three;
    public GameObject ThreeBuyWindow;

    public GameObject Four;
    public GameObject FourBuyWindow;

    public GameObject BuyNotion;
    public GameObject MaxNotion;
    public GameObject BuyNotNotionA; //다이아
    public GameObject BuyNotNotionB; //코인
    public GameObject UNITNotion;
    public GameObject EventNotion;
    public GameObject ComingNotion;
    public GameObject DoriNotion;
    public GameObject MileageNotion;
    public GameObject MileageOneNotion;

    private int screen = 0;
    private int BD;
    private int UNIT;
    private int DORI;
    private int ManDu;
    private int GoogleAds;
    private int CoinAds;
    private int EggSave;
    private int InfoEgg;
    private int OneNumber = 0;
    private int TwoNumber = 0;
    private int ThreeNumber = 0;
    private int FourNumber = 0;
    //1
    private int OneItemUNIT = 0;
    private int OneItemBD = 0;
    private int OneItemunit = 0;
    private int OneItembd = 0;
    private int OneNum = 0;
    private int OneUNIT = 0;
    private int OneBD = 0;
    //알
    private int OneEgg = 0;
    private bool EggAttack = false;
    private int OneEggValue = 0;
    private bool EggOpen = false;
    private bool Eggstart = false;

    public GameObject EggOK;
    public GameObject EggClick;
    //3
    public GameObject DiaBuy;
    private int ThreeItemUNIT = 0; //구매 아이템 기본 가격
    private int ThreeItemBD = 0;
    private int ThreeItemunit = 0;
    private int ThreeItembd = 0;
    private int ThreeNum = 0; //아이템 구매갯수
    private int ThreeUNIT; //구매시 유닛 가격
    private int ThreeBD; // 구매시 비디 가격
    private int HardTicket;

    //4
    private int FourMileage;
    //
    string Doristring = "도라의 깃털 ui";
    string Astring = "003_heart";
    string Bstring = "자석 ui";
    string Cstring = "미니 포션 ui";
    string Dstring = "1회용 해킹툴 ui";
    string Estring = "시간의 모래시계 ui";
    string Fstring = "디스코 뮤직박스 ui";
    string Gstring = "초능력 기압계 ui";
    string Hstring = "중국산 엔진오일 ui";

    string Kstring = "영구 해킹툴ui";

    string Doriname = "도라의 깃털";
    string Aname = "온전한 하트";
    string Bname = "자석";
    string Cname = "미니 포션";
    string Dname = "1회용 해킹툴";
    string Ename = "모래 시계";
    string Fname = "디스코 뮤직박스";
    string Gname = "초능력 기압계";
    string Hname = "중국산 엔진오일";

    string Kname = "영구 해킹툴";

    string TypeA = "퀘스트 아이템";
    string TypeB = "소비 아이템";
    string TypeC = "스킨 아이템";
    string TypeD = "앨범 아이템";
    //string Kstring = "i023";
    //
    private int Anum;
    private int Bnum;
    private int Cnum;
    private int Dnum;
    private int Enum;
    private int Fnum;
    private int Gnum;
    private int Hnum;

    private int Knum;
    //스킨
    private int BlackSkin;
    private int WhiteSkin;
    private int WowSkin;
    //독수리
    private int DoveEagle;
    private int DoveDori;

    //황금알해제
    private int GoldEgg;
    public GameObject goldegg;
    public GameObject EggHelp;

    //바로보여주기
    private int shopnum;
    public UIScrollBar bar;

    private AudioSource source;
    public AudioSource Mainsource;
    public AudioClip Click;
    public AudioClip Coin;
    public AudioClip Egg;

    public AudioClip EffectOne;
    public AudioClip EffectTwo;
    public AudioClip EffectThree;

    void Awake() {
        source = GetComponent<AudioSource>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Mileagetxt.text = " ";
        EggInfo.text = " ";

        ItemCheck(Anum, 3);
        ItemCheck(Bnum, 4);
        ItemCheck(Cnum, 5);
        ItemCheck(Dnum, 6);
        ItemCheck(Enum, 7);
        ItemCheck(Fnum, 8);

        GoldEgg = PlayerPrefs.GetInt("GoldEgg", 0);
        if(GoldEgg ==1)
        {
            goldegg.SetActive(true);
        }
        else
        {
            goldegg.SetActive(false);
        }

        EggClick.SetActive(false);
        EggOK.SetActive(false);

        OpenEffect.SetActive(false);
        OneEffect.SetActive(false);
        TwoEffect.SetActive(false);
        ThreeEffect.SetActive(false);

        One.SetActive(false);
        OneBuyBtn.SetActive(false);
        OneBuyWindow.SetActive(false);
        EggWindow.SetActive(false);
        EggBackground.SetActive(false);
        RewardCoin.SetActive(false);
        RewardItem.SetActive(false);

        Two.SetActive(false);
        TwoBuyWindow.SetActive(false);

        Three.SetActive(false);
        ThreeBuyWindow.SetActive(false);

        Four.SetActive(false);
        FourBuyWindow.SetActive(false);

        OneCheck.SetActive(false);
        TwoCheck.SetActive(false);
        ThreeCheck.SetActive(false);
        FourCheck.SetActive(false);

        GoogleAds = PlayerPrefs.GetInt("GoogleAds", 0);
        CoinAds = PlayerPrefs.GetInt("CoinAds", 0);
        EggSave = PlayerPrefs.GetInt("EggSave", 0);

        shopnum = PlayerPrefs.GetInt("Shop", 0);
        if(shopnum == 1)
        {
            two();
            bar.value = 1;
            PlayerPrefs.SetInt("Shop", 0);
        }
        else if(shopnum ==2)
        {
            two();
            bar.value = 0;
            PlayerPrefs.SetInt("Shop", 0);
        }
        else
        {
            bar.value = 0;
            PlayerPrefs.SetInt("Shop", 0);
        }

        StartCoroutine(ModeCheck());
    }
    void ItemCheck(int A, int B)
    {
        OneEggValue = B;
        if (A > 999)
        {
            A = 999;
            Save(A);
        }
    }
    void OnEnable()
    {
        UnityAdsHelper.UNITGet += UNITGet;
    }
    void OnDisable()
    {
        UnityAdsHelper.UNITGet -= UNITGet;
    }
    void UNITGet()
    {
        source.PlayOneShot(Coin, 0.75f);
        UNITNotion.SetActive(true);
    }
    IEnumerator ModeCheck()
    {
        BD = PlayerPrefs.GetInt("BD", 0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        DORI = PlayerPrefs.GetInt("DORI", 0);
        if(BD >= 99999)
        {
            BD = 99999;
            PlayerPrefs.SetInt("BD", BD);
        }

        if(UNIT >= 9999999)
        {
            UNIT = 9999999;
            PlayerPrefs.SetInt("UNIT", UNIT);
        }

        Anum = PlayerPrefs.GetInt("Anum", 0);
        Bnum = PlayerPrefs.GetInt("Bnum", 0);
        Cnum = PlayerPrefs.GetInt("Cnum", 0);
        Dnum = PlayerPrefs.GetInt("Dnum", 0);
        Enum = PlayerPrefs.GetInt("Enum", 0);
        Fnum = PlayerPrefs.GetInt("Fnum", 0);
        Gnum = PlayerPrefs.GetInt("Gnum", 0);
        Hnum = PlayerPrefs.GetInt("Hnum", 0);

        Knum = PlayerPrefs.GetInt("Knum", 0);

        HardTicket = PlayerPrefs.GetInt("HardTicket", 0);

        BlackSkin = PlayerPrefs.GetInt("BlackSkin", 0);
        WhiteSkin = PlayerPrefs.GetInt("WhiteSkin", 0);
        WowSkin = PlayerPrefs.GetInt("WowSkin", 0);
        DoveEagle = PlayerPrefs.GetInt("DoveEagle", 0);
        DoveDori = PlayerPrefs.GetInt("DoveDori", 0);

        InfoEgg = PlayerPrefs.GetInt("InfoEgg", 0);

        Mileage = PlayerPrefs.GetInt("Mileage", 0);
        MileageX = PlayerPrefs.GetInt("MileageX", 0);

        MileageXtxt.text = "X " + MileageX.ToString() + " 점";
        Mileagetxt2.text = "보유 마일리지 : " + MileageX.ToString() + "점 / 99점";
        EggMileage.fillAmount = Mileage * 0.1f;
        EggMileage2.fillAmount = MileageX * 0.011f;

        if (Mileage >= 10)
        {
            if (MileageX < 100)
            {
                Mileage -= 10;
                MileageX += 1;
                PlayerPrefs.SetInt("Mileage", Mileage);
                PlayerPrefs.SetInt("MileageX", MileageX);
            }
            else
            {
                Mileage = 99;
                PlayerPrefs.SetInt("Mileage", Mileage);
            }
        }

        bd.text = BD.ToString();
        unit.text = UNIT.ToString();
        dori.text = DORI.ToString();

        OneBuyB.text = OneNum.ToString();
        OneBuyC.text = OneItemUNIT.ToString();
        OneBuyD.text = OneItemBD.ToString();
        OneBuyE.text = OneItemUNIT.ToString();
        OneBuyF.text = OneNum.ToString();

        ThreeBuyC.text = ThreeNum.ToString();
        ThreeBuyD.text = ThreeItemUNIT.ToString();
        ThreeBuyE.text = ThreeItemBD.ToString();
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EggOpen == false)
            {
                if (screen == 0)
                {
                    PlayerPrefs.SetString("Scene", "MainScene");
                    SceneManager.LoadScene("LoadScene");
                }
                else if (screen == 1)
                {
                    screen = 0;
                    OneBtn.SetActive(true);
                    TwoBtn.SetActive(true);
                    ThreeBtn.SetActive(true);
                    FourBtn.SetActive(true);

                    One.SetActive(false);
                    Two.SetActive(false);
                    Three.SetActive(false);
                    Four.SetActive(false);
                }
                else if (screen == 2)
                {
                    screen = 1;
                    OneBuyWindow.SetActive(false);
                    TwoBuyWindow.SetActive(false);
                    ThreeBuyWindow.SetActive(false);
                    FourBuyWindow.SetActive(false);
                }
            }
        }
    }
    public void one()
    {
        source.PlayOneShot(Click, 0.75f);
        if(screen ==0)
        {
            screen = 1;
            OneBtn.SetActive(false);
            TwoBtn.SetActive(false);
            ThreeBtn.SetActive(false);
            FourBtn.SetActive(false);
            One.SetActive(true);
        }
    }
    public void OneClick1()
    {
        if(screen ==1)
        {
            source.PlayOneShot(Click, 0.75f);
            OneNumber = 1;
            Information.text = "\n비둘기가 갓 낳은 알입니다.\n맞습니다. 장물입니다. 안에는\n풍성한 선물이 기다리고 있답니다!\n들키기 전에 얼른 구매하세요!\n";
            EggInfo.text = "랜덤아이템 2 ~ 4개 , 후쿠시마 비둘기 스킨 , 영구 해킹툴";
            OneBuyBtn.SetActive(true);
            OneCheck.SetActive(true);
            TwoCheck.SetActive(false);
            ThreeCheck.SetActive(false);
            FourCheck.SetActive(false);
        }
    }
    public void OneClick2()
    {
        if(screen ==1)
        {
            source.PlayOneShot(Click, 0.75f);
            OneNumber = 2;
            Information.text = "\n자식을 강하게 키운다며\n알 홀로 내버려 두고 갔네요.\n이런 걸 지나칠 수 없죠. 안에는\n특별한 선물이 가득하답니다!\n";
            EggInfo.text = "랜덤아이템 4 ~ 7개 , 클로킹 비둘기 스킨 , 독수리 캐릭터";
            OneBuyBtn.SetActive(true);
            OneCheck.SetActive(false);
            TwoCheck.SetActive(true);
            ThreeCheck.SetActive(false);
            FourCheck.SetActive(false);
        }
    }
    public void OneClick3()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            OneNumber = 3;
            Information.text = "\n부엉이 알은 숲에서 아주 가끔\n구할 수 있는 희귀 알 입니다.\n어떻게 구해 왔냐구요?\n그런 건 묻지말고 얼른 사가세요!\n";
            EggInfo.text = "랜덤아이템 7 ~ 10개 , 와정대 비둘기 스킨 , 도라 캐릭터";
            OneBuyBtn.SetActive(true);
            OneCheck.SetActive(false);
            TwoCheck.SetActive(false);
            ThreeCheck.SetActive(true);
            FourCheck.SetActive(false);
        }
    }
    public void OneClick4()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            OneNumber = 4;
            Information.text = "\n황금알을 낳는 거위 라는 동화를\n아시나요? 맞습니다. 제가 그 거위의\n주인입니다. 거짓말인거 같다구요?\n일단 선 구매 후 생각해보시죠!\n";
            EggInfo.text = "모든 스킨 , 모든 캐릭터";
            OneBuyBtn.SetActive(true);
            OneCheck.SetActive(false);
            TwoCheck.SetActive(false);
            ThreeCheck.SetActive(false);
            FourCheck.SetActive(true);
        }
    }
    public void OneBuy()
    {
        source.PlayOneShot(Click, 0.75f);
        if (OneNumber == 1)
        {
            screen = 2;
            OneBuyWindow.SetActive(true);
            OneBuyWindowA.SetActive(true);
            OneBuyWindowB.SetActive(false);

            OneMainSprite.spriteName = "비둘기 알";
            OneBuyA.text = "비둘기 알";

            if(EggSave == 0)
            {
                OneItemUNIT = 2000;
                OneItemBD = 10;
            }
            else
            {
                OneItemUNIT = 1500;
                OneItemBD = 8;
            }
            OneItemunit = OneItemUNIT;
            OneItembd = OneItemBD;
            OneNum = 1;
        }
        else if(OneNumber ==2)
        {
            screen = 2;
            OneBuyWindow.SetActive(true);
            OneBuyWindowA.SetActive(true);
            OneBuyWindowB.SetActive(false);

            OneMainSprite.spriteName = "독수리알";
            OneBuyA.text = "독수리 알";

            if(EggSave == 0)
            {
                OneItemUNIT = 5000;
                OneItemBD = 25;
            }
            else
            {
                OneItemUNIT = 4000;
                OneItemBD = 18;
            }
            OneItemunit = OneItemUNIT;
            OneItembd = OneItemBD;
            OneNum = 1;
        }
        else if (OneNumber == 3)
        {
            screen = 2;
            OneBuyWindow.SetActive(true);
            OneBuyWindowA.SetActive(false);
            OneBuyWindowB.SetActive(true);

            OneItemUNIT = 3;
            OneItemunit = OneItemUNIT;
            OneNum = 1;
        }
        else if (OneNumber == 4)
        {
            screen = 2;
            OneBuyWindow.SetActive(true);
            OneBuyWindowA.SetActive(true);
            OneBuyWindowB.SetActive(false);

            OneMainSprite.spriteName = "황금알";
            OneBuyA.text = "황금 알";

            if(EggSave == 0)
            {
                OneItemUNIT = 30000;
                OneItemBD = 150;
            }
            else
            {
                OneItemUNIT = 24000;
                OneItemBD = 120;
            }
            OneItemunit = OneItemUNIT;
            OneItembd = OneItemBD;
            OneNum = 1;
        }
    }
    public void OneBuyUNIT()
    {
        source.PlayOneShot(Click, 0.75f);
        if (OneNumber == 1)
        {
            if (UNIT >= OneItemUNIT)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 2;
                UNIT -= OneItemUNIT;
                PlayerPrefs.SetInt("UNIT", UNIT);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "비둘기 알";
                OneMainEgg2.spriteName = "비둘기 알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                BuyNotNotionB.SetActive(false);
                BuyNotNotionB.SetActive(true);
            }
        }
        else if (OneNumber == 2)
        {
            if (UNIT >= OneItemUNIT)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 2;
                UNIT -= OneItemUNIT;
                PlayerPrefs.SetInt("UNIT", UNIT);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "독수리알";
                OneMainEgg2.spriteName = "독수리알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                BuyNotNotionB.SetActive(false);
                BuyNotNotionB.SetActive(true);
            }
        }
        else if (OneNumber == 3)
        {
            if (DORI >= OneItemUNIT)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 2;
                DORI -= OneItemUNIT;
                PlayerPrefs.SetInt("DORI", DORI);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "부엉이알";
                OneMainEgg2.spriteName = "부엉이알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                DoriNotion.SetActive(false);
                DoriNotion.SetActive(true);
            }
        }
        else if (OneNumber == 4)
        {
            if (UNIT >= OneItemUNIT)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 2;
                UNIT -= OneItemUNIT;
                PlayerPrefs.SetInt("UNIT", UNIT);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "황금알";
                OneMainEgg2.spriteName = "황금알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                BuyNotNotionB.SetActive(false);
                BuyNotNotionB.SetActive(true);
            }
        }
    }
    public void OneBuyBD()
    {
        source.PlayOneShot(Click, 0.75f);
        if (OneNumber == 1)
        {
            if (BD >= OneItemBD)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 1;
                BD -= OneItemBD;
                PlayerPrefs.SetInt("BD", BD);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "비둘기 알";
                OneMainEgg2.spriteName = "비둘기 알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                BuyNotNotionA.SetActive(false);
                BuyNotNotionA.SetActive(true);
            }
        }
        else if (OneNumber == 2)
        {
            if (BD >= OneItemBD)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 1;
                BD -= OneItemBD;
                PlayerPrefs.SetInt("BD", BD);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "독수리알";
                OneMainEgg2.spriteName = "독수리알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                BuyNotNotionA.SetActive(false);
                BuyNotNotionA.SetActive(true);
            }
        }
        else if (OneNumber == 3)
        {
            EventComing();
        }
        else if (OneNumber == 4)
        {
            if (BD >= OneItemBD)
            {
                source.PlayOneShot(Coin, 0.75f);
                screen = 1;
                BD -= OneItemBD;
                PlayerPrefs.SetInt("BD", BD);
                OneEgg = OneNum;

                BuyNotion.SetActive(false);
                BuyNotion.SetActive(true);
                OneBuyWindow.SetActive(false);

                OneBuing();

                OneMainEgg.spriteName = "황금알";
                OneMainEgg2.spriteName = "황금알";
                OneEggA.text = "X" + OneEgg.ToString();
            }
            else
            {
                BuyNotNotionA.SetActive(false);
                BuyNotNotionA.SetActive(true);
            }
        }
    }
    void OneBuing()
    {
        EggOpen = true;
        EggClick.SetActive(true);
        RewardCoin.SetActive(false);
        RewardItem.SetActive(false);
        EggWindow.SetActive(true);
        Mainsource.volume = 0.35f;
    }

    public void EventComing()
    {
        source.PlayOneShot(Click, 0.75f);
        EventNotion.SetActive(false);
        EventNotion.SetActive(true);
    }
    public void Coming()
    {
        source.PlayOneShot(Click, 0.75f);
        ComingNotion.SetActive(false);
        ComingNotion.SetActive(true);
    }

    public void OneUp()
    {
        source.PlayOneShot(Click, 0.75f);
        if (OneNum < 99)
        {
            OneNum += 1;
            OneItemUNIT = OneItemUNIT + OneItemunit;
            OneItemBD = OneItemBD + OneItembd;
        }
        else
        {
            OneNum = 1;
            OneItemUNIT = OneItemunit;
            OneItemBD = OneItembd;
        }
    }
    public void OneDown()
    {
        source.PlayOneShot(Click, 0.75f);
        if (OneNum > 1)
        {
            OneNum -= 1;
            OneItemUNIT = OneItemUNIT - OneItemunit;
            OneItemBD = OneItemBD - OneItembd;
        }
        else
        {
            OneNum = 99;
            OneItemUNIT = OneItemunit * 99;
            OneItemBD =OneItembd * 99;
        }
    }

    public void OneCancel()
    {
        source.PlayOneShot(Click, 0.75f);
        screen = 1;
        OneBuyWindow.SetActive(false);
    }

    IEnumerator EggStart()
    {
        if (OneNumber == 1)
        {
            OneMainEgg.spriteName = "비둘기 알";
            OneMainEgg2.spriteName = "비둘기 알";
        }
        else if (OneNumber == 2)
        {
            OneMainEgg.spriteName = "독수리알";
            OneMainEgg2.spriteName = "독수리알";
        }
        else if (OneNumber == 3)
        {
            OneMainEgg.spriteName = "부엉이알";
            OneMainEgg2.spriteName = "부엉이알";
        }
        else if (OneNumber == 4)
        {
            OneMainEgg.spriteName = "황금알";
            OneMainEgg2.spriteName = "황금알";
        }
        EggClick.SetActive(false);
        OpenEffect.SetActive(false);
        source.PlayOneShot(Egg, 1.5f);
        yield return new WaitForSeconds(0.2f);
        if (OneNumber == 1)
        {
            OneMainEgg.spriteName = "비둘기 알 반토막";
            OneMainEgg2.spriteName = "비둘기 알 반토막";
        }
        else if(OneNumber == 2)
        {
            OneMainEgg.spriteName = "독수리알 반토막";
            OneMainEgg2.spriteName = "독수리알 반토막";
        }
        else if (OneNumber == 3)
        {
            OneMainEgg.spriteName = "부엉이알 반토막";
            OneMainEgg2.spriteName = "부엉이알 반토막";
        }
        else if (OneNumber == 4)
        {
            OneMainEgg.spriteName = "황금알 반토막";
            OneMainEgg2.spriteName = "황금알 반토막";
        }
        OpenEffect.SetActive(true);
        InfoEgg += 1;
        PlayerPrefs.SetInt("InfoEgg", InfoEgg);
    }

    public void Eggattack()
    {
        if (EggAttack == false)
        {
            if (OneEgg > 0)
            {
                if (Eggstart == false)
                {
                    Eggstart = true;
                    StartCoroutine(EggStart());
                }
                EggBackground.SetActive(true);
                if (OneNumber == 1)
                {
                    EggAttack = true;
                    Eggstart = false;
                    OneEgg -= 1;
                    OneEggA.text = "X" + OneEgg.ToString();
                    StartCoroutine(DoveEggRandomReward());
                }
                else if (OneNumber == 2)
                {
                    EggAttack = true;
                    Eggstart = false;
                    OneEgg -= 1;
                    OneEggA.text = "X" + OneEgg.ToString();
                    StartCoroutine(EagleEggRandomReward());
                }
                else if (OneNumber == 3)
                {
                    EggAttack = true;
                    Eggstart = false;
                    OneEgg -= 1;
                    OneEggA.text = "X" + OneEgg.ToString();
                    StartCoroutine(OwlEggRandomReward());
                }
                else if(OneNumber ==4)
                {
                    EggAttack = true;
                    Eggstart = false;
                    OneEgg -= 1;
                    OneEggA.text = "X" + OneEgg.ToString();
                    StartCoroutine(MoleEggRandomReward());
                }
            }
            else
            {
                EggOK.SetActive(true);
            }
        }
    }   
    public void EggEnd()
    {
        EggOK.SetActive(false);
        OpenEffect.SetActive(false);
        OneEffect.SetActive(false);
        TwoEffect.SetActive(false);
        ThreeEffect.SetActive(false);
        screen = 1;
        EggOpen = false;
        Eggstart = false;
        EggWindow.SetActive(false);
        EggBackground.SetActive(false);
        Mainsource.volume = 1.0f;
        Mileagetxt.text = " ";
    }

    IEnumerator DoveEggRandomReward()
    {
        OneEggItem.enabled = true;
        OneEggItem2.enabled = true;
        OneEggEagle.enabled = false;
        OneEggDori.enabled = false;

        RewardCoin.SetActive(false);
        RewardItem.SetActive(false);
        int A = Random.Range(0, 100);
        int B = Random.Range(2, 5);
        int C = Random.Range(1, 2);
        if (A < 10)
        {
            Effecttwo();
            source.PlayOneShot(EffectTwo, 1.25f);
            OneEggValue = 1;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Doristring;
            OneEggItem2.spriteName = Doristring;
            OneEggName.text = Doriname;
            OneEggType.text = TypeA;
            //OneEggGet.text = "X" + C.ToString();
            OneEggGet.text = " ";
            OneEggNumber.text = DORI.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(DORI,C));
        }
        else if(A < 25)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 3;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Astring;
            OneEggItem2.spriteName = Astring;
            OneEggName.text = Aname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Anum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Anum, B));
        }
        else if(A < 40)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 4;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Bstring;
            OneEggItem2.spriteName = Bstring;
            OneEggName.text = Bname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Bnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Bnum, B));
        }
        else if(A < 55)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 5;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Cstring;
            OneEggItem2.spriteName = Cstring;
            OneEggName.text = Cname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Cnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Cnum, B));
        }
        else if(A < 70)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 6;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Dstring;
            OneEggItem2.spriteName = Dstring;
            OneEggName.text = Dname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Dnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Dnum, B));
        }
        //else if(A < 65)
        //{
        //    Effectone();
        //    source.PlayOneShot(EffectOne, 1.0f);
        //    OneEggValue = 7;
        //    RewardItem.SetActive(true);
        //    OneEggItem.spriteName = Estring;
        //    OneEggName.text = Ename;
        //    OneEggType.text = TypeB;
        //    OneEggGet.text = "X" + B.ToString();
        //    OneEggNumber.text = Enum.ToString() + "/999";
        //    yield return new WaitForSeconds(0.5f);
        //    StartCoroutine(Plus(Enum, B));
        //}
        else if(A < 80)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 8;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Fstring;
            OneEggItem2.spriteName = Fstring;
            OneEggName.text = Fname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Fnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Fnum, B));
        }
        else if (A < 90)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 9;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Gstring;
            OneEggItem2.spriteName = Gstring;
            OneEggName.text = Gname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Gnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Gnum, B));
        }
        else if (A < 95)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 10;
            RewardItem.SetActive(true);
            OneEggItem.spriteName =Hstring;
            OneEggItem2.spriteName = Hstring;
            OneEggName.text = Hname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Hnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Hnum, B));
        }

        else if(A < 100)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = "후쿠시마스킨ui";
            OneEggItem2.spriteName = "후쿠시마스킨ui";
            OneEggName.text = "후쿠시마 비둘기 스킨";
            OneEggType.text = TypeC;
            if(BlackSkin  ==0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = BlackSkin.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중" ;
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (BlackSkin ==0)
            {
                BlackSkin += C;
                C -= 1;
                OneEggNumber.text = BlackSkin.ToString() + "/1";
                PlayerPrefs.SetInt("BlackSkin", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 3000;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
    }
    IEnumerator EagleEggRandomReward()
    {
        OneEggItem.enabled = true;
        OneEggItem2.enabled = true;
        OneEggEagle.enabled = false;
        OneEggDori.enabled = false;

        RewardCoin.SetActive(false);
        RewardItem.SetActive(false);
        int A = Random.Range(0, 100);
        int B = Random.Range(4, 8);
        int C = Random.Range(1, 2);
        if (A < 10)
        {
            Effecttwo();
            source.PlayOneShot(EffectTwo, 1.25f);
            OneEggValue = 1;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Doristring;
            OneEggItem2.spriteName = Doristring;
            OneEggName.text = Doriname;
            OneEggType.text = TypeA;
            //OneEggGet.text = "X" + C.ToString();
            OneEggGet.text = " ";
            OneEggNumber.text = DORI.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(DORI, C));
        }
        else if (A < 25)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 3;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Astring;
            OneEggItem2.spriteName = Astring;
            OneEggName.text = Aname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Anum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Anum, B));
        }
        else if (A < 40)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 4;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Bstring;
            OneEggItem2.spriteName = Bstring;
            OneEggName.text = Bname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Bnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Bnum, B));
        }
        else if (A < 50)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 5;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Cstring;
            OneEggItem2.spriteName = Cstring;
            OneEggName.text = Cname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Cnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Cnum, B));
        }
        else if (A < 60)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 6;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Dstring;
            OneEggItem2.spriteName = Dstring;
            OneEggName.text = Dname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Dnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Dnum, B));
        }
        //else if (A < 65)
        //{
        //    Effectone();
        //    source.PlayOneShot(EffectOne, 1.0f);
        //    OneEggValue = 7;
        //    RewardItem.SetActive(true);
        //    OneEggItem.spriteName = Estring;
        //    OneEggName.text = Ename;
        //    OneEggType.text = TypeB;
        //    OneEggGet.text = "X" + B.ToString();
        //    OneEggNumber.text = Enum.ToString() + "/999";
        //    yield return new WaitForSeconds(0.5f);
        //    StartCoroutine(Plus(Enum, B));
        //}
        else if (A < 70)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 8;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Fstring;
            OneEggItem2.spriteName = Fstring;
            OneEggName.text = Fname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Fnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Fnum, B));
        }
        else if (A < 80)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 9;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Gstring;
            OneEggItem2.spriteName = Gstring;
            OneEggName.text = Gname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Gnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Gnum, B));
        }
        else if (A < 90)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 10;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Hstring;
            OneEggItem2.spriteName = Hstring;
            OneEggName.text = Hname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Hnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Hnum, B));
        }
        else if (A < 95)
        {
            OneEggItem.enabled = false;
            OneEggItem2.enabled = false;
            OneEggEagle.enabled = true;
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            //OneEggItem.spriteName = "Eagle4";
            OneEggName.text = "독수리 캐릭터";
            OneEggType.text = TypeD;
            if (DoveEagle == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = DoveEagle.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (DoveEagle == 0)
            {
                DoveEagle += C;
                C -= 1;
                OneEggNumber.text = DoveEagle.ToString() + "/1";
                PlayerPrefs.SetInt("DoveEagle", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 3000;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 100)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = "클로킹 스킨 ui";
            OneEggItem2.spriteName = "클로킹 스킨 ui";
            OneEggName.text = "클로킹 비둘기 스킨";
            OneEggType.text = TypeC;
            if (WhiteSkin == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = WhiteSkin.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (WhiteSkin == 0)
            {
                WhiteSkin += C;
                C -= 1;
                OneEggNumber.text = WhiteSkin.ToString() + "/1";
                PlayerPrefs.SetInt("WhiteSkin", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 2500;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
    }
    IEnumerator OwlEggRandomReward()
    {
        OneEggItem.enabled = true;
        OneEggItem2.enabled = true;
        OneEggEagle.enabled = false;
        OneEggDori.enabled = false;

        RewardCoin.SetActive(false);
        RewardItem.SetActive(false);
        int A = Random.Range(0, 100);
        int B = Random.Range(7, 11);
        int C = Random.Range(1, 2);
        if (A < 10)
        {
            Effecttwo();
            source.PlayOneShot(EffectTwo, 1.25f);
            OneEggValue = 1;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Doristring;
            OneEggItem2.spriteName = Doristring;
            OneEggName.text = Doriname;
            OneEggType.text = TypeA;
            //OneEggGet.text = "X" + C.ToString();
            OneEggGet.text = " ";
            OneEggNumber.text = DORI.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(DORI, C));
        }
        else if (A < 25)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 3;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Astring;
            OneEggItem2.spriteName = Astring;
            OneEggName.text = Aname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Anum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Anum, B));
        }
        else if (A < 40)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 4;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Bstring;
            OneEggItem2.spriteName = Bstring;
            OneEggName.text = Bname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Bnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Bnum, B));
        }
        else if (A < 50)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 5;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Cstring;
            OneEggItem2.spriteName = Cstring;
            OneEggName.text = Cname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Cnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Cnum, B));
        }
        else if (A < 60)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 6;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Dstring;
            OneEggItem2.spriteName = Dstring;
            OneEggName.text = Dname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Dnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Dnum, B));
        }
        //else if (A < 65)
        //{
        //    Effectone();
        //    source.PlayOneShot(EffectOne, 1.0f);
        //    OneEggValue = 7;
        //    RewardItem.SetActive(true);
        //    OneEggItem.spriteName = Estring;
        //    OneEggName.text = Ename;
        //    OneEggType.text = TypeB;
        //    OneEggGet.text = "X" + B.ToString();
        //    OneEggNumber.text = Enum.ToString() + "/999";
        //    yield return new WaitForSeconds(0.5f);
        //    StartCoroutine(Plus(Enum, B));
        //}
        else if (A < 70)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 8;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Fstring;
            OneEggItem2.spriteName = Fstring;
            OneEggName.text = Fname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Fnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Fnum, B));
        }
        else if (A < 80)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 9;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Gstring;
            OneEggItem2.spriteName = Gstring;
            OneEggName.text = Gname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Gnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Gnum, B));
        }
        else if (A < 90)
        {
            Effectone();
            source.PlayOneShot(EffectOne, 1.0f);
            OneEggValue = 10;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Hstring;
            OneEggItem2.spriteName = Hstring;
            OneEggName.text = Hname;
            OneEggType.text = TypeB;
            OneEggGet.text = "X" + B.ToString();
            OneEggNumber.text = Hnum.ToString() + "/999";
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Plus(Hnum, B));
        }
        else if (A < 95)
        {
            OneEggItem.enabled = false;
            OneEggItem2.enabled = false;
            OneEggDori.enabled = true;
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            //OneEggItem.spriteName = "Eagle4";
            OneEggName.text = "도라 캐릭터";
            OneEggType.text = TypeD;
            if (DoveDori == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = DoveDori.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (DoveDori == 0)
            {
                DoveDori += C;
                C -= 1;
                OneEggNumber.text = DoveDori.ToString() + "/1";
                PlayerPrefs.SetInt("DoveDori", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 3000;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 100)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = "와정대 ui";
            OneEggItem2.spriteName = "와정대 ui";
            OneEggName.text = "와정대 비둘기 스킨";
            OneEggType.text = TypeC;
            if (WowSkin == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = WowSkin.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (WowSkin == 0)
            {
                WowSkin += C;
                C -= 1;
                OneEggNumber.text = WowSkin.ToString() + "/1";
                PlayerPrefs.SetInt("WowSkin", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 2500;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
    }
    IEnumerator MoleEggRandomReward()
    {
        OneEggItem.enabled = true;
        OneEggItem2.enabled = true;
        OneEggEagle.enabled = false;
        OneEggDori.enabled = false;

        RewardCoin.SetActive(false);
        RewardItem.SetActive(false);
        int A = Random.Range(0, 100);
        int B = Random.Range(2, 5);
        int C = Random.Range(1, 2);
        if (A < 15)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = "후쿠시마스킨ui";
            OneEggItem2.spriteName = "후쿠시마스킨ui";
            OneEggName.text = "후쿠시마 비둘기 스킨";
            OneEggType.text = TypeC;
            if (BlackSkin == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = BlackSkin.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (BlackSkin == 0)
            {
                BlackSkin += C;
                C -= 1;
                OneEggNumber.text = BlackSkin.ToString() + "/1";
                PlayerPrefs.SetInt("BlackSkin", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 3000;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 30)
        {
            OneEggItem.enabled = false;
            OneEggItem2.enabled = false;
            OneEggEagle.enabled = true;
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            //OneEggItem.spriteName = "Eagle4";
            OneEggName.text = "독수리 캐릭터";
            OneEggType.text = TypeD;
            if (DoveEagle == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = DoveEagle.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = " 보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (DoveEagle == 0)
            {
                DoveEagle += C;
                C -= 1;
                OneEggNumber.text = DoveEagle.ToString() + "/1";
                PlayerPrefs.SetInt("DoveEagle", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 2500;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 45)
        {
            OneEggItem.enabled = false;
            OneEggItem2.enabled = false;
            OneEggDori.enabled = true;
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            //OneEggItem.spriteName = "Eagle4";
            OneEggName.text = "도라 캐릭터";
            OneEggType.text = TypeD;
            if (DoveDori == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = DoveDori.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (DoveDori == 0)
            {
                DoveDori += C;
                C -= 1;
                OneEggNumber.text = DoveDori.ToString() + "/1";
                PlayerPrefs.SetInt("DoveDori", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 2500;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 60)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = "클로킹 스킨 ui";
            OneEggItem2.spriteName = "클로킹 스킨 ui";
            OneEggName.text = "클로킹 비둘기 스킨";
            OneEggType.text = TypeC;
            if (WhiteSkin == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = WhiteSkin.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (WhiteSkin == 0)
            {
                WhiteSkin += C;
                C -= 1;
                OneEggNumber.text = WhiteSkin.ToString() + "/1";
                PlayerPrefs.SetInt("WhiteSkin", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 3000;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 75)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = "와정대 ui";
            OneEggItem2.spriteName = "와정대 ui";
            OneEggName.text = "와정대 비둘기 스킨";
            OneEggType.text = TypeC;
            if (WowSkin == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = WowSkin.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (WowSkin == 0)
            {
                WowSkin += C;
                C -= 1;
                OneEggNumber.text = WowSkin.ToString() + "/1";
                PlayerPrefs.SetInt("WowSkin", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 3000;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else if (A < 100)
        {
            Effectthree();
            source.PlayOneShot(EffectThree, 1.5f);
            OneEggValue = 99;
            RewardItem.SetActive(true);
            OneEggItem.spriteName = Kstring;
            OneEggItem2.spriteName = Kstring;
            OneEggName.text = Kname;
            OneEggType.text = TypeB;
            if (Knum == 0)
            {
                OneEggGet.text = " 잠금해제! ";
                OneEggNumber.text = Knum.ToString() + "/1";
                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                OneEggGet.text = "보유중";
                OneEggNumber.text = "최대 한도 초과!";
                yield return new WaitForSeconds(1.5f);
            }
            if (Knum == 0)
            {
                Knum += C;
                C -= 1;
                OneEggNumber.text = Knum.ToString() + "/1";
                PlayerPrefs.SetInt("Knum", 1);
                EggAttack = false;
            }
            else
            {
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = 2500;
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
    }

    void Effectone()
    {
        OneEffect.SetActive(false);
        TwoEffect.SetActive(false);
        ThreeEffect.SetActive(false);
        OneEffect.SetActive(true);
        Mileagetxt.text = "+ 1";
        Mileage += 1;
        PlayerPrefs.SetInt("Mileage",Mileage);
    }
    void Effecttwo()
    {
        OneEffect.SetActive(false);
        TwoEffect.SetActive(false);
        ThreeEffect.SetActive(false);
        OneEffect.SetActive(true);
        TwoEffect.SetActive(true);
        Mileagetxt.text = "+ 2";
        Mileage += 2;
        PlayerPrefs.SetInt("Mileage", Mileage);
    }
    void Effectthree()
    {
        OneEffect.SetActive(false);
        TwoEffect.SetActive(false);
        ThreeEffect.SetActive(false);
        OneEffect.SetActive(true);
        TwoEffect.SetActive(true);
        ThreeEffect.SetActive(true);
        Mileagetxt.text = "+ 3";
        Mileage += 3;
        PlayerPrefs.SetInt("Mileage", Mileage);
    }

    IEnumerator Plus(int A , int B) //A에다가 B를 더한다
    {
        if (B > 0)
        {
            if (A < 999)
            {
                B -= 1;
                A += 1;
                OneEggNumber.text = A.ToString() + "/999";
            }
            else
            {
                Save(A);
                OneEggNumber.text = " 최대 한도 초과!";
                yield return new WaitForSeconds(1.0f);
                RewardItem.SetActive(false);
                RewardCoin.SetActive(true);
                int Coin = (B * 50);
                OneCoinGet.text = "+" + Coin.ToString();
                OneCoinNumber.text = UNIT.ToString();
                StopAllCoroutines();
                StartCoroutine(ModeCheck());
                StartCoroutine(PlusCoin(UNIT, Coin));
            }
        }
        else
        {
            Save(A);
            StopAllCoroutines();
            StartCoroutine(ModeCheck());
            EggAttack = false;
        }
        yield return new WaitForSeconds(0.03f);
        StartCoroutine(Plus(A,B));
    }
    IEnumerator PlusCoin(int A, int B)
    {
        if(B > 0)
        {
            if (B > 100)
            {
                B -= 100;
                A += 100;
            }
            else
            {
                B -= 10;
                A += 10;
            }
            OneCoinNumber.text = A.ToString();
        }
        else
        {
            if(A >= 9999999)
            {
                A = 9999999;
            }
            PlayerPrefs.SetInt("UNIT", A);
            StopAllCoroutines();
            StartCoroutine(ModeCheck());
            EggAttack = false;
        }
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(PlusCoin(A, B));
    }

    void Save(int A)
    {
        if (OneEggValue == 1)
        {
            PlayerPrefs.SetInt("DORI", A);
        }
        //else if (OneEggValue == 2)
        //{
        //    PlayerPrefs.SetInt("ManDu", A);
        //}
        else if (OneEggValue == 3)
        {
            PlayerPrefs.SetInt("Anum", A);
        }
        else if (OneEggValue == 4)
        {
            PlayerPrefs.SetInt("Bnum", A);
        }
        else if (OneEggValue == 5)
        {
            PlayerPrefs.SetInt("Cnum", A);
        }
        else if (OneEggValue == 6)
        {
            PlayerPrefs.SetInt("Dnum", A);
        }
        else if (OneEggValue == 7)
        {
            PlayerPrefs.SetInt("Enum", A);
        }
        else if (OneEggValue == 8)
        {
            PlayerPrefs.SetInt("Fnum", A);
        }
        else if (OneEggValue == 9)
        {
            PlayerPrefs.SetInt("Gnum", A);
        }
        else if (OneEggValue == 10)
        {
            PlayerPrefs.SetInt("Hnum", A);
        }
        else if (OneEggValue == 13)
        {
            PlayerPrefs.SetInt("Knum", A);
        }
    }
    /// //////////////////////////////////////////////////////////////////////////////////////////
    public void two()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            OneBtn.SetActive(false);
            TwoBtn.SetActive(false);
            ThreeBtn.SetActive(false);
            FourBtn.SetActive(false);
            Two.SetActive(true);
        }
    }
    public void TwoClick1()
    {
        if(screen ==1)
        {
            source.PlayOneShot(Click, 0.75f);
            TwoNumber = 1;
            screen = 2;
            TwoBuyWindow.SetActive(true);
            TwoBuyA.text = "코인 주머니를 구매하시겠습니까?";
            TwoBuyB.text = "그리고 코인 10000개를 받으세요.";
            TwoBuyC.text = "10";
        }
    }
    public void TwoClick2()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            TwoNumber = 2;
            screen = 2;
            TwoBuyWindow.SetActive(true);
            TwoBuyA.text = "코인 바구니를 구매하시겠습니까?";
            TwoBuyB.text = "그리고 코인 50000개를 받으세요.";
            TwoBuyC.text = "50";
        }
    }
    public void TwoClick3()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            TwoNumber = 3;
            screen = 2;
            TwoBuyWindow.SetActive(true);
            TwoBuyA.text = "코인 통을 구매하시겠습니까?";
            TwoBuyB.text = "그리고 코인 100000개를 받으세요.";
            TwoBuyC.text = "100";
        }
    }
    public void TwoClick4()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            TwoNumber = 4;
            screen = 2;
            TwoBuyWindow.SetActive(true);
            TwoBuyA.text = "코인 수레를 구매하시겠습니까?";
            TwoBuyB.text = "그리고 코인 500000개를 받으세요.";
            TwoBuyC.text = "500";
        }
    }
    public void TwoClick5()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            TwoNumber = 5;
            screen = 2;
            TwoBuyWindow.SetActive(true);
            TwoBuyA.text = "코인 더미를 구매하시겠습니까?";
            TwoBuyB.text = "그리고 코인 1000000개를 받으세요.";
            TwoBuyC.text = "1000";
        }
    }
    public void TwoBuy()
    {
        source.PlayOneShot(Click, 0.75f);
        if (TwoNumber ==1)
        {
            if (UNIT + 10000 <= 9999999)
            {
                if (BD >= 10)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= 10;
                    PlayerPrefs.SetInt("BD", BD);
                    UNIT += 10000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    TwoBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (TwoNumber == 2)
        {
            if (UNIT + 50000 <= 9999999)
            {
                if (BD >= 50)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= 50;
                    PlayerPrefs.SetInt("BD", BD);
                    UNIT += 50000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    TwoBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if(TwoNumber == 3)
        {
            if (UNIT + 100000 <= 9999999)
            {
                if (BD >= 100)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= 100;
                    PlayerPrefs.SetInt("BD", BD);
                    UNIT += 100000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    TwoBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if(TwoNumber == 4)
        {
            if (UNIT + 500000 <= 9999999)
            {
                if (BD >= 500)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= 500;
                    PlayerPrefs.SetInt("BD", BD);
                    UNIT += 500000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    TwoBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (TwoNumber == 5)
        {
            if (UNIT + 1000000 <= 9999999)
            {
                if (BD >= 1000)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= 1000;
                    PlayerPrefs.SetInt("BD", BD);
                    UNIT += 1000000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    TwoBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
    }
    public void TwoCancel()
    {
        source.PlayOneShot(Click, 0.75f);
        screen = 1;
        TwoBuyWindow.SetActive(false);
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////
    public void three()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            OneBtn.SetActive(false);
            TwoBtn.SetActive(false);
            ThreeBtn.SetActive(false);
            FourBtn.SetActive(false);
            Three.SetActive(true);
        }
    }
    public void ThreeClick1()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 1;
            screen = 2;

            ThreeItemUNIT = 1000;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 0;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(false);

            ThreeMainSprite.spriteName = Astring;
            ThreeMainSprite2.spriteName = Astring;
            ThreeBuyA.text = "온전한 하트";
            ThreeBuyB.text = "HP를 일정 회복시킵니다.\n이걸 먹는다면 최소\n굶어 죽지는 않겠죠!";
            ThreeBuyNumber.text = "보유중 : " + Anum.ToString();
        }
    }
    public void ThreeClick2()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 2;
            screen = 2;

            ThreeItemUNIT = 1000;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 5;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = Bstring;
            ThreeMainSprite2.spriteName = Bstring;
            ThreeBuyA.text = "자석";
            ThreeBuyB.text = "특수한 자기력을 이용해\n주변에 만두가 있을 시\n자신에게 당겨올 수 있습니다.";
            ThreeBuyNumber.text = "보유중 : " + Bnum.ToString();
        }
    }
    public void ThreeClick3()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 3;
            screen = 2;

            ThreeItemUNIT = 1000;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 5;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = Cstring;
            ThreeMainSprite2.spriteName = Cstring;
            ThreeBuyA.text = "미니포션";
            ThreeBuyB.text = "잠시동안 몸이 작아지고\n비행속도도 빨라지며\n구멍도 통과 가능해집니다";
            ThreeBuyNumber.text = "보유중 : "+Cnum.ToString();
        }
    }
    public void ThreeClick4()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 4;
            screen = 2;

            ThreeItemUNIT = 1500;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 7;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = Dstring;
            ThreeMainSprite2.spriteName = Dstring;
            ThreeBuyA.text = "1회용 해킹툴";
            ThreeBuyB.text = "시스템을 해킹해 잠시 동안\n스코어 획득량이 2배로\n늘어납니다! 와우!!";
            ThreeBuyNumber.text = "보유중 : "+Dnum.ToString();
        }
    }
    public void ThreeClick5()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 5;
            screen = 2;

            ThreeItemUNIT = 2000;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 10;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = Estring;
            ThreeMainSprite2.spriteName = Estring;
            ThreeBuyA.text = "시간의 모래시계";
            ThreeBuyB.text = "3초전으로 시간을\n되돌립니다 엥? 이거\n완전 트레... 읍읍";
            ThreeBuyNumber.text = "보유중 : " + Enum.ToString();
        }
    }
    public void ThreeClick6()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 6;
            screen = 2;

            ThreeItemUNIT = 1000;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 5;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = Fstring;
            ThreeMainSprite2.spriteName = Fstring;
            ThreeBuyA.text = "디스코 뮤직박스";
            ThreeBuyB.text = "배경음악이 신나는 힙합\n디스코 음악으로 바뀝니다.\n덩~실~덩~실";
            ThreeBuyNumber.text = "보유중 : " + Fnum.ToString();
        }
    }
    public void ThreeClick7()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 7;
            screen = 2;

            ThreeItemUNIT = 1000;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 5;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = Gstring;
            ThreeMainSprite2.spriteName = Gstring;
            ThreeBuyA.text = "초능력 기압계";
            ThreeBuyB.text = "초능력이 깃든 기압계를\n이용해 날씨의 속성을 반대로\n변화시킵니다. 뽀로롱~";
            ThreeBuyNumber.text = "보유중 : " + Gnum.ToString();
        }
    }

    public void ThreeClickHard()
    {
        if (screen == 1)
        {
            source.PlayOneShot(Click, 0.75f);
            ThreeNumber = 9;
            screen = 2;

            ThreeItemUNIT = 1500;
            ThreeItemunit = ThreeItemUNIT;
            ThreeItemBD = 10;
            ThreeItembd = ThreeItemBD;
            ThreeNum = 1;
            ThreeBuyWindow.SetActive(true);
            DiaBuy.SetActive(true);

            ThreeMainSprite.spriteName = "하드모드 티켓";
            ThreeMainSprite2.spriteName = "하드모드 티켓";
            ThreeBuyA.text = "하드모드 입장권";
            ThreeBuyB.text = "하드모드를 1회 입장을\n가능하게 해줍니다.\n한번 신나게 달려볼까요?";
            ThreeBuyNumber.text = "보유중 : " + HardTicket.ToString();
        }
    }

    public void ThreeBuyUNIT()
    {
        source.PlayOneShot(Click, 0.75f);
        if (ThreeNumber ==1)
        {
            if(Anum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Anum += ThreeNum;
                    PlayerPrefs.SetInt("Anum", Anum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 2)
        {
            if (Bnum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Bnum += ThreeNum;
                    PlayerPrefs.SetInt("Bnum", Bnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 3)
        {
            if (Cnum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Cnum += ThreeNum;
                    PlayerPrefs.SetInt("Cnum", Cnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 4)
        {
            if (Dnum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Dnum += ThreeNum;
                    PlayerPrefs.SetInt("Dnum", Dnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 5)
        {
            if (Enum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Enum += ThreeNum;
                    PlayerPrefs.SetInt("Enum", Enum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 6)
        {
            if (Fnum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Fnum += ThreeNum;
                    PlayerPrefs.SetInt("Fnum", Fnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 7)
        {
            if (Fnum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Gnum += ThreeNum;
                    PlayerPrefs.SetInt("Gnum", Gnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 8)
        {
            if (Hnum + ThreeNum < 1000)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    Hnum += ThreeNum;
                    PlayerPrefs.SetInt("Hnum", Hnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 9)
        {
            if (HardTicket + ThreeNum < 100)
            {
                if (UNIT > ThreeItemUNIT)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    UNIT -= ThreeItemUNIT;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    HardTicket += ThreeNum;
                    PlayerPrefs.SetInt("HardTicket", HardTicket);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionB.SetActive(false);
                    BuyNotNotionB.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
    }
    public void ThreeBuyBD()
    {
        source.PlayOneShot(Click, 0.75f);
        if (ThreeNumber == 1)
        {
            if (Anum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Anum += ThreeNum;
                    PlayerPrefs.SetInt("Anum", Anum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 2)
        {
            if (Bnum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Bnum += ThreeNum;
                    PlayerPrefs.SetInt("Bnum", Bnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 3)
        {
            if (Cnum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Cnum += ThreeNum;
                    PlayerPrefs.SetInt("Cnum", Cnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 4)
        {
            if (Dnum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Dnum += ThreeNum;
                    PlayerPrefs.SetInt("Dnum", Dnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 5)
        {
            if (Enum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Enum += ThreeNum;
                    PlayerPrefs.SetInt("Enum", Enum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 6)
        {
            if (Fnum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Fnum += ThreeNum;
                    PlayerPrefs.SetInt("Fnum", Fnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 7)
        {
            if (Fnum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Gnum += ThreeNum;
                    PlayerPrefs.SetInt("Gnum", Gnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 8)
        {
            if (Hnum + ThreeNum < 1000)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    Hnum += ThreeNum;
                    PlayerPrefs.SetInt("Hnum", Hnum);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
        else if (ThreeNumber == 9)
        {
            if (HardTicket + ThreeNum < 100)
            {
                if (BD > ThreeItemBD)
                {
                    source.PlayOneShot(Coin, 0.75f);
                    screen = 1;
                    BD -= ThreeItemBD;
                    PlayerPrefs.SetInt("BD", BD);
                    HardTicket += ThreeNum;
                    PlayerPrefs.SetInt("HardTicket", HardTicket);
                    BuyNotion.SetActive(false);
                    BuyNotion.SetActive(true);
                    ThreeBuyWindow.SetActive(false);
                }
                else
                {
                    BuyNotNotionA.SetActive(false);
                    BuyNotNotionA.SetActive(true);
                }
            }
            else
            {
                MaxNotion.SetActive(false);
                MaxNotion.SetActive(true);
            }
        }
    }
    public void ThreeUp()
    {
        source.PlayOneShot(Click, 0.75f);
        if (ThreeNum < 99)
        {
            ThreeNum += 1;
            ThreeItemUNIT= ThreeItemUNIT + ThreeItemunit;
            ThreeItemBD = ThreeItemBD + ThreeItembd;
        }
        else
        {
            ThreeNum = 1;
            ThreeItemUNIT = ThreeItemunit;
            ThreeItemBD = ThreeItembd;
        }
    }
    public void ThreeDown()
    {
        source.PlayOneShot(Click, 0.75f);
        if (ThreeNum > 1)
        {
            ThreeNum -= 1;
            ThreeItemUNIT = ThreeItemUNIT - ThreeItemunit;
            ThreeItemBD = ThreeItemBD - ThreeItembd;
        }
        else
        {
            ThreeNum = 99;
            ThreeItemUNIT = ThreeItemunit * 99;
            ThreeItemBD = ThreeItembd * 99;
        }
    }
    /// //////////////////////////////////////////////////////////////////////////////////////////////
    public void four()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            OneBtn.SetActive(false);
            TwoBtn.SetActive(false);
            ThreeBtn.SetActive(false);
            FourBtn.SetActive(false);
            Four.SetActive(true);
        }
    }
    public void FourClick1()
    {
        source.PlayOneShot(Click, 0.75f);
        if(screen ==1)
        {
            screen = 2;
            FourNumber = 1;
            FourMileage = 50;
            FourBuyWindow.SetActive(true);
            FourMainSprite.SetActive(true);
            FourMainSprite2.SetActive(false);
            FourMainSprite3.SetActive(false);
            FourBuyNumber.text = "마일리지 "+FourMileage.ToString()+"점";
            FourBuyA.text = "광고 제거";
            FourBuyB.text = "기쁨 , 해방";
            FourBuyC.text = "갑툭튀 광고를 제거할 수 있습니다.";
        }
    }
    public void FourClick2()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            FourNumber = 2;
            FourMileage = 40;
            FourBuyWindow.SetActive(true);
            FourMainSprite.SetActive(false);
            FourMainSprite2.SetActive(true);
            FourMainSprite3.SetActive(false);
            FourBuyNumber.text = "마일리지 " + FourMileage.ToString() + "점";
            FourBuyA.text = "알 영구 할인권";
            FourBuyB.text = "알 무한 뽑기";
            FourBuyC.text = "알을 영구적으로 25% 할인됩니다.";
        }
    }
    public void FourClick3()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            FourNumber = 3;
            FourMileage = 30;
            FourBuyWindow.SetActive(true);
            FourMainSprite.SetActive(false);
            FourMainSprite2.SetActive(false);
            FourMainSprite3.SetActive(true);
            FourBuyNumber.text = "마일리지 " + FourMileage.ToString() + "점";
            FourBuyA.text = "코인 2배";
            FourBuyB.text = "코인 부자";
            FourBuyC.text = "획득 코인을 영구적으로 2배 늘려줍니다.";
        }
    }
    public void FourBuy()
    {
        source.PlayOneShot(Click, 0.75f);
        if (FourNumber == 1)
        {
            if (GoogleAds == 0)
            {
                if (MileageX >= FourMileage)
                {
                    FourBuyWindow.SetActive(false);
                    BuyNotion.SetActive(true);
                    MileageX -= FourMileage;
                    PlayerPrefs.SetInt("MileageX", MileageX);
                    GoogleAds = 1;
                    PlayerPrefs.SetInt("GoogleAds", 1);
                    screen = 1;
                }
                else
                {
                    MileageNotion.SetActive(false);
                    MileageNotion.SetActive(true);
                }
            }
            else
            {
                MileageOneNotion.SetActive(false);
                MileageOneNotion.SetActive(true);
            }
        }
        else if (FourNumber == 2)
        {
            if (EggSave == 0)
            {
                if (MileageX >= FourMileage)
                {
                    FourBuyWindow.SetActive(false);
                    BuyNotion.SetActive(true);
                    MileageX -= FourMileage;
                    PlayerPrefs.SetInt("MileageX", MileageX);
                    EggSave = 1;
                    PlayerPrefs.SetInt("EggSave", EggSave);
                    screen = 1;
                }
                else
                {
                    MileageNotion.SetActive(false);
                    MileageNotion.SetActive(true);
                }
            }
            else
            {
                MileageOneNotion.SetActive(false);
                MileageOneNotion.SetActive(true);
            }
        }
        else if(FourNumber == 3)
        {
            if (CoinAds == 0)
            {
                if (MileageX >= FourMileage)
                {
                    FourBuyWindow.SetActive(false);
                    BuyNotion.SetActive(true);
                    MileageX -= FourMileage;
                    PlayerPrefs.SetInt("MileageX", MileageX);
                    CoinAds = 1;
                    PlayerPrefs.SetInt("CoinAds", 1);
                    screen = 1;
                }
                else
                {
                    MileageNotion.SetActive(false);
                    MileageNotion.SetActive(true);
                }
            }
            else
            {
                MileageOneNotion.SetActive(false);
                MileageOneNotion.SetActive(true);
            }
        }
    }

    public void Exit()
    {
        if(screen ==0)
        {
            PlayerPrefs.SetString("Scene", "MainScene");
            SceneManager.LoadScene("LoadScene");
        }
        else if(screen ==1)
        {
            OneBtn.SetActive(true);
            TwoBtn.SetActive(true);
            ThreeBtn.SetActive(true);
            FourBtn.SetActive(true);
            screen = 0;
            One.SetActive(false);
            Two.SetActive(false);
            Three.SetActive(false);
            Four.SetActive(false);
        }
        else if(screen ==2)
        {
            screen = 1;
            OneBuyWindow.SetActive(false);
            TwoBuyWindow.SetActive(false);
            ThreeBuyWindow.SetActive(false);
            FourBuyWindow.SetActive(false);
            EggHelp.SetActive(false);
        }
    }
    public void Diamond()
    {
        PlayerPrefs.SetInt("DORI", 999);
    }

    public void eggHelp()
    {
        source.PlayOneShot(Click, 0.75f);
        if(screen ==1)
        {
            screen = 2;
            EggHelp.SetActive(true);
        }
    }
}
