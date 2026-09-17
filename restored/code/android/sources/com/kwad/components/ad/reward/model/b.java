package com.kwad.components.ad.reward.model;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.utils.ai;
import java.text.SimpleDateFormat;
import java.util.Date;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    private static SimpleDateFormat jU = new SimpleDateFormat("yyyy-MM-dd");
    public long mu = -1;
    public int mv = 0;

    public static void L(Context context) {
        String strVv = ai.Vv();
        b bVar = new b();
        if (TextUtils.isEmpty(strVv)) {
            bVar.mv = 1;
            bVar.mu = System.currentTimeMillis();
            ai.am(context, bVar.toJson().toString());
            return;
        }
        try {
            bVar.parseJson(new JSONObject(strVv));
            if (b(bVar.mu, System.currentTimeMillis())) {
                bVar.mv++;
            } else {
                bVar.mv = 1;
                bVar.mu = System.currentTimeMillis();
            }
            ai.am(context, bVar.toJson().toString());
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    public static int dV() {
        String strVv = ai.Vv();
        if (TextUtils.isEmpty(strVv)) {
            return 0;
        }
        b bVar = new b();
        try {
            bVar.parseJson(new JSONObject(strVv));
            if (b(bVar.mu, System.currentTimeMillis())) {
                return bVar.mv;
            }
            return 0;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return 0;
        }
    }

    private static boolean b(long j, long j2) {
        if (j > 0 && j2 > 0) {
            try {
                return jU.format(new Date(j)).equals(jU.format(new Date(j2)));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        return false;
    }
}
