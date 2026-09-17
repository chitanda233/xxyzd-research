package com.kwad.components.ad.reward.h;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ai;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static long vD = -1;
    public static int vE;

    private static boolean j(long j) {
        return ip() > 0 && j > 0 && ip() / 2460601000L == j / 2460601000L;
    }

    public static void J(Context context) {
        b bVar = new b();
        if (j(System.currentTimeMillis())) {
            vE++;
        } else {
            vE = 1;
        }
        vD = System.currentTimeMillis();
        bVar.vF = vE;
        bVar.jV = vD;
        ai.ak(context, bVar.toJson().toString());
    }

    private static long ip() {
        long j = vD;
        if (j != -1) {
            return j;
        }
        String strVt = ai.Vt();
        if (TextUtils.isEmpty(strVt)) {
            return 0L;
        }
        b bVar = new b();
        try {
            bVar.parseJson(new JSONObject(strVt));
            vD = bVar.jV;
            vE = bVar.vF;
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
        return vD;
    }

    public static int dT() {
        if (!j(System.currentTimeMillis())) {
            vE = 0;
        }
        return vE;
    }
}
