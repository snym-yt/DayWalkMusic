using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

public class MusicGenAPI : MonoBehaviour{
    // Set your Replicate API token here
    private string apiToken = "r8_fKptrAHgbmTKfrs1SrJOnZcyZH5bx4P0OrPRf";
    private string apiUrl = "https://api.replicate.com/v1/predictions"; // APIのエンドポイントURL

    // Start is called before the first frame update
    void Start(){
        StartCoroutine(SendAPIRequest());
    }

    IEnumerator SendAPIRequest(){
        string modelVersion = "melody"; // 使用するモデルのバージョン
        string promptText = "Generate a relaxing and upbeat melody."; // 生成したい音楽の説明をここに入力
        string requestData = "{\"version\": \"" + modelVersion + "\", \"input\": {\"model_version\": \"" + modelVersion + "\", \"prompt\": \"" + promptText + "\"}}";

        using (UnityWebRequest webRequest = new UnityWebRequest(apiUrl, "POST")){
            byte[] jsonBytes = Encoding.UTF8.GetBytes(requestData);
            webRequest.uploadHandler = new UploadHandlerRaw(jsonBytes);
            webRequest.downloadHandler = new DownloadHandlerBuffer();
            webRequest.SetRequestHeader("Content-Type", "application/json");

            // Here's how you set the "Authorization" header with the token
            webRequest.SetRequestHeader("Authorization", "Token " + apiToken);

            yield return webRequest.SendWebRequest();

            if (webRequest.result != UnityWebRequest.Result.Success){
                Debug.LogError("API request error: " + webRequest.error);
            }else{
                string responseBody = webRequest.downloadHandler.text;
                // responseBodyを処理してデータを取得
                Debug.Log("API response: " + responseBody);
            }
        }
    }
}

