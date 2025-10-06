using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool isPaused = false;

        void Update()
        {
            // Example: Pause/unpause on pressing the Escape key
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }

        public void PauseGame()
        {
            Time.timeScale = 0f; // Set time scale to zero to pause
            isPaused = true;
            Debug.Log("Game Paused");
            // Optionally, show a pause menu here
        }

        public void ResumeGame()
        {
            Time.timeScale = 1f; // Set time scale back to one to resume
            isPaused = false;
            Debug.Log("Game Resumed");
            // Optionally, hide the pause menu here
        }
}
