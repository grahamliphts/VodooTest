package com.vhay.unity;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.util.Log;

/*!
    \brief The native Popup Class allow native popup on Android and button callback for Unity
    \brief Lib state can be followed through Logcat using "Vhay Lib" Tag
 */
public class nativePopup {
    private static final nativePopup ourInstance = new nativePopup();

    private static final String LOGTAG = "Vhay Lib";

    /*!
        \brief Get current instance of nativePopup singleton
     */
    public static nativePopup getInstance() {
        return ourInstance;
    }

    public static Activity mainActivity;

    /*!
        \brief button pressed callback
     */
    public interface AlertViewCallback {
        public void onButtonTapped(int id);
    }
    /*!
        \bried nativPopup class default constructor
     */
    private nativePopup() {
        Log.i(LOGTAG,"Created nativePopup");
    }
    /*!
        \brief show native android popup with one to three buttons, depending on the amount of elements in strings argument
        \param strings "title","content","Button label 1 ",[...],"Button label 3"
        \param button pressed callback
     */
    public void showAlertView(String[] strings, final AlertViewCallback callback)
    {
        if (strings.length<3)
        {
            Log.i(LOGTAG,"Error - expected at least 3 strings, got " + strings.length);
            return;
        }
        DialogInterface.OnClickListener myClickListener = new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int id) {
                dialogInterface.dismiss();
                Log.i(LOGTAG, "Tapped: " + id);
                callback.onButtonTapped(id);
            }
        };

        AlertDialog alertDialog = new AlertDialog.Builder(mainActivity)
                .setTitle(strings[0])
                .setMessage(strings[1])
                .setCancelable(false)
                .create();
        alertDialog.setButton(AlertDialog.BUTTON_NEUTRAL,strings[2],myClickListener);
        if (strings.length>3)
            alertDialog.setButton(AlertDialog.BUTTON_NEGATIVE,strings[3],myClickListener);
        if (strings.length>4)
            alertDialog.setButton(AlertDialog.BUTTON_POSITIVE,strings[4],myClickListener);
        alertDialog.show();
    }
}