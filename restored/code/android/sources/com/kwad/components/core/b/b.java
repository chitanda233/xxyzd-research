package com.kwad.components.core.b;

import android.graphics.Color;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public String OU = null;
    public String OV = null;
    public String title;

    public static b c(JSONObject jSONObject) {
        b bVar = new b();
        bVar.parseJson(jSONObject);
        return bVar;
    }

    public b() {
    }

    public b(String str) {
        this.title = str;
    }

    public final String getTitle() {
        return this.title;
    }

    public final int oD() {
        try {
            String str = this.OU;
            if (str != null) {
                return Color.parseColor(str);
            }
            return -1;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return -1;
        }
    }

    public final int oE() {
        try {
            String str = this.OV;
            if (str != null) {
                return Color.parseColor(str);
            }
            return -1;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return -1;
        }
    }
}
