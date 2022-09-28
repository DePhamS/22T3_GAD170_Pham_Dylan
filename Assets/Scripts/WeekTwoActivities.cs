using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DylanPham
{
    public class WeekTwoActivities : MonoBehaviour
    {
        private string favouriteGame = "Team Fortress 2";
        private int hoursPlayed = 1834;
        private float costOfGame = 0f;


        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed);
        }
    }
}
