using UnityEngine;
using System.Collections;

public class AchieveManager : MonoBehaviour {
    //1번째 업적
    private int AdsNumber;
    private int FirstNumber; //진행상황

    public UILabel FirstCoin; //보상코인갯수
    public UILabel FirstPlan; //몇번을 해야되는지
    public UILabel Firstlabel; //진행 상황 글자
    public UISprite Firstsp; //진행 상황 그림
    public GameObject Firsting;
    public GameObject FirstReward;
    public GameObject Firstfalse; //왼쪽 하단 업적완료시 비활성화
    public GameObject FirstClear; //업적 완료시 활성화
    //하트
    public UISprite FirstA;
    public UISprite FirstB;
    public UISprite FirstC;
    public UISprite FirstD;
    public UISprite FirstE;
    //2번째 업적
    private int HighScore;
    private int SecondNumber;

    public UILabel SecondCoin;
    public UILabel SecondPlan;
    public UILabel Secondlabel;
    public UISprite Secondsp;
    public GameObject Seconding;
    public GameObject SecondReward;
    public GameObject Secondfalse;
    public GameObject SecondClear;
    //하트
    public UISprite SecondA;
    public UISprite SecondB;
    public UISprite SecondC;
    public UISprite SecondD;
    public UISprite SecondE;
    public UISprite SecondF;
    public UISprite SecondG;
    public UISprite SecondH;
    public UISprite SecondI;
    public UISprite SecondJ;
    //3번째 업적
    private int Touchdove;
    private int ThirdNumber;

    public UILabel ThirdCoin;
    public UILabel ThirdPlan;
    public UILabel Thirdlabel;
    public UISprite Thirdsp;
    public GameObject Thirding;
    public GameObject ThirdReward;
    public GameObject Thirdfalse;
    public GameObject ThirdClear;
    //하트
    public UISprite ThirdA;

    //4번째 업적
    private int QuestNumber;
    private int ForthNumber;

    public UILabel ForthCoin;
    public UILabel ForthPlan;
    public UILabel Forthlabel;
    public UISprite Forthsp;
    public GameObject Forthing;
    public GameObject ForthReward;
    public GameObject Forthfalse;
    public GameObject ForthClear;
    //하트
    public UISprite ForthA;
    public UISprite ForthB;
    public UISprite ForthC;
    public UISprite ForthD;
    public UISprite ForthE;
    public UISprite ForthF;
    public UISprite ForthG;
    public UISprite ForthH;
    public UISprite ForthI;
    public UISprite ForthJ;
    //5번째 업적
    private int InfoLevel;
    private int FifthNumber;

    public UILabel FifthCoin;
    public UILabel FifthPlan;
    public UILabel Fifthlabel;
    public UISprite Fifthsp;
    public GameObject Fifthing;
    public GameObject FifthReward;
    public GameObject Fifthfalse;
    public GameObject FifthClear;

    public UISprite FifthA;
    public UISprite FifthB;
    public UISprite FifthC;
    public UISprite FifthD;
    public UISprite FifthE;
    public UISprite FifthF;
    public UISprite FifthG;
    public UISprite FifthH;
    public UISprite FifthI;
    public UISprite FifthJ;

    //6번째 업적
    private int InfoHidden;
    private int SixthNumber;

    public UILabel SixthCoin;
    public UILabel SixthPlan;
    public UILabel Sixthlabel;
    public UISprite Sixthsp;
    public GameObject Sixthing;
    public GameObject SixthReward;
    public GameObject Sixthfalse;
    public GameObject SixthClear;

    public UISprite SixthA;
    public UISprite SixthB;
    public UISprite SixthC;
    public UISprite SixthD;
    public UISprite SixthE;

    //7번째 업적
    private int InfoTalk;
    private int SeventhNumber;

    public UILabel SeventhCoin;
    public UILabel SeventhPlan;
    public UILabel Seventhlabel;
    public UISprite Seventhsp;
    public GameObject Seventhing;
    public GameObject SeventhReward;
    public GameObject Seventhfalse;
    public GameObject SeventhClear;

    public UISprite SeventhA;
    public UISprite SeventhB;
    public UISprite SeventhC;
    public UISprite SeventhD;
    public UISprite SeventhE;

    //8번째 업적
    private int InfoUFO;
    private int EighthNumber;

    public UILabel EighthCoin;
    public UILabel EighthPlan;
    public UILabel Eighthlabel;
    public UISprite Eighthsp;
    public GameObject Eighthing;
    public GameObject EighthReward;
    public GameObject Eighthfalse;
    public GameObject EighthClear;

    public UISprite EighthA;
    public UISprite EighthB;
    public UISprite EighthC;
    public UISprite EighthD;
    public UISprite EighthE;

    //9번째 업적
    private int InfoItem;
    private int NinthNumber;

    public UILabel NinthCoin;
    public UILabel NinthPlan;
    public UILabel Ninthlabel;
    public UISprite Ninthsp;
    public GameObject Ninthing;
    public GameObject NinthReward;
    public GameObject Ninthfalse;
    public GameObject NinthClear;

    public UISprite NinthA;
    public UISprite NinthB;
    public UISprite NinthC;
    public UISprite NinthD;
    public UISprite NinthE;

    //10번째업적
    private int InfoEgg;
    private int TenthNumber;

    public UILabel TenthCoin;
    public UILabel TenthPlan;
    public UILabel Tenthlabel;
    public UISprite Tenthsp;
    public GameObject Tenthing;
    public GameObject TenthReward;
    public GameObject Tenthfalse;
    public GameObject TenthClear;

    public UISprite TenthA;
    public UISprite TenthB;
    public UISprite TenthC;
    public UISprite TenthD;
    public UISprite TenthE;

    //11번째 업적
    private int InfoSkill;
    private int EleventhNumber;

    public UILabel EleventhCoin;
    public UILabel EleventhPlan;
    public UILabel Eleventhlabel;
    public UISprite Eleventhsp;
    public GameObject Eleventhing;
    public GameObject EleventhReward;
    public GameObject Eleventhfalse;
    public GameObject EleventhClear;

    public UISprite EleventhA;
    public UISprite EleventhB;
    public UISprite EleventhC;
    public UISprite EleventhD;
    public UISprite EleventhE;

    //12번째
    private int InfoFuck;
    private int TwelfthNumber;

    public UILabel TwelfthCoin;
    public UILabel TwelfthPlan;
    public UILabel Twelfthlabel;
    public UISprite Twelfthsp;
    public GameObject Twelfthing;
    public GameObject TwelfthReward;
    public GameObject Twelfthfalse;
    public GameObject TwelfthClear;

    public UISprite TwelfthA;
    public UISprite TwelfthB;
    public UISprite TwelfthC;
    public UISprite TwelfthD;
    public UISprite TwelfthE;

    //

    public GameObject CoinGet;
    private int UNIT;

    public delegate void achievemanager();
    public static event achievemanager Click , Coin , Clear , AchieveCheck , AchieveClear, AchieveEnd;
    void Awake()
    {
        FirstReward.SetActive(false);
        Firsting.SetActive(true);
        SecondReward.SetActive(false);
        Seconding.SetActive(true);
        ThirdReward.SetActive(false);
        Thirding.SetActive(true);

        CoinGet.SetActive(false);
    }

    void OnEnable()
    {
        AdsNumber = PlayerPrefs.GetInt("AdsNumber", 0);
        FirstNumber = PlayerPrefs.GetInt("FirstNumber", 0);

        HighScore = PlayerPrefs.GetInt("TOT_High", 0);
        SecondNumber = PlayerPrefs.GetInt("SecondNumber", 0);

        Touchdove = PlayerPrefs.GetInt("Touchdove", 0);
        ThirdNumber = PlayerPrefs.GetInt("ThirdNumber", 0);

        QuestNumber = PlayerPrefs.GetInt("QuestNumber", 0);
        ForthNumber = PlayerPrefs.GetInt("ForthNumber", 0);

        InfoLevel = PlayerPrefs.GetInt("InfoLevel", 0);
        FifthNumber = PlayerPrefs.GetInt("FifthNumber", 0);

        InfoHidden = PlayerPrefs.GetInt("InfoHidden", 0);
        SixthNumber = PlayerPrefs.GetInt("SixthNumber", 0);

        InfoTalk = PlayerPrefs.GetInt("InfoTalk", 0);
        SeventhNumber = PlayerPrefs.GetInt("SeventhNumber", 0);

        InfoUFO = PlayerPrefs.GetInt("InfoUFO", 0);
        EighthNumber = PlayerPrefs.GetInt("EighthNumber", 0);

        InfoItem = PlayerPrefs.GetInt("InfoItem", 0);
        NinthNumber = PlayerPrefs.GetInt("NinthNumber", 0);

        InfoEgg = PlayerPrefs.GetInt("InfoEgg", 0);
        TenthNumber = PlayerPrefs.GetInt("TenthNumber", 0);

        InfoSkill = PlayerPrefs.GetInt("InfoSkill", 0);
        EleventhNumber = PlayerPrefs.GetInt("EleventhNumber", 0);

        InfoFuck = PlayerPrefs.GetInt("InfoFuck", 0);
        TwelfthNumber = PlayerPrefs.GetInt("TwelfthNumber", 0);

        FirstCheck(FirstNumber);
        SecondCheck(SecondNumber);
        ThirdCheck(ThirdNumber);
        ForthCheck(ForthNumber);
        FifthCheck(FifthNumber);
        SixthCheck(SixthNumber);
        SeventhCheck(SeventhNumber);
        EighthCheck(EighthNumber);
        NinthCheck(NinthNumber);
        TenthCheck(TenthNumber);
        EleventhCheck(EleventhNumber);
        TwelfthCheck(TwelfthNumber);

        UNIT = PlayerPrefs.GetInt("UNIT", 0);
    }
    void OnDisable()
    {
        AchieveEnd();
    }

