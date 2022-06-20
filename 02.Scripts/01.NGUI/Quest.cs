using UnityEngine;
using System.Collections;

public class Quest : MonoBehaviour {
    //1번째 퀘스트
    private int FirstQuest;
    private int InfoBird;
    public GameObject Firstclear;
    public UILabel FirstMain;
    public GameObject First;

    //2번째 퀘스트
    private int SecondQuest;
    private int InfoCar;
    public GameObject Secondclear;
    public UILabel SecondMain;
    public GameObject Second;

    //기본퀘스트
    private int InfoTrash;
    public GameObject Unclear;

    //
    private int QuestOne;
    private int QuestTwo;

    //
    public GameObject Quest1;
    public GameObject Quest2;
    private int QuestNumber;
    public GameObject NotQuest;

    public GameObject QuestStart;
    //임무받기를 통해 임무획득
    private int QuestStartNumber;
    private int QuestGet;

    private int UNIT;
    public GameObject Info;
    public GameObject Reward;
    public UILabel InfoA;
    public UILabel InfoB;
    public UILabel InfoC;
    public UILabel InfoD;

    private int A =0;

    public UILabel Change;
    public GameObject Clear;
    public UIScrollBar bar;

    //퀘스트 완료목록
    public UISprite Quest11;
    public UISprite Quest12;
    public UISprite Quest13;
    public UISprite Quest14;
    public UISprite Quest15;
    public UISprite Quest16;

    public UISprite Quest21;
    public UISprite Quest22;
    public UISprite Quest23;
    public UISprite Quest24;
    public UISprite Quest25;
    public UISprite Quest26;
    public UISprite Quest27;
    public UISprite Quest28;

    private float Alpha = 0.5f;
    private int B;

    //타이머
    public UILabel Timelabel;
    public UISprite Questsp;

    public delegate void quest();
    public static event quest Click , Coin , questclear , questcheck , questend;

