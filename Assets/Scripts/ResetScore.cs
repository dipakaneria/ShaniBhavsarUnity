using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
//using System; ??
//using System.Diagnostics;
using System.Collections.Specialized;
using System.IO;
using UnityEngine.Analytics;

public class ResetScore : MonoBehaviour {

	public void ResetGameScore()
	{
		File.Delete(Application.persistentDataPath + "/save.dat");
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.buildIndex);
	}
}
