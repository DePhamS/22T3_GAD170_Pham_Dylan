using Newtonsoft.Json.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public enum TheBoys { Undefined, BigTony, TinyKevin, RegularSteve}

    public class WeekFiveActivity : MonoBehaviour
    {
        [SerializeField] private TheBoys chosenBoy = TheBoys.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string preferredName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialise()
        {
            // We want to set up all 3 characters here
            // using an if statment, we can say:
            // use if statments
            // if variable == 0, set up big tony
            // if variable == 1, set up tiny kevin
            // if variable == 2, set up regular steve
            // if statment
            // switch statement

            switch (chosenBoy)
            {
                case TheBoys.Undefined:
                    Debug.Log("The Boys undefined. Set its enum in the inspector!");
                    break;
                case TheBoys.BigTony:
                    Setup("Tony", "Smith", "Big Tony", "0487 472 222", "Unkown", "tonysmith123@gmail.com");
                    break;
                case TheBoys.TinyKevin:
                    Setup("Kevin", "Lee", "Tiny Kevin", "0562 936 581", "Unkown", "kevinlee123@gmail.com");
                    break;
                case TheBoys.RegularSteve:
                    Setup("Steve", "Reeves", "Regular Steve", "0487 892 561", "Unknown", "stevereeves123@gmail.com");
                    break;
                default:
                    Debug.Log("Invalid Selection!");
                    break;
            }
        }

        private void Setup(string newFirstName,
                           string newLastName,
                           string newPreferredName,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail)
        {
            firstName = newFirstName;
            lastName = newLastName;
            preferredName = newPreferredName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }
    }
}
