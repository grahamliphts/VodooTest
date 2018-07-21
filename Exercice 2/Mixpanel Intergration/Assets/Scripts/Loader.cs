using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*!
 * \brief Loader is a temporary scene used at App Launch to log the App launch Event, 
 * It call the MixPanel_helper event "GameLaunchedEvent"

 */
public class Loader : MonoBehaviour {

    [SerializeField]
    private Mixpannel_Helper MixHelper;

    // Use this for initialization
    void Start () {
        MixHelper.GameLaunchedEvent();
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

}
