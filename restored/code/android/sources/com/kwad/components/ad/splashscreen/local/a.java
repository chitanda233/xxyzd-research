package com.kwad.components.ad.splashscreen.local;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ai;
import java.text.SimpleDateFormat;
import java.util.Date;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.core.response.a.a {
    private static SimpleDateFormat jU = new SimpleDateFormat("yyyy-MM-dd");
    public long jV = 0;
    public int jW = 0;

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

    public static void V(Context context) {
        String strVu = ai.Vu();
        a aVar = new a();
        if (TextUtils.isEmpty(strVu)) {
            aVar.jW = 1;
            aVar.jV = System.currentTimeMillis();
            ai.al(context, aVar.toJson().toString());
            return;
        }
        try {
            aVar.parseJson(new JSONObject(strVu));
            if (b(aVar.jV, System.currentTimeMillis())) {
                aVar.jW++;
            } else {
                aVar.jW = 1;
            }
            aVar.jV = System.currentTimeMillis();
            ai.al(context, aVar.toJson().toString());
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
    }
}
