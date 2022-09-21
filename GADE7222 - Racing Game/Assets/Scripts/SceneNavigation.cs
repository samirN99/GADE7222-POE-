using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void CheckpointDialogue()
    {
        SceneManager.LoadScene("Checkpoint Dialogue");
    }

    public void BeginnerDialogue()
    {
        SceneManager.LoadScene("Beginner Dialogue");
    }

    public void AdvancedDialogue()
    {
        SceneManager.LoadScene("Advanced Dialogue");
    }

    public void CheckpointRace()
    {
        SceneManager.LoadScene("Checkpoint Race");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Race Select");
    }
}
