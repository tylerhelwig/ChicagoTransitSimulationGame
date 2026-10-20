using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private dialogueManager dialogueManager;
    [SerializeField] private string[] lines;

    private bool isInRange;
    void Start()
    {
        foreach(string s in lines) 
        {
            Debug.Log(s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogueManager.StartDialogue(lines);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isInRange = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isInRange = false;
        dialogueManager.EndDialogue();
    }
    
}
