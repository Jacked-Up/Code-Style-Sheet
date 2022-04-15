using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace JackedUp.Examples {
    /// <summary>
    /// A class that manages a dog company.
    /// </summary>
    /// <para>Author: Jack Randolph</para>
    public class DogWalkingCompany : MonoBehaviour {
        #region Variables

        private const int BAD_RATING_THRESHOLD = 3;
        private const int DOLLARS_PER_HOUR = 8;
        
        /// <summary>
        /// A list of hired dog walkers.
        /// </summary>
        public List<DogWalker> hiredDogWalkers = new List<DogWalker>();
        
        /// <summary>
        /// A list of fired dog walkers.
        /// </summary>
        public List<DogWalker> firedDogWalkers = new List<DogWalker>();

        /// <summary>
        /// Dog walker information.
        /// </summary>
        [Serializable]
        public struct DogWalker {
            public string name;
            public int rating;
            public int hours;
            public int totalEarnings;

            /// <summary>
            /// Pays the dog walker the specified amount.
            /// </summary>
            /// <param name="amount">Total amount to pay.</param>
            public void Pay(int amount) {
                totalEarnings += amount;
                hours = 0;
            }
        }

        #endregion

        /// <summary>
        /// Pays all dog walkers for their time.
        /// </summary>
        public void PayAllDogWalkers() {
            FireAllLowRatedDogWalkers();
            
            foreach (var dogWalker in hiredDogWalkers) {
                var payment = dogWalker.hours * DOLLARS_PER_HOUR;
                dogWalker.Pay(payment);
            }
        }
        
        /// <summary>
        /// Fires all dog walkers with a rating equal to three or less.
        /// </summary>
        public void FireAllLowRatedDogWalkers() {
            foreach (var dogWalker in hiredDogWalkers.Where(dogWalker => dogWalker.rating <= BAD_RATING_THRESHOLD))
                FireDogWalker(dogWalker);
        }
        
        /// <summary>
        /// Hires a new dog walker.
        /// </summary>
        /// <param name="newDogWalker">Information about the new dog walker.</param>
        public void HireDogWalker(DogWalker newDogWalker) {
            if (hiredDogWalkers.Contains(newDogWalker))
                return;
            
            hiredDogWalkers ??= new List<DogWalker>();
            hiredDogWalkers.Add(newDogWalker);
        }

        /// <summary>
        /// Fires a dog walker.
        /// </summary>
        /// <param name="dogWalker">The dog walker to fire.</param>
        public void FireDogWalker(DogWalker dogWalker) {
            if (!hiredDogWalkers.Contains(dogWalker))
                return;

            hiredDogWalkers.Remove(dogWalker);
            
            if (firedDogWalkers.Contains(dogWalker))
                return;
            
            firedDogWalkers ??= new List<DogWalker>();
            firedDogWalkers.Add(dogWalker);
        }
    }
}