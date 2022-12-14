using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<WeekFiveActivity> contacts = new List<WeekFiveActivity>();

        private void Start()
        {
            // Let's loop through our collection.
            // Create integer call i and give it value of 0
            // if i < Count, then do the things inside this loop
            // then, increase i by 1... making i = 1.. then i = 2... then i = 3...

            for(int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Initialise();
            }
        }
    }
}