    public void AdsPlus()
    {
        AdsNumber += 1;
        PlayerPrefs.SetInt("AdsNumber", AdsNumber);
        FirstCheck(FirstNumber);
    }
    public void HighPlus()
    {
        HighScore += 1000;
        PlayerPrefs.SetInt("TOT_High", HighScore);
        SecondCheck(SecondNumber);
    }
    public void QuestPlus()
    {
        QuestNumber += 10;
        PlayerPrefs.SetInt("QuestNumber", QuestNumber);
        ForthCheck(ForthNumber);
    }
    public void LevelPlus()
    {
        InfoLevel += 10;
        PlayerPrefs.SetInt("InfoLevel", InfoLevel);
        FifthCheck(FifthNumber);
    }
    public void HiddenPlus()
    {
        InfoHidden += 10;
        PlayerPrefs.SetInt("InfoHidden", InfoHidden);
        SixthCheck(SixthNumber);
    }
    public void TalkPlus()
    {
        InfoTalk += 10;
        PlayerPrefs.SetInt("InfoTalk", InfoTalk);
        SeventhCheck(SeventhNumber);
    }
    public void UFOPlus()
    {
        InfoUFO += 10;
        PlayerPrefs.SetInt("InfoUFO", InfoUFO);
        EighthCheck(EighthNumber);
    }
    public void ItemPlus()
    {
        InfoItem += 10;
        PlayerPrefs.SetInt("InfoItem", InfoItem);
        NinthCheck(NinthNumber);
    }
    public void EggPlus()
    {
        InfoEgg += 10;
        PlayerPrefs.SetInt("InfoEgg", InfoEgg);
        TenthCheck(TenthNumber);
    }
    public void SkillPlus()
    {
        InfoSkill += 10;
        PlayerPrefs.SetInt("InfoSkill", InfoSkill);
        EleventhCheck(EleventhNumber);
    }
    public void FuckPlus()
    {
        InfoFuck += 10;
        PlayerPrefs.SetInt("InfoFuck", InfoFuck);
        TwelfthCheck(TwelfthNumber);
    }

