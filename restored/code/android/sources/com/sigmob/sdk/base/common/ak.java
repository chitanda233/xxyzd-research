package com.sigmob.sdk.base.common;

import android.content.Context;
import android.widget.Toast;

/* JADX INFO: loaded from: classes3.dex */
public class ak extends Toast {
    public ak(Context context) {
        super(context);
    }

    public static Toast a(Context context, CharSequence text, int duration) {
        Toast toastMakeText = Toast.makeText(context, text, duration);
        toastMakeText.setGravity(17, 0, 0);
        return toastMakeText;
    }
}
