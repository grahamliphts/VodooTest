using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*! \brief
 *  This class is a simple wrapper for NativePopup library for Android 
 */
public class PluginTest : MonoBehaviour {

   

	const string pluginName = "com.vhay.unity.nativePopup";
	class AlertViewCallback : AndroidJavaProxy
	{
		private System.Action<int> alertHandler;

		public AlertViewCallback(System.Action<int>alertHandlerIn) : base (pluginName + "$AlertViewCallback")
		{
			alertHandler = alertHandlerIn;
		}
		public void onButtonTapped(int index)
		{
			Debug.Log("Button tapped: " + index);
			if (alertHandler != null)
				alertHandler(index);
		}
	}

	static AndroidJavaClass _pluginClass;
	static AndroidJavaObject _pluginInstance;

    /*! \brief  intialize Java Singleton with current Unity context 
     *  \return AndroidJavaClass in charge of nativePopup management
     */
	public static AndroidJavaClass PluginClass
	{
		get {
			if (_pluginClass==null)
			{
				_pluginClass = new AndroidJavaClass(pluginName);
				AndroidJavaClass playerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
				AndroidJavaObject activity = playerClass.GetStatic<AndroidJavaObject>("currentActivity");
				_pluginClass.SetStatic<AndroidJavaObject>("mainActivity",activity);
			}
			return _pluginClass;
		}
	}

    /*! \brief  C# Wrapper for  "getInstance" native Java Function
     *  \return AndroidJavaObject wich is the current Instance of Java Class
     */
    public static AndroidJavaObject PluginInstance
	{
		get {
			if (_pluginInstance==null)
			{
				_pluginInstance = PluginClass.CallStatic<AndroidJavaObject>("getInstance");
			}
			return _pluginInstance;
		}
	}

	// Use this for initialization
	void Start () {
		
	}

	float elapsedTime = 0;
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
            showNativePopup(new string[]{"Native popup","Hello World","Ok"},(int obj) => {
				Debug.Log("Local Handler called: " + obj);
			});
		}
		
	}

    /*! \brief This function allow NativePopup appearence using native code
     *  \param strings[] "Title","Popup Content","Button label 1 ",[...],"Button label 3"
     *  \param System.Action<int>handler C# handler for button ID pressed
     */
    public void showNativePopup(string[] strings, System.Action<int>handler = null)
	{
		if (strings.Length<3)
		{
			Debug.LogError("Needs at least 3 strings (title,content,button label)");
			return;
		}

		if (Application.platform == RuntimePlatform.Android)
			PluginInstance.Call("showAlertView", new object[] { strings, new AlertViewCallback(handler) });
		else
			Debug.LogWarning("Unsupported platform (Android Only)");
	}
}
