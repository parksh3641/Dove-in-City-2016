using UnityEngine;
using System.Collections;

public class Option : MonoBehaviour {
    private AudioSource source;
    public AudioClip Mario;
    private AudioSource Effectsource;

    public UISprite MusicSprite;
    public UISprite EffectSprite;
    public UISprite IanguageSprite;
    public UISprite Option1btn;
    public UISprite Option2btn;

    public UILabel MusicLabel;
    public UILabel EffectLabel;
    public UILabel IanguageLabel;

    public GameObject Option1;
    public GameObject Option2;
    public GameObject credit;

    private int M = 0;
    private int E = 0;
    private int Mmute;
    private int Emute;
    private int HiddenCount = 0; //10번 온오프시 이스터에그로 마리오노래나옴

    public delegate void select();
    public static event select click;

    void Start () {
        source = GetComponent<AudioSource>();
        Effectsource = GameObject.Find("Select").GetComponent<AudioSource>();

        credit.SetActive(false);
        Option1.SetActive(true);
        Option2.SetActive(false);

        Mmute = PlayerPrefs.GetInt("Mmute", 0);
        Emute = PlayerPrefs.GetInt("Emute", 0);
        if(Mmute ==1)
        {
            M = 1;
            source.enabled = false;
            MusicLabel.text = "OFF";
        }
        if(Emute ==1)
        {
            E = 1;
            Effectsource.enabled = false;
            EffectLabel.text = "ON";
        }
    }
    void OnEnable()
    {
        Credit.Finish += Finish;
    }
    void OnDisable()
    {
        Credit.Finish -= Finish;
    }
    void Finish()
    {
        source.UnPause();
    }
    public void MusicOnOff()
    {
        click();
        if (M == 0)
        {
            M = 1;
            PlayerPrefs.SetInt("Mmute", M);
            source.enabled = false;
            MusicLabel.text = "OFF";
            HiddenCount += 1;
        }
        else if (M == 1)
        {
            M = 0;
            PlayerPrefs.SetInt("Mmute", M);
            source.enabled = true;
            MusicLabel.text = "ON";
            if(HiddenCount >= 10)
            {
                source.Stop();
                source.PlayOneShot(Mario, 1f);
            }
        }
    }
    public void EffectOnOff()
    {
        click();
        if (E == 0)
        {
            E = 1;
            PlayerPrefs.SetInt("Emute", E);
            Effectsource.enabled = false;
            EffectLabel.text = "OFF";
        }
        else if(E ==1)
        {
            E = 0;
            PlayerPrefs.SetInt("Emute", E);
            Effectsource.enabled = true;
            EffectLabel.text = "ON";
        }
    }

    public void option1()
    {
        click();
        Option2.SetActive(false);
        Option1.SetActive(true);
    }
    public void option2()
    {
        click();
        Option1.SetActive(false);
        Option2.SetActive(true);
    }

    public void CreditPlay()
    {
        source.Pause();
        credit.SetActive(true);
    }
}
