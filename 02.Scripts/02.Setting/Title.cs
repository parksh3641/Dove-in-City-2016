using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
    public UILabel MainTitle;

    public UISprite Title1Sprite;
    public UISprite Title2Sprite;

    public GameObject TitleEuqip; //칭호장착시 알림
    public GameObject TitleLock;

    private int Title1UnLock =1; //칭호1해제여부
    private int Title2UnLock =1;
    private int TITLE; //칭호종류
    private int TitleNumber;

    private AudioSource source;
    public AudioClip Click;
    void Start()
    {
        source = GetComponent<AudioSource>();
        TITLE = PlayerPrefs.GetInt("TITLE", 0);
        if(TITLE ==1)
        {
            MainTitle.text = "새내기";
            Title1Sprite.spriteName = "i018";
            Title2Sprite.spriteName = "000_icon";
        }
        else if(TITLE ==2)
        {
            MainTitle.text = "마라토너";
            Title1Sprite.spriteName = "000_icon";
            Title2Sprite.spriteName = "i018";
        }
    }
    public void Title1Equip()
    {
        if(TitleNumber ==1)
        {
        }
        else
        {
            if (Title1UnLock == 1)
            {
                source.PlayOneShot(Click, 0.75f);
                TitleNumber = 1;
                TitleEuqip.SetActive(false);
                TitleEuqip.SetActive(true);
                TITLE = 1;
                PlayerPrefs.SetInt("TITLE", TITLE);
                MainTitle.text = "새내기";
                Title1Sprite.spriteName = "i018";
                Title2Sprite.spriteName = "000_icon";
            }
            else
            {
                TitleLock.SetActive(false);
                TitleLock.SetActive(true);
            }
        }
    }
    public void Title2Equip()
    {
        if (TitleNumber == 2)
        {
        }
        else
        {
            if (Title2UnLock == 1)
            {
                source.PlayOneShot(Click, 0.75f);
                TitleNumber = 2;
                TitleEuqip.SetActive(false);
                TitleEuqip.SetActive(true);
                TITLE = 2;
                PlayerPrefs.SetInt("TITLE", TITLE);
                MainTitle.text = "마라토너";
                Title1Sprite.spriteName = "000_icon";
                Title2Sprite.spriteName = "i018";
            }
            else
            {
                TitleLock.SetActive(false);
                TitleLock.SetActive(true);
            }
        }
    }
}
