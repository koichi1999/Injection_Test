using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Spray : MonoBehaviour
{
    int[] tank_channels = new int[] {1, 2, 3}; //射出するタンクのチャンネル
    int duration = 300; //射出時間を管理する変数
    [SerializeField] private Text _text;

    private void Start()
    {
        _text.text = "Space Keyを押してね";
    }

    // Update is called once per frame
    void Update()
    {
        SpaceKeyDown();
    }

    void SpaceKeyDown()
    {
        bool isCalled = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCalled = true;
            Debug.Log("Spacekey was presed");
        }
        
        if (isCalled == true)
        {
            Debug.Log("isCalled == true");
            HumanDll.HumanClass1.Spray_1027(tank_channels[0], duration);
            Debug.Log("Spray_1027() was called");
        }
    }
}
