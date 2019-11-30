using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txt : MonoBehaviour
{
    void Start(){
		Text texto = GameObject.Find("Canvas/Rola").GetComponent<Text>();
		texto.text = "xixi de vaca";
    }
}
