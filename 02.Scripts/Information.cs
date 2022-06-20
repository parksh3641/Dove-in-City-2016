using UnityEngine;
using System.Collections;

public class Information : MonoBehaviour {
    public UILabel dove; //구구 루루 차이
    public UILabel speedtxt;

    public UILabel Z;
    public UILabel A; //돌
    public UILabel B; //뺑소니
    public UILabel C; //비둘기사냥
    public UILabel D; //높이날기스킬활용
    public UILabel E; //히든스테이지방문
    public UILabel F; //아슬점수

    public int Dove;
    public int InfoZero;

    public int InfoOne;
    public int InfoTwo;
    public int InfoThree;
    public int InfoFour;
    public int InfoFive;
    public int InfoSix;

    public float Speed;
    public UISprite speed;
    void Start()
    {
        Speed = GameManager.Speed;
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            InfoZero = PlayerPrefs.GetInt("TOT_Black", 0);
            dove.text = "구구의 최고점수 :";
        }
        else if (Dove == 1)
        {
            InfoZero = PlayerPrefs.GetInt("TOT_White", 0);
            dove.text = "루루의 최고점수 :";
        }
        InfoOne = PlayerPrefs.GetInt("InfoStone", 0);
        InfoTwo = PlayerPrefs.GetInt("InfoCar", 0);
        InfoThree = PlayerPrefs.GetInt("InfoBird", 0);
        InfoFour = PlayerPrefs.GetInt("InfoSkill", 0);
        InfoFive = PlayerPrefs.GetInt("InfoHidden", 0);
        InfoSix = PlayerPrefs.GetInt("InfoBuild", 0);

        Z.text = InfoZero.ToString() + " 점";
        A.text = InfoOne.ToString() + " 개";
        B.text = InfoTwo.ToString() + " 번";
        C.text = InfoThree.ToString() + " 번";
        D.text = InfoFour.ToString() + " 번";
        E.text = InfoFive.ToString() + " 번";
        F.text = InfoSix.ToString() + " 번";

        speed.fillAmount = Speed * 0.5f;
        speedtxt.text = (Speed * 10).ToString() + "/20 Km";

    }
    void OnEnable()
    {
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            InfoZero = PlayerPrefs.GetInt("TOT_Black", 0);
            dove.text = "구구의 최고점수 :";
        }
        else if (Dove == 1)
        {
            InfoZero = PlayerPrefs.GetInt("TOT_White", 0);
            dove.text = "루루의 최고점수 :";
        }

        Z.text = InfoZero.ToString() + " 점";
    }
}
