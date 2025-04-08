using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour
{
	public TextMeshProUGUI storyText1, storyText2, buttonText1, buttonText2;
	public void nextView(int inc)
	{
		GameManager.Instance.view += inc; /* advance to next story */
		
		/* read game files from resources */
		string path = GameManager.Instance.view.ToString();

		TextAsset file = Resources.Load<TextAsset>(path + "/info");
		string[] info = file.text.Split('\n');
		file = Resources.Load<TextAsset>(path + "/text");
		string[] text = file.text.Split('\n');
		file = Resources.Load<TextAsset>(path + "/button");
		string[] button = file.text.Split('\n');

		
		/* Hide all images in case of no scene change */
		if (SceneManager.GetActiveScene().name == "story" + info[0]) {
			GameObject parent = GameObject.Find("Canvas/Sprites");
			foreach (Transform child in parent.transform)
				child.gameObject.GetComponent<SpriteRenderer>().enabled = false;
		} else { /* load scene from first info line */
			SceneManager.LoadScene("story" + info[0]);
		}

		/* Load images */
		bool ok = false;
		foreach (string i in info) {
			if (!ok) {
				ok = true;
			} else if (i != "") {
				GameObject sprite = GameObject.Find("Canvas/Sprites/image" + i);
				sprite.GetComponent<SpriteRenderer>().enabled = true;
			}
		}

		/* Load story text */
		storyText1.text = text[0];
		storyText2.text = text[1];

		/* Load button text */
		buttonText1.text = button[0];
		buttonText2.text = button[1];
	}

}

