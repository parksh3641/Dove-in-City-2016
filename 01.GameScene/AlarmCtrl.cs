using UnityEngine;
using System.Collections;

public class AlarmCtrl : MonoBehaviour {

    public GameObject alarmA; //업적
    public GameObject alarmB; //아이템
    public GameObject alarmC; //수집
    public GameObject alarmD; //둥지
    public GameObject alarmE; //퀘스트
    public GameObject alarmF; //스킨

    public UILabel alarma;
    public UILabel alarmb;
    public UILabel alarmc;
    public UILabel alarmd;
    public UILabel alarme;
    public UILabel alarmf;

    private int BlackSkin;
    private int WhiteSkin;
    private int WowSkin;

    private int DoveEagle;
    private int DoveDori;

    private int Tutorial;
    private int QuestNumber = 0; //업적에 임무완료에 쓰임
    private int questNumber = 0; //임무 업적 숫자에 쓰임

    private int SkinNumber = 0;
    private int AlbumNumber = 0;

    private int AchieveNumber = 0;
    private int Touchdove;
    private int ThirdNumber;

    void Awake()
    {
        alarmA.SetActive(false);
        alarmB.SetActive(false);
        alarmC.SetActive(false);
        alarmD.SetActive(false);
        alarmE.SetActive(false);
        alarmF.SetActive(false);

        BlackSkin = PlayerPrefs.GetInt("BlackSkin", 0);
        if(BlackSkin ==1)
        {
            SkinNumber += 1;
            AlbumNumber += 1;
        }
        WhiteSkin = PlayerPrefs.GetInt("WhiteSkin", 0);
        if(WhiteSkin ==1)
        {
            SkinNumber += 1;
            AlbumNumber += 1;
        }
        WowSkin = PlayerPrefs.GetInt("WowSkin", 0);
        if(WowSkin ==1)
        {
            SkinNumber += 1;
            AlbumNumber += 1;
        }
        DoveEagle = PlayerPrefs.GetInt("DoveEagle", 0);
        if (DoveEagle == 1)
        {
            AlbumNumber += 1;
        }
        DoveDori = PlayerPrefs.GetInt("DoveDori", 0);
        if (DoveDori == 1)
        {
            AlbumNumber += 1;
        }

        if (AlbumNumber > 0)
        {
            alarmD.SetActive(true);
            alarmd.text = AlbumNumber.ToString();
        }
        if (SkinNumber > 0)
        {
            alarmF.SetActive(true);
            alarmf.text = SkinNumber.ToString();
        }

        Tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        QuestNumber = PlayerPrefs.GetInt("QuestNumber", 0);
        if(Tutorial == 0)
        {
            if (QuestNumber == 1)
            {
                alarmA.SetActive(true);
                alarma.text = "1";
            }
        }

        StartCoroutine(ModeCheck());
    }  
    IEnumerator ModeCheck()
    {
        Touchdove = PlayerPrefs.GetInt("Touchdove", 0);
        ThirdNumber = PlayerPrefs.GetInt("ThirdNumber", 0);
        if (ThirdNumber ==0)
        {
            if(Touchdove >= 200)
            {
                StopAllCoroutines();
                AchieveCheck();
            }
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
    void OnEnable()
    {
        AchieveManager.Clear += Clear;
        AchieveManager.AchieveClear += AchieveClear;
        AchieveManager.AchieveCheck += AchieveCheck;
        AchieveManager.AchieveEnd += AchieveEnd;

        Quest.questcheck += QuestCheck;
        Quest.questclear += QuestClear;
        Quest.questend += QuestEnd;

        SkinManager.SkinCheck += SkinCheck;
        Select.DoveCheck += DoveCheck;
    }
    void OnDisable()
    {
        AchieveManager.Clear -= Clear;
        AchieveManager.AchieveClear -= AchieveClear;
        AchieveManager.AchieveCheck -= AchieveCheck;
        AchieveManager.AchieveEnd -= AchieveEnd;

        Quest.questcheck -= QuestCheck;
        Quest.questclear -= QuestClear;
        Quest.questend -= QuestEnd;

        SkinManager.SkinCheck -= SkinCheck;
        Select.DoveCheck -= DoveCheck;
    }
    void AchieveCheck()
    {
        if(AchieveNumber ==0)
        {
            if (gameObject != null)
            {
                alarmA.SetActive(true);
            }
        }
        AchieveNumber += 1;
        alarma.text = AchieveNumber.ToString();
    }
    void AchieveClear()
    {
        AchieveNumber -= 1;
        alarma.text = AchieveNumber.ToString();
        if (AchieveNumber == 0)
        {
            alarmA.SetActive(false);
        }
    }
    void AchieveEnd()
    {
        AchieveNumber = 0;
    }

    void QuestCheck()
    {
        if(questNumber ==0)
        {
            if (gameObject != null)
            {
                alarmE.SetActive(true);
            }
        }
        questNumber += 1;
        alarme.text = questNumber.ToString();
    }
    void QuestClear()
    {
        questNumber -= 1;
        alarme.text = questNumber.ToString();
        if (questNumber == 0)
        {
            alarmE.SetActive(false);
        }
    }
    void QuestEnd()
    {
        questNumber = 0;
    }

    void SkinCheck()
    {
        SkinNumber -= 1;
        alarmf.text = SkinNumber.ToString();
        AlbumNumber -= 1;
        alarmd.text = AlbumNumber.ToString();
        if (SkinNumber ==0)
        {
            alarmF.SetActive(false);
        }
        if (AlbumNumber == 0)
        {
            alarmD.SetActive(false);
        }
    }
    void DoveCheck()
    {
        AlbumNumber -= 1;
        alarmd.text = AlbumNumber.ToString();
        if(AlbumNumber ==0)
        {
            alarmD.SetActive(false);
        }
    }
    void Clear()
    {
        AchieveNumber = 0;
        alarmA.SetActive(false);
    }
}
