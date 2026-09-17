package com.qq.gdt.action.i;

import android.content.Context;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class x {
    public static void a(JSONObject jSONObject, Context context) {
        try {
            com.qq.gdt.action.d.d.b bVarD = h.d(context);
            jSONObject.putOpt("taid", bVarD.b);
            jSONObject.putOpt("taid_standard", bVarD.b);
            jSONObject.putOpt("taid_ticket_standard", bVarD.c);
            jSONObject.putOpt("m10", bVarD.f3039a);
            jSONObject.putOpt("m10_standard", bVarD.f3039a);
            jSONObject.putOpt("m10Error", Integer.valueOf(bVarD.d));
        } catch (Throwable th) {
            o.a("appendTuringDID err", th);
        }
    }
}
