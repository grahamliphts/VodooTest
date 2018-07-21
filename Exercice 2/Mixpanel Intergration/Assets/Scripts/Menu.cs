using UnityEngine;
using UnityEngine.SceneManagement;

/*!
 * \brief Very simple Menu manager, needed to show a classic game workflow (loading -> menu -> game)
 */
public class Menu : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartButtonPressed()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
