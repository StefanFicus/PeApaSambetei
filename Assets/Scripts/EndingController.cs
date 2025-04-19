using UnityEngine;

public class EndingController : MonoBehaviour
{
	public void ending()
	{
		if (GameManager.Instance.inventory[3] == true) // am sabie
			GameManager.Instance.view += 5; // ending 5: glorie
		else if (GameManager.Instance.inventory[1] == true && GameManager.Instance.inventory[2] == true) { // smicele + apa vie moarta
			if (GameManager.Instance.inventory[0] == true) // baba
				GameManager.Instance.view += 3; // ending 3: reinviat
			else
				GameManager.Instance.view++; // ending 2: las
		} else
			GameManager.Instance.view += 4; // ending 4: ars
	}
}
