using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToRunGraphScene : MonoBehaviour{

    public void OnClickRunGraphButton(){
        SceneManager.LoadScene("RunningGraph");
    }

}
