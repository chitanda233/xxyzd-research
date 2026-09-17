package com.gorilla.base;

import android.app.Activity;
import android.widget.Toast;
import com.unity3d.player.UnityPlayer;

/* JADX INFO: loaded from: classes3.dex */
public final class GorillaBaseToast {
    private GorillaBaseToast() {
    }

    public static void showToast(final String str, int i) {
        final Activity activity;
        if (str == null || str.trim().isEmpty() || (activity = UnityPlayer.currentActivity) == null) {
            return;
        }
        final int i2 = i != 1 ? 0 : 1;
        activity.runOnUiThread(new Runnable() { // from class: com.gorilla.base.GorillaBaseToast$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                Toast.makeText(activity.getApplicationContext(), str, i2).show();
            }
        });
    }
}
