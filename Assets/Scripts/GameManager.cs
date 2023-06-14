using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; } //ENCAPSULATION

    public AnimalCharacter[] animalCharacters;

    public AnimalCharacter currentAnimalCharacter;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (animalCharacters.Length > 0)
        {
            currentAnimalCharacter = animalCharacters[0];
        }
    }

    public void SetCharacter(AnimalCharacter animalCharacter)
    {
        currentAnimalCharacter = animalCharacter;
    }

}
