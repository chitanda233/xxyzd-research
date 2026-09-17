package com.kwad.sdk.a.a.a;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ai;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static int aul = 0;
    public static long vD = -1;

    private static boolean j(long j) {
        return ip() > 0 && j > 0 && ip() / 2460601000L == j / 2460601000L;
    }

    public static void J(Context context) {
        a aVar = new a();
        if (j(System.currentTimeMillis())) {
            aul++;
        } else {
            aul = 1;
        }
        vD = System.currentTimeMillis();
        aVar.aul = aul;
        aVar.jV = vD;
        ai.at(context, aVar.toJson().toString());
    }

    private static long ip() {
        long j = vD;
        if (j != -1) {
            return j;
        }
        String strVE = ai.VE();
        if (TextUtils.isEmpty(strVE)) {
            return 0L;
        }
        a aVar = new a();
        try {
            aVar.parseJson(new JSONObject(strVE));
            vD = aVar.jV;
            aul = aVar.aul;
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
        return vD;
    }

    public static int dT() {
        if (!j(System.currentTimeMillis())) {
            aul = 0;
        }
        return aul;
    }
}
