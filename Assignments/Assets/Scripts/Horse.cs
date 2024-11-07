using UnityEngine;

public class Horse : Animal
{
    void Start()
   {
        animalSound = "Neeeiigh";
        makeSound();
    }

    protected override void makeSound()
    {
        base.makeSound();
        Talk();
    }
     void Talk()
    {
        Debug.Log("I'm a horse who just wants food.");
    }
}