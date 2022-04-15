using UnityEngine;

namespace JackedUp {
    // Static classes are great if they are used correctly
    // Static classes can be used for a whole slew of different things: dependency manager, game manager,
    // network manager, etc
    //
    // Since these classes do not inherit from mono behavior, they do not need to be inside of the scene to run
    // That's why they are perfect for managers
    
    /// <summary>
    /// 
    /// </summary>
    /// <para>Author: </para>
    public static class StaticClassExample {
        #region Variables

        

        #endregion

        // This is the most power attribute in the world
        // This attribute invokes the method before the first scene is loaded
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void BeforeSceneLoadCallback() {}
        
        // ALTERNATIVELY
        // This attribute invokes the method after the first scene is loaded
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void AfterSceneLoadCallback() {}
    }
}