package com.unicom.online.account.kernel;

import android.content.Context;
import com.unicom.online.account.shield.ResultListener;
import java.lang.ref.WeakReference;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public abstract class l {
    public static int b;
    public static int c;
    public static int d;
    public static WeakReference e;

    public static void b(int i, ResultListener resultListener, int i2, String str, int i3) {
        ar.b("type:" + i + "\nmsg:" + str);
        try {
            String strC = bp.c();
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("resultCode", i2);
            jSONObject.put("resultMsg", str);
            jSONObject.put("resultData", "");
            jSONObject.put("seq", strC);
            b();
            if (resultListener != null) {
                resultListener.onResult(jSONObject.toString());
            }
            bp.e().getClass();
            if (ap.b) {
                bp.e().getClass();
                String strB = bp.b(1, 1, strC, i2, i3, i2, str);
                bp.e().getClass();
                an.b(bp.b(), strB);
            }
        } catch (Exception e2) {
            if (ar.b) {
                e2.printStackTrace();
            }
        }
    }

    public static Context c() {
        WeakReference weakReference = e;
        if (weakReference != null) {
            return (Context) weakReference.get();
        }
        return null;
    }

    public static void b() {
        d = 0;
        c = 0;
        b = 0;
    }
}
