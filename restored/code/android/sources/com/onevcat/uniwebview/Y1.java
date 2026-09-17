package com.onevcat.uniwebview;

import com.byazt.bv.BaseConstants;
import java.util.HashMap;
import java.util.Map;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class Y1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f2873a;
    public final String b;
    public final String c;
    public final JSONObject d;

    public Y1(String identifier, String resultCode, String data, Map map) {
        Intrinsics.checkNotNullParameter(identifier, "identifier");
        Intrinsics.checkNotNullParameter(resultCode, "resultCode");
        Intrinsics.checkNotNullParameter(data, "data");
        this.f2873a = identifier;
        this.b = resultCode;
        this.c = data;
        if (map != null) {
            this.d = new JSONObject(map);
        }
    }

    public final String toString() {
        HashMap map = new HashMap();
        map.put("identifier", this.f2873a);
        map.put("resultCode", this.b);
        map.put("data", this.c);
        JSONObject jSONObject = this.d;
        if (jSONObject != null) {
            map.put(BaseConstants.EVENT_LABEL_EXTRA, String.valueOf(jSONObject));
        }
        String string = new JSONObject(map).toString();
        Intrinsics.checkNotNullExpressionValue(string, "obj.toString()");
        return string;
    }
}
