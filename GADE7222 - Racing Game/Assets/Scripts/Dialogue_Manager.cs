using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue_Manager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Queue<string> characterDialogue;
    public TextAsset dialogue;
    // Start is called before the first frame update
    void Start()
    {
        characterDialogue = new Queue<string>();
        if (SceneManager.GetActiveScene().name == "Checkpoint Dialogue")
        {
            CheckpointDialogueStart();
        }
        else if (SceneManager.GetActiveScene().name == "Beginner Dialogue")
        {
            BeginnerDialogueStart();
        }
        else
        {
            AdvancedDialogueStart();
        }
    }

    public void CheckpointDialogueStart ()
    {
        NpcCharacters charcInJSON = JsonUtility.FromJson<NpcCharacters>(dialogue.text);
        characterDialogue.Clear();
        foreach (Characters character in charcInJSON.checkpointRace)
        {
            characterDialogue.Enqueue(character.characterName);
            characterDialogue.Enqueue(character.dialogue);
        }
        NextSentence();
    }

    public void BeginnerDialogueStart()
    {
        NpcCharacters charcInJSON = JsonUtility.FromJson<NpcCharacters>(dialogue.text);
        characterDialogue.Clear();
        foreach (Characters character in charcInJSON.beginnerRace)
        {
            characterDialogue.Enqueue(character.characterName);
            characterDialogue.Enqueue(character.dialogue);
        }
        NextSentence();
    }

    public void AdvancedDialogueStart()
    {
        NpcCharacters charcInJSON = JsonUtility.FromJson<NpcCharacters>(dialogue.text);
        characterDialogue.Clear();
        foreach (Characters character in charcInJSON.advancedRace)
        {
            characterDialogue.Enqueue(character.characterName);
            characterDialogue.Enqueue(character.dialogue);
        }
        NextSentence();
    }
    public void NextSentence()
    {
        if (characterDialogue.Count == 0)
        {
            NextScene();
            return;
        }
        //Debug.Log("Test");
        string nameQueue = characterDialogue.Dequeue();
        nameText.text = nameQueue;
        string dialogueQueue = characterDialogue.Dequeue();
        dialogueText.text = dialogueQueue;
    }

    public void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "Checkpoint Dialogue")
        {
            SceneManager.LoadScene("Checkpoint Race");
        }
        else if (SceneManager.GetActiveScene().name == "Beginner Dialogue")
        {
            SceneManager.LoadScene("Race Select");
        }
        else
        {
            SceneManager.LoadScene("Race Select");
        }
    }
}
