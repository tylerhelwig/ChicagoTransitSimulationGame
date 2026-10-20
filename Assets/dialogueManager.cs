using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text dialogueText;

    private string[] lines;
    private int currentLine;


    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
    }

    public void StartDialogue(string[] dialogueLines)
    {
        lines = dialogueLines;
        currentLine = 0;

        dialogueBox.SetActive(true);
        dialogueText.text = lines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueBox.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            NextLine();
        }
    }

    void NextLine()
    {
        currentLine++;

        if (currentLine >= lines.Length)
        {
            EndDialogue();
        }
        else
        {
            dialogueText.text = lines[currentLine];
        }
    }

    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
    }
}

