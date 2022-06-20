using UnityEngine;
using System.Collections;

public class SkinManager : MonoBehaviour {

    public GameObject Dove1;
    public GameObject Dove2;
    public GameObject Dove3;
    public GameObject Dove4;
    public GameObject Dove5;

    public UILabel Dove1msg;
    public UILabel Dove2msg;
    public UILabel Dove3msg;
    public UILabel Dove4msg;

    public GameObject LockA;
    public GameObject LockB;
    public GameObject LockC;
    public GameObject SkinLock; //다른비둘기가 스킨 착용한거 누를시

    public UILabel MainName;

    public UILabel SkinA;
    public UILabel SkinB;
    public UILabel SkinC;

    public GameObject SkinAEquip;
    public GameObject SkinBEquip;
    public GameObject SkinCEquip;
    public GameObject SkinX;
    public GameObject SkinXX; //히든컈릭터는 착용불가.

    private int BlackSkin;
    private int WhiteSkin;
    private int WowSkin;

    private int Dove;
    private int Skin;

    private AudioSource source;
    public AudioClip Click;
    public AudioClip Coin;

    //스킨 착용시 저장
    private int SkinStateA; //스킨1은 누가착용했는지
    private int SkinStateB; //스킨2는 누가착용했는지
    private int SkinStateC;

    public delegate void skinmanager();
    public static event skinmanager SkinCheck;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        SkinLock.SetActive(false);
        SkinX.SetActive(false);
        SkinXX.SetActive(false);
        SkinAEquip.SetActive(false);
        SkinBEquip.SetActive(false);
        SkinCEquip.SetActive(false);
        LockA.SetActive(true);
        LockB.SetActive(true);
        LockC.SetActive(true);

