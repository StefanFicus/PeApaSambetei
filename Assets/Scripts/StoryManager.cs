using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour
{
	public void nextView(int inc)
	{
		GameManager.Instance.view += inc; /* advance to next story */

		/* skip other views */
		if (GameManager.Instance.skipNext == true) {
			GameManager.Instance.view++;
			GameManager.Instance.skipNext = false;
		}

		/* read game files from resources */
		string path = GameManager.Instance.view.ToString();

		TextAsset file = Resources.Load<TextAsset>(path + "/info");
		string[] info = file.text.Split('\n');
		SceneManager.LoadScene("story" + info[0]);
	}


	public void skipNext()
	{
		/* skip over the second button option */
		GameManager.Instance.skipNext = true;

		/* set inventory based on view number */
		switch(GameManager.Instance.view)
		{
			case 4:
				GameManager.Instance.inventory[0] = true;
				break;
			case 7:
				GameManager.Instance.inventory[1] = true;
				break;
			case 11:
				GameManager.Instance.inventory[2] = true;
				break;
			case 18:
				GameManager.Instance.inventory[3] = true;
				break;

		}
	}
}

