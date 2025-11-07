using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia {
    public class DataTarget : MonoBehaviour {
        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;        

        void Start() {
            }

        void Update() {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();        
            foreach (TrackableBehaviour tb in tbs) {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize(); 
                Debug.Log("Active image target:" + name + " -size: " + size.x + ", " + size.y);		
                TextTargetName.GetComponent<Text>().text = name;
                ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);
                if (name == "panci_masak") {
                    TextDescription.GetComponent<Text>().text = "All-Clad Copper Core Sauce Pan\n\n+ Made in United States\n+ Made with Copper and Stainless Steel\n+ Size : 4 quart\n+ Dimensions : 5.4 x 5.4 x 5.4 inches\n\nPrice : $ 399.99";
                    }  
                if (name == "wajan_penggorengan") {
                    TextDescription.GetComponent<Text>().text = "Copper Outer Frying Pan\n\n+ Made in United States\n+ Made with Copper and Stainless Steel\n+ Diameter : 21 cm\n+ Height : 2 cm\n+ Weight : 645 g\n\nPrice : $ 33.95";
                    }
                if (name == "pisau_dapur") {
                    TextDescription.GetComponent<Text>().text = "Nitrogen Collection Chef's Knife\n\n+ Made in United States\n+ Made with Nitrogen-Infused Steel\n+ Dimensions : 0.75 x 4.38 x 16.88 inches\n+ Weight : 0.983 g\n\nPrice : $ 14.99";         
                    }    
                if (name == "talenan") {
                    TextDescription.GetComponent<Text>().text = "Large Wooden Cutting Board with Handle\n\n+ Made in China\n+ Made with Rubberwood\n+ Dimensions : 18 x 8 x 0.75 inches\n\nPrice : $ 9.49";         
                    }   
        }    
    }
}
}