using UnityEngine;

public class Dog : Animal
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalSound = "Woof";
        makeSound();
    }

    protected override void makeSound()
    {
        base.makeSound();
        BegForFood();
    }

    void BegForFood()
    {
        Debug.Log("I'm a dog whom is begging for food.");
    }
}
