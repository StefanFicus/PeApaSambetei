using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour
{
	public void nextView(int inc)
	{
		GameManager.Instance.view += inc; /* advance to next story */
		
		/* read game files from resources */
		string path = GameManager.Instance.view.ToString();

		TextAsset file = Resources.Load<TextAsset>(path + "/info");
		string[] info = file.text.Split('\n');
		SceneManager.LoadScene("story" + info[0]);
	}
}

