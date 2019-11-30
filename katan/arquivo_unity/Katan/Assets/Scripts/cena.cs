using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cena : MonoBehaviour
{
	public void mudar_cena(string cena){
		SceneManager.LoadScene(cena);
	}
}
