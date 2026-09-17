package com.kwad.components.ad.interstitial.d;

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
    public long mu = -1;
    public int mv = 0;

    public static void L(Context context) {
        String strVw = ai.Vw();
        a aVar = new a();
        if (TextUtils.isEmpty(strVw)) {
            aVar.mv = 1;
            aVar.mu = System.currentTimeMillis();
            ai.an(context, aVar.toJson().toString());
            return;
        }
        try {
            aVar.parseJson(new JSONObject(strVw));
            if (b(aVar.mu, System.currentTimeMillis())) {
                aVar.mv++;
            } else {
                aVar.mv = 1;
                aVar.mu = System.currentTimeMillis();
            }
            ai.an(context, aVar.toJson().toString());
        } catch (Exception e) {
            c.printStackTrace(e);
        }
    }

    public static int dV() {
        String strVw = ai.Vw();
        if (TextUtils.isEmpty(strVw)) {
            return 0;
        }
        a aVar = new a();
        try {
            aVar.parseJson(new JSONObject(strVw));
            if (b(aVar.mu, System.currentTimeMillis())) {
                return aVar.mv;
            }
            return 0;
        } catch (Exception e) {
            c.printStackTrace(e);
            return 0;
        }
    }

    private static boolean b(long j, long j2) {
        if (j > 0 && j2 > 0) {
            try {
                return jU.format(new Date(j)).equals(jU.format(new Date(j2)));
            } catch (Exception e) {
                c.printStackTrace(e);
            }
        }
        return false;
    }
}
