using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour {
    private int START;
    private int BD;
    private int UNIT;
    private int Anum;
    private int Bnum;
    private int Cnum;
    private int Dnum;
    private int Enum;

    void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        START = PlayerPrefs.GetInt("START", 0);

        if(START ==0)
        {
            PlayerPrefs.DeleteAll();
            //ModeCheck();
        }
	
	}
    void ModeCheck()
    {
        START = 1;
        BD = 10;
        UNIT = 10000;

        PlayerPrefs.SetInt("UNIT", UNIT);
        PlayerPrefs.SetInt("BD", BD);
        PlayerPrefs.SetInt("START", START);

    }
}
