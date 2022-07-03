using UnityEngine;
using System.Collections;

public class MiniTouch : MonoBehaviour {
    public MiniManager manager;

    void OnClick()
    {
        manager.Click();
    }
}
