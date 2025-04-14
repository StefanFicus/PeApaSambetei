using UnityEngine;
using TMPro;

public class SpriteController : MonoBehaviour
{
	void Awake()
	{
		/* read game files from resources */
		string path = GameManager.Instance.view.ToString();
		TextAsset file = Resources.Load<TextAsset>(path + "/info");
		string[] info = file.text.Split('\n');

		/* Hide all images in case of no scene reload */
		GameObject parent = this.gameObject;
		foreach (Transform child in parent.transform)
			child.gameObject.GetComponent<SpriteRenderer>().enabled = false;

		/* load required images */
		for (int i = 1; i < info.Length - 1; i++) {
			string j = info[i];
			GameObject child = parent.transform.Find("image" + j).gameObject;
			if (child)
				child.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
