package com.kwad.components.ad.interstitial.c;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ai;
import java.text.SimpleDateFormat;
import java.util.Date;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    private static SimpleDateFormat jU = new SimpleDateFormat("yyyy-MM-dd");
    public long jV = -1;

    /* JADX INFO: renamed from: ms, reason: collision with root package name */
    public int f2756ms = 0;
    public int mt = 0;

    private static boolean b(long j, long j2) {
        if (j > 0 && j2 > 0) {
            try {
                return jU.format(new Date(j)).equals(jU.format(new Date(j2)));
            } catch (Exception e) {
                c.printStackTraceOnly(e);
            }
        }
        return false;
    }

    public static void J(Context context) {
        String strVs = ai.Vs();
        b bVar = new b();
        if (TextUtils.isEmpty(strVs)) {
            bVar.f2756ms = 1;
            bVar.jV = System.currentTimeMillis();
            ai.ai(context, bVar.toJson().toString());
            return;
        }
        try {
            bVar.parseJson(new JSONObject(strVs));
            if (b(bVar.jV, System.currentTimeMillis())) {
                bVar.f2756ms++;
            } else {
                bVar.f2756ms = 1;
                bVar.mt = 0;
                bVar.jV = System.currentTimeMillis();
            }
            ai.ai(context, bVar.toJson().toString());
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
    }

    public static void K(Context context) {
        String strVs = ai.Vs();
        b bVar = new b();
        if (TextUtils.isEmpty(strVs)) {
            bVar.mt = 1;
            bVar.jV = System.currentTimeMillis();
            ai.ai(context, bVar.toJson().toString());
            return;
        }
        try {
            bVar.parseJson(new JSONObject(strVs));
            if (b(bVar.jV, System.currentTimeMillis())) {
                bVar.mt++;
            } else {
                bVar.mt = 1;
                bVar.f2756ms = 0;
                bVar.jV = System.currentTimeMillis();
            }
            ai.ai(context, bVar.toJson().toString());
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
    }

    public static int dT() {
        String strVs = ai.Vs();
        if (TextUtils.isEmpty(strVs)) {
            return 0;
        }
        b bVar = new b();
        try {
            bVar.parseJson(new JSONObject(strVs));
            return bVar.f2756ms;
        } catch (Exception e) {
            c.printStackTraceOnly(e);
            return 0;
        }
    }

    public static int dU() {
        String strVs = ai.Vs();
        if (TextUtils.isEmpty(strVs)) {
            return 0;
        }
        b bVar = new b();
        try {
            bVar.parseJson(new JSONObject(strVs));
            return bVar.mt;
        } catch (Exception e) {
            c.printStackTraceOnly(e);
            return 0;
        }
    }
}
