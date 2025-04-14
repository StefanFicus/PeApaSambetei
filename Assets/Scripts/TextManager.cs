using UnityEngine;
using TMPro;
public class TextManager : MonoBehaviour
{
	public TextMeshProUGUI[] storyText, buttonText;
	void Awake()
	{
		/* load text */
		string path = GameManager.Instance.view.ToString();

		TextAsset file = Resources.Load<TextAsset>(path + "/text");
		string[] story = file.text.Split('\n');
		file = Resources.Load<TextAsset>(path + "/button");
		string[] button = file.text.Split('\n');

		for (int i = 0; i < story.Length - 1; i++) 
			if (storyText[i])
				storyText[i].text = story[i];
		

		for (int i = 0; i < button.Length - 1; i++) 
			if (buttonText[i])
				buttonText[i].text = button[i];
	}
}
