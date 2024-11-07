using UnityEngine;

public class Cat : Animal
{
    void Start()
   {
        animalSound = "Meow";
        makeSound();
    }

    protected override void makeSound()
    {
        base.makeSound();
        Yell();
    }

     void Yell()
    {
        Debug.Log("I'm a cat who owns this place.");
    }
}
