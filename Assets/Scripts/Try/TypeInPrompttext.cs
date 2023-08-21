// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TypeInPrompttext : MonoBehaviour{
    public InputField promptInputField; // ユーザー入力を受けるInputField
    public MusicGenAPI apiExample; // あなたのAPI通信スクリプトへの参照

    // ユーザー入力をAPI通信スクリプトに渡す
    public void SetPromptText(){
        string promptText = promptInputField.text;
        apiExample.SetPrompt(promptText);
    }
}
