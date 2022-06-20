using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    public GameObject MainUI;

    public UILabel Title;
    public UILabel bd;
    public UILabel unit;
    public UILabel highScore;
    public UILabel hardticket;
    public UILabel albumNum;
    public UILabel Rank;

    public UIToggle black;
    public UIToggle white;
    public UIToggle eagle;
    public UIToggle dori;
    public UIToggle hidden;

    public BoxCollider MainDove;

    public UISprite blacksp;
    public UISprite whitesp;
    public UISprite eaglesp;
    public UISprite dorisp;
    public UISprite hiddensp;

    public GameObject AlbumOne;
    public GameObject AlbumTwo;
    public GameObject AlbumThree;
    public GameObject AlbumFour;
    public GameObject AlbumFive;
    public GameObject AlbumSix;

    public UILabel Mainskilla;
    public UILabel Mainskillb;

    private int MainSkillNumber;

    public GameObject exit; //게임종료
    public GameObject album;
    public GameObject title;
    public GameObject skin;
    public GameObject option;
    public GameObject achievements;
    public GameObject Bag;
    //public GameObject PlayerInf;
    //public GameObject Collection;
    //public GameObject CollectionA;
    //public GameObject CollectionB;
    //public GameObject Ranking;
    public GameObject Language;
    public GameObject Mode;
    public GameObject AdInfo; //광고 주의사항
    public GameObject quest;
    public GameObject help;
    public GameObject tutorialchoice;
    public GameObject gpa;
    public GameObject upgrade;
    public GameObject GameLv;
    public GameObject GameBag; //아이템없음 주머니추천
    public GameObject DataClear;
    public GameObject Event;
    public GameObject EventHelp;
    public GameObject Rankhelp;
    public GameObject Treasure;
    public GameObject MasterBook;

    public UISprite WindowBlack;
    public GameObject Cupoon;
    //public GameObject Icon;
    public GameObject UNITNotion;
    public GameObject Rightnow;

    //튜토리얼
    public GameObject Talkbar;
    public GameObject Nextbar;
    public GameObject Vector;
    public UILabel Talktxt;
    private int Tutorial;
    public GameObject TutorialReward;
    private int TalkNumber = 0;
    private int ForthNumber;

    private int BD;
    private int UNIT;
    private int HighScore;
    private int HardTicket;
    private int GPA;
    private int Patch;
    private int Patch2;
    private int Patch3;
    private int Hard;
    private int NoItem;

    public static int screen =0;

    private int Dove;

    private int Mmute;
    private int Emute;

    private int AlbumNum = 0;
    private int ToggelNum;

    private int DoveEagle;
    private int BuyNumber;
    private int DoveDori;
    private int DoveHidden;

    public GameObject EagleLock;
    public UILabel EagleMsg;
    public GameObject DoriLock;
    public UILabel DoriMsg;
    public GameObject BuyWindow;

    public GameObject EagleNew;
    public GameObject DoriNew;
    public GameObject HiddenNew;

    public GameObject CoinNot;
    public GameObject DiaNot;
    public GameObject EagleUnLock;
    public GameObject DoriUnLock;
    public GameObject GPAUnLock;
    public GameObject HardNot;

    public UILabel BuyA; //제목
    public UILabel BuyB; //코인가격
    public UILabel BuyC; //다이아가격

    private AudioSource source;
    public AudioClip Click;
    public AudioClip Coin;
    public AudioClip EffectThree;

    public delegate void select();
    public static event select DoveOne , DoveTwo , DoveThree , DoveFour , ChangeSkin , Nick , DoveCheck , DoveFive;

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        source = GetComponent<AudioSource>();

        BuyWindow.SetActive(false);
        EagleLock.SetActive(false);
        DoriLock.SetActive(false);
        AdInfo.SetActive(false);

        Talkbar.SetActive(false);
        Vector.SetActive(false);

        EagleNew.SetActive(false);
        DoriNew.SetActive(false);

        BD = PlayerPrefs.GetInt("BD", 0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        HighScore = PlayerPrefs.GetInt("TOT_High", 0);
        if(HighScore <= 500)
        {
            Rank.text = "없음";
            PlayerPrefs.SetInt("Rank", 0);
        }
        else if (HighScore <= 1000)
        {
            Rank.text = "알";
            PlayerPrefs.SetInt("Rank", 1);
        }
        else if (HighScore <= 2000)
        {
            Rank.text = "병아리";
            PlayerPrefs.SetInt("Rank", 2);
        }
        else if (HighScore <= 4000)
        {
            Rank.text = "참새";
            PlayerPrefs.SetInt("Rank", 3);
        }
        else if (HighScore <= 7000)
        {
            Rank.text = "비둘기";
            PlayerPrefs.SetInt("Rank", 4);
        }
        else if (HighScore <= 11000)
        {
            Rank.text = "닭둘기";
            PlayerPrefs.SetInt("Rank", 5);
        }
        else
        {
            Rank.text = "삼계탕";
            PlayerPrefs.SetInt("Rank", 6);
        }
        Dove = PlayerPrefs.GetInt("Dove", 0);
        DoveEagle = PlayerPrefs.GetInt("DoveEagle", 0);
        if(DoveEagle ==1)
        {
            EagleNew.SetActive(true);
        }
        DoveDori = PlayerPrefs.GetInt("DoveDori", 0);
        if (DoveDori == 1)
        {
            DoriNew.SetActive(true);
        }
        Tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        GPA = PlayerPrefs.GetInt("GPA", 0);

        Patch = PlayerPrefs.GetInt("Patch", 0);
        if(Patch ==0)
        {
            PlayerPrefs.SetInt("HeartNumber", 1);
            PlayerPrefs.SetInt("SkillNumber", 1);
            PlayerPrefs.SetInt("HitNumber", 1);
            PlayerPrefs.SetInt("CoinNumber", 1);
            PlayerPrefs.SetInt("HardTicket", 5);

            PlayerPrefs.SetInt("EventA", 99);
            PlayerPrefs.SetInt("EventB", 99);
            PlayerPrefs.SetInt("EventC", 99);

            PlayerPrefs.SetInt("SHRIMP", 10);

            PlayerPrefs.SetInt("Patch", 1);
        }

        Patch2 = PlayerPrefs.GetInt("Patch2", 0);
        if(Patch2 ==0)
        {
            PlayerPrefs.SetInt("ContinueNumber", 1);
            PlayerPrefs.SetInt("CoinPlusNumber", 1);

            PlayerPrefs.SetInt("Patch2", 1);
        }

        Patch3 = PlayerPrefs.GetInt("Patch3", 0);
        if (Patch3 == 0)
        {
            PlayerPrefs.SetInt("SkinStateA", 0);
            PlayerPrefs.SetInt("SkinStateB", 0);
            PlayerPrefs.SetInt("SkinStateC", 0);

            PlayerPrefs.SetInt("Patch3", 1);
        }
        HardTicket = PlayerPrefs.GetInt("HardTicket", 0);
        MainSkillNumber = PlayerPrefs.GetInt("MainSkillNumber", 0);

        Rightnow.SetActive(false);
        UNITNotion.SetActive(false);

        AlbumOne.SetActive(true);
        AlbumTwo.SetActive(true);
        AlbumThree.SetActive(false);
        AlbumFour.SetActive(false);
        AlbumFive.SetActive(false);
        AlbumSix.SetActive(false);

        StartCoroutine(ModeCheck());
    }
    void Start()
    {
        Bag.SetActive(true);
        Bag.SetActive(false);
        achievements.SetActive(true);
        achievements.SetActive(false);
        quest.SetActive(true);
        quest.SetActive(false);

        if (Tutorial == 0)
        {
            screen = 4;
            TutorialReward.SetActive(true);
        }
        else
        {
            screen = 0;
            TutorialReward.SetActive(false);
            Nick();
        }

        if (Dove == 0)
        {
            ToggelNum = 0;
        }
        else if (Dove == 1)
        {
            ToggelNum = 1;
        }
        else if (Dove == 2)
        {
            ToggelNum = 2;
        }
        else if (Dove == 3)
        {
            ToggelNum = 3;
        }
        else if(Dove ==4)
        {
            ToggelNum = 4;
        }

        if (HighScore >= 300)
        {
            if (GPA == 0)
            {
                gpa.SetActive(true);
            }
        }

        if(HighScore >= 5000)
        {
            PlayerPrefs.SetInt("GoldEgg", 1);
        }
    }
    void OnEnable()
    {
        Option.click += click;
        Quest.Click += click;
        AchieveManager.Click += click;
        UpgradeManager.Click += click;
        EventManager.Click += click;
        InventoryManager.Click += click;

        Quest.Coin += coin;
        AchieveManager.Coin += coin;
        UpgradeManager.Coin += coin;
        EventManager.Coin += coin;
        InventoryManager.Coin += coin;

        UnityAdsHelper.UNITGet += UNITGet;
    }
    void OnDisable()
    {
        Option.click -= click;
        Quest.Click -= click;
        AchieveManager.Click -= click;
        UpgradeManager.Click -= click;
        EventManager.Click -= click;
        InventoryManager.Click -= click;

        Quest.Coin -= coin;
        AchieveManager.Coin -= coin;
        UpgradeManager.Coin -= coin;
        EventManager.Coin -= coin;
        InventoryManager.Coin -= coin;

        UnityAdsHelper.UNITGet -= UNITGet;
    }
    void click()
    {
        source.PlayOneShot(Click, 0.75f);
    }
    void coin()
    {
        source.PlayOneShot(Coin, 0.75f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (screen == 0)
            {
                source.PlayOneShot(Click, 0.75f);
                screen = 1;
                exit.SetActive(true);
                //WindowBlack.enabled = true;
            }
            else if (screen == 1)
            {
                screen = 0;
                MainUI.SetActive(true);
                WindowBlack.enabled = false;
            }
            else if (screen == 2)
            {
                screen = 1;
            }
            else if(screen ==3)
            {
                screen = 2;
            }
        }
    }
    IEnumerator ModeCheck()
    {
        BD = PlayerPrefs.GetInt("BD", 0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        bd.text = BD.ToString();
        unit.text = UNIT.ToString();
        highScore.text = HighScore.ToString();
        hardticket.text = "입장권 : " + HardTicket.ToString() + "개 보유";

        DoveHidden = PlayerPrefs.GetInt("DoveHidden", 0);
        NoItem = PlayerPrefs.GetInt("NoItem", 0);

        if (screen ==0)
        {
            MasterBook.SetActive(false);
            exit.SetActive(false);
            album.SetActive(false);
            option.SetActive(false);
            //Icon.SetActive(false);
            achievements.SetActive(false);
            //PlayerInf.SetActive(false);
            Bag.SetActive(false);
            //Collection.SetActive(false);
            //Ranking.SetActive(false);
            quest.SetActive(false);
            upgrade.SetActive(false);
            GameLv.SetActive(false);
            Event.SetActive(false);
        }
        else if(screen ==1)
        {
            title.SetActive(false);
            Treasure.SetActive(false);
            skin.SetActive(false);
            Language.SetActive(false);
            Cupoon.SetActive(false);
            //CollectionA.SetActive(false);
            //CollectionB.SetActive(false);
            Mode.SetActive(false);
            AdInfo.SetActive(false);
            help.SetActive(false);
            tutorialchoice.SetActive(false);
            DataClear.SetActive(false);
            EventHelp.SetActive(false);
            GameBag.SetActive(false);
            Rankhelp.SetActive(false);
        }
        if(screen > 0)
        {
            MainDove.enabled = false;
        }
        else
        {
            MainDove.enabled = true;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ModeCheck());
    }
    //비둘기변경 유일하게 앨범만 여기서 관리!!
    public void BuyExit()
    {
        source.PlayOneShot(Click, 0.75f);
        BuyWindow.SetActive(false);
    }
    public void BuyEagle()
    {
        source.PlayOneShot(Click, 0.75f);
        BuyWindow.SetActive(true);
        BuyA.text = "독수리를 즉시 오픈 하시겠습니까?";
        BuyB.text = "60000";
        BuyC.text = "300";
        BuyNumber = 1;
    }
    public void BuyDori()
    {
        source.PlayOneShot(Click, 0.75f);
        BuyWindow.SetActive(true);
        BuyA.text = "도라를 즉시 오픈 하시겠습니까?";
        BuyB.text = "120000";
        BuyC.text = "600";
        BuyNumber = 2;
    }
    public void BuyCoin()
    {
        source.PlayOneShot(Click, 0.75f);
        if (BuyNumber == 1)
        {
            if(UNIT >= 60000)
            {            
                BuyWindow.SetActive(false);
                EagleUnLock.SetActive(false);
                EagleUnLock.SetActive(true);
                source.PlayOneShot(EffectThree, 0.75f);

                DoveEagle = 1;
                PlayerPrefs.SetInt("DoveEagle", 1);
                EagleLock.SetActive(false);
                EagleMsg.enabled = true;

                //오픈 이펙트 필요
                UNIT -= 60000;
                PlayerPrefs.SetInt("UNIT", UNIT);
            }
            else
            {
                CoinNot.SetActive(false);
                CoinNot.SetActive(true);
            }
        }
        else if(BuyNumber == 2)
        {
            if (UNIT >= 120000)
            {
                BuyWindow.SetActive(false);
                DoriUnLock.SetActive(false);
                DoriUnLock.SetActive(true);
                source.PlayOneShot(EffectThree, 0.75f);

                DoveDori = 1;
                PlayerPrefs.SetInt("DoveDori", 1);
                DoriLock.SetActive(false);
                DoriMsg.enabled = true;

                //오픈 이펙트 필요
                UNIT -= 120000;
                PlayerPrefs.SetInt("UNIT", UNIT);
            }
            else
            {
                CoinNot.SetActive(false);
                CoinNot.SetActive(true);
            }

        }
    }
    public void BuyDiamond()
    {
        source.PlayOneShot(Click, 0.75f);
        if (BuyNumber == 1)
        {
            if (BD >= 300)
            {
                BuyWindow.SetActive(false);
                EagleUnLock.SetActive(false);
                EagleUnLock.SetActive(true);
                source.PlayOneShot(EffectThree, 0.75f);

                DoveEagle = 1;
                PlayerPrefs.SetInt("DoveEagle", 1);
                EagleNew.SetActive(true);
                EagleLock.SetActive(false);
                EagleMsg.enabled = true;

                //오픈 이펙트 필요
                BD -= 500;
                PlayerPrefs.SetInt("BD", BD);
            }
            else
            {
                DiaNot.SetActive(false);
                DiaNot.SetActive(true);
            }
        }
        if (BuyNumber == 2)
        {
            if (BD >= 600)
            {
                BuyWindow.SetActive(false);
                DoriUnLock.SetActive(false);
                DoriUnLock.SetActive(true);
                source.PlayOneShot(EffectThree, 0.75f);

                DoveDori = 1;
                PlayerPrefs.SetInt("DoveDori", 1);
                DoriNew.SetActive(true);
                DoriLock.SetActive(false);
                DoriMsg.enabled = true;

                //오픈 이펙트 필요
                BD -= 1100;
                PlayerPrefs.SetInt("BD", BD);
            }
            else
            {
                DiaNot.SetActive(false);
                DiaNot.SetActive(true);
            }
        }
    }

    public void Album()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            album.SetActive(true);
            AlbumNum = 0;
            AlbumOne.SetActive(true);
            AlbumTwo.SetActive(true);
            AlbumThree.SetActive(false);
            AlbumFour.SetActive(false);
            AlbumFive.SetActive(false);
            AlbumSix.SetActive(false);

            EagleLock.SetActive(false);
            DoriLock.SetActive(false);
            ToggleCheck();
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
            if(DoveHidden >= 1)
            {
                albumNum.text = "1 / 3";
            }
            else
            {
                albumNum.text = "1 / 2";
            }
        }
    }

    void ToggleCheck()
    {
        if (ToggelNum == 0)
        {
            black.value = true;
            white.value = false;
            eagle.value = false;
            dori.value = false;
            hidden.value = false;

            blacksp.enabled = true;
            whitesp.enabled = false;
            eaglesp.enabled = false;
            dorisp.enabled = false;
            hiddensp.enabled = false;
        }
        else if (ToggelNum == 1)
        {
            black.value = false;
            white.value = true;
            eagle.value = false;
            dori.value = false;
            hidden.value = false;

            blacksp.enabled = false;
            whitesp.enabled = true;
            eaglesp.enabled = false;
            dorisp.enabled = false;
            hiddensp.enabled = false;
        }
        else if (ToggelNum == 2)
        {
            black.value = false;
            white.value = false;
            eagle.value = true;
            dori.value = false;
            hidden.value = false;

            blacksp.enabled = false;
            whitesp.enabled = false;
            eaglesp.enabled = true;
            dorisp.enabled = false;
            hiddensp.enabled = false;
        }
        else if (ToggelNum == 3)
        {
            black.value = false;
            white.value = false;
            eagle.value = false;
            dori.value = true;
            hidden.value = false;

            blacksp.enabled = false;
            whitesp.enabled = false;
            eaglesp.enabled = false;
            dorisp.enabled = true;
            hiddensp.enabled = false;
        }
        else if (ToggelNum == 4)
        {
            black.value = false;
            white.value = false;
            eagle.value = false;
            dori.value = false;
            hidden.value = true;

            blacksp.enabled = false;
            whitesp.enabled = false;
            eaglesp.enabled = false;
            dorisp.enabled = false;
            hiddensp.enabled = true;
        }
    }

    public void Black()
    {
        source.PlayOneShot(Click, 0.75f);
        Dove = 0;
        PlayerPrefs.SetInt("Dove", Dove);
        DoveOne();
        ToggelNum = 0;
        ToggleCheck();
    }
    public void White()
    {
        source.PlayOneShot(Click, 0.75f);
        Dove = 1;
        PlayerPrefs.SetInt("Dove", Dove);
        DoveTwo();
        ToggelNum = 1;
        ToggleCheck();
    }
    public void Eagle()
    {
        source.PlayOneShot(Click, 0.75f);
        Dove = 2;
        PlayerPrefs.SetInt("Dove", Dove);
        DoveThree();
        ToggelNum = 2;
        ToggleCheck();

        if(DoveEagle ==1)
        {
            PlayerPrefs.SetInt("DoveEagle", 2);
            EagleNew.SetActive(false);
            DoveCheck();
        }
    }
    public void Dori()
    {
        source.PlayOneShot(Click, 0.75f);
        Dove = 3;
        PlayerPrefs.SetInt("Dove", Dove);
        DoveFour();
        ToggelNum = 3;
        ToggleCheck();

        if (DoveDori == 1)
        {
            PlayerPrefs.SetInt("DoveDori", 2);
            DoriNew.SetActive(false);
            DoveCheck();
        }
    }
    public void Hidden()
    {
        source.PlayOneShot(Click, 0.75f);
        Dove = 4;
        PlayerPrefs.SetInt("Dove", Dove);
        DoveFive();
        ToggelNum = 4;
        ToggleCheck();
    }

    public void MainSkillA()
    {
        source.PlayOneShot(Click, 0.75f);
        MainSkillNumber = 0;
        PlayerPrefs.SetInt("MainSkillNumber", MainSkillNumber);
        Mainskilla.text = "높이날기(사용중)";
        Mainskillb.text = "에그어택";
    }
    public void MainSkillB()
    {
        source.PlayOneShot(Click, 0.75f);
        MainSkillNumber = 1;
        PlayerPrefs.SetInt("MainSkillNumber", MainSkillNumber);
        Mainskilla.text = "높이날기";
        Mainskillb.text = "에그어택(사용중)";
    }

    public void NextPage()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen < 2)
        {
            if (AlbumNum == 0)
            {
                AlbumNum = 1;
                AlbumOne.SetActive(false);
                AlbumTwo.SetActive(false);
                AlbumThree.SetActive(true);
                AlbumFour.SetActive(true);
                ToggleCheck();
                if(DoveEagle ==0)
                {
                    EagleLock.SetActive(true);
                    EagleMsg.enabled = false;
                }
                if(DoveDori ==0)
                {
                    DoriLock.SetActive(true);
                    DoriMsg.enabled = false;
                }
                if (DoveHidden >= 1)
                {
                    albumNum.text = "2 / 3";
                }
                else
                {
                    albumNum.text = "2 / 2";
                }
            }
            else if (AlbumNum == 1)
            {
                if(DoveHidden >=1)
                {
                    AlbumNum = 2;
                    AlbumThree.SetActive(false);
                    AlbumFour.SetActive(false);
                    AlbumFive.SetActive(true);
                    AlbumSix.SetActive(true);
                    EagleLock.SetActive(false);
                    DoriLock.SetActive(false);
                    ToggleCheck();
                    if(MainSkillNumber == 0)
                    {
                        Mainskilla.text = "높이날기(사용중)";
                    }
                    else
                    {
                        Mainskillb.text = "에그어택(사용중)";
                    }
                    albumNum.text = "3 / 3";
                }
            }
        }
    }
    public void BackPage()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen < 2)
        {
            if (AlbumNum == 0)
            {

            }
            else if (AlbumNum == 1)
            {
                AlbumNum = 0;
                AlbumOne.SetActive(true);
                AlbumTwo.SetActive(true);
                AlbumThree.SetActive(false);
                AlbumFour.SetActive(false);
                ToggleCheck();
                EagleLock.SetActive(false);
                DoriLock.SetActive(false);
                if (DoveHidden >= 1)
                {
                    albumNum.text = "1 / 3";
                }
                else
                {
                    albumNum.text = "1 / 2";
                }
            }
            else if (AlbumNum == 2)
            {
                if (DoveHidden >= 1)
                {
                    AlbumNum = 1;
                    AlbumThree.SetActive(true);
                    AlbumFour.SetActive(true);
                    AlbumFive.SetActive(false);
                    AlbumSix.SetActive(false);
                    ToggleCheck();
                    if (DoveEagle == 0)
                    {
                        EagleLock.SetActive(true);
                        EagleMsg.enabled = false;
                    }
                    if (DoveDori == 0)
                    {
                        DoriLock.SetActive(true);
                        DoriMsg.enabled = false;
                    }
                    if (DoveHidden >= 1)
                    {
                        albumNum.text = "2 / 3";
                    }
                    else
                    {
                        albumNum.text = "2 / 2";
                    }
                }
            }
        }
    }
    //
    public void GameExit()
    {
        PlayerPrefs.SetInt("Count", 0);
        Application.Quit();
    }
    public void Exit()
    {
        BuyWindow.SetActive(false);
        if (screen ==1)
        {
            source.PlayOneShot(Click, 0.75f);
            screen = 0;
            MainUI.SetActive(true);
            WindowBlack.enabled = false;
        }
        else if(screen == 2)
        {
            source.PlayOneShot(Click, 0.75f);
            screen = 1;
        }
        else if(screen ==4)
        {
            screen = 3;
            WindowBlack.enabled = false;
            achievements.SetActive(false);
            ForthNumber = PlayerPrefs.GetInt("ForthNumber", 0);
            if(ForthNumber == 1)
            {
                TalkNumber = 1;
                Nextbtn();
            }
        }
    }
    //
    void UNITGet()
    {
        source.PlayOneShot(Coin, 0.75f);
        UNITNotion.SetActive(true);
    }
    //곧출시됩니다
    public void incoming()
    {
        source.PlayOneShot(Click, 0.75f);
        Rightnow.SetActive(false);
        Rightnow.SetActive(true);
    }
    public void URL()
    {
        Application.OpenURL("http://m.blog.naver.com/burningdiamond");
    }
    public void GoogleURL()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.BuringDiamond.doveintheCity");
    }
    public void bag()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            Bag.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }

    public void gameLv()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            if(Dove == 4)
            {
                SceneManager.LoadScene(9);
            }
            else
            {
                screen = 1;
                GameLv.SetActive(true);
                WindowBlack.enabled = true;
                WindowBlack.alpha = 0.4f;
            }
        }
    }
    public void GameStart() //게임시작
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            Hard = 0;
            PlayerPrefs.SetInt("Hard", 0);
            if (HighScore < 1000)
            {
                if (NoItem == 0)
                {
                    screen = 2;
                    GameBag.SetActive(true);
                }
                else
                {
                    SceneManager.LoadScene(3);
                }
            }
            else
            {
                SceneManager.LoadScene(3);
            }
        }
    }
    public void GameStartHard()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            if(HardTicket >= 1)
            {
                Hard = 1;
                PlayerPrefs.SetInt("Hard", 1);
                if (HighScore < 1000)
                {
                    if (NoItem == 0)
                    {
                        screen = 2;
                        GameBag.SetActive(true);
                    }
                    else
                    {
                        HardTicket -= 1;
                        PlayerPrefs.SetInt("HardTicket", HardTicket);
                        SceneManager.LoadScene(3);
                    }
                }
                else
                {
                    HardTicket -= 1;
                    PlayerPrefs.SetInt("HardTicket", HardTicket);
                    SceneManager.LoadScene(3);
                }
            }
            else
            {
                HardNot.SetActive(false);
                HardNot.SetActive(true);
            }
        }
    }

    public void BagGo()
    {
        source.PlayOneShot(Click, 0.75f);
        screen = 0;
        GameLv.SetActive(false);
        GameBag.SetActive(false);
        WindowBlack.enabled = false;
        bag();
    } //주머니갈께용
    public void NoStart() //걍시작
    {
        if(Hard ==1)
        {
            HardTicket -= 1;
            PlayerPrefs.SetInt("HardTicket", HardTicket);
        }
        SceneManager.LoadScene(3);
    }

    public void Shop()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen ==0)
        {
            SceneManager.LoadScene(5);
        }
    }
    public void GoldShop()
    {
        source.PlayOneShot(Click, 0.75f);
        PlayerPrefs.SetInt("Shop", 1);
        if (screen == 0)
        {
            SceneManager.LoadScene(5);
        }
    }
    public void DiaShop()
    {
        source.PlayOneShot(Click, 0.75f);
        PlayerPrefs.SetInt("Shop", 2);
        if (screen == 0)
        {
            SceneManager.LoadScene(5);
        }
    }
    public void BagShop()
    {
        screen = 0;
        SceneManager.LoadScene(5);
    }
    //public void Talk()
    //{
    //    if(Dove < 2)
    //    {
    //        screen = 0;
    //        SceneManager.LoadScene(9);
    //    }
    //    else
    //    {
    //        source.PlayOneShot(Click, 0.75f);
    //        Rightnow.SetActive(false);
    //        Rightnow.SetActive(true);
    //    }
    //}
    public void TitleChange()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            title.SetActive(true);
        }
    } //안쓰임
    public void TreasureChange()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            Treasure.SetActive(true);
        }
    }
    public void Masterbook()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            MasterBook.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    public void SkinChange()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            skin.SetActive(true);
            ChangeSkin();
        }
    }
    public void OptionChange()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            option.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    public void Achievements()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            achievements.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
        else if(screen == 3)
        {
            screen = 4;
            achievements.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    //public void Playerinformation()
    //{
    //    source.PlayOneShot(Click, 0.75f);
    //    if (screen == 0)
    //    {
    //        screen = 1;
    //        PlayerInf.SetActive(true);
    //    }
    //}
    public void cupoon()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            Cupoon.SetActive(true);
        }
    }
    public void LanguageSetting()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            Language.SetActive(true);
        }
    }
    public void ModeInfo()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            Mode.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    public void tutorial()
    {
        screen = 0;
        SceneManager.LoadScene(6);
    }
    public void Ad()
    {
        source.PlayOneShot(Click, 0.75f);
        Rankhelp.SetActive(false);
        AdInfo.SetActive(true);
    }
    public void QuestChange()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            quest.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    public void Help()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            help.SetActive(true);
        }
    }
    public void RankHelp()
    {
        source.PlayOneShot(Click, 0.75f);
        AdInfo.SetActive(false);
        Rankhelp.SetActive(true);
    }
    public void Upgrade()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            upgrade.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    public void EventCheck()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 0)
        {
            screen = 1;
            Event.SetActive(true);
            WindowBlack.enabled = true;
            WindowBlack.alpha = 0.4f;
        }
    }
    public void Eventhelp()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            EventHelp.SetActive(true);
        }
    }
    public void Dataclear()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            DataClear.SetActive(true);
        }
    }
    public void DataDel()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
    public void MiniGame()
    {
        if(DoveHidden >= 1)
        {
            if(Dove >=4)
            {
                screen = 0;
                SceneManager.LoadScene(11);
            }
            else
            {
                source.PlayOneShot(Click, 0.75f);
                Rightnow.SetActive(false);
                Rightnow.SetActive(true);
            }
        }
        else
        {
            source.PlayOneShot(Click, 0.75f);
            Rightnow.SetActive(false);
            Rightnow.SetActive(true);
        }
    }
    /// ///////////////////////////////////////////////////////
    public void Tutorialchoice()
    {
        source.PlayOneShot(Click, 0.75f);
        if (screen == 1)
        {
            screen = 2;
            tutorialchoice.SetActive(true);
        }
    }
    public void TutorialReplayA()
    {
        screen = 0;
        SceneManager.LoadScene(6);
    }
    public void TutorialReplayB()
    {
        WindowBlack.enabled = false;
        album.SetActive(false);
        tutorialchoice.SetActive(false);
        help.SetActive(false);
        Talkbar.SetActive(true);
        Vector.SetActive(true);
        TalkNumber = 1;
        Nextbtn();
    }
    /// ///////////////////////////////////////////////////////
    public void Reward()
    {
        TutorialReward.SetActive(false);
        UNIT += 50000;
        PlayerPrefs.SetInt("UNIT", UNIT);
        BD += 50;
        PlayerPrefs.SetInt("BD", BD);
        Talkbar.SetActive(true);
        Vector.SetActive(true);
        Vector.transform.localPosition = new Vector3(-140, -390, 0);
        Tutorial = 1;
        PlayerPrefs.SetInt("Tutorial", Tutorial);
        Nextbtn();
    }
    public void Nextbtn()
    {
        source.PlayOneShot(Click, 0.75f);
        if (TalkNumber == 0)
        {
            Talktxt.text = "\n업적을 클릭해 보상을 받습니다.\n\n";
            screen = 3;
        }
        else if (TalkNumber == 1)
        {
            TalkNumber = 3;
            Talktxt.text = "\n상점에서 사거나, 얻은 아이템을\n주머니에 착용할 수 있습니다.\n";
            Vector.transform.localPosition = new Vector3(-70, -390, 0);
        }
        else if (TalkNumber == 3)
        {
            TalkNumber = 4;
            Talktxt.text = "\n둥지에서 캐릭터와 스킨을\n바꿀 수 있습니다.\n";
            Vector.transform.localPosition = new Vector3(140, -390, 0);
        }
        else if (TalkNumber == 4)
        {
            TalkNumber = 5;
            Talktxt.text = "\n임무를 완료해 보상을 받을 수 있습니다.\n\n";
            Vector.transform.localPosition = new Vector3(70, -390, 0);
        }
        else if (TalkNumber == 5)
        {
            TalkNumber = 8;
            Talkbar.GetComponent<Transform>().transform.localPosition = new Vector3(0, -185, 0);
            Talktxt.text = "\n강화를 통해 자신의 조류를 \n진화 시킬 수 있습니다.\n";
            Vector.transform.localPosition = new Vector3(135, 330, 0);
            Vector.transform.localRotation = Quaternion.identity;
        }
        else if (TalkNumber == 8)
        {
            TalkNumber = 9;
            Talktxt.text = "\n진짜 모험의 세계에선 튜토리얼에 없는\n예측불허의 상황이 가득합니다... 만\n";
            Vector.SetActive(false);
        }
        else if (TalkNumber == 9)
        {
            TalkNumber = 10;
            Talktxt.text = "\n자세한 설명은 생략합니다.\n\n";
            Vector.SetActive(false);
        }
        else if (TalkNumber == 10)
        {
            TalkNumber = 11;
            Talktxt.text = "\n튜토리얼은 둥지에서\n다시 볼 수 있습니다.\n";
            Vector.SetActive(false);
        }
        else if (TalkNumber == 11)
        {
            Talkbar.SetActive(false);
            screen = 0;
            Nick();
        }
    }
    /// ///////////////////////////////////////////////////////
    public void GPAOK()
    {
        gpa.SetActive(false);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.BuringDiamond.DoveintheCity");
        GPA = 1;
        PlayerPrefs.SetInt("GPA", GPA);
        BD += 50;
        PlayerPrefs.SetInt("BD", BD);
        source.PlayOneShot(Coin, 0.75f);
        GPAUnLock.SetActive(false);
        GPAUnLock.SetActive(true);
    }
    public void GPANO()
    {
        gpa.SetActive(false);
        WindowBlack.enabled = false;
        GPA = 1;
        PlayerPrefs.SetInt("GPA", GPA);
    }

    //public void collection()
    //{
    //    source.PlayOneShot(Click, 0.75f);
    //    if (screen == 0)
    //    {
    //        MainUI.SetActive(false);
    //        screen = 1;
    //        Collection.SetActive(true);
    //    }
    //}
    //public void collectionA()
    //{
    //    source.PlayOneShot(Click, 0.75f);
    //    if (screen == 1)
    //    {
    //        //Rightnow.SetActive(false);
    //        //Rightnow.SetActive(true);
    //        screen = 2;
    //        CollectionA.SetActive(true);
    //    }
    //}
    //public void collectionB()
    //{
    //    source.PlayOneShot(Click, 0.75f);
    //    if (screen == 1)
    //    {
    //        Rightnow.SetActive(false);
    //        Rightnow.SetActive(true);
    //        //screen = 2;
    //        //CollectionB.SetActive(true);
    //    }
    //}
}