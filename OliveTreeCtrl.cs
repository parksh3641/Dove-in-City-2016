using UnityEngine;
using System.Collections;

public class OliveTreeCtrl : MonoBehaviour {
    private Transform A;
    public float shake = 0.02f;
    public float shakeTime = 0.1f;

    void Start()
    {
        A = GetComponent<Transform>();
    }

    void OnEnable()
    {
        PlayerCtrl.OliveTreeIn += OliveTreeIn;
        TutorialCtrl.OliveTreeIn += OliveTreeIn;
    }
    void OnDisable()
    {
        PlayerCtrl.OliveTreeIn -= OliveTreeIn;
        TutorialCtrl.OliveTreeIn -= OliveTreeIn;
    }
    void OliveTreeIn()
    {
        StartCoroutine(Shake());
    }
    IEnumerator Shake()
    {
        yield return new WaitForSeconds(0.25f);
        transform.position = new Vector3(A.position.x + shake, A.position.y, transform.position.z);
        yield return new WaitForSeconds(shakeTime);
        transform.position = new Vector3(A.position.x - shake, A.position.y, transform.position.z);
        yield return new WaitForSeconds(shakeTime);
        transform.position = new Vector3(A.position.x + shake, A.position.y, transform.position.z);
        yield return new WaitForSeconds(shakeTime);
        transform.position = new Vector3(A.position.x - shake, A.position.y, transform.position.z);
        yield return new WaitForSeconds(shakeTime);
    }
}
