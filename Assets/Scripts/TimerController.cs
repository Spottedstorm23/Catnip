using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
	public float CurrentTime = 180;
	public Text CountdownText;

	void DisplayTime(float TimeToDisplay)
	{
		if (TimeToDisplay < 0)
		{
			TimeToDisplay = 0;
		}

		float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
		float seconds = Mathf.FloorToInt(TimeToDisplay % 60);

		CountdownText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
	}

	private void Update()
	{
			if (CurrentTime >= 0)
			{
				CurrentTime -= Time.deltaTime;

				DisplayTime(CurrentTime);
			}
			else if (CurrentTime < 0)
			{
				CurrentTime = 0;
				GameOver();
			}
	}

	private void GameOver()
	{
		SceneManager.LoadScene("Endscene");
	}
}