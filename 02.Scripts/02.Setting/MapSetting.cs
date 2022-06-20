using UnityEngine;
using System.Collections;

public class MapSetting : MonoBehaviour {
    //배경화면 프리팹
    public GameObject Seoul0;
    public GameObject Seoul1;
    public GameObject Seoul2;
    public GameObject Seoul3;
    public GameObject Seoul4;
    public GameObject Seoul5;

    public GameObject Sea;

    public int A = 0;

    private bool map = false;

    private float WhichY = 8.192f;
    //private float Whichy = 0.012f;

    void Awake()
    {
        if (A == 1)
        {
            //float A = Random.Range(0, 1);
            float B = Random.Range(0, 2);
            float C = Random.Range(0, 2);
            float D = Random.Range(0, 2);
            float E = Random.Range(0, 2);
            float F = Random.Range(0, 2);
            float G = Random.Range(0, 2);

            Instantiate(Seoul5, new Vector3(0, -WhichY, 1), Quaternion.identity); //1번째 맵
            Instantiate(Seoul0, new Vector3(0, 0, 1), Quaternion.identity); //2
            Instantiate(Seoul1, new Vector3(0, WhichY, 1), Quaternion.identity); //3
            if (B == 0)
            {
                Instantiate(Seoul1, new Vector3(0, (WhichY * 2), 1), Quaternion.identity);
            }
            else if (B == 1)
            {
                Instantiate(Seoul2, new Vector3(0, (WhichY * 2), 1), Quaternion.identity);
            }
            if (C == 0)
            {
                Instantiate(Seoul1, new Vector3(0, (WhichY * 3), 1), Quaternion.identity);
            }
            else if (C == 1)
            {
                Instantiate(Seoul2, new Vector3(0, (WhichY * 3), 1), Quaternion.identity);
            }
            if (D == 0)
            {
                Instantiate(Seoul1, new Vector3(0, (WhichY * 6), 1), Quaternion.identity);
            }
            else if (D == 1)
            {
                Instantiate(Seoul2, new Vector3(0, (WhichY * 6), 1), Quaternion.identity);
            }
            if (E == 0)
            {
                Instantiate(Seoul1, new Vector3(0, (WhichY * 7), 1), Quaternion.identity);
            }
            else if (E == 1)
            {
                Instantiate(Seoul2, new Vector3(0, (WhichY * 7), 1), Quaternion.identity);
            }
            if (F == 0)
            {
                Instantiate(Seoul1, new Vector3(0, (WhichY * 8), 1), Quaternion.identity);
            }
            else if (F == 1)
            {
                Instantiate(Seoul2, new Vector3(0, (WhichY * 8), 1), Quaternion.identity);
            }

            if (G == 0)
            {
                Instantiate(Seoul3, new Vector3(0, (WhichY * 4), 1), Quaternion.identity);
                float H = Random.Range(0, 2);
                if (H == 0)
                {
                    Instantiate(Seoul1, new Vector3(0, (WhichY * 5), 1), Quaternion.identity);
                }
                else
                {
                    Instantiate(Seoul2, new Vector3(0, (WhichY * 5), 1), Quaternion.identity);
                }
            }
            else if (G == 1)
            {
                Instantiate(Seoul3, new Vector3(0, (WhichY * 5), 1), Quaternion.identity);
                float H = Random.Range(0, 2);
                if (H == 0)
                {
                    Instantiate(Seoul1, new Vector3(0, (WhichY * 4), 1), Quaternion.identity);
                }
                else
                {
                    Instantiate(Seoul2, new Vector3(0, (WhichY * 4), 1), Quaternion.identity);
                }
            }

            Instantiate(Seoul4, new Vector3(0, (WhichY * 9), 1), Quaternion.identity); //마지막 맵

            Instantiate(Sea, new Vector3(0, WhichY * 10, 1), Quaternion.identity); //마지막 맵 바다1

            Instantiate(Sea, new Vector3(0, WhichY * 11, 1), Quaternion.identity); //마지막 맵 바다2

            Instantiate(Sea, new Vector3(0, WhichY * 12, 1), Quaternion.identity); //마지막 맵 바다3
        }
    }
}
