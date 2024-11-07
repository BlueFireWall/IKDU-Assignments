using System;
using UnityEngine;

public class Animal : MonoBehaviour
{
        public string animalSound;
        protected virtual void makeSound()
        {
            Debug.Log(animalSound);
        }
    



}
