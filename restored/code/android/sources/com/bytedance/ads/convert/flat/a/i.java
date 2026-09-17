package com.bytedance.ads.convert.flat.a;

import androidx.core.app.NotificationCompat;
import com.byazt.hs.sl;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class i {
    public String b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1684a = "";
    public String c = "";
    public String d = "";
    public int e = -1;
    public String f = "";
    public long g = 0;

    public i(String str) {
        this.b = str;
    }

    public JSONObject a() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("tk", this.f1684a).put("vd", this.d).put("cr", this.c).put(NotificationCompat.CATEGORY_ERROR, this.b).put(sl.c, this.e).put("pr", this.f);
        } catch (Exception unused) {
        }
        return jSONObject;
    }

    public String toString() {
        return a().toString();
    }
}
