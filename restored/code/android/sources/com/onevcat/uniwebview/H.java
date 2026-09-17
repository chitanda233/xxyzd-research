package com.onevcat.uniwebview;

import com.byazt.bv.BaseConstants;
import java.util.HashMap;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class H implements c2 {
    @Override // com.onevcat.uniwebview.c2
    public final void a(String name, d2 method, Y1 payload) {
        Intrinsics.checkNotNullParameter(name, "name");
        Intrinsics.checkNotNullParameter(method, "method");
        Intrinsics.checkNotNullParameter(payload, "payload");
        HashMap map = new HashMap();
        map.put("identifier", payload.f2873a);
        map.put("resultCode", payload.b);
        map.put("data", payload.c);
        JSONObject jSONObject = payload.d;
        if (jSONObject != null) {
            map.put(BaseConstants.EVENT_LABEL_EXTRA, String.valueOf(jSONObject));
        }
        String string = new JSONObject(map).toString();
        Intrinsics.checkNotNullExpressionValue(string, "obj.toString()");
        a(name, method, string);
    }

    @Override // com.onevcat.uniwebview.c2
    public final void a(String name, d2 method, String parameters) {
        Intrinsics.checkNotNullParameter(name, "name");
        Intrinsics.checkNotNullParameter(method, "method");
        Intrinsics.checkNotNullParameter(parameters, "parameters");
    }
}
