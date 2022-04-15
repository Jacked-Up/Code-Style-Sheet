using UnityEngine;

// Always use name spaces
// Put classes into namespaces that make sense
namespace JackedUp {
    // Explain/summarize the script in two lines or less
    // Add your name to the 'Author' parameter IF you made the script
    /// <summary>
    /// 
    /// </summary>
    /// <para>Author: </para>
    public class MonoBehaviorExample : MonoBehaviour {
        // Please create a region for storing all class level variables/properties/return types
        #region Variables

        // Constants
        public const int PUBLIC_CONSTANT_VARIABLE = 2;
        private const int PRIVATE_CONSTANT_VARIABLE = 2;
        
        // Public scope
        public static bool PublicStaticVariable;
        public bool publicVariable;
        
        // Protected scope
        protected bool ProtectVariable;
        
        // Private scope
        private static bool _privateStaticVariable;
        private bool _privateVariables;

        #endregion

        // While you do not need to add the private accessor, add it anyways
        // This helps with readability
        private void Start() {
            // Please use debugs when it is necessary
            // Add all debugs into this if compilation condition so that they are not included inside compiled code
#if UNITY_EDITOR
            Debug.Log("Hello world!");
#endif

            // In this example, we are debugging the sum of 5 and 4 added together
            // Use string interpolation in all strings to ensure best readability
#if UNITY_EDITOR
            // This
            Debug.Log($"5 + 4 = {AddTwoNumbers(5, 4)}");
            
            // Not this
            Debug.Log("5 + 4 = " + AddTwoNumbers(5, 4));
#endif
        }

        // Note the name of the method tells you EXACTLY what this method does
        private int AddTwoNumbers(int numberA, int numberB) {
            return numberA + numberB;
        }
        
        // Use lambdas for better readability
        // They also make the code look better ;)
        // EXAMPLE:
        // private int AddTwoNumbers(int numberA, int numberB) 
        //     => numberA + numberB;

        // You do not need to summarize anything with a private accessor
        private void MyPrivateMethod() {}
        
        // You must summarize anything that does not use a private accessor
        // Make sure your explanation are short and concise
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myNumber"> </param>
        public void MyPublicMethod(int myNumber) {
            // Magic variables are GROSS
            // Use constants for better code readability AND more preformat code
            
            // This
            var newNumber = myNumber + PRIVATE_CONSTANT_VARIABLE;
            
            // Not this
            var otherNewNumber = myNumber + 2;
        }
    }
}
