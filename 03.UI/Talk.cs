using UnityEngine;
using System.Collections;

public class Talk : MonoBehaviour {

    public GameObject MainUI;
    public GameObject TalkUI;

    public GameObject Godsp;
    public GameObject Molesp;

    public GameObject NotionGod;
    public GameObject NotionMole;

    public float Cooltime = 0.5f;

    public UISprite GodSprite;
    public UILabel MainName;
    public UILabel MainTalk;

    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Next;
    public GameObject Ok;

    private int Anum;
    private int UNIT;
    private int InfoTalk;

    public UILabel Onetxt;
    public UILabel Twotxt;
    public UILabel Threetxt;

    private int A = 0; //깃털 얻을 확률   
    private int B = 0;

    private int TalkValue = 0; //대화하는 사람 종류
    private int TalkStart = 0; //대화종류설정
    private int TalkNumber = 0;

    private AudioSource source;
    public AudioClip Click;
    public AudioClip Oha;

    public delegate void talk();
    public static event talk TalkEnd , HitDie , WhatDie , DoriFeather , Talking , UnderWorld;
    void Awake()
    {
        source = GetComponent<AudioSource>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Anum = PlayerPrefs.GetInt("Anum", 0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        InfoTalk = PlayerPrefs.GetInt("InfoTalk", 0);
        MainUI.SetActive(true);
        TalkUI.SetActive(false);

        NotionGod.SetActive(false);
        NotionMole.SetActive(false);

        Next.SetActive(false);
        Ok.SetActive(false);
    }
    void OnEnable()
    {
        GodCtrl.GodTalk += GodTalk;
        GodCtrl.MoleTalk += MoleTalk;
        GameManager.TalkStart += GodTalk;
    }
    void OnDisable()
    {
        GodCtrl.GodTalk -= GodTalk;
        GodCtrl.MoleTalk -= MoleTalk;
        GameManager.TalkStart -= GodTalk;
    }
    //대화설정
    void GodTalk()
    {
        source.PlayOneShot(Oha, 0.75f);
        Talking();
        Next.SetActive(false);
        Ok.SetActive(false);
        Godsp.SetActive(true);
        Molesp.SetActive(false);

        NotionGod.SetActive(false);
        NotionGod.SetActive(true);

        TalkValue = 0;
        InfoTalk += 1;
        PlayerPrefs.SetInt("InfoTalk", InfoTalk);
        TalkSetting();
    }
    void MoleTalk()
    {
        source.PlayOneShot(Oha, 0.75f);
        Talking();
        Next.SetActive(false);
        Ok.SetActive(false);
        Godsp.SetActive(false);
        Molesp.SetActive(true);

        NotionMole.SetActive(false);
        NotionMole.SetActive(true);

        TalkValue = 1;
        InfoTalk += 1;
        PlayerPrefs.SetInt("InfoTalk", InfoTalk);
        TalkSetting();
    }

    void TalkSetting()
    {
        MainUI.SetActive(false);
        TalkUI.SetActive(true);

        if (TalkValue ==0)
        {
            GodSprite.spriteName = "산신령 본체";
            MainName.text = "산신령 (2300세)";
        }
        else if(TalkValue ==1)
        {
            GodSprite.spriteName = "Mole5";
            MainName.text = "두더지 (3세)";
        }
        TalkNumSetting();
    }
    //대화시작
    void TalkNumSetting()
    {
        if(TalkValue ==0)
        {
            B = Random.Range(0, 100);
            if (B < 45)
            {
                TalkStart = 0;
            }
            else if (B < 90)
            {
                TalkStart = 1;
            }
            else if (B < 100)
            {
                TalkStart = 2;
            }

            GodTalkStart();
        }
        else if(TalkValue ==1)
        {
            B = Random.Range(0, 2);
            if(B == 0)
            {
                TalkStart = 0;
            }
            else
            {
                TalkStart = 1;
            }
            MoleTalkStart();
        }
    }
    void GodTalkStart()
    {
        if(TalkStart == 0)
        {
            MainTalk.text = "금도끼가 내것이냐 네것이냐?\n\n";
        }
        else if(TalkStart ==1)
        {
            MainTalk.text = "니 몇살인데 눈을 그렇게 뜨냐?\n\n";
        }
        else if (TalkStart == 2)
        {
            MainTalk.text = "나에게 오다니 용기가 가상다도다.\n\n";
        }
        Answer();
    }
    void MoleTalkStart()
    {
        if (TalkStart == 0)
        {
            MainTalk.text = "나 쓰다듬어줄래?\n\n";
        }
        else if (TalkStart == 1)
        {
            MainTalk.text = "지하세계 구경할래?\n\n";
        }
        Answer();
    }

    //대화후 대답설정
    void Answer()
    {
        One.SetActive(true);
        Two.SetActive(true);
        Three.SetActive(true);
        if(TalkValue ==0)
        {
            if (TalkStart == 0)
            {
                Onetxt.text = "\n제것입니다.\n";
                Twotxt.text = "\n제것이 아닙니다.\n";
                Threetxt.text = "왜 산신령이\n산에서 안살고\n물속에서 살아요?";
            }
            else if (TalkStart ==1)
            {
                Onetxt.text = "죄송합니다.\n2살 입니다.\n";
                Twotxt.text = "\n틀딱 극혐!\n";
                Threetxt.text = "\n반하셨나요?\n";
            }
            else if (TalkStart == 2)
            {
                Onetxt.text = "과찬이십니다.\n(권장)";
                Twotxt.text = "시끄러워!\n아이템이나 줘!";
                Threetxt.text = "시끄러워!\n돈이나 얼른줘!";
            }
        }
        else if(TalkValue ==1)
        {
            if (TalkStart == 0)
            {
                Onetxt.text = "\n그래.\n";
                Twotxt.text = "\n그래!\n";
                Threetxt.text = "\n그래?\n";
            }
            else if (TalkStart == 1)
            {
                Onetxt.text = "\n싫은데?\n";
                Twotxt.text = "\n그래\n";
                Threetxt.text = "\n(도망친다)\n";
            }
        }
    }
    //대화끝남
    void AnswerEnd()
    {
        One.SetActive(false);
        Two.SetActive(false);
        Three.SetActive(false);
        Next.SetActive(true);
    }

    public void OneBtn()
    {
        source.PlayOneShot(Click, 0.75f);
        if (TalkValue ==0)
        {
            TalkNumber = 0;
            if (TalkStart ==0)
            {
                MainTalk.text = "허허 적절한 야부리는 현대사회의 미덕이란다. 여기 있다.\n";
                AnswerEnd();
            }
            else if(TalkStart ==1)
            {
                MainTalk.text = "제 1회 올림픽도 못본게 어디서!\n\n";
                AnswerEnd();
            }
            else if(TalkStart ==2)
            {
                MainTalk.text = "겸손은 더이상 사회의 미덕이 아니다!\n";
                AnswerEnd();
            }
        }
        else if(TalkValue ==1)
        {
            TalkNumber = 0;
            if (TalkStart == 0)
            {
                MainTalk.text = "이상한 느낌이다\n\n";
                AnswerEnd();
            }
            else if (TalkStart == 1)
            {
                MainTalk.text = "싫다면 더더욱 구경시켜 줘야지!\n\n";
                AnswerEnd();
            }
        }
    }
    public void TwoBtn()
    {
        source.PlayOneShot(Click, 0.75f);
        if (TalkValue == 0)
        {
            TalkNumber = 1;
            if (TalkStart == 0)
            {
                MainTalk.text = "내가 제일 싫어하는 두가지가 있어.\n첫번째는 탕수육에 소스 부어먹는 것, 두번째는 착한척 하는 거라네.";
                AnswerEnd();
            }
            else if (TalkStart == 1)
            {
                MainTalk.text = "허허 귀엽노라\n\n";
                AnswerEnd();
            }
            else if (TalkStart == 2)
            {
                MainTalk.text = "어엇?! 여기 있습니다.\n\n";
                AnswerEnd();
            }
        }
        else if (TalkValue == 1)
        {
            TalkNumber = 1;
            if (TalkStart == 0)
            {
                MainTalk.text = "이상한 느낌이다\n\n";
                AnswerEnd();
            }
            else if (TalkStart == 1)
            {
                MainTalk.text = "좋다면 더더욱 구경시켜 줘야지!\n\n";
                AnswerEnd();
            }
        }
    }
    public void ThreeBtn()
    {
        source.PlayOneShot(Click, 0.75f);
        if (TalkValue == 0)
        {
            TalkNumber = 2;
            if (TalkStart == 0)
            {
                MainTalk.text = "보증금 올라서..\n\n";
                AnswerEnd();
            }
            else if (TalkStart == 1)
            {
                MainTalk.text = "뭬야?? 여봐라 이놈을 당장 쳐라! 어? 맞다 이젠 나밖에 없지..\n";
                AnswerEnd();
            }
            else if (TalkStart == 2)
            {
                MainTalk.text = "어엇?! 여기 있습니다.\n\n";
                AnswerEnd();
            }
        }
        else if (TalkValue == 1)
        {
            TalkNumber = 2;
            if (TalkStart == 0)
            {
                MainTalk.text = "이상한 느낌이다\n\n";
                AnswerEnd();
            }
            else if (TalkStart == 1)
            {
                MainTalk.text = "(뒤도 돌아보지 않고 도망쳤다)\n\n";
                AnswerEnd();
            }
        }
    }
    public void NextBtn()
    {
        source.PlayOneShot(Click, 0.75f);
        Next.SetActive(false);
        Ok.SetActive(true);
        if (TalkValue == 0)
        {
            if (TalkStart == 0)
            {
                if (TalkNumber == 0)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "눈이 침침해 도라의 깃털이 금도끼로 보였나보다\n도라의 깃털을 획득";
                    }
                    else
                    {
                        MainTalk.text = "산신령으로부터 온전한 하트 획득\n\n";
                    }
                }
                else if (TalkNumber == 1)
                {
                    MainTalk.text = "산신령이 내게 팔콘펀치를 날렸다.\n\n";
                }
                else if (TalkNumber == 2)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "눈이 침침해 도라의 깃털이 금도끼로 보였나보다\n도라의 깃털을 획득";
                    }
                    else
                    {
                        MainTalk.text = "산신령으로부터 온전한 하트 획득\n\n";
                    }
                }
            }
            else if (TalkStart == 1)
            {
                if (TalkNumber == 0)
                {
                    MainTalk.text = "눈을 부라리다 산신령에게 팔콘펀치를 날렸다.\n";
                }
                else if (TalkNumber == 1)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "산신령으로부터 도라의 깃털을 획득\n\n";
                    }
                    else
                    {
                        MainTalk.text = "산신령으로부터 온전한 하트 획득\n\n";
                    }
                }
                else if (TalkNumber == 2)
                {
                    MainTalk.text = "산신령이 내게 팔콘킥을 날렸다.\n\n";
                }
 
            }
            else if (TalkStart == 2)
            {
                if (TalkNumber == 0)
                {
                    MainTalk.text = "산신령이 기분나빠 한대 쳤다.\n\n";
                }
                else if (TalkNumber == 1)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "산신령으로부터 도라의 깃털을 획득\n\n";
                    }
                    else
                    {
                        MainTalk.text = "산신령으로부터 온전한 하트를 획득\n";
                    }
                }
                else if (TalkNumber == 2)
                {
                    MainTalk.text = "1000 Coin 획득\n\n";
                }
            }
        }
        else if(TalkValue ==1 )
        {
            if (TalkStart == 0)
            {
                if (TalkNumber == 0)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "두더지를 쓰다듬자 몸이 이상하다.\n\n";
                    }
                    else
                    {
                        MainTalk.text = "두더지를 쓰다듬어 줬지만\n내몸에는 아무 이상이 없는 것 같다\n";
                    }
                }
                else if (TalkNumber == 1)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "두더지를 쓰다듬자 몸이 이상하다.\n\n";
                    }
                    else
                    {
                        MainTalk.text = "두더지를 쓰다듬어 줬지만\n내몸에는 아무 이상이 없는 것 같다\n";
                    }
                }
                else if (TalkNumber == 2)
                {
                    A = Random.Range(0, 2);
                    if (A == 0)
                    {
                        MainTalk.text = "두더지를 쓰다듬자 몸이 이상하다.\n\n";
                    }
                    else
                    {
                        MainTalk.text = "두더지를 쓰다듬어 줬지만\n내몸에는 아무 이상이 없는 것 같다\n";
                    }
                }
            }
            else if (TalkStart == 1)
            {
                if (TalkNumber == 0)
                {
                    MainTalk.text = "이상한 지하실로 갔다.\n\n";
                }
                else if (TalkNumber == 1)
                {
                    MainTalk.text = "이상한 지하실로 갔다.\n\n";
                }
                else if (TalkNumber == 2)
                {
                    MainTalk.text = "성공적으로 도망쳤다.\n\n";
                }
            }
        }
    }
    public void OkBtn()
    {
        source.PlayOneShot(Click, 0.75f);
        MainUI.SetActive(true);
        TalkUI.SetActive(false);
        TalkEnd();
        if (TalkValue == 0)
        {
            if (TalkStart == 0)
            {
                if(TalkNumber ==0)
                {
                    if (A == 0)
                    {
                        DoriFeather();
                    }
                    else
                    {
                        Anum += 1;
                        PlayerPrefs.SetInt("Anum", Anum);
                    }
                }
                else if(TalkNumber ==1)
                {
                    HitDie();
                }
                else if(TalkNumber ==2)
                {
                    if (A == 0)
                    {
                        DoriFeather();
                    }
                    else
                    {
                        Anum += 1;
                        PlayerPrefs.SetInt("Anum", Anum);
                    }
                }
            }
            else if(TalkStart ==1)
            {
                if(TalkNumber ==0)
                {
                    HitDie();
                }
                else if(TalkNumber ==1)
                {
                    if (A == 0)
                    {
                        DoriFeather();
                    }
                    else
                    {
                        Anum += 1;
                        PlayerPrefs.SetInt("Anum", Anum);
                    }
                }
                else if (TalkNumber == 2)
                {
                    HitDie();
                }
            }
            else if (TalkStart == 2)
            {
                if (TalkNumber == 0)
                {
                    HitDie();
                }
                else if (TalkNumber == 1)
                {
                    if (A == 0)
                    {
                        DoriFeather();
                    }
                    else
                    {
                        Anum += 1;
                        PlayerPrefs.SetInt("Anum", Anum);
                    }
                }
                else if (TalkNumber == 2)
                {
                    UNIT += 1000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                }
            }
        }
        else if(TalkValue ==1)
        {
            if (TalkStart == 0)
            {
                if (TalkNumber == 0)
                {
                    if (A == 0)
                    {
                        WhatDie();
                    }
                    else
                    {

                    }
                }
                else if (TalkNumber == 1)
                {
                    if (A == 0)
                    {
                        WhatDie();
                    }
                    else
                    {

                    }
                }
                else if (TalkNumber == 2)
                {
                    if (A == 0)
                    {
                        WhatDie();
                    }
                    else
                    {

                    }
                }
            }
            else if (TalkStart == 1)
            {
                if (TalkNumber == 0)
                {
                    UnderWorld();
                }
                else if (TalkNumber == 1)
                {
                    UnderWorld();
                }
                else if (TalkNumber == 2)
                {

                }
                else
                {
                    UnderWorld();
                }
            }
        }
    }
}