    void Awake()
    {
        Firstclear.SetActive(false);
        Secondclear.SetActive(false);

        Quest1.SetActive(true);
        Quest2.SetActive(false);

        QuestStartNumber = PlayerPrefs.GetInt("QuestStartNumber", 0);
        QuestCheck(QuestStartNumber);

        Info.SetActive(false);
        Reward.SetActive(false);
        Clear.SetActive(false);

        Quest11.alpha = Alpha;
        Quest12.alpha = Alpha;
        Quest13.alpha = Alpha;
        Quest14.alpha = Alpha;
        Quest15.alpha = Alpha;
        Quest16.alpha = Alpha;

        Quest21.alpha = Alpha;
        Quest22.alpha = Alpha;
        Quest23.alpha = Alpha;
        Quest24.alpha = Alpha;
        Quest25.alpha = Alpha;
        Quest26.alpha = Alpha;
        Quest27.alpha = Alpha;
        Quest28.alpha = Alpha;
    }
    void OnEnable()
    {
        InfoTrash = PlayerPrefs.GetInt("InfoTrash", 0);
        UnCheck();

        InfoBird = PlayerPrefs.GetInt("InfoBird", 0);
        FirstQuest = PlayerPrefs.GetInt("FirstQuest", 0);
        FirstCheck(FirstQuest);

        InfoCar = PlayerPrefs.GetInt("InfoCar", 0);
        SecondQuest = PlayerPrefs.GetInt("SecondQuest", 0);
        SecondCheck(SecondQuest);

        QuestNumber = PlayerPrefs.GetInt("QuestNumber", 0);

        UNIT = PlayerPrefs.GetInt("UNIT", 0);

        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        B = 0;
        questend();
        StopAllCoroutines();
    }
    void Update()
    {
        if (B >= 1)
        {
            Reward.SetActive(true);
        }
    }
    IEnumerator ModeCheck()
    {
        if (QuestGet == 0)
        {
            NotQuest.SetActive(true);
        }
        else
        {
            NotQuest.SetActive(false);
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }

    void QuestCheck(int A)
    {
        if(A ==0)
        {
            First.SetActive(false);
            Second.SetActive(false);
            Timelabel.text = "준비 됨";
            Questsp.alpha = 0.0f;
        }
        else if(A ==1)
        {
            First.SetActive(true);
            Second.SetActive(true);
            Timelabel.text = "없음";
            QuestGet = 1;
        }
    }
    void UnCheck()
    {
        Reward.SetActive(true);
        if (InfoTrash >= 20)
        {
            Unclear.SetActive(true);
            Reward.SetActive(true);
            questcheck();
            B = +1;
        }
        else
        {
            Unclear.SetActive(false);
            Reward.SetActive(false);
        }
    }
    void FirstCheck(int A)
    {
        Reward.SetActive(true);
        if (A ==0)
        {
            FirstMain.text = "동족 상잔!";
            if (InfoBird >= 20)
            {
                Firstclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Firstclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if(A ==1)
        {
            Quest11.alpha = 0.0f;
            FirstMain.text = "동족 상잔2";
            if (InfoBird >= 30)
            {
                Firstclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Firstclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 2)
        {
            Quest11.alpha = 0.0f;
            Quest12.alpha = 0.0f;
            FirstMain.text = "동족 상잔3";
            if (InfoBird >= 40)
            {
                Firstclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Firstclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 3)
        {
            Quest11.alpha = 0.0f;
            Quest12.alpha = 0.0f;
            Quest13.alpha = 0.0f;
            FirstMain.text = "동족 상잔4";
            if (InfoBird >= 50)
            {
                Firstclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Firstclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 4)
        {
            Quest11.alpha = 0.0f;
            Quest12.alpha = 0.0f;
            Quest13.alpha = 0.0f;
            Quest14.alpha = 0.0f;
            FirstMain.text = "동족 상잔5";
            if (InfoBird >= 60)
            {
                Firstclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Firstclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 5)
        {
            Quest11.alpha = 0.0f;
            Quest12.alpha = 0.0f;
            Quest13.alpha = 0.0f;
            Quest14.alpha = 0.0f;
            Quest15.alpha = 0.0f;
            FirstMain.text = "동족 상잔6";
            if (InfoBird >= 100)
            {
                Firstclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Firstclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if(A ==6)
        {
            Quest11.alpha = 0.0f;
            Quest12.alpha = 0.0f;
            Quest13.alpha = 0.0f;
            Quest14.alpha = 0.0f;
            Quest15.alpha = 0.0f;
            Quest16.alpha = 0.0f;

            First.SetActive(false);
        }
    }
    void SecondCheck(int A)
    {
        Reward.SetActive(true);
        if (A == 0)
        {
            SecondMain.text = "로드킬 미수";
            if (InfoCar >= 10)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if(A ==1)
        {
            Quest21.alpha = 0.0f;
            SecondMain.text = "로드킬 혐의";
            if (InfoCar >= 20)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 2)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            SecondMain.text = "로드킬 불구속 입건";
            if (InfoCar >= 30)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 3)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            Quest23.alpha = 0.0f;
            SecondMain.text = "로드킬 구속 입건";
            if (InfoCar >= 40)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 4)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            Quest23.alpha = 0.0f;
            Quest24.alpha = 0.0f;
            SecondMain.text = "로드킬 항소";
            if (InfoCar >= 50)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 5)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            Quest23.alpha = 0.0f;
            Quest24.alpha = 0.0f;
            Quest25.alpha = 0.0f;
            SecondMain.text = "로드킬 상고";
            if (InfoCar >= 60)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 6)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            Quest23.alpha = 0.0f;
            Quest24.alpha = 0.0f;
            Quest25.alpha = 0.0f;
            Quest26.alpha = 0.0f;
            SecondMain.text = "로드킬 대법원 판결";
            if (InfoCar >= 70)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if (A == 7)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            Quest23.alpha = 0.0f;
            Quest24.alpha = 0.0f;
            Quest25.alpha = 0.0f;
            Quest26.alpha = 0.0f;
            Quest27.alpha = 0.0f;
            SecondMain.text = "로드킬 Final";
            if (InfoCar >= 100)
            {
                Secondclear.SetActive(true);
                Reward.SetActive(true);
                questcheck();
                B = +1;
            }
            else
            {
                Secondclear.SetActive(false);
                Reward.SetActive(false);
            }
        }
        else if(A ==8)
        {
            Quest21.alpha = 0.0f;
            Quest22.alpha = 0.0f;
            Quest23.alpha = 0.0f;
            Quest24.alpha = 0.0f;
            Quest25.alpha = 0.0f;
            Quest26.alpha = 0.0f;
            Quest27.alpha = 0.0f;
            Quest28.alpha = 0.0f;

            Second.SetActive(false);
        }
    }

    public void Unquest()
    {
        Click();
        QuestOne = 3;

        Info.SetActive(true);
        InfoA.text = "기본 임무";
        InfoB.text = "쓰레기를 20번 먹는다\n";
        InfoC.text = InfoTrash.ToString() + "/20";
        InfoD.text = "5000";
    }
    public void Firstquest()
    {
        Click();
        QuestOne = 1;
        if (FirstQuest ==0)
        {
            Info.SetActive(true);
            InfoA.text = "동족 상잔!";
            InfoB.text = "비둘기를 20마리 먹는다\n";
            InfoC.text = InfoBird.ToString() + "/20";
            InfoD.text = "1000";
        }
        else if(FirstQuest ==1)
        {
            Info.SetActive(true);
            InfoA.text = "동족 상잔2";
            InfoB.text = "비둘기를 30마리 먹는다\n";
            InfoC.text = InfoBird.ToString() + "/30";
            InfoD.text = "2000";
        }
        else if (FirstQuest == 2)
        {
            Info.SetActive(true);
            InfoA.text = "동족 상잔3";
            InfoB.text = "비둘기를 40마리 먹는다\n";
            InfoC.text = InfoBird.ToString() + "/40";
            InfoD.text = "5000";
        }
        else if (FirstQuest == 3)
        {
            Info.SetActive(true);
            InfoA.text = "동족 상잔4";
            InfoB.text = "비둘기를 50마리 먹는다\n";
            InfoC.text = InfoBird.ToString() + "/50";
            InfoD.text = "10000";
        }
        else if (FirstQuest == 4)
        {
            Info.SetActive(true);
            InfoA.text = "동족 상잔5";
            InfoB.text = "비둘기를 60마리 먹는다\n";
            InfoC.text = InfoBird.ToString() + "/60";
            InfoD.text = "20000";
        }
        else if (FirstQuest == 5)
        {
            Info.SetActive(true);
            InfoA.text = "동족 상잔6";
            InfoB.text = "비둘기를 100마리 먹는다\n";
            InfoC.text = InfoBird.ToString() + "/100";
            InfoD.text = "100000";
        }
    }
    public void Secondquest()
    {
        Click();
        QuestOne = 2;
        if (SecondQuest == 0)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 미수";
            InfoB.text = "자동차에 10번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/10";
            InfoD.text = "1000";
        }
        else if (SecondQuest == 1)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 혐의";
            InfoB.text = "자동차에 20번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/20";
            InfoD.text = "2000";
        }
        else if (SecondQuest == 2)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 불구속 입건";
            InfoB.text = "자동차에 30번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/30";
            InfoD.text = "5000";
        }
        else if (SecondQuest == 3)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 구속 입건";
            InfoB.text = "자동차에 40번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/40";
            InfoD.text = "10000";
        }
        else if (SecondQuest == 4)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 항소";
            InfoB.text = "자동차에 50번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/50";
            InfoD.text = "20000";
        }
        else if (SecondQuest == 5)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 상고";
            InfoB.text = "자동차에 60번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/60";
            InfoD.text = "30000";
        }
        else if (SecondQuest == 6)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 대법원 판결";
            InfoB.text = "자동차에 70번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/70";
            InfoD.text = "50000";
        }
        else if (SecondQuest == 7)
        {
            Info.SetActive(true);
            InfoA.text = "로드킬 Final";
            InfoB.text = "자동차에 100번 부딪치고 살아남는다\n";
            InfoC.text = InfoCar.ToString() + "/100";
            InfoD.text = "100000";
        }
    }

    public void QuestClear()
    {
        Click();
        Coin();
        questclear();
        B = -1;
        Info.SetActive(false);
        Clear.SetActive(false);
        Clear.SetActive(true);
        if (QuestOne == 1)
        {
            if (FirstQuest == 0)
            {
                UNIT += 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                FirstQuest = 1;
                PlayerPrefs.SetInt("FirstQuest", FirstQuest);
                InfoBird -= 20;
                PlayerPrefs.SetInt("InfoBird", InfoBird);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                FirstCheck(FirstQuest);
            }
            else if (FirstQuest == 1)
            {
                UNIT += 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                FirstQuest = 2;
                PlayerPrefs.SetInt("FirstQuest", FirstQuest);
                InfoBird -= 30;
                PlayerPrefs.SetInt("InfoBird", InfoBird);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                FirstCheck(FirstQuest);
            }
            else if (FirstQuest == 2)
            {
                UNIT += 5000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                FirstQuest = 3;
                PlayerPrefs.SetInt("FirstQuest", FirstQuest);
                InfoBird -= 40;
                PlayerPrefs.SetInt("InfoBird", InfoBird);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                FirstCheck(FirstQuest);
            }
            else if (FirstQuest == 3)
            {
                UNIT += 10000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                FirstQuest = 4;
                PlayerPrefs.SetInt("FirstQuest", FirstQuest);
                InfoBird -= 50;
                PlayerPrefs.SetInt("InfoBird", InfoBird);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                FirstCheck(FirstQuest);
            }
            else if (FirstQuest == 4)
            {
                UNIT += 20000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                FirstQuest = 5;
                PlayerPrefs.SetInt("FirstQuest", FirstQuest);
                InfoBird -= 60;
                PlayerPrefs.SetInt("InfoBird", InfoBird);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                FirstCheck(FirstQuest);
            }
            else if (FirstQuest == 5)
            {
                UNIT += 100000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                FirstQuest = 6;
                PlayerPrefs.SetInt("FirstQuest", FirstQuest);
                InfoBird -= 100;
                PlayerPrefs.SetInt("InfoBird", InfoBird);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                FirstCheck(FirstQuest);
            }
            else if (FirstQuest == 6)
            {
                //읍슴
            }
        }
        else if (QuestOne == 2)
        {
            if (SecondQuest == 0)
            {
                UNIT += 1000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 1;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 10;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 1)
            {
                UNIT += 2000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 2;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 20;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 2)
            {
                UNIT += 5000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 3;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 30;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 3)
            {
                UNIT += 10000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 4;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 40;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 4)
            {
                UNIT += 20000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 5;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 50;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 5)
            {
                UNIT += 30000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 6;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 60;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 6)
            {
                UNIT += 50000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 7;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 70;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
            else if (SecondQuest == 7)
            {
                UNIT += 100000;
                PlayerPrefs.SetInt("UNIT", UNIT);
                SecondQuest = 8;
                PlayerPrefs.SetInt("SecondQuest", SecondQuest);
                InfoCar -= 100;
                PlayerPrefs.SetInt("InfoCar", InfoCar);
                QuestNumber += 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
                SecondCheck(SecondQuest);
            }
        }
        else if (QuestOne == 3)
        {
            UNIT += 5000;
            PlayerPrefs.SetInt("UNIT", UNIT);
            InfoTrash -= 20;
            PlayerPrefs.SetInt("InfoTrash", InfoTrash);
            UnCheck();
        }
    }
    public void InfoExit()
    {
        Click();
        Info.SetActive(false);
        QuestOne = 0;
        QuestTwo = 0;
    }

    public void QuestChange()
    {
        Click();
        if (A ==0)
        {
            A = 1;
            Quest1.SetActive(false);
            Quest2.SetActive(true);
            Change.text = "진행중인 퀘스트";
            bar.value = 0;
        }
        else if(A ==1)
        {
            A = 0;
            Quest1.SetActive(true);
            Quest2.SetActive(false);
            Change.text = "완료된 퀘스트";
            bar.value = 0;
        }
    }
    public void QuestGo()
    {
        Click();
        if(QuestStartNumber ==0)
        {
            Coin();
            QuestStart.SetActive(false);
            QuestStart.SetActive(true);
            QuestStartNumber = 1;
            PlayerPrefs.SetInt("QuestStartNumber", QuestStartNumber);
            QuestCheck(QuestStartNumber);
            Timelabel.text = "없음";
            Questsp.alpha = 0.4f;
            NotQuest.SetActive(false);
        }
    }

    public void UnPlus()
    {
        InfoTrash += 10;
        PlayerPrefs.SetInt("InfoTrash", InfoTrash);
        UnCheck();
    }
    public void FirstPlus()
    {
        InfoBird += 10;
        PlayerPrefs.SetInt("InfoBird", InfoBird);
        FirstCheck(FirstQuest);
    }
    public void SecondPlus()
    {
        InfoCar += 10;
        PlayerPrefs.SetInt("InfoCar", InfoCar);
        SecondCheck(SecondQuest);
    }
}
