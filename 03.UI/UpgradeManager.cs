using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour
{
    //1번째
    private int HeartNumber;

    public UILabel FirstCoin;
    public UILabel FirstMainA;
    public UILabel FirstMainB;
    public UILabel FirstLv;
    public UISprite Firstsp;

    //2번째
    private int SkillNumber;

    public UILabel SecondCoin;
    public UILabel SecondMainA;
    public UILabel SecondMainB;
    public UILabel SecondLv;
    public UISprite Secondsp;

    //3번째
    private int HitNumber;

    public UILabel ThirdCoin;
    public UILabel ThirdMainA;
    public UILabel ThirdMainB;
    public UILabel ThirdLv;
    public UISprite Thirdsp;

    //4번째
    private int CoinNumber;

    public UILabel ForthCoin;
    public UILabel ForthMainA;
    public UILabel ForthMainB;
    public UILabel ForthLv;
    public UISprite Forthsp;

    //5번째
    private int ContinueNumber;

    public UILabel FifthCoin;
    public UILabel FifthMainA;
    public UILabel FifthMainB;
    public UILabel FifthLv;
    public UISprite Fifthsp;

    //6번째
    private int CoinPlusNumber;

    public UILabel SixthCoin;
    public UILabel SixthMainA;
    public UILabel SixthMainB;
    public UILabel SixthLv;
    public UISprite Sixthsp;

    //

    private int UNIT;
    private int UpgradeCheck; //처음일경우 앙ㅋ
    public GameObject NotionCoin;
    public GameObject NotionUpgrade;
    public GameObject NotionUpgradeMax;

    public delegate void upgrademanager();
    public static event upgrademanager Click, Coin;

    void Awake()
    {
        NotionCoin.SetActive(false);
        NotionUpgrade.SetActive(false);
        NotionUpgradeMax.SetActive(false);
    }

    void OnEnable()
    {
        HeartNumber = PlayerPrefs.GetInt("HeartNumber", 0);
        FirstCheck(HeartNumber);

        SkillNumber = PlayerPrefs.GetInt("SkillNumber", 0);
        SecondCheck(SkillNumber);

        HitNumber = PlayerPrefs.GetInt("HitNumber", 0);
        ThirdCheck(HitNumber);

        CoinNumber = PlayerPrefs.GetInt("CoinNumber", 0);
        ForthCheck(CoinNumber);

        ContinueNumber = PlayerPrefs.GetInt("ContinueNumber", 0);
        FifthCheck(ContinueNumber);

        CoinPlusNumber = PlayerPrefs.GetInt("CoinPlusNumber", 0);
        SixthCheck(CoinPlusNumber);

        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator ModeCheck()
    {
        UNIT = PlayerPrefs.GetInt("UNIT", 0);

        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }

    void FirstCheck(int A)
    {
        FirstLv.text = "레벨 " + HeartNumber.ToString();
        Firstsp.fillAmount = HeartNumber * 0.09f;
        if (A == 1)
        {
            FirstCoin.text = "1000";
            FirstMainA.text = "50";
            FirstMainB.text = "+ 5";
        }
        else if (A == 2)
        {
            FirstCoin.text = "2000";
            FirstMainA.text = "55";
            FirstMainB.text = "+ 5";
        }
        else if (A == 3)
        {
            FirstCoin.text = "4000";
            FirstMainA.text = "60";
            FirstMainB.text = "+ 5";
        }
        else if (A == 4)
        {
            FirstCoin.text = "8000";
            FirstMainA.text = "65";
            FirstMainB.text = "+ 5";
        }
        else if (A == 5)
        {
            FirstCoin.text = "16000";
            FirstMainA.text = "70";
            FirstMainB.text = "+ 5";
        }
        else if (A == 6)
        {
            FirstCoin.text = "32000";
            FirstMainA.text = "75";
            FirstMainB.text = "+ 5";
        }
        else if (A == 7)
        {
            FirstCoin.text = "48000";
            FirstMainA.text = "80";
            FirstMainB.text = "+ 5";
        }
        else if (A == 8)
        {
            FirstCoin.text = "72000";
            FirstMainA.text = "85";
            FirstMainB.text = "+ 5";
        }
        else if (A == 9)
        {
            FirstCoin.text = "108000";
            FirstMainA.text = "90";
            FirstMainB.text = "+ 5";
        }
        else if (A == 10)
        {
            FirstCoin.text = "162000";
            FirstMainA.text = "95";
            FirstMainB.text = "+ 5";
        }
        else if (A == 11)
        {
            FirstCoin.text = "Max";
            FirstMainA.text = "100";
            FirstMainB.text = " ";
            Firstsp.fillAmount = 1f;
        }
    }
    public void FirstOK()
    {
        Click();
        if (HeartNumber == 1)
        {
            if (UNIT >= 1000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 2;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 2)
        {
            if (UNIT >= 2000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 3;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 3)
        {
            if (UNIT >= 4000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 4000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 4;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 4)
        {
            if (UNIT >= 8000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 8000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 5;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 5)
        {
            if (UNIT >= 16000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 16000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 6;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 6)
        {
            if (UNIT >= 32000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 32000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 7;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 7)
        {
            if (UNIT >= 48000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 48000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 8;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 8)
        {
            if (UNIT >= 72000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 72000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 9;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 9)
        {
            if (UNIT >= 108000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 108000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 10;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HeartNumber == 10)
        {
            if (UNIT >= 162000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 162000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HeartNumber = 11;
                PlayerPrefs.SetInt("HeartNumber", HeartNumber);
                FirstCheck(HeartNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else
        {
            NotionUpgradeMax.SetActive(false);
            NotionUpgradeMax.SetActive(true);
        }
    }

    void SecondCheck(int A)
    {
        SecondLv.text = "레벨 " + SkillNumber.ToString();
        Secondsp.fillAmount = SkillNumber * 0.09f;
        if (SkillNumber == 1)
        {
            SecondCoin.text = "1000";
            SecondMainA.text = "10초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 2)
        {
            SecondCoin.text = "2000";
            SecondMainA.text = "10.5초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 3)
        {
            SecondCoin.text = "4000";
            SecondMainA.text = "11초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 4)
        {
            SecondCoin.text = "8000";
            SecondMainA.text = "11.5초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 5)
        {
            SecondCoin.text = "16000";
            SecondMainA.text = "12초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 6)
        {
            SecondCoin.text = "32000";
            SecondMainA.text = "12.5초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 7)
        {
            SecondCoin.text = "48000";
            SecondMainA.text = "13초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 8)
        {
            SecondCoin.text = "72000";
            SecondMainA.text = "13.5초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 9)
        {
            SecondCoin.text = "108000";
            SecondMainA.text = "14초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 10)
        {
            SecondCoin.text = "162000";
            SecondMainA.text = "14.5초";
            SecondMainB.text = "+ 0.5초";
        }
        else if (SkillNumber == 11)
        {
            SecondCoin.text = "Max";
            SecondMainA.text = "15초";
            SecondMainB.text = " ";
            Secondsp.fillAmount = 1f;
        }
    }
    public void SecondOK()
    {
        Click();
        if (SkillNumber == 1)
        {
            if (UNIT >= 1000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 2;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 2)
        {
            if (UNIT >= 2000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 3;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 3)
        {
            if (UNIT >= 4000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 4000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 4;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 4)
        {
            if (UNIT >= 8000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 8000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 5;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 5)
        {
            if (UNIT >= 16000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 16000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 6;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 6)
        {
            if (UNIT >= 32000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 32000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 7;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 7)
        {
            if (UNIT >= 48000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 48000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 8;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 8)
        {
            if (UNIT >= 72000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 72000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 9;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 9)
        {
            if (UNIT >= 108000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 108000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 10;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (SkillNumber == 10)
        {
            if (UNIT >= 162000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 162000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SkillNumber = 11;
                PlayerPrefs.SetInt("SkillNumber", SkillNumber);
                SecondCheck(SkillNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else
        {
            NotionUpgradeMax.SetActive(false);
            NotionUpgradeMax.SetActive(true);
        }
    }

    void ThirdCheck(int A)
    {
        ThirdLv.text = "레벨 " + HitNumber.ToString();
        Thirdsp.fillAmount = HitNumber * 0.09f;
        if (A == 1)
        {
            ThirdCoin.text = "1000";
            ThirdMainA.text = "2.1초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 2)
        {
            ThirdCoin.text = "2000";
            ThirdMainA.text = "2.25초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 3)
        {
            ThirdCoin.text = "4000";
            ThirdMainA.text = "2.4초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 4)
        {
            ThirdCoin.text = "8000";
            ThirdMainA.text = "2.55초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 5)
        {
            ThirdCoin.text = "16000";
            ThirdMainA.text = "2.7초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 6)
        {
            ThirdCoin.text = "32000";
            ThirdMainA.text = "2.85초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 7)
        {
            ThirdCoin.text = "48000";
            ThirdMainA.text = "3초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 8)
        {
            ThirdCoin.text = "72000";
            ThirdMainA.text = "3.15초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 9)
        {
            ThirdCoin.text = "108000";
            ThirdMainA.text = "3.3초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 10)
        {
            ThirdCoin.text = "162000";
            ThirdMainA.text = "3.45초";
            ThirdMainB.text = "+ 0.15초";
        }
        else if (A == 11)
        {
            ThirdCoin.text = "Max";
            ThirdMainA.text = "3.6초";
            ThirdMainB.text = " ";
            Thirdsp.fillAmount = 1f;
        }
    }
    public void ThirdOK()
    {
        Click();
        if (HitNumber == 1)
        {
            if (UNIT >= 1000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 2;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 2)
        {
            if (UNIT >= 2000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 3;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 3)
        {
            if (UNIT >= 4000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 4000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 4;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 4)
        {
            if (UNIT >= 8000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 8000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 5;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 5)
        {
            if (UNIT >= 16000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 16000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 6;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 6)
        {
            if (UNIT >= 32000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 32000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 7;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 7)
        {
            if (UNIT >= 48000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 48000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 8;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 8)
        {
            if (UNIT >= 72000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 72000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 9;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 9)
        {
            if (UNIT >= 108000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 108000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 10;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (HitNumber == 10)
        {
            if (UNIT >= 162000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 162000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                HitNumber = 11;
                PlayerPrefs.SetInt("HitNumber", HitNumber);
                ThirdCheck(HitNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else
        {
            NotionUpgradeMax.SetActive(false);
            NotionUpgradeMax.SetActive(true);
        }
    }

    void ForthCheck(int A)
    {
        ForthLv.text = "레벨 " + CoinNumber.ToString();
        Forthsp.fillAmount = CoinNumber * 0.09f;
        if (A == 1)
        {
            ForthCoin.text = "1000";
            ForthMainA.text = "50%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 2)
        {
            ForthCoin.text = "2000";
            ForthMainA.text = "55%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 3)
        {
            ForthCoin.text = "4000";
            ForthMainA.text = "60%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 4)
        {
            ForthCoin.text = "8000";
            ForthMainA.text = "65%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 5)
        {
            ForthCoin.text = "16000";
            ForthMainA.text = "70%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 6)
        {
            ForthCoin.text = "32000";
            ForthMainA.text = "75%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 7)
        {
            ForthCoin.text = "48000";
            ForthMainA.text = "80%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 8)
        {
            ForthCoin.text = "72000";
            ForthMainA.text = "85%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 9)
        {
            ForthCoin.text = "108000";
            ForthMainA.text = "90%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 10)
        {
            ForthCoin.text = "162000";
            ForthMainA.text = "95%";
            ForthMainB.text = "+ 5%";
        }
        else if (A == 11)
        {
            ForthCoin.text = "Max";
            ForthMainA.text = "100%";
            ForthMainB.text = " ";
            Forthsp.fillAmount = 1f;
        }
    }
    public void ForthOK()
    {
        Click();
        if (CoinNumber == 1)
        {
            if (UNIT >= 1000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 2;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 2)
        {
            if (UNIT >= 2000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 3;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 3)
        {
            if (UNIT >= 4000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 4000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 4;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 4)
        {
            if (UNIT >= 8000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 8000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 5;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 5)
        {
            if (UNIT >= 16000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 16000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 6;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 6)
        {
            if (UNIT >= 32000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 32000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 7;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 7)
        {
            if (UNIT >= 48000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 48000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 8;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 8)
        {
            if (UNIT >= 72000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 72000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 9;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 9)
        {
            if (UNIT >= 108000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 108000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 10;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinNumber == 10)
        {
            if (UNIT >= 162000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 162000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinNumber = 11;
                PlayerPrefs.SetInt("CoinNumber", CoinNumber);
                ForthCheck(CoinNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else
        {
            NotionUpgradeMax.SetActive(false);
            NotionUpgradeMax.SetActive(true);
        }
    }

    void FifthCheck(int A)
    {
        FifthLv.text = "레벨 " + ContinueNumber.ToString();
        Fifthsp.fillAmount = ContinueNumber * 0.17f;
        if (A == 1)
        {
            FifthCoin.text = "4000";
            FifthMainA.text = "10번";
            FifthMainB.text = "+ 1번";
        }
        else if (A == 2)
        {
            FifthCoin.text = "8000";
            FifthMainA.text = "11번";
            FifthMainB.text = "+ 1번";
        }
        else if (A == 3)
        {
            FifthCoin.text = "16000";
            FifthMainA.text = "12번";
            FifthMainB.text = "+ 1번";
        }
        else if (A == 4)
        {
            FifthCoin.text = "32000";
            FifthMainA.text = "13번";
            FifthMainB.text = "+ 1번";
        }
        else if (A == 5)
        {
            FifthCoin.text = "64000";
            FifthMainA.text = "14번";
            FifthMainB.text = "+ 1번";
        }
        else if (A == 6)
        {
            FifthCoin.text = "Max";
            FifthMainA.text = "15번";
            FifthMainB.text = " ";
        }
    }
    public void FifthOK()
    {
        Click();
        if (ContinueNumber == 1)
        {
            if (UNIT >= 4000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 4000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                ContinueNumber = 2;
                PlayerPrefs.SetInt("ContinueNumber", ContinueNumber);
                FifthCheck(ContinueNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (ContinueNumber == 2)
        {
            if (UNIT >= 8000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 8000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                ContinueNumber = 3;
                PlayerPrefs.SetInt("ContinueNumber", ContinueNumber);
                FifthCheck(ContinueNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (ContinueNumber == 3)
        {
            if (UNIT >= 16000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 16000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                ContinueNumber = 4;
                PlayerPrefs.SetInt("ContinueNumber", ContinueNumber);
                FifthCheck(ContinueNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (ContinueNumber == 4)
        {
            if (UNIT >= 32000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 32000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                ContinueNumber = 5;
                PlayerPrefs.SetInt("ContinueNumber", ContinueNumber);
                FifthCheck(ContinueNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (ContinueNumber == 5)
        {
            if (UNIT >= 64000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 64000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                ContinueNumber = 6;
                PlayerPrefs.SetInt("ContinueNumber", ContinueNumber);
                FifthCheck(ContinueNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else
        {
            NotionUpgradeMax.SetActive(false);
            NotionUpgradeMax.SetActive(true);
        }
    }

    void SixthCheck(int A)
    {
        SixthLv.text = "레벨 " + CoinPlusNumber.ToString();
        Sixthsp.fillAmount = CoinPlusNumber * 0.095f;
        if (A == 1)
        {
            SixthCoin.text = "1000";
            SixthMainA.text = "30";
            SixthMainB.text = "+ 3";
        }
        else if (A == 2)
        {
            SixthCoin.text = "2000";
            SixthMainA.text = "33";
            SixthMainB.text = "+ 3";
        }
        else if (A == 3)
        {
            SixthCoin.text = "4000";
            SixthMainA.text = "36";
            SixthMainB.text = "+ 3";
        }
        else if (A == 4)
        {
            SixthCoin.text = "8000";
            SixthMainA.text = "39";
            SixthMainB.text = "+ 3";
        }
        else if (A == 5)
        {
            SixthCoin.text = "16000";
            SixthMainA.text = "42";
            SixthMainB.text = "+ 3";
        }
        else if (A == 6)
        {
            SixthCoin.text = "32000";
            SixthMainA.text = "45";
            SixthMainB.text = "+ 3";
        }
        else if (A == 7)
        {
            SixthCoin.text = "48000";
            SixthMainA.text = "48";
            SixthMainB.text = "+ 3";
        }
        else if (A == 8)
        {
            SixthCoin.text = "72000";
            SixthMainA.text = "51";
            SixthMainB.text = "+ 3";
        }
        else if (A == 9)
        {
            SixthCoin.text = "108000";
            SixthMainA.text = "54";
            SixthMainB.text = "+ 3";
        }
        else if (A == 10)
        {
            SixthCoin.text = "162000";
            SixthMainA.text = "57";
            SixthMainB.text = "+ 3";
        }
        else if (A == 11)
        {
            SixthCoin.text = "Max";
            SixthMainA.text = "60";
            SixthMainB.text = " ";
        }
    }
    public void SixthOK()
    {
        Click();
        if (CoinPlusNumber == 1)
        {
            if (UNIT >= 1000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 2;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 2)
        {
            if (UNIT >= 2000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 3;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 3)
        {
            if (UNIT >= 4000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 4000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 4;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 4)
        {
            if (UNIT >= 8000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 8000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 5;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 5)
        {
            if (UNIT >= 16000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 16000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 6;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 6)
        {
            if (UNIT >= 32000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 32000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 7;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 7)
        {
            if (UNIT >= 48000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 48000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 8;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 8)
        {
            if (UNIT >= 72000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 72000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 9;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 9)
        {
            if (UNIT >= 108000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 108000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 10;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else if (CoinPlusNumber == 10)
        {
            if (UNIT >= 162000)
            {
                Coin();
                NotionUpgrade.SetActive(false);
                NotionUpgrade.SetActive(true);
                UNIT -= 162000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                CoinPlusNumber = 11;
                PlayerPrefs.SetInt("CoinPlusNumber", CoinPlusNumber);
                SixthCheck(CoinPlusNumber);
            }
            else
            {
                NotionCoin.SetActive(false);
                NotionCoin.SetActive(true);
            }
        }
        else
        {
            NotionUpgradeMax.SetActive(false);
            NotionUpgradeMax.SetActive(true);
        }
    }
}
