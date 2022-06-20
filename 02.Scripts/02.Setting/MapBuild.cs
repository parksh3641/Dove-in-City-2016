using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapBuild : MonoBehaviour {
    public Transform[] objList;

    void Start()
    {
        objList = gameObject.GetComponentsInChildren<Transform>();

    }
}
