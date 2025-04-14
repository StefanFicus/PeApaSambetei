using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

	/* story view state  */
	public int view = 1; 

	private void Awake()
	{
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
	}
}
