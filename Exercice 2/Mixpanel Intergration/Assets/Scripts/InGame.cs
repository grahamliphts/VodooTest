using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*!
 * \brief inGame class is a simple representation a game loop, private void generateScore() represent a full gameloop by generating a score and trigger the EndGame event
 */
public class InGame : MonoBehaviour {

    [SerializeField]
    private Text Score;
    [SerializeField]
    private Mixpannel_Helper MixHelper;
    private int _Score;
    

    // Use this for initialization
    void Start () {
        generateScore();
        
    }

    /*! 
     * \brief public function for replay button Call
     */
    public void restartButtonPressed()
    {
        generateScore();
    }
    /*! 
     * \brief public function for EndGame button Call
     */
    public void endGameButtonPressed()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    /*! 
    * \brief GameEvent, generate Score and call GamePlayedEvent of the Mixpannel_Helper script
    */
    private void generateScore()
    {
        _Score = (int)Random.Range(0f, 100f);
        Score.text = "Score : " + _Score.ToString();

        MixHelper.GamePlayedEvent(_Score);
    }
}
