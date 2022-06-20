using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour
{
    private int BD;
    private int UNIT;
    private int DORI;

    private int A , B , D , G , I , L , M , N , O , R , T , U;

    public UILabel FirstA, FirstB, FirstC, FirstD, FirstE, FirstF, FirstG;
    public UILabel SecondA, SecondB, SecondC, SecondD, SecondE, SecondF, SecondG;
    public UILabel ThirdA, ThirdB, ThirdC, ThirdD;
    public UILabel first, second, third;

    private int EventA; //남은횟수
    private int EventB;
    private int EventC;

    private int ANumber = 0;
    private int BNumber = 0;
    private int CNumber = 0;

    public GameObject NotionReward; //받음!
    public GameObject NotionX; //알파벳부족
    public GameObject NotionXX; //남은횟수부족

    public delegate void eventmanager();
    public static event eventmanager Click, Coin;
    void Awake()
    {
        NotionReward.SetActive(false);
        NotionX.SetActive(false);
        NotionXX.SetActive(false);

        //PlayerPrefs.SetInt("A",3);
        //PlayerPrefs.SetInt("B",3);
        //PlayerPrefs.SetInt("D",3);
        //PlayerPrefs.SetInt("G",3);
        //PlayerPrefs.SetInt("I",3);
        //PlayerPrefs.SetInt("M",3);
        //PlayerPrefs.SetInt("N",3);
        //PlayerPrefs.SetInt("O",3);
        //PlayerPrefs.SetInt("R",3);
        //PlayerPrefs.SetInt("T",3);
        //PlayerPrefs.SetInt("L",3);
        //PlayerPrefs.SetInt("U",3);
    }

    void OnEnable()
    {
        A = PlayerPrefs.GetInt("A", 0);
        B = PlayerPrefs.GetInt("B", 0);
        D = PlayerPrefs.GetInt("D", 0);
        G = PlayerPrefs.GetInt("G", 0);
        I = PlayerPrefs.GetInt("I", 0);
        L = PlayerPrefs.GetInt("L", 0);
        M = PlayerPrefs.GetInt("M", 0);
        N = PlayerPrefs.GetInt("N", 0);
        O = PlayerPrefs.GetInt("O", 0);
        R = PlayerPrefs.GetInt("R", 0);
        T = PlayerPrefs.GetInt("T", 0);
        U = PlayerPrefs.GetInt("U", 0);

        FirstCheck();
        SecondCheck();
        ThirdCheck();

        BD = PlayerPrefs.GetInt("BD",0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        DORI = PlayerPrefs.GetInt("DORI", 0);

        EventA = PlayerPrefs.GetInt("EventA", 0);
        EventB = PlayerPrefs.GetInt("EventB", 0);
        EventC = PlayerPrefs.GetInt("EventC", 0);

        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        ANumber = 0;
        BNumber = 0;
        CNumber = 0;
        StopAllCoroutines();
    }

    IEnumerator ModeCheck()
    {
        A = PlayerPrefs.GetInt("A", 0);
        B = PlayerPrefs.GetInt("B", 0);
        D = PlayerPrefs.GetInt("D", 0);
        G = PlayerPrefs.GetInt("G", 0);
        I = PlayerPrefs.GetInt("I", 0);
        L = PlayerPrefs.GetInt("L", 0);
        M = PlayerPrefs.GetInt("M", 0);
        N = PlayerPrefs.GetInt("N", 0);
        O = PlayerPrefs.GetInt("O", 0);
        R = PlayerPrefs.GetInt("R", 0);
        T = PlayerPrefs.GetInt("T", 0);
        U = PlayerPrefs.GetInt("U", 0);

        first.text = "남은횟수 : " + EventA.ToString();
        second.text = "남은횟수 : " + EventB.ToString();
        third.text = "남은횟수 : " + EventC.ToString();
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }

    void FirstCheck()
    {
        if(B == 0)
        {
            FirstA.color = new Color(255, 255, 255, 1);
            ANumber -= 1;
        }
        else
        {
            FirstA.color = new Color(0, 255, 0, 1);
            ANumber += 1;
        }

        if(U == 0)
        {
            FirstB.color = new Color(255, 255, 255, 1);
            ANumber -= 1;
        }
        else
        {
            FirstB.color = new Color(0, 255, 0, 1);
            ANumber += 1;
        }

        if (R == 0)
        {
            FirstC.color = new Color(255, 255, 255, 1);
            ANumber -= 1;
        }
        else
        {
            FirstC.color = new Color(0, 255, 0, 1);
            ANumber += 1;
        }

        if (N == 0)
        {
            FirstD.color = new Color(255, 255, 255, 1);
            FirstF.color = new Color(255, 255, 255, 1);
            ANumber -= 2;
        }
        else if (N == 1)
        {
            FirstD.color = new Color(0, 255, 0, 1);
            FirstF.color = new Color(255, 255, 255, 1);
            ANumber += 1;
        }
        else if (N >= 2)
        {
            FirstD.color = new Color(0, 255, 0, 1);
            FirstF.color = new Color(0, 255, 0, 1);
            ANumber += 2;
        }

        if (I ==0)
        {
            FirstE.color = new Color(255, 255, 255, 1);
            ANumber -= 1;
        }
        else
        {
            FirstE.color = new Color(0, 255, 0, 1);
            ANumber += 1;
        }

        if(G == 0)
        {
            FirstG.color = new Color(255, 255, 255, 1);
            ANumber -= 1;
        }
        else
        {
            FirstG.color = new Color(0, 255, 0, 1);
            ANumber += 1;
        }
    }
    void SecondCheck()
    {
        if (D == 0)
        {
            SecondA.color = new Color(255, 255, 255, 1);
            SecondG.color = new Color(255, 255, 255, 1);
            BNumber -= 2;
        }
        else if(D == 1)
        {
            SecondA.color = new Color(0, 255, 0, 1);
            SecondG.color = new Color(255, 255, 255, 1);
            BNumber += 1;
        }
        else if(D >= 2)
        {
            SecondA.color = new Color(0, 255, 0, 1);
            SecondG.color = new Color(0, 255, 0, 1);
            BNumber += 2;
        }

        if (I == 0)
        {
            SecondB.color = new Color(255, 255, 255, 1);
            BNumber -= 1;
        }
        else
        {
            SecondB.color = new Color(0, 255, 0, 1);
            BNumber += 1;
        }

        if (A == 0)
        {
            SecondC.color = new Color(255, 255, 255, 1);
            BNumber -= 1;
        }
        else
        {
            SecondC.color = new Color(0, 255, 0, 1);
            BNumber += 1;
        }

        if (M == 0)
        {
            SecondD.color = new Color(255, 255, 255, 1);
            BNumber -= 1;
        }
        else
        {
            SecondD.color = new Color(0, 255, 0, 1);
            BNumber += 1;
        }

        if (O == 0)
        {
            SecondE.color = new Color(255, 255, 255, 1);
            BNumber -= 1;
        }
        else
        {
            SecondE.color = new Color(0, 255, 0, 1);
            BNumber += 1;
        }

        if (N == 0)
        {
            SecondF.color = new Color(255, 255, 255, 1);
            BNumber -= 1;
        }
        else
        {
            SecondF.color = new Color(0, 255, 0, 1);
            BNumber += 1;
        }
    }
    void ThirdCheck()
    {
        if (G == 0)
        {
            ThirdA.color = new Color(255, 255, 255, 1);
            CNumber -= 1;
        }
        else
        {
            ThirdA.color = new Color(0, 255, 0, 1);
            CNumber += 1;
        }

        if (O == 0)
        {
            ThirdB.color = new Color(255, 255, 255, 1);
            CNumber -= 1;
        }
        else
        {
            ThirdB.color = new Color(0, 255, 0, 1);
            CNumber += 1;
        }

        if (L == 0)
        {
            ThirdC.color = new Color(255, 255, 255, 1);
            CNumber -= 1;
        }
        else
        {
            ThirdC.color = new Color(0, 255, 0, 1);
            CNumber += 1;
        }

        if (D == 0)
        {
            ThirdD.color = new Color(255, 255, 255, 1);
            CNumber -= 1;
        }
        else
        {
            ThirdD.color = new Color(0, 255, 0, 1);
            CNumber += 1;
        }
    }

    void FirstMinus()
    {
        B -= 1;
        PlayerPrefs.SetInt("B", B);
        U -= 1;
        PlayerPrefs.SetInt("U", U);
        R -= 1;
        PlayerPrefs.SetInt("R", R);
        N -= 2;
        PlayerPrefs.SetInt("N", N);
        I -= 1;
        PlayerPrefs.SetInt("I", I);
        G -= 1;
        PlayerPrefs.SetInt("G", G);

        ANumber = 0;
        BNumber = 0;
        CNumber = 0;

        FirstCheck();
        SecondCheck();
        ThirdCheck();
    }
    void SecondMinus()
    {
        D -= 2;
        PlayerPrefs.SetInt("D", D);
        I -= 1;
        PlayerPrefs.SetInt("I", I);
        A -= 1;
        PlayerPrefs.SetInt("A", A);
        M -= 1;
        PlayerPrefs.SetInt("M", M);
        O -= 1;
        PlayerPrefs.SetInt("O", O);
        N -= 1;
        PlayerPrefs.SetInt("N", N);

        ANumber = 0;
        BNumber = 0;
        CNumber = 0;

        FirstCheck();
        SecondCheck();
        ThirdCheck();
    }
    void ThirdMinus()
    {
        G -= 1;
        PlayerPrefs.SetInt("G", G);
        O -= 1;
        PlayerPrefs.SetInt("O", O);
        L -= 1;
        PlayerPrefs.SetInt("L", L);
        D -= 1;
        PlayerPrefs.SetInt("D", D);

        ANumber = 0;
        BNumber = 0;
        CNumber = 0;

        FirstCheck();
        SecondCheck();
        ThirdCheck();
    }

    public void RewardA()
    {
        Click();
        if (ANumber == 7)
        {
            if(EventA >= 1)
            {
                Coin();
                FirstMinus();
                EventA -= 1;
                PlayerPrefs.SetInt("EventA", EventA);
                DORI += 30;
                PlayerPrefs.SetInt("DORI", DORI);
                NotionReward.SetActive(false);
                NotionReward.SetActive(true);
            }
            else
            {
                NotionXX.SetActive(false);
                NotionXX.SetActive(true);
            }
        }
        else
        {
            NotionX.SetActive(false);
            NotionX.SetActive(true);
        }
    }
    public void RewardB()
    {
        Click();
        if (BNumber == 7)
        {
            if (EventB >= 1)
            {
                Coin();
                SecondMinus();
                EventB -= 1;
                PlayerPrefs.SetInt("EventB", EventB);
                BD += 250;
                PlayerPrefs.SetInt("BD", BD);
                NotionReward.SetActive(false);
                NotionReward.SetActive(true);
            }
            else
            {
                NotionXX.SetActive(false);
                NotionXX.SetActive(true);
            }
        }
        else
        {
            NotionX.SetActive(false);
            NotionX.SetActive(true);
        }
    }
    public void RewardC()
    {
        Click();
        if (CNumber == 4)
        {
            if (EventC >= 1)
            {
                Coin();
                ThirdMinus();
                EventC -= 1;
                PlayerPrefs.SetInt("EventC", EventC);
                UNIT += 50000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                NotionReward.SetActive(false);
                NotionReward.SetActive(true);
            }
            else
            {
                NotionXX.SetActive(false);
                NotionXX.SetActive(true);
            }
        }
        else
        {
            NotionX.SetActive(false);
            NotionX.SetActive(true);
        }
    }
}
