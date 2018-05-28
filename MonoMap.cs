using UnityEngine;

namespace MonoMap
{
    // A new instance of this class is created every time we begin
    //controlling a vessel The instance is destroyed when we leave
    //the vessel

    [KSPAddon(KSPAddon.Startup.Flight, false)]
    class MonoMap : MonoBehaviour
    {
        public static string NAME = "MonoMap";
        public static string VERSION = "1.0";

        void Start()
        {
            Debug.Log(NAME + " " + VERSION + " initialized");
        }

        void Update()
        {

            if (MapView.MapIsEnabled == false)
            {
                // Find all audio sources
                foreach (AudioSource a in FindObjectsOfType(typeof(AudioSource)) as AudioSource[])
                {
                    // Enable 3D sound
                    a.spatialBlend = 1.0f;
                }
            }
            else
            {
                // Find all audio sources
                foreach (AudioSource a in FindObjectsOfType(typeof(AudioSource)) as AudioSource[])
                {
                    // Disable 3D sound
                    a.spatialBlend = 0.0f;
                }
            }
                
        }

    }
}
