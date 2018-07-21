using UnityEngine;
using mixpanel;

/*!
 * \brief The Mixpannel_Helper is dedicated to simplification of Mixpanel tool integration.
 * \brief It Handle a generic implementation of launch counter, first launch event and party counter
 * \brief it also simplify GamePlayed and appLaunched event sending by reduce the integration to only two calls void GamePlayedEvent(int score) and void GameLaunchedEvent() nothing more have to be written by gameDevs.
 * \param AppName, App descriptor for Mixpanel UI and sort options
 * \param verbose, usefull for event debugging
 */
public class Mixpannel_Helper : MonoBehaviour {

    [SerializeField]
    private string AppName;
    [SerializeField]
    private bool verbose;

    private bool FirstLaunch = true;
    private int LaunchCount = 0;
    private bool initialized = false;

    /*!
     * \brief This function handle gamePlayed event sending to Mixpanel
     * \brief it also manage game counting for the current session to simplify implementation to gameDev
     * \param score last played round score
     */
    public void GamePlayedEvent(int score)
    {
        if (!initialized)
            intialize();

        int gamePlayed = PlayerPrefs.GetInt("GameCount");
        gamePlayed++;
        PlayerPrefs.SetInt("GameCount", gamePlayed);
        var props = new Value();
        props["Score "] = score;
        props["Game Count"] = gamePlayed;
        Mixpanel.Track(AppName + " Game Played", props);
        if(verbose)
        {
            Debug.Log(AppName + " GamePlayedEvent sent");
            Debug.Log("Score : " + score);
            Debug.Log("Game Count : " + gamePlayed);

        }
        
    }
    /*!
     * \brief This function is called at the very beggining of the game and hande the gameLaunched event sending
     * \brief the FirstLaunched and the launchCount parameters are managed internaly and so gameDev don't ask to waste time with it
     */
    public void GameLaunchedEvent()
    {
        if (!initialized)
            intialize();

        LaunchCount++;
        PlayerPrefs.SetInt("LaunchCount", LaunchCount);
        var props = new Value();
        props["First Time "] = FirstLaunch;
        props["Count"] = LaunchCount;
        Mixpanel.Track( AppName + "App Launched", props);

        if(verbose)
        {
            Debug.Log(AppName + " GameLaunchedEvent sent");
            Debug.Log("First Launch : " + FirstLaunch);
            Debug.Log("Count : " + LaunchCount);

        }
       

    }
    /*!
     * /brief To avoid using the helper without proper initialization, the initialisation event is called at the first Helper event call.
     */
    void intialize()
    {
        if (PlayerPrefs.GetInt("FirstLaunch") == 0)
            PlayerPrefs.SetInt("FirstLaunch", 1);
        else
            FirstLaunch = false;

        LaunchCount = PlayerPrefs.GetInt("LaunchCount");
        PlayerPrefs.SetInt("GameCount", 0);
        initialized = true;
    }
}
