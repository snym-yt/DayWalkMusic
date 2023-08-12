using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Textを使用する為追加。
using System; //DateTimeを使用する為追加。


public class DateText : MonoBehaviour{

    [SerializeField] Text TodayText;

    DateTime TodayNow;

    private void Update(){
        TodayNow = DateTime.Now;

        TodayText.text = TodayNow.Year.ToString() + "/" + 
                        TodayNow.Month.ToString() + "/" +
                        TodayNow.Day.ToString();
    }
}
