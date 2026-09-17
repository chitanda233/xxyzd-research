package com.byazt.pp;

import android.content.Context;
import android.widget.Toast;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1434, 15})
public final class uj {
    public static Toast c;

    public static void c(Context context, String str) {
        c(context, str, 0);
    }

    public static void c(Context context, String str, int i) {
        Toast toastC = c(context);
        if (toastC != null) {
            toastC.setDuration(i);
            toastC.setText(String.valueOf(str));
            toastC.show();
            return;
        }
        com.byazt.eu.tt.tt("TToast", "toast msg: ".concat(String.valueOf(str)));
    }

    private static Toast c(Context context) {
        if (context == null) {
            return c;
        }
        Toast toastMakeText = Toast.makeText(context.getApplicationContext(), "", 0);
        c = toastMakeText;
        return toastMakeText;
    }
}
