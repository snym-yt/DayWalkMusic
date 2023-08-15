using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sample;

public class SampleScene : MonoBehaviour{
    public void OnClick(){
        Debug.Log("HelloPlugin.HelloWorld() = " + HelloPlugin.HelloWorld());

    }
}