    void FirstCheck(int A)
    {
        if (A ==0)
        {
            FirstA.spriteName = "001_heart_bar";
            FirstB.spriteName = "001_heart_bar";
            FirstC.spriteName = "001_heart_bar";
            FirstD.spriteName = "001_heart_bar";
            FirstE.spriteName = "001_heart_bar";

            FirstCoin.text = "5000";
            FirstPlan.text = "광고 3번 시청";
            Firstlabel.text = AdsNumber.ToString() + "/3";
            Firstsp.fillAmount = AdsNumber * 0.33f;
            if(AdsNumber >=3)
            {
                FirstReward.SetActive(true);
                Firsting.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FirstReward.SetActive(false);
                Firsting.SetActive(true);
            }
        }
        else if(A ==1)
        {
            FirstA.spriteName = "002_heart_p";
            FirstB.spriteName = "001_heart_bar";
            FirstC.spriteName = "001_heart_bar";
            FirstD.spriteName = "001_heart_bar";
            FirstE.spriteName = "001_heart_bar";

            FirstCoin.text = "10000";
            FirstPlan.text = "광고 10번 시청";
            Firstlabel.text = AdsNumber.ToString() + "/10";
            Firstsp.fillAmount = AdsNumber * 0.1f;
            if (AdsNumber >= 10)
            {
                FirstReward.SetActive(true);
                Firsting.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FirstReward.SetActive(false);
                Firsting.SetActive(true);
            }
        }
        else if(A == 2)
        {
            FirstA.spriteName = "002_heart_p";
            FirstB.spriteName = "002_heart_p";
            FirstC.spriteName = "001_heart_bar";
            FirstD.spriteName = "001_heart_bar";
            FirstE.spriteName = "001_heart_bar";

            FirstCoin.text = "15000";
            FirstPlan.text = "광고 20번 시청";
            Firstlabel.text = AdsNumber.ToString() + "/20";
            Firstsp.fillAmount = AdsNumber * 0.05f;
            if (AdsNumber >= 20)
            {
                FirstReward.SetActive(true);
                Firsting.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FirstReward.SetActive(false);
                Firsting.SetActive(true);
            }
        }
        else if (A == 3)
        {
            FirstA.spriteName = "002_heart_p";
            FirstB.spriteName = "002_heart_p";
            FirstC.spriteName = "002_heart_p";
            FirstD.spriteName = "001_heart_bar";
            FirstE.spriteName = "001_heart_bar";

            FirstCoin.text = "20000";
            FirstPlan.text = "광고 50번 시청";
            Firstlabel.text = AdsNumber.ToString() + "/50";
            Firstsp.fillAmount = AdsNumber * 0.02f;
            if (AdsNumber >= 50)
            {
                FirstReward.SetActive(true);
                Firsting.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FirstReward.SetActive(false);
                Firsting.SetActive(true);
            }
        }
        else if (A == 4)
        {
            FirstA.spriteName = "002_heart_p";
            FirstB.spriteName = "002_heart_p";
            FirstC.spriteName = "002_heart_p";
            FirstD.spriteName = "002_heart_p";
            FirstE.spriteName = "001_heart_bar";

            FirstCoin.text = "25000";
            FirstPlan.text = "광고 100번 시청";
            Firstlabel.text = AdsNumber.ToString() + "/100";
            Firstsp.fillAmount = AdsNumber * 0.01f;
            if (AdsNumber >= 100)
            {
                FirstReward.SetActive(true);
                Firsting.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FirstReward.SetActive(false);
                Firsting.SetActive(true);
            }
        }
        else if(A ==5)
        {
            FirstA.spriteName = "002_heart_p";
            FirstB.spriteName = "002_heart_p";
            FirstC.spriteName = "002_heart_p";
            FirstD.spriteName = "002_heart_p";
            FirstE.spriteName = "002_heart_p";

            FirstPlan.text = "광고 100번 시청";

            FirstReward.SetActive(false);
            Firsting.SetActive(false);
            Firstfalse.SetActive(false);

            FirstClear.SetActive(true);
        }
    }
    public void FirstOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (FirstNumber ==0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 5000;  
            PlayerPrefs.SetInt("UNIT", UNIT);

            FirstNumber = 1;
            PlayerPrefs.SetInt("FirstNumber", 1);
            FirstCheck(FirstNumber);
        }
        else if(FirstNumber ==1)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FirstNumber = 2;
            PlayerPrefs.SetInt("FirstNumber", 2);
            FirstCheck(FirstNumber);
        }
        else if (FirstNumber == 2)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 15000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FirstNumber = 3;
            PlayerPrefs.SetInt("FirstNumber", 3);
            FirstCheck(FirstNumber);
        }
        else if (FirstNumber == 3)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FirstNumber = 4;
            PlayerPrefs.SetInt("FirstNumber", 4);
            FirstCheck(FirstNumber);
        }
        else if (FirstNumber == 4)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 25000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FirstNumber = 5;
            PlayerPrefs.SetInt("FirstNumber", 5);
            FirstCheck(FirstNumber);
        }
    }

    void SecondCheck(int A)
    {
        if (A ==0)
        {
            SecondA.spriteName = "001_heart_bar";
            SecondB.spriteName = "001_heart_bar";
            SecondC.spriteName = "001_heart_bar";
            SecondD.spriteName = "001_heart_bar";
            SecondE.spriteName = "001_heart_bar";
            SecondF.spriteName = "001_heart_bar";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "1000";
            SecondPlan.text = "점수 500점 획득";
            Secondlabel.text = HighScore.ToString() + "/500";
            Secondsp.fillAmount = HighScore * 0.002f;
            if (HighScore >= 500)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if(A ==1)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "001_heart_bar";
            SecondC.spriteName = "001_heart_bar";
            SecondD.spriteName = "001_heart_bar";
            SecondE.spriteName = "001_heart_bar";
            SecondF.spriteName = "001_heart_bar";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "2000";
            SecondPlan.text = "점수 1000점 획득";
            Secondlabel.text = HighScore.ToString() + "/1000";
            Secondsp.fillAmount = HighScore * 0.001f;
            if (HighScore >= 1000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 2)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "001_heart_bar";
            SecondD.spriteName = "001_heart_bar";
            SecondE.spriteName = "001_heart_bar";
            SecondF.spriteName = "001_heart_bar";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "5000";
            SecondPlan.text = "점수 2000점 획득";
            Secondlabel.text = HighScore.ToString() + "/2000";
            Secondsp.fillAmount = HighScore * 0.0005f;
            if (HighScore >= 2000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 3)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "001_heart_bar";
            SecondE.spriteName = "001_heart_bar";
            SecondF.spriteName = "001_heart_bar";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "10000";
            SecondPlan.text = "점수 3000점 획득";
            Secondlabel.text = HighScore.ToString() + "/3000";
            Secondsp.fillAmount = HighScore * 0.00033f;
            if (HighScore >= 3000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 4)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "001_heart_bar";
            SecondF.spriteName = "001_heart_bar";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "20000";
            SecondPlan.text = "점수 5000점 획득";
            Secondlabel.text = HighScore.ToString() + "/5000";
            Secondsp.fillAmount = HighScore * 0.0002f;
            if (HighScore >= 5000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 5)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "002_heart_p";
            SecondF.spriteName = "001_heart_bar";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "40000";
            SecondPlan.text = "점수 8000점 획득";
            Secondlabel.text = HighScore.ToString() + "/8000";
            Secondsp.fillAmount = HighScore * 0.000125f;
            if (HighScore >= 8000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 6)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "002_heart_p";
            SecondF.spriteName = "002_heart_p";
            SecondG.spriteName = "001_heart_bar";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "80000";
            SecondPlan.text = "점수 10000점 획득";
            Secondlabel.text = HighScore.ToString() + "/10000";
            Secondsp.fillAmount = HighScore * 0.0001f;
            if (HighScore >= 10000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 7)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "002_heart_p";
            SecondF.spriteName = "002_heart_p";
            SecondG.spriteName = "002_heart_p";
            SecondH.spriteName = "001_heart_bar";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "150000";
            SecondPlan.text = "점수 15000점 획득";
            Secondlabel.text = HighScore.ToString() + "/15000";
            Secondsp.fillAmount = HighScore * 0.000067f;
            if (HighScore >= 15000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 8)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "002_heart_p";
            SecondF.spriteName = "002_heart_p";
            SecondG.spriteName = "002_heart_p";
            SecondH.spriteName = "002_heart_p";
            SecondI.spriteName = "001_heart_bar";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "300000";
            SecondPlan.text = "점수 20000점 획득";
            Secondlabel.text = HighScore.ToString() + "/20000";
            Secondsp.fillAmount = HighScore * 0.00005f;
            if (HighScore >= 20000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 9)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "002_heart_p";
            SecondF.spriteName = "002_heart_p";
            SecondG.spriteName = "002_heart_p";
            SecondH.spriteName = "002_heart_p";
            SecondI.spriteName = "002_heart_p";
            SecondJ.spriteName = "001_heart_bar";

            SecondCoin.text = "500000";
            SecondPlan.text = "점수 50000점 획득";
            Secondlabel.text = HighScore.ToString() + "/50000";
            Secondsp.fillAmount = HighScore * 0.00002f;
            if (HighScore >= 50000)
            {
                SecondReward.SetActive(true);
                Seconding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SecondReward.SetActive(false);
                Seconding.SetActive(true);
            }
        }
        else if (A == 10)
        {
            SecondA.spriteName = "002_heart_p";
            SecondB.spriteName = "002_heart_p";
            SecondC.spriteName = "002_heart_p";
            SecondD.spriteName = "002_heart_p";
            SecondE.spriteName = "002_heart_p";
            SecondF.spriteName = "002_heart_p";
            SecondG.spriteName = "002_heart_p";
            SecondH.spriteName = "002_heart_p";
            SecondI.spriteName = "002_heart_p";
            SecondJ.spriteName = "002_heart_p";

            SecondPlan.text = "점수 50000점 획득";

            SecondReward.SetActive(false);
            Seconding.SetActive(false);
            Secondfalse.SetActive(false);

            SecondClear.SetActive(true);
        }
    }
    public void SecondOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (SecondNumber == 0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 1000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 1;
            PlayerPrefs.SetInt("SecondNumber", 1);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 1)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 2000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 2;
            PlayerPrefs.SetInt("SecondNumber", 2);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 2)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 3;
            PlayerPrefs.SetInt("SecondNumber", 3);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 3)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 4;
            PlayerPrefs.SetInt("SecondNumber", 4);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 4)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 5;
            PlayerPrefs.SetInt("SecondNumber", 5);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 5)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 40000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 6;
            PlayerPrefs.SetInt("SecondNumber", 6);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 6)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 80000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 7;
            PlayerPrefs.SetInt("SecondNumber", 7);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 7)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 150000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 8;
            PlayerPrefs.SetInt("SecondNumber", 8);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 8)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 300000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 9;
            PlayerPrefs.SetInt("SecondNumber", 9);
            SecondCheck(SecondNumber);
        }
        else if (SecondNumber == 9)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 500000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SecondNumber = 10;
            PlayerPrefs.SetInt("SecondNumber", 10);
            SecondCheck(SecondNumber);
        }
    }

    void ThirdCheck(int A)
    {
        if (A == 0)
        {
            ThirdA.spriteName = "001_heart_bar";

            ThirdCoin.text = "20000";
            ThirdPlan.text = "비둘기 200번 클릭";
            Thirdlabel.text = Touchdove.ToString() + "/200";
            Thirdsp.fillAmount = Touchdove * 0.005f;
            if (Touchdove >= 200)
            {
                ThirdReward.SetActive(true);
                Thirding.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ThirdReward.SetActive(false);
                Thirding.SetActive(true);
            }
        }
        else if(A ==1)
        {
            ThirdA.spriteName = "002_heart_p";

            ThirdPlan.text = "비둘기 200번 클릭";

            ThirdReward.SetActive(false);
            Thirding.SetActive(false);
            Thirdfalse.SetActive(false);

            ThirdClear.SetActive(true);
        }
    }
    public void ThirdOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (ThirdNumber == 0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ThirdNumber = 1;
            PlayerPrefs.SetInt("ThirdNumber", 1);
            ThirdCheck(ThirdNumber);
        }
    }

    void ForthCheck(int A)
    {
        if (A == 0)
        {
            ForthA.spriteName = "001_heart_bar";
            ForthB.spriteName = "001_heart_bar";
            ForthC.spriteName = "001_heart_bar";
            ForthD.spriteName = "001_heart_bar";
            ForthE.spriteName = "001_heart_bar";
            ForthF.spriteName = "001_heart_bar";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "1000";
            ForthPlan.text = "임무 1개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/1";
            Forthsp.fillAmount = QuestNumber * 1f;
            if (QuestNumber >= 1)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if(A ==1)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "001_heart_bar";
            ForthC.spriteName = "001_heart_bar";
            ForthD.spriteName = "001_heart_bar";
            ForthE.spriteName = "001_heart_bar";
            ForthF.spriteName = "001_heart_bar";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "4000";
            ForthPlan.text = "임무 3개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/3";
            Forthsp.fillAmount = QuestNumber * 0.33f;
            if (QuestNumber >= 3)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "001_heart_bar";
            ForthD.spriteName = "001_heart_bar";
            ForthE.spriteName = "001_heart_bar";
            ForthF.spriteName = "001_heart_bar";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "10000";
            ForthPlan.text = "임무 10개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/10";
            Forthsp.fillAmount = QuestNumber * 0.1f;
            if (QuestNumber >= 10)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "001_heart_bar";
            ForthE.spriteName = "001_heart_bar";
            ForthF.spriteName = "001_heart_bar";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "20000";
            ForthPlan.text = "임무 20개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/20";
            Forthsp.fillAmount = QuestNumber * 0.05f;
            if (QuestNumber >= 20)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "001_heart_bar";
            ForthF.spriteName = "001_heart_bar";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "50000";
            ForthPlan.text = "임무 50개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/50";
            Forthsp.fillAmount = QuestNumber * 0.02f;
            if (QuestNumber >= 50)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "002_heart_p";
            ForthF.spriteName = "001_heart_bar";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "100000";
            ForthPlan.text = "임무 100개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/100";
            Forthsp.fillAmount = QuestNumber * 0.01f;
            if (QuestNumber >= 100)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 6)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "002_heart_p";
            ForthF.spriteName = "002_heart_p";
            ForthG.spriteName = "001_heart_bar";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "150000";
            ForthPlan.text = "임무 150개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/150";
            Forthsp.fillAmount = QuestNumber * 0.0066f;
            if (QuestNumber >= 150)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 7)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "002_heart_p";
            ForthF.spriteName = "002_heart_p";
            ForthG.spriteName = "002_heart_p";
            ForthH.spriteName = "001_heart_bar";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "300000";
            ForthPlan.text = "임무 200개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/200";
            Forthsp.fillAmount = QuestNumber * 0.005f;
            if (QuestNumber >= 200)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 8)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "002_heart_p";
            ForthF.spriteName = "002_heart_p";
            ForthG.spriteName = "002_heart_p";
            ForthH.spriteName = "002_heart_p";
            ForthI.spriteName = "001_heart_bar";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "600000";
            ForthPlan.text = "임무 300개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/300";
            Forthsp.fillAmount = QuestNumber * 0.0033f;
            if (QuestNumber >= 300)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 9)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "002_heart_p";
            ForthF.spriteName = "002_heart_p";
            ForthG.spriteName = "002_heart_p";
            ForthH.spriteName = "002_heart_p";
            ForthI.spriteName = "002_heart_p";
            ForthJ.spriteName = "001_heart_bar";

            ForthCoin.text = "1000000";
            ForthPlan.text = "임무 500개 완료";
            Forthlabel.text = QuestNumber.ToString() + "/500";
            Forthsp.fillAmount = QuestNumber * 0.002f;
            if (QuestNumber >= 500)
            {
                ForthReward.SetActive(true);
                Forthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                ForthReward.SetActive(false);
                Forthing.SetActive(true);
            }
        }
        else if (A == 10)
        {
            ForthA.spriteName = "002_heart_p";
            ForthB.spriteName = "002_heart_p";
            ForthC.spriteName = "002_heart_p";
            ForthD.spriteName = "002_heart_p";
            ForthE.spriteName = "002_heart_p";
            ForthF.spriteName = "002_heart_p";
            ForthG.spriteName = "002_heart_p";
            ForthH.spriteName = "002_heart_p";
            ForthI.spriteName = "002_heart_p";
            ForthJ.spriteName = "002_heart_p";

            ForthPlan.text = "임무 500개 완료";

            ForthReward.SetActive(false);
            Forthing.SetActive(false);
            Forthfalse.SetActive(false);

            ForthClear.SetActive(true);
        }
    }
    public void ForthOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (ForthNumber == 0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 1000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 1;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
            Clear();
        }
        else if(ForthNumber ==1)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 4000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 2;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 2)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 3;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 3)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 4;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 4)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 5;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 5)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 100000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 6;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 6)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 150000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 7;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 7)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 300000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 8;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 8)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 600000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 9;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
        else if (ForthNumber == 9)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 1000000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            ForthNumber = 10;
            PlayerPrefs.SetInt("ForthNumber", ForthNumber);
            ForthCheck(ForthNumber);
        }
    }

    void FifthCheck(int A)
    {
        if (A == 0)
        {
            FifthA.spriteName = "001_heart_bar";
            FifthB.spriteName = "001_heart_bar";
            FifthC.spriteName = "001_heart_bar";
            FifthD.spriteName = "001_heart_bar";
            FifthE.spriteName = "001_heart_bar";
            FifthF.spriteName = "001_heart_bar";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "1000";
            FifthPlan.text = "스테이지 2번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/2";
            Fifthsp.fillAmount = InfoLevel * 0.5f;
            if (InfoLevel >= 2)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "001_heart_bar";
            FifthC.spriteName = "001_heart_bar";
            FifthD.spriteName = "001_heart_bar";
            FifthE.spriteName = "001_heart_bar";
            FifthF.spriteName = "001_heart_bar";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "2000";
            FifthPlan.text = "스테이지 10번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/10";
            Fifthsp.fillAmount = InfoLevel * 0.1f;
            if (InfoLevel >= 10)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "001_heart_bar";
            FifthD.spriteName = "001_heart_bar";
            FifthE.spriteName = "001_heart_bar";
            FifthF.spriteName = "001_heart_bar";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "5000";
            FifthPlan.text = "스테이지 20번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/20";
            Fifthsp.fillAmount = InfoLevel * 0.05f;
            if (InfoLevel >= 20)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "001_heart_bar";
            FifthE.spriteName = "001_heart_bar";
            FifthF.spriteName = "001_heart_bar";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "10000";
            FifthPlan.text = "스테이지 40번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/40";
            Fifthsp.fillAmount = InfoLevel * 0.025f;
            if (InfoLevel >= 40)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "001_heart_bar";
            FifthF.spriteName = "001_heart_bar";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "20000";
            FifthPlan.text = "스테이지 80번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/80";
            Fifthsp.fillAmount = InfoLevel * 0.0125f;
            if (InfoLevel >= 80)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "002_heart_p";
            FifthF.spriteName = "001_heart_bar";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "40000";
            FifthPlan.text = "스테이지 160번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/160";
            Fifthsp.fillAmount = InfoLevel * 0.00625f;
            if (InfoLevel >= 160)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 6)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "002_heart_p";
            FifthF.spriteName = "002_heart_p";
            FifthG.spriteName = "001_heart_bar";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "70000";
            FifthPlan.text = "스테이지 250번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/250";
            Fifthsp.fillAmount = InfoLevel * 0.004f;
            if (InfoLevel >= 250)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 7)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "002_heart_p";
            FifthF.spriteName = "002_heart_p";
            FifthG.spriteName = "002_heart_p";
            FifthH.spriteName = "001_heart_bar";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "120000";
            FifthPlan.text = "스테이지 400번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/400";
            Fifthsp.fillAmount = InfoLevel * 0.0025f;
            if (InfoLevel >= 400)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 8)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "002_heart_p";
            FifthF.spriteName = "002_heart_p";
            FifthG.spriteName = "002_heart_p";
            FifthH.spriteName = "002_heart_p";
            FifthI.spriteName = "001_heart_bar";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "180000";
            FifthPlan.text = "스테이지 600번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/600";
            Fifthsp.fillAmount = InfoLevel * 0.00167f;
            if (InfoLevel >= 600)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 9)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "002_heart_p";
            FifthF.spriteName = "002_heart_p";
            FifthG.spriteName = "002_heart_p";
            FifthH.spriteName = "002_heart_p";
            FifthI.spriteName = "002_heart_p";
            FifthJ.spriteName = "001_heart_bar";

            FifthCoin.text = "250000";
            FifthPlan.text = "스테이지 1000번 통과";
            Fifthlabel.text = InfoLevel.ToString() + "/100";
            Fifthsp.fillAmount = InfoLevel * 0.001f;
            if (InfoLevel >= 1000)
            {
                FifthReward.SetActive(true);
                Fifthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                FifthReward.SetActive(false);
                Fifthing.SetActive(true);
            }
        }
        else if (A == 10)
        {
            FifthA.spriteName = "002_heart_p";
            FifthB.spriteName = "002_heart_p";
            FifthC.spriteName = "002_heart_p";
            FifthD.spriteName = "002_heart_p";
            FifthE.spriteName = "002_heart_p";
            FifthF.spriteName = "002_heart_p";
            FifthG.spriteName = "002_heart_p";
            FifthH.spriteName = "002_heart_p";
            FifthI.spriteName = "002_heart_p";
            FifthJ.spriteName = "002_heart_p";

            FifthPlan.text = "스테이지 1000번 통과";

            FifthReward.SetActive(false);
            Fifthing.SetActive(false);
            Fifthfalse.SetActive(false);

            FifthClear.SetActive(true);
        }
    }
    public void FifthOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (FifthNumber == 0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 1000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 1;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if(FifthNumber ==1)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 2000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 2;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 2)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 3;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 3)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 4;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 4)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 5;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 5)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 40000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 6;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 6)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 70000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 7;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 7)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 120000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 8;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 8)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 180000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 9;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
        else if (FifthNumber == 9)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 250000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            FifthNumber = 10;
            PlayerPrefs.SetInt("FifthNumber", FifthNumber);
            FifthCheck(FifthNumber);
        }
    }

    void SixthCheck(int A)
    {
        if (A == 0)
        {
            SixthA.spriteName = "001_heart_bar";
            SixthB.spriteName = "001_heart_bar";
            SixthC.spriteName = "001_heart_bar";
            SixthD.spriteName = "001_heart_bar";
            SixthE.spriteName = "001_heart_bar";

            SixthCoin.text = "5000";
            SixthPlan.text = "히든스테이지 1번 진입";
            Sixthlabel.text = InfoHidden.ToString() + "/1";
            Sixthsp.fillAmount = InfoHidden * 1f;
            if (InfoHidden >= 1)
            {
                SixthReward.SetActive(true);
                Sixthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SixthReward.SetActive(false);
                Sixthing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            SixthA.spriteName = "002_heart_p";
            SixthB.spriteName = "001_heart_bar";
            SixthC.spriteName = "001_heart_bar";
            SixthD.spriteName = "001_heart_bar";
            SixthE.spriteName = "001_heart_bar";

            SixthCoin.text = "10000";
            SixthPlan.text = "히든스테이지 3번 진입";
            Sixthlabel.text = InfoHidden.ToString() + "/3";
            Sixthsp.fillAmount = InfoHidden * 0.33f;
            if (InfoHidden >= 3)
            {
                SixthReward.SetActive(true);
                Sixthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SixthReward.SetActive(false);
                Sixthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            SixthA.spriteName = "002_heart_p";
            SixthB.spriteName = "002_heart_p";
            SixthC.spriteName = "001_heart_bar";
            SixthD.spriteName = "001_heart_bar";
            SixthE.spriteName = "001_heart_bar";

            SixthCoin.text = "20000";
            SixthPlan.text = "히든스테이지 10번 진입";
            Sixthlabel.text = InfoHidden.ToString() + "/10";
            Sixthsp.fillAmount = InfoHidden * 0.1f;
            if (InfoHidden >= 10)
            {
                SixthReward.SetActive(true);
                Sixthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SixthReward.SetActive(false);
                Sixthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            SixthA.spriteName = "002_heart_p";
            SixthB.spriteName = "002_heart_p";
            SixthC.spriteName = "002_heart_p";
            SixthD.spriteName = "001_heart_bar";
            SixthE.spriteName = "001_heart_bar";

            SixthCoin.text = "50000";
            SixthPlan.text = "히든스테이지 20번 진입";
            Sixthlabel.text = InfoHidden.ToString() + "/20";
            Sixthsp.fillAmount = InfoHidden * 0.05f;
            if (InfoHidden >= 20)
            {
                SixthReward.SetActive(true);
                Sixthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SixthReward.SetActive(false);
                Sixthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            SixthA.spriteName = "002_heart_p";
            SixthB.spriteName = "002_heart_p";
            SixthC.spriteName = "002_heart_p";
            SixthD.spriteName = "002_heart_p";
            SixthE.spriteName = "001_heart_bar";

            SixthCoin.text = "100000";
            SixthPlan.text = "히든스테이지 50번 진입";
            Sixthlabel.text = InfoHidden.ToString() + "/50";
            Sixthsp.fillAmount = InfoHidden * 0.02f;
            if (InfoHidden >= 50)
            {
                SixthReward.SetActive(true);
                Sixthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SixthReward.SetActive(false);
                Sixthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            SixthA.spriteName = "002_heart_p";
            SixthB.spriteName = "002_heart_p";
            SixthC.spriteName = "002_heart_p";
            SixthD.spriteName = "002_heart_p";
            SixthE.spriteName = "002_heart_p";

            SixthPlan.text = "히든스테이지 50번 진입";

            SixthReward.SetActive(false);
            Sixthing.SetActive(false);
            Sixthfalse.SetActive(false);

            SixthClear.SetActive(true);
        }
    }
    public void SixthOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (SixthNumber == 0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SixthNumber = 1;
            PlayerPrefs.SetInt("SixthNumber", SixthNumber);
            SixthCheck(SixthNumber);
        }
        else if(SixthNumber ==1)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SixthNumber = 2;
            PlayerPrefs.SetInt("SixthNumber", SixthNumber);
            SixthCheck(SixthNumber);
        }
        else if (SixthNumber == 2)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SixthNumber = 3;
            PlayerPrefs.SetInt("SixthNumber", SixthNumber);
            SixthCheck(SixthNumber);
        }
        else if (SixthNumber == 3)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SixthNumber = 4;
            PlayerPrefs.SetInt("SixthNumber", SixthNumber);
            SixthCheck(SixthNumber);
        }
        else if (SixthNumber == 4)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 100000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SixthNumber = 5;
            PlayerPrefs.SetInt("SixthNumber", SixthNumber);
            SixthCheck(SixthNumber);
        }
    }

    void SeventhCheck(int A)
    {
        if (A == 0)
        {
            SeventhA.spriteName = "001_heart_bar";
            SeventhB.spriteName = "001_heart_bar";
            SeventhC.spriteName = "001_heart_bar";
            SeventhD.spriteName = "001_heart_bar";
            SeventhE.spriteName = "001_heart_bar";

            SeventhCoin.text = "5000";
            SeventhPlan.text = "대화 2번 하기";
            Seventhlabel.text = InfoTalk.ToString() + "/2";
            Seventhsp.fillAmount = InfoTalk * 0.5f;
            if (InfoTalk >= 2)
            {
                SeventhReward.SetActive(true);
                Seventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SeventhReward.SetActive(false);
                Seventhing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            SeventhA.spriteName = "002_heart_p";
            SeventhB.spriteName = "001_heart_bar";
            SeventhC.spriteName = "001_heart_bar";
            SeventhD.spriteName = "001_heart_bar";
            SeventhE.spriteName = "001_heart_bar";

            SeventhCoin.text = "10000";
            SeventhPlan.text = "대화 10번 하기";
            Seventhlabel.text = InfoTalk.ToString() + "/10";
            Seventhsp.fillAmount = InfoTalk * 0.1f;
            if (InfoTalk >= 10)
            {
                SeventhReward.SetActive(true);
                Seventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SeventhReward.SetActive(false);
                Seventhing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            SeventhA.spriteName = "002_heart_p";
            SeventhB.spriteName = "002_heart_p";
            SeventhC.spriteName = "001_heart_bar";
            SeventhD.spriteName = "001_heart_bar";
            SeventhE.spriteName = "001_heart_bar";

            SeventhCoin.text = "25000";
            SeventhPlan.text = "대화 30번 하기";
            Seventhlabel.text = InfoTalk.ToString() + "/30";
            Seventhsp.fillAmount = InfoTalk * 0.033f;
            if (InfoTalk >= 30)
            {
                SeventhReward.SetActive(true);
                Seventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SeventhReward.SetActive(false);
                Seventhing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            SeventhA.spriteName = "002_heart_p";
            SeventhB.spriteName = "002_heart_p";
            SeventhC.spriteName = "002_heart_p";
            SeventhD.spriteName = "001_heart_bar";
            SeventhE.spriteName = "001_heart_bar";

            SeventhCoin.text = "50000";
            SeventhPlan.text = "대화 60번 하기";
            Seventhlabel.text = InfoTalk.ToString() + "/60";
            Seventhsp.fillAmount = InfoTalk * 0.0167f;
            if (InfoTalk >= 60)
            {
                SeventhReward.SetActive(true);
                Seventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SeventhReward.SetActive(false);
                Seventhing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            SeventhA.spriteName = "002_heart_p";
            SeventhB.spriteName = "002_heart_p";
            SeventhC.spriteName = "002_heart_p";
            SeventhD.spriteName = "002_heart_p";
            SeventhE.spriteName = "001_heart_bar";

            SeventhCoin.text = "100000";
            SeventhPlan.text = "대화 100번 하기";
            Seventhlabel.text = InfoTalk.ToString() + "/100";
            Seventhsp.fillAmount = InfoTalk * 0.01f;
            if (InfoTalk >= 100)
            {
                SeventhReward.SetActive(true);
                Seventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                SeventhReward.SetActive(false);
                Seventhing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            SeventhA.spriteName = "002_heart_p";
            SeventhB.spriteName = "002_heart_p";
            SeventhC.spriteName = "002_heart_p";
            SeventhD.spriteName = "002_heart_p";
            SeventhE.spriteName = "002_heart_p";

            SeventhPlan.text = "대화 100번 하기";

            SeventhReward.SetActive(false);
            Seventhing.SetActive(false);
            Seventhfalse.SetActive(false);

            SeventhClear.SetActive(true);
        }
    }
    public void SeventhOK()
    {
        Click();
        Coin();
        AchieveClear();
        if (SeventhNumber == 0)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SeventhNumber = 1;
            PlayerPrefs.SetInt("SeventhNumber", SeventhNumber);
            SeventhCheck(SeventhNumber);
        }
        else if(SeventhNumber ==1)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SeventhNumber = 2;
            PlayerPrefs.SetInt("SeventhNumber", SeventhNumber);
            SeventhCheck(SeventhNumber);
        }
        else if (SeventhNumber == 2)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 25000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SeventhNumber = 3;
            PlayerPrefs.SetInt("SeventhNumber", SeventhNumber);
            SeventhCheck(SeventhNumber);
        }
        else if (SeventhNumber == 3)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SeventhNumber = 4;
            PlayerPrefs.SetInt("SeventhNumber", SeventhNumber);
            SeventhCheck(SeventhNumber);
        }
        else if (SeventhNumber == 4)
        {
            CoinGet.SetActive(false);
            CoinGet.SetActive(true);

            UNIT += 100000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            SeventhNumber = 5;
            PlayerPrefs.SetInt("SeventhNumber", SeventhNumber);
            SeventhCheck(SeventhNumber);
        }
    }

    void EighthCheck(int A)
    {
        if (A == 0)
        {
            EighthA.spriteName = "001_heart_bar";
            EighthB.spriteName = "001_heart_bar";
            EighthC.spriteName = "001_heart_bar";
            EighthD.spriteName = "001_heart_bar";
            EighthE.spriteName = "001_heart_bar";

            EighthCoin.text = "3000";
            EighthPlan.text = "UFO한테 납치 1번 당하기";
            Eighthlabel.text = InfoUFO.ToString() + "/1";
            Eighthsp.fillAmount = InfoUFO * 1f;
            if (InfoUFO >= 1)
            {
                EighthReward.SetActive(true);
                Eighthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EighthReward.SetActive(false);
                Eighthing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            EighthA.spriteName = "002_heart_p";
            EighthB.spriteName = "001_heart_bar";
            EighthC.spriteName = "001_heart_bar";
            EighthD.spriteName = "001_heart_bar";
            EighthE.spriteName = "001_heart_bar";

            EighthCoin.text = "7000";
            EighthPlan.text = "UFO한테 납치 3번 당하기";
            Eighthlabel.text = InfoUFO.ToString() + "/3";
            Eighthsp.fillAmount = InfoUFO * 0.33f;
            if (InfoUFO >= 3)
            {
                EighthReward.SetActive(true);
                Eighthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EighthReward.SetActive(false);
                Eighthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            EighthA.spriteName = "002_heart_p";
            EighthB.spriteName = "002_heart_p";
            EighthC.spriteName = "001_heart_bar";
            EighthD.spriteName = "001_heart_bar";
            EighthE.spriteName = "001_heart_bar";

            EighthCoin.text = "15000";
            EighthPlan.text = "UFO한테 납치 10번 당하기";
            Eighthlabel.text = InfoUFO.ToString() + "/10";
            Eighthsp.fillAmount = InfoUFO * 0.1f;
            if (InfoUFO >= 10)
            {
                EighthReward.SetActive(true);
                Eighthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EighthReward.SetActive(false);
                Eighthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            EighthA.spriteName = "002_heart_p";
            EighthB.spriteName = "002_heart_p";
            EighthC.spriteName = "002_heart_p";
            EighthD.spriteName = "001_heart_bar";
            EighthE.spriteName = "001_heart_bar";

            EighthCoin.text = "25000";
            EighthPlan.text = "UFO한테 납치 20번 당하기";
            Eighthlabel.text = InfoUFO.ToString() + "/20";
            Eighthsp.fillAmount = InfoUFO * 0.05f;
            if (InfoUFO >= 20)
            {
                EighthReward.SetActive(true);
                Eighthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EighthReward.SetActive(false);
                Eighthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            EighthA.spriteName = "002_heart_p";
            EighthB.spriteName = "002_heart_p";
            EighthC.spriteName = "002_heart_p";
            EighthD.spriteName = "002_heart_p";
            EighthE.spriteName = "001_heart_bar";

            EighthCoin.text = "50000";
            EighthPlan.text = "UFO한테 납치 50번 당하기";
            Eighthlabel.text = InfoUFO.ToString() + "/50";
            Eighthsp.fillAmount = InfoUFO * 0.02f;
            if (InfoUFO >= 50)
            {
                EighthReward.SetActive(true);
                Eighthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EighthReward.SetActive(false);
                Eighthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            EighthA.spriteName = "002_heart_p";
            EighthB.spriteName = "002_heart_p";
            EighthC.spriteName = "002_heart_p";
            EighthD.spriteName = "002_heart_p";
            EighthE.spriteName = "002_heart_p";

            EighthPlan.text = "UFO한테 납치 50번 당하기";

            EighthReward.SetActive(false);
            Eighthing.SetActive(false);
            Eighthfalse.SetActive(false);

            EighthClear.SetActive(true);
        }
    }
    public void EighthOK()
    {
        Click();
        Coin();
        AchieveClear();
        CoinGet.SetActive(false);
        CoinGet.SetActive(true);
        if (EighthNumber == 0)
        {
            UNIT += 3000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EighthNumber = 1;
            PlayerPrefs.SetInt("EighthNumber", EighthNumber);
            EighthCheck(EighthNumber);
        }
        else if(EighthNumber == 1)
        {
            UNIT += 7000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EighthNumber = 2;
            PlayerPrefs.SetInt("EighthNumber", EighthNumber);
            EighthCheck(EighthNumber);
        }
        else if (EighthNumber == 2)
        {
            UNIT += 15000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EighthNumber = 3;
            PlayerPrefs.SetInt("EighthNumber", EighthNumber);
            EighthCheck(EighthNumber);
        }
        else if (EighthNumber == 3)
        {
            UNIT += 25000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EighthNumber = 4;
            PlayerPrefs.SetInt("EighthNumber", EighthNumber);
            EighthCheck(EighthNumber);
        }
        else if (EighthNumber == 4)
        {
            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EighthNumber = 5;
            PlayerPrefs.SetInt("EighthNumber", EighthNumber);
            EighthCheck(EighthNumber);
        }
    }

    void NinthCheck(int A)
    {
        if (A == 0)
        {
            NinthA.spriteName = "001_heart_bar";
            NinthB.spriteName = "001_heart_bar";
            NinthC.spriteName = "001_heart_bar";
            NinthD.spriteName = "001_heart_bar";
            NinthE.spriteName = "001_heart_bar";

            NinthCoin.text = "5000";
            NinthPlan.text = "아이템 5번 사용하기";
            Ninthlabel.text = InfoItem.ToString() + "/5";
            Ninthsp.fillAmount = InfoItem * 0.2f;
            if (InfoItem >= 5)
            {
                NinthReward.SetActive(true);
                Ninthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                NinthReward.SetActive(false);
                Ninthing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            NinthA.spriteName = "002_heart_p";
            NinthB.spriteName = "001_heart_bar";
            NinthC.spriteName = "001_heart_bar";
            NinthD.spriteName = "001_heart_bar";
            NinthE.spriteName = "001_heart_bar";

            NinthCoin.text = "15000";
            NinthPlan.text = "아이템 20번 사용하기";
            Ninthlabel.text = InfoItem.ToString() + "/20";
            Ninthsp.fillAmount = InfoItem * 0.05f;
            if (InfoItem >= 20)
            {
                NinthReward.SetActive(true);
                Ninthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                NinthReward.SetActive(false);
                Ninthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            NinthA.spriteName = "002_heart_p";
            NinthB.spriteName = "002_heart_p";
            NinthC.spriteName = "001_heart_bar";
            NinthD.spriteName = "001_heart_bar";
            NinthE.spriteName = "001_heart_bar";

            NinthCoin.text = "30000";
            NinthPlan.text = "아이템 50번 사용하기";
            Ninthlabel.text = InfoItem.ToString() + "/50";
            Ninthsp.fillAmount = InfoItem * 0.02f;
            if (InfoItem >= 50)
            {
                NinthReward.SetActive(true);
                Ninthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                NinthReward.SetActive(false);
                Ninthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            NinthA.spriteName = "002_heart_p";
            NinthB.spriteName = "002_heart_p";
            NinthC.spriteName = "002_heart_p";
            NinthD.spriteName = "001_heart_bar";
            NinthE.spriteName = "001_heart_bar";

            NinthCoin.text = "60000";
            NinthPlan.text = "아이템 100번 사용하기";
            Ninthlabel.text = InfoItem.ToString() + "/100";
            Ninthsp.fillAmount = InfoItem * 0.01f;
            if (InfoItem >= 100)
            {
                NinthReward.SetActive(true);
                Ninthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                NinthReward.SetActive(false);
                Ninthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            NinthA.spriteName = "002_heart_p";
            NinthB.spriteName = "002_heart_p";
            NinthC.spriteName = "002_heart_p";
            NinthD.spriteName = "002_heart_p";
            NinthE.spriteName = "001_heart_bar";

            NinthCoin.text = "100000";
            NinthPlan.text = "아이템 200번 사용하기";
            Ninthlabel.text = InfoItem.ToString() + "/200";
            Ninthsp.fillAmount = InfoItem * 0.005f;
            if (InfoItem >= 200)
            {
                NinthReward.SetActive(true);
                Ninthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                NinthReward.SetActive(false);
                Ninthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            NinthA.spriteName = "002_heart_p";
            NinthB.spriteName = "002_heart_p";
            NinthC.spriteName = "002_heart_p";
            NinthD.spriteName = "002_heart_p";
            NinthE.spriteName = "002_heart_p";

            NinthPlan.text = "아이템 200번 사용하기";

            NinthReward.SetActive(false);
            Ninthing.SetActive(false);
            Ninthfalse.SetActive(false);

            NinthClear.SetActive(true);
        }
    }
    public void NinthOK()
    {
        Click();
        Coin();
        AchieveClear();
        CoinGet.SetActive(false);
        CoinGet.SetActive(true);
        if (NinthNumber == 0)
        {
            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            NinthNumber = 1;
            PlayerPrefs.SetInt("NinthNumber", NinthNumber);
            NinthCheck(NinthNumber);
        }
        else if (NinthNumber == 1)
        {
            UNIT += 15000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            NinthNumber = 2;
            PlayerPrefs.SetInt("NinthNumber", NinthNumber);
            NinthCheck(NinthNumber);
        }
        else if (NinthNumber == 2)
        {
            UNIT += 30000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            NinthNumber = 3;
            PlayerPrefs.SetInt("NinthNumber", NinthNumber);
            NinthCheck(NinthNumber);
        }
        else if (NinthNumber == 3)
        {
            UNIT += 60000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            NinthNumber = 4;
            PlayerPrefs.SetInt("NinthNumber", NinthNumber);
            NinthCheck(NinthNumber);
        }
        else if (NinthNumber == 4)
        {
            UNIT += 100000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            NinthNumber = 5;
            PlayerPrefs.SetInt("NinthNumber", NinthNumber);
            NinthCheck(NinthNumber);
        }
    }

    void TenthCheck(int A)
    {
        if (A == 0)
        {
            TenthA.spriteName = "001_heart_bar";
            TenthB.spriteName = "001_heart_bar";
            TenthC.spriteName = "001_heart_bar";
            TenthD.spriteName = "001_heart_bar";
            TenthE.spriteName = "001_heart_bar";

            TenthCoin.text = "5000";
            TenthPlan.text = "상점에서 알 10번 까기";
            Tenthlabel.text = InfoEgg.ToString() + "/10";
            Tenthsp.fillAmount = InfoEgg * 0.1f;
            if (InfoEgg >= 10)
            {
                TenthReward.SetActive(true);
                Tenthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TenthReward.SetActive(false);
                Tenthing.SetActive(true);
            }
        }
        else if(A ==1)
        {
            TenthA.spriteName = "002_heart_p";
            TenthB.spriteName = "001_heart_bar";
            TenthC.spriteName = "001_heart_bar";
            TenthD.spriteName = "001_heart_bar";
            TenthE.spriteName = "001_heart_bar";

            TenthCoin.text = "10000";
            TenthPlan.text = "상점에서 알 30번 까기";
            Tenthlabel.text = InfoEgg.ToString() + "/30";
            Tenthsp.fillAmount = InfoEgg * 0.033f;
            if (InfoEgg >= 30)
            {
                TenthReward.SetActive(true);
                Tenthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TenthReward.SetActive(false);
                Tenthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            TenthA.spriteName = "002_heart_p";
            TenthB.spriteName = "002_heart_p";
            TenthC.spriteName = "001_heart_bar";
            TenthD.spriteName = "001_heart_bar";
            TenthE.spriteName = "001_heart_bar";

            TenthCoin.text = "25000";
            TenthPlan.text = "상점에서 알 70번 까기";
            Tenthlabel.text = InfoEgg.ToString() + "/70";
            Tenthsp.fillAmount = InfoEgg * 0.014f;
            if (InfoEgg >= 70)
            {
                TenthReward.SetActive(true);
                Tenthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TenthReward.SetActive(false);
                Tenthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            TenthA.spriteName = "002_heart_p";
            TenthB.spriteName = "002_heart_p";
            TenthC.spriteName = "002_heart_p";
            TenthD.spriteName = "001_heart_bar";
            TenthE.spriteName = "001_heart_bar";

            TenthCoin.text = "50000";
            TenthPlan.text = "상점에서 알 150번 까기";
            Tenthlabel.text = InfoEgg.ToString() + "/150";
            Tenthsp.fillAmount = InfoEgg * 0.0067f;
            if (InfoEgg >= 150)
            {
                TenthReward.SetActive(true);
                Tenthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TenthReward.SetActive(false);
                Tenthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            TenthA.spriteName = "002_heart_p";
            TenthB.spriteName = "002_heart_p";
            TenthC.spriteName = "002_heart_p";
            TenthD.spriteName = "002_heart_p";
            TenthE.spriteName = "001_heart_bar";

            TenthCoin.text = "100000";
            TenthPlan.text = "상점에서 알 300번 까기";
            Tenthlabel.text = InfoEgg.ToString() + "/300";
            Tenthsp.fillAmount = InfoEgg * 0.0033f;
            if (InfoEgg >= 300)
            {
                TenthReward.SetActive(true);
                Tenthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TenthReward.SetActive(false);
                Tenthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            TenthA.spriteName = "002_heart_p";
            TenthB.spriteName = "002_heart_p";
            TenthC.spriteName = "002_heart_p";
            TenthD.spriteName = "002_heart_p";
            TenthE.spriteName = "002_heart_p";

            TenthPlan.text = "상점에서 알 300번 까기";

            TenthReward.SetActive(false);
            Tenthing.SetActive(false);
            Tenthfalse.SetActive(false);

            TenthClear.SetActive(true);
        }
    }
    public void TenthOK()
    {
        Click();
        Coin();
        AchieveClear();
        CoinGet.SetActive(false);
        CoinGet.SetActive(true);
        if (TenthNumber == 0)
        {
            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TenthNumber = 1;
            PlayerPrefs.SetInt("TenthNumber", TenthNumber);
            TenthCheck(TenthNumber);
        }
        else if (TenthNumber == 1)
        {
            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TenthNumber = 2;
            PlayerPrefs.SetInt("TenthNumber", TenthNumber);
            TenthCheck(TenthNumber);
        }
        else if (TenthNumber == 2)
        {
            UNIT += 25000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TenthNumber = 3;
            PlayerPrefs.SetInt("TenthNumber", TenthNumber);
            TenthCheck(TenthNumber);
        }
        else if (TenthNumber == 3)
        {
            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TenthNumber = 4;
            PlayerPrefs.SetInt("TenthNumber", TenthNumber);
            TenthCheck(TenthNumber);
        }
        else if (TenthNumber == 4)
        {
            UNIT += 100000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TenthNumber = 5;
            PlayerPrefs.SetInt("TenthNumber", TenthNumber);
            TenthCheck(TenthNumber);
        }
    }

    void EleventhCheck(int A)
    {
        if (A == 0)
        {
            EleventhA.spriteName = "001_heart_bar";
            EleventhB.spriteName = "001_heart_bar";
            EleventhC.spriteName = "001_heart_bar";
            EleventhD.spriteName = "001_heart_bar";
            EleventhE.spriteName = "001_heart_bar";

            EleventhCoin.text = "3000";
            EleventhPlan.text = "높이날기 스킬 10번 사용";
            Eleventhlabel.text = InfoSkill.ToString() + "/10";
            Eleventhsp.fillAmount = InfoSkill * 0.1f;
            if (InfoSkill >= 10)
            {
                EleventhReward.SetActive(true);
                Eleventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EleventhReward.SetActive(false);
                Eleventhing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            EleventhA.spriteName = "002_heart_p";
            EleventhB.spriteName = "001_heart_bar";
            EleventhC.spriteName = "001_heart_bar";
            EleventhD.spriteName = "001_heart_bar";
            EleventhE.spriteName = "001_heart_bar";

            EleventhCoin.text = "10000";
            EleventhPlan.text = "높이날기 스킬 50번 사용";
            Eleventhlabel.text = InfoSkill.ToString() + "/50";
            Eleventhsp.fillAmount = InfoSkill * 0.02f;
            if (InfoSkill >= 50)
            {
                EleventhReward.SetActive(true);
                Eleventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EleventhReward.SetActive(false);
                Eleventhing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            EleventhA.spriteName = "002_heart_p";
            EleventhB.spriteName = "002_heart_p";
            EleventhC.spriteName = "001_heart_bar";
            EleventhD.spriteName = "001_heart_bar";
            EleventhE.spriteName = "001_heart_bar";

            EleventhCoin.text = "20000";
            EleventhPlan.text = "높이날기 스킬 100번 사용";
            Eleventhlabel.text = InfoSkill.ToString() + "/100";
            Eleventhsp.fillAmount = InfoSkill * 0.01f;
            if (InfoSkill >= 100)
            {
                EleventhReward.SetActive(true);
                Eleventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EleventhReward.SetActive(false);
                Eleventhing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            EleventhA.spriteName = "002_heart_p";
            EleventhB.spriteName = "002_heart_p";
            EleventhC.spriteName = "002_heart_p";
            EleventhD.spriteName = "001_heart_bar";
            EleventhE.spriteName = "001_heart_bar";

            EleventhCoin.text = "50000";
            EleventhPlan.text = "높이날기 스킬 200번 사용";
            Eleventhlabel.text = InfoSkill.ToString() + "/200";
            Eleventhsp.fillAmount = InfoSkill * 0.005f;
            if (InfoSkill >= 200)
            {
                EleventhReward.SetActive(true);
                Eleventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EleventhReward.SetActive(false);
                Eleventhing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            EleventhA.spriteName = "002_heart_p";
            EleventhB.spriteName = "002_heart_p";
            EleventhC.spriteName = "002_heart_p";
            EleventhD.spriteName = "002_heart_p";
            EleventhE.spriteName = "001_heart_bar";

            EleventhCoin.text = "100000";
            EleventhPlan.text = "높이날기 스킬 500번 사용";
            Eleventhlabel.text = InfoSkill.ToString() + "/500";
            Eleventhsp.fillAmount = InfoSkill * 0.002f;
            if (InfoSkill >= 500)
            {
                EleventhReward.SetActive(true);
                Eleventhing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                EleventhReward.SetActive(false);
                Eleventhing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            EleventhA.spriteName = "002_heart_p";
            EleventhB.spriteName = "002_heart_p";
            EleventhC.spriteName = "002_heart_p";
            EleventhD.spriteName = "002_heart_p";
            EleventhE.spriteName = "002_heart_p";

            EleventhPlan.text = "높이날기 스킬 500번 사용";

            EleventhReward.SetActive(false);
            Eleventhing.SetActive(false);
            Eleventhfalse.SetActive(false);

            EleventhClear.SetActive(true);
        }
    }
    public void EleventhOK()
    {
        Click();
        Coin();
        AchieveClear();
        CoinGet.SetActive(false);
        CoinGet.SetActive(true);
        if (EleventhNumber == 0)
        {
            UNIT += 3000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EleventhNumber = 1;
            PlayerPrefs.SetInt("EleventhNumber", EleventhNumber);
            EleventhCheck(EleventhNumber);
        }
        else if (EleventhNumber == 1)
        {
            UNIT += 10000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EleventhNumber = 2;
            PlayerPrefs.SetInt("EleventhNumber", EleventhNumber);
            EleventhCheck(EleventhNumber);
        }
        else if (EleventhNumber == 2)
        {
            UNIT += 20000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EleventhNumber = 3;
            PlayerPrefs.SetInt("EleventhNumber", EleventhNumber);
            EleventhCheck(EleventhNumber);
        }
        else if (EleventhNumber == 3)
        {
            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EleventhNumber = 4;
            PlayerPrefs.SetInt("EleventhNumber", EleventhNumber);
            EleventhCheck(EleventhNumber);
        }
        else if (EleventhNumber == 4)
        {
            UNIT += 100000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            EleventhNumber = 5;
            PlayerPrefs.SetInt("EleventhNumber", EleventhNumber);
            EleventhCheck(EleventhNumber);
        }
    }

    void TwelfthCheck(int A)
    {
        if (A == 0)
        {
            TwelfthA.spriteName = "001_heart_bar";
            TwelfthB.spriteName = "001_heart_bar";
            TwelfthC.spriteName = "001_heart_bar";
            TwelfthD.spriteName = "001_heart_bar";
            TwelfthE.spriteName = "001_heart_bar";

            TwelfthCoin.text = "3000";
            TwelfthPlan.text = "부작용 1번 체험하기";
            Twelfthlabel.text = InfoFuck.ToString() + "/1";
            Twelfthsp.fillAmount = InfoFuck * 1f;
            if (InfoFuck >= 1)
            {
                TwelfthReward.SetActive(true);
                Twelfthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TwelfthReward.SetActive(false);
                Twelfthing.SetActive(true);
            }
        }
        else if (A == 1)
        {
            TwelfthA.spriteName = "002_heart_p";
            TwelfthB.spriteName = "001_heart_bar";
            TwelfthC.spriteName = "001_heart_bar";
            TwelfthD.spriteName = "001_heart_bar";
            TwelfthE.spriteName = "001_heart_bar";

            TwelfthCoin.text = "7000";
            TwelfthPlan.text = "부작용 3번 체험하기";
            Twelfthlabel.text = InfoFuck.ToString() + "/3";
            Twelfthsp.fillAmount = InfoFuck * 0.33f;
            if (InfoFuck >= 3)
            {
                TwelfthReward.SetActive(true);
                Twelfthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TwelfthReward.SetActive(false);
                Twelfthing.SetActive(true);
            }
        }
        else if (A == 2)
        {
            TwelfthA.spriteName = "002_heart_p";
            TwelfthB.spriteName = "002_heart_p";
            TwelfthC.spriteName = "001_heart_bar";
            TwelfthD.spriteName = "001_heart_bar";
            TwelfthE.spriteName = "001_heart_bar";

            TwelfthCoin.text = "15000";
            TwelfthPlan.text = "부작용 10번 체험하기";
            Twelfthlabel.text = InfoFuck.ToString() + "/10";
            Twelfthsp.fillAmount = InfoFuck * 0.1f;
            if (InfoFuck >= 10)
            {
                TwelfthReward.SetActive(true);
                Twelfthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TwelfthReward.SetActive(false);
                Twelfthing.SetActive(true);
            }
        }
        else if (A == 3)
        {
            TwelfthA.spriteName = "002_heart_p";
            TwelfthB.spriteName = "002_heart_p";
            TwelfthC.spriteName = "002_heart_p";
            TwelfthD.spriteName = "001_heart_bar";
            TwelfthE.spriteName = "001_heart_bar";

            TwelfthCoin.text = "25000";
            TwelfthPlan.text = "부작용 20번 체험하기";
            Twelfthlabel.text = InfoFuck.ToString() + "/20";
            Twelfthsp.fillAmount = InfoFuck * 0.05f;
            if (InfoFuck >= 20)
            {
                TwelfthReward.SetActive(true);
                Twelfthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TwelfthReward.SetActive(false);
                Twelfthing.SetActive(true);
            }
        }
        else if (A == 4)
        {
            TwelfthA.spriteName = "002_heart_p";
            TwelfthB.spriteName = "002_heart_p";
            TwelfthC.spriteName = "002_heart_p";
            TwelfthD.spriteName = "002_heart_p";
            TwelfthE.spriteName = "001_heart_bar";

            TwelfthCoin.text = "50000";
            TwelfthPlan.text = "부작용 50번 체험하기";
            Twelfthlabel.text = InfoFuck.ToString() + "/50";
            Twelfthsp.fillAmount = InfoFuck * 0.02f;
            if (InfoFuck >= 50)
            {
                TwelfthReward.SetActive(true);
                Twelfthing.SetActive(false);
                AchieveCheck();
            }
            else
            {
                TwelfthReward.SetActive(false);
                Twelfthing.SetActive(true);
            }
        }
        else if (A == 5)
        {
            TwelfthA.spriteName = "002_heart_p";
            TwelfthB.spriteName = "002_heart_p";
            TwelfthC.spriteName = "002_heart_p";
            TwelfthD.spriteName = "002_heart_p";
            TwelfthE.spriteName = "002_heart_p";

            TwelfthPlan.text = "부작용 50번 체험하기";

            TwelfthReward.SetActive(false);
            Twelfthing.SetActive(false);
            Twelfthfalse.SetActive(false);

            TwelfthClear.SetActive(true);
        }
    }
    public void TwelfthOK()
    {
        Click();
        Coin();
        AchieveClear();
        CoinGet.SetActive(false);
        CoinGet.SetActive(true);
        if (TwelfthNumber == 0)
        {
            UNIT += 3000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TwelfthNumber = 1;
            PlayerPrefs.SetInt("TwelfthNumber", TwelfthNumber);
            TwelfthCheck(TwelfthNumber);
        }
        else if (TwelfthNumber == 1)
        {
            UNIT += 7000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TwelfthNumber = 2;
            PlayerPrefs.SetInt("TwelfthNumber", TwelfthNumber);
            TwelfthCheck(TwelfthNumber);
        }
        else if (TwelfthNumber == 2)
        {
            UNIT += 15000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TwelfthNumber = 3;
            PlayerPrefs.SetInt("TwelfthNumber", TwelfthNumber);
            TwelfthCheck(TwelfthNumber);
        }
        else if (TwelfthNumber == 3)
        {
            UNIT += 25000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TwelfthNumber = 4;
            PlayerPrefs.SetInt("TwelfthNumber", TwelfthNumber);
            TwelfthCheck(TwelfthNumber);
        }
        else if (TwelfthNumber == 4)
        {
            UNIT += 50000;
            PlayerPrefs.SetInt("UNIT", UNIT);

            TwelfthNumber = 5;
            PlayerPrefs.SetInt("TwelfthNumber", TwelfthNumber);
            TwelfthCheck(TwelfthNumber);
        }
    }
}
