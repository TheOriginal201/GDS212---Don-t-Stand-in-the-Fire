using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	public Animator transition;
	public float transitionTime = 1f;
    public GameObject title;
    public GameObject infoWindow;
    //public GameObject levelLoader;

    public void Start()
    {
		//levelLoader = GameObject.FindGameObjectWithTag("LevelLoader");
		title = GameObject.FindGameObjectWithTag("Title");
		infoWindow = GameObject.FindGameObjectWithTag("InfoWindow");
		infoWindow.SetActive(false);
	}
    public void ShowInfo()
    {
		title.SetActive(false);
		infoWindow.SetActive(true);
    }

    public void LoadNextLevel()
	{
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
		//Time.timeScale = 1;
	}

	public void LoadPreviousLevel()
	{
		StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
	}

	public void ExitGame()
	{
		Debug.Log("Exiting");
		Application.Quit();
	}

	public void StartMenu()
    {
        Debug.Log("Menu");
		//gameObject.SetActive(true);
		Time.timeScale = 1;
		//SceneManager.LoadScene(0);
		//levelLoader.SetActive(true);
		SceneManager.LoadScene(0);
	}

	IEnumerator LoadLevel(int levelIndex)
	{
		transition.SetTrigger("Start");
		//levelLoader.SetActive(true);
		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene(levelIndex);
	}
}