        SkinStateA = PlayerPrefs.GetInt("SkinStateA", 0);
        SkinStateB = PlayerPrefs.GetInt("SkinStateB", 0);
        SkinStateC = PlayerPrefs.GetInt("SkinStateC", 0);
        if (SkinStateA == 0)
        {
            SkinA.text = "착용 가능";
        }
        else if (SkinStateA == 1)
        {
            SkinA.text = "[구구]";
            Dove1msg.text = "후쿠시마 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAA", 1);
        }
        else if (SkinStateA == 2)
        {
            SkinA.text = "[루루]";
            Dove2msg.text = "후쿠시마 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAB", 1);
        }
        else if (SkinStateA == 3)
        {
            SkinA.text = "[수리수리]";
            Dove3msg.text = "후쿠시마 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAC", 1);
        }
        else if (SkinStateA == 4)
        {
            SkinA.text = "[도라]";
            Dove4msg.text = "후쿠시마 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAD", 1);
        }
        //
        if (SkinStateB == 0)
        {
            SkinB.text = "착용 가능";
        }
        else if (SkinStateB == 1)
        {
            SkinB.text = "[구구]";
            Dove1msg.text = "클로킹 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAA", 2);
        }
        else if (SkinStateB == 2)
        {
            SkinB.text = "[루루]";
            Dove2msg.text = "클로킹 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAB", 2);
        }
        else if (SkinStateB == 3)
        {
            SkinB.text = "[수리수리]";
            Dove3msg.text = "클로킹 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAC", 2);
        }
        else if (SkinStateB == 4)
        {
            SkinB.text = "[도라]";
            Dove4msg.text = "클로킹 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAD", 2);
        }
        //
        if (SkinStateC == 0)
        {
            SkinC.text = "착용 가능";
        }
        else if (SkinStateC == 1)
        {
            SkinC.text = "[구구]";
            Dove1msg.text = "와정대 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAA", 3);
        }
        else if (SkinStateC == 2)
        {
            SkinC.text = "[루루]";
            Dove2msg.text = "와정대 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAB", 3);
        }
        else if (SkinStateC == 3)
        {
            SkinC.text = "[수리수리]";
            Dove3msg.text = "와정대 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAC", 3);
        }
        else if (SkinStateC == 4)
        {
            SkinC.text = "[도라]";
            Dove4msg.text = "와정대 비둘기 스킨 착용 중";
            PlayerPrefs.SetInt("SkinAD", 3);
        }

        //StartCoroutine(ModeCheck());
    }
    IEnumerator ModeCheck()
    {
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(ModeCheck());
    }
    void OnEnable()
    {
        Select.ChangeSkin += ChangeSkin;
    }
    void OnDisable()
    {
        Select.ChangeSkin -= ChangeSkin;
    }
    void ChangeSkin()
    {
        BlackSkin = PlayerPrefs.GetInt("BlackSkin", 0);
        if (BlackSkin == 1)
        {
            LockA.SetActive(false);
            PlayerPrefs.SetInt("BlackSkin", 2);
            SkinCheck();
        }
        else if (BlackSkin == 2)
        {
            LockA.SetActive(false);
        }

        WhiteSkin = PlayerPrefs.GetInt("WhiteSkin", 0);
        if (WhiteSkin == 1)
        {
            LockB.SetActive(false);
            PlayerPrefs.SetInt("WhiteSkin", 2);
            SkinCheck();
        }
        else if (WhiteSkin == 2)
        {
            LockB.SetActive(false);
        }

        WowSkin = PlayerPrefs.GetInt("WowSkin", 0);
        if (WowSkin == 1)
        {
            LockC.SetActive(false);
            PlayerPrefs.SetInt("WowSkin", 2);
            SkinCheck();
        }
        else if (WowSkin == 2)
        {
            LockC.SetActive(false);
        }

        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            MainName.text = "구구";
            MainName.color = new Color(0, 0, 255f, 1f);
            Dove1.SetActive(true);
            Dove2.SetActive(false);
            Dove3.SetActive(false);
            Dove4.SetActive(false);
            Dove5.SetActive(false);
        }
        else if (Dove == 1)
        {
            MainName.text = "루루";
            MainName.color = new Color(255f, 0.65f, 0, 1f);
            Dove1.SetActive(false);
            Dove2.SetActive(true);
            Dove3.SetActive(false);
            Dove4.SetActive(false);
            Dove5.SetActive(false);
        }
        else if (Dove == 2)
        {
            MainName.text = "수리수리";
            MainName.color = new Color(255f, 0, 0, 1f);
            Dove1.SetActive(false);
            Dove2.SetActive(false);
            Dove3.SetActive(true);
            Dove4.SetActive(false);
            Dove5.SetActive(false);
        }
        else if (Dove == 3)
        {
            MainName.text = "도라";
            MainName.color = new Color(255f, 255f, 0, 1f);
            Dove1.SetActive(false);
            Dove2.SetActive(false);
            Dove3.SetActive(false);
            Dove4.SetActive(true);
            Dove5.SetActive(false);
        }
        else if(Dove ==4)
        {
            MainName.text = "알파";
            MainName.color = new Color(0, 255f, 0, 1f);
            Dove1.SetActive(false);
            Dove2.SetActive(false);
            Dove3.SetActive(false);
            Dove4.SetActive(false);
            Dove5.SetActive(true);
        }
    }

    public void HSkin()
    {
        source.PlayOneShot(Click, 0.75f);
        if (Dove == 0)
        {
            if (SkinStateA == 0)
            {
                SkinA.text = "[구구]";
                Dove1msg.text = "후쿠시마 비둘기 스킨 착용 중";
                SkinStateA = 1;
                PlayerPrefs.SetInt("SkinStateA", 1);
                SkinAEquip.SetActive(false);
                SkinAEquip.SetActive(true);
                Skin = 1;
                PlayerPrefs.SetInt("Skin", 1);
                PlayerPrefs.SetInt("SkinAA", 1);
                if (SkinStateB == 1)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
                if (SkinStateC == 1)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateA == 1)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 1)
        {
            if (SkinStateA == 0)
            {
                SkinA.text = "[루루]";
                Dove2msg.text = "후쿠시마 비둘기 스킨 착용 중";
                SkinStateA = 2;
                PlayerPrefs.SetInt("SkinStateA", 2);
                SkinAEquip.SetActive(false);
                SkinAEquip.SetActive(true);
                Skin = 2;
                PlayerPrefs.SetInt("Skin", 2);
                PlayerPrefs.SetInt("SkinAB", 1);
                if (SkinStateB == 2)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
                if (SkinStateC == 2)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateA == 2)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 2)
        {
            if (SkinStateA == 0)
            {
                SkinA.text = "[수리수리]";
                Dove3msg.text = "후쿠시마 비둘기 스킨 착용 중";
                SkinStateA = 3;
                PlayerPrefs.SetInt("SkinStateA", 3);
                SkinAEquip.SetActive(false);
                SkinAEquip.SetActive(true);
                Skin = 3;
                PlayerPrefs.SetInt("Skin", 3);
                PlayerPrefs.SetInt("SkinAC", 1);
                if (SkinStateB == 3)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
                else if (SkinStateC == 3)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateA == 3)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 3)
        {
            if (SkinStateA == 0)
            {
                SkinA.text = "[도라]";
                Dove4msg.text = "후쿠시마 비둘기 스킨 착용 중";
                SkinStateA = 4;
                PlayerPrefs.SetInt("SkinStateA", 4);
                SkinAEquip.SetActive(false);
                SkinAEquip.SetActive(true);
                Skin = 4;
                PlayerPrefs.SetInt("Skin", 4);
                PlayerPrefs.SetInt("SkinAD", 1);
                if (SkinStateB == 4)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
                if (SkinStateC == 4)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateA == 4)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if(Dove ==4)
        {
            SkinXX.SetActive(false);
            SkinXX.SetActive(true);
        }
    }

    public void CSkin()
    {
        source.PlayOneShot(Click, 0.75f);
        if (Dove == 0)
        {
            if (SkinStateB == 0)
            {
                SkinB.text = "[구구]";
                Dove1msg.text = "클로킹 비둘기 스킨 착용 중";
                SkinStateB = 1;
                PlayerPrefs.SetInt("SkinStateB", 1);
                SkinBEquip.SetActive(false);
                SkinBEquip.SetActive(true);
                Skin = 5;
                PlayerPrefs.SetInt("Skin", 5);
                PlayerPrefs.SetInt("SkinAA", 2);
                if (SkinStateA == 1)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateC == 1)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if(SkinStateB ==1)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 1)
        {
            if (SkinStateB == 0)
            {
                SkinB.text = "[루루]";
                Dove2msg.text = "클로킹 비둘기 스킨 착용 중";
                SkinStateB = 2;
                PlayerPrefs.SetInt("SkinStateB", 2);
                SkinBEquip.SetActive(false);
                SkinBEquip.SetActive(true);
                Skin = 6;
                PlayerPrefs.SetInt("Skin", 6);
                PlayerPrefs.SetInt("SkinAB", 2);
                if (SkinStateA == 2)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateC == 2)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateB == 2)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 2)
        {
            if (SkinStateB == 0)
            {
                SkinB.text = "[수리수리]";
                Dove3msg.text = "클로킹 비둘기 스킨 착용 중";
                SkinStateB = 3;
                PlayerPrefs.SetInt("SkinStateB", 3);
                SkinBEquip.SetActive(false);
                SkinBEquip.SetActive(true);
                Skin = 7;
                PlayerPrefs.SetInt("Skin", 7);
                PlayerPrefs.SetInt("SkinAC", 2);
                if (SkinStateA == 3)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateC == 3)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateB == 3)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 3)
        {
            if (SkinStateB == 0)
            {
                SkinB.text = "[도라]";
                Dove4msg.text = "클로킹 비둘기 스킨 착용 중";
                SkinStateB = 4;
                PlayerPrefs.SetInt("SkinStateB", 4);
                SkinBEquip.SetActive(false);
                SkinBEquip.SetActive(true);
                Skin = 8;
                PlayerPrefs.SetInt("Skin", 8);
                PlayerPrefs.SetInt("SkinAD", 2);
                if (SkinStateA == 4)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateC == 4)
                {
                    SkinStateC = 0;
                    SkinC.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateC", 0);
                }
            }
            else
            {
                if (SkinStateB == 4)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 4)
        {
            SkinXX.SetActive(false);
            SkinXX.SetActive(true);
        }
    }

    public void WSkin()
    {
        source.PlayOneShot(Click, 0.75f);
        if (Dove == 0)
        {
            if (SkinStateC == 0)
            {
                SkinC.text = "[구구]";
                Dove1msg.text = "와정대 비둘기 스킨 착용 중";
                SkinStateC = 1;
                PlayerPrefs.SetInt("SkinStateC", 1);
                SkinCEquip.SetActive(false);
                SkinCEquip.SetActive(true);
                Skin = 9;
                PlayerPrefs.SetInt("Skin", 9);
                PlayerPrefs.SetInt("SkinAA", 3);
                if (SkinStateA ==1)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateB == 1)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
            }
            else
            {
                if (SkinStateC == 1)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 1)
        {
            if (SkinStateC == 0)
            {
                SkinC.text = "[루루]";
                Dove2msg.text = "와정대 비둘기 스킨 착용 중";
                SkinStateC = 2;
                PlayerPrefs.SetInt("SkinStateC", 2);
                SkinCEquip.SetActive(false);
                SkinCEquip.SetActive(true);
                Skin = 10;
                PlayerPrefs.SetInt("Skin", 10);
                PlayerPrefs.SetInt("SkinAB", 3);
                if (SkinStateA == 2)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateB == 2)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
            }
            else
            {
                if (SkinStateC == 2)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 2)
        {
            if (SkinStateC == 0)
            {
                SkinC.text = "[수리수리]";
                Dove3msg.text = "와정대 비둘기 스킨 착용 중";
                SkinStateC = 3;
                PlayerPrefs.SetInt("SkinStateC", 3);
                SkinCEquip.SetActive(false);
                SkinCEquip.SetActive(true);
                Skin = 11;
                PlayerPrefs.SetInt("Skin", 11);
                PlayerPrefs.SetInt("SkinAC", 3);
                if (SkinStateA == 3)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateB == 3)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
            }
            else
            {
                if (SkinStateC == 3)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 3)
        {
            if (SkinStateC == 0)
            {
                SkinC.text = "[도라]";
                Dove4msg.text = "와정대 비둘기 스킨 착용 중";
                SkinStateC = 4;
                PlayerPrefs.SetInt("SkinStateC", 4);
                SkinCEquip.SetActive(false);
                SkinCEquip.SetActive(true);
                Skin = 12;
                PlayerPrefs.SetInt("Skin", 12);
                PlayerPrefs.SetInt("SkinAD", 3);
                if (SkinStateA == 4)
                {
                    SkinStateA = 0;
                    SkinA.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateA", 0);
                }
                if (SkinStateB == 4)
                {
                    SkinStateB = 0;
                    SkinB.text = "착용 가능";
                    PlayerPrefs.SetInt("SkinStateB", 0);
                }
            }
            else
            {
                if (SkinStateC == 4)
                {

                }
                else
                {
                    SkinLock.SetActive(false);
                    SkinLock.SetActive(true);
                }
            }
        }
        else if (Dove == 4)
        {
            SkinXX.SetActive(false);
            SkinXX.SetActive(true);
        }
    }

    public void NoSkin()
    {
        source.PlayOneShot(Coin, 0.75f);
        SkinX.SetActive(false);
        SkinX.SetActive(true);

        SkinA.text = "착용 가능";
        SkinB.text = "착용 가능";
        SkinC.text = "착용 가능";

        Dove1msg.text = " ";
        Dove2msg.text = " ";
        Dove3msg.text = " ";
        Dove4msg.text = " ";

        Skin = 0;
        PlayerPrefs.SetInt("Skin", 0);
        PlayerPrefs.SetInt("SkinAA", 0);
        PlayerPrefs.SetInt("SkinAB", 0);
        PlayerPrefs.SetInt("SkinAC", 0);
        PlayerPrefs.SetInt("SkinAD", 0);

        SkinStateA = 0;
        SkinStateB = 0;
        SkinStateC = 0;

        PlayerPrefs.SetInt("SkinStateA", 0);
        PlayerPrefs.SetInt("SkinStateB", 0);
        PlayerPrefs.SetInt("SkinStateC", 0);
    }
}
