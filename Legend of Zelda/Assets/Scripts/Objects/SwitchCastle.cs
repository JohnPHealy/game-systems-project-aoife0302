using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCastle : MonoBehaviour
{
    public bool active;
    public BoolValue storedValue;
    public Sprite activeSprite;
    private SpriteRenderer mySprite;

    [SerializeField]
    private GameObject Background;

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        active = storedValue.RuntimeValue;
        if (active)
        {
            ActivateSwitch();
        }
    }

    public void ActivateSwitch()
    {
        active = true;
        storedValue.RuntimeValue = active;
        EndGame();
        mySprite.sprite = activeSprite;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Is it the player?
        if (other.CompareTag("Player"))
        {
            ActivateSwitch();
        }

    }

    public void EndGame()
    {
        Debug.Log("GAME Complete!");
        Background.SetActive(true);
    }
}
