package com.kwad.components.core.pfmonitor.model;

import android.text.TextUtils;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public int air;
    public List<a> ais;

    public static b bd(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        try {
            b bVar = new b();
            bVar.parseJson(new JSONObject(str));
            return bVar;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    public final List<a> vE() {
        return this.ais;
    }
}
