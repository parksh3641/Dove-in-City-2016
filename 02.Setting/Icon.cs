using UnityEngine;
using System.Collections;

public class Icon : MonoBehaviour {
    public UISprite Mainicon;

    public GameObject notion;
    private int icon = 0;

    public UIToggle icon1;
    public UIToggle icon2;
    public UIToggle icon3;

    private AudioSource source;
    public AudioClip Click;
    void Start()
    {
        icon = PlayerPrefs.GetInt("icon", 0);
        if(icon ==0)
        {
            Mainicon.spriteName = "medal_01";
        }
        else if(icon ==1)
        {
            Mainicon.spriteName = "medal_02";
        }
        else if (icon == 2)
        {
            Mainicon.spriteName = "medal_03";
        }
        source = GetComponent<AudioSource>();
    }   
    void OnEnable()
    {
        icon = PlayerPrefs.GetInt("icon", 0);
        if (icon == 0)
        {
            icon1.value = true;
            icon2.value = false;
            icon3.value = false;
        }
        else if (icon == 1)
        {
            icon1.value = false;
            icon2.value = true;
            icon3.value = false;
        }
        else if (icon == 2)
        {
            icon1.value = false;
            icon2.value = false;
            icon3.value = true;
        }
    }
    public void Icon1()
    {
        source.PlayOneShot(Click, 0.75f);
        Mainicon.spriteName = "medal_01";
        icon = 0;
        PlayerPrefs.SetInt("icon", icon);
    }
    public void Icon2()
    {
        source.PlayOneShot(Click, 0.75f);
        Mainicon.spriteName = "medal_02";
        icon = 1;
        PlayerPrefs.SetInt("icon", icon);
    }
    public void Icon3()
    {
        source.PlayOneShot(Click, 0.75f);
        Mainicon.spriteName = "medal_03";
        icon = 2;
        PlayerPrefs.SetInt("icon", icon);
    }
}
