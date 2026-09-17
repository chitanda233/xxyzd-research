package com.kuaishou.weapon.p0;

import android.content.Context;
import android.text.TextUtils;
import com.kuaishou.weapon.p0.jni.Engine;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class ca {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private JSONObject f2668a;

    public ca(Context context) {
        if (Engine.loadSuccess) {
            Engine.getInstance(context);
            String strBcd = Engine.bcd();
            if (TextUtils.isEmpty(strBcd) || strBcd.length() <= 2) {
                return;
            }
            try {
                this.f2668a = new JSONObject(strBcd);
            } catch (Exception unused) {
            }
        }
    }

    public String a(String str) {
        JSONObject jSONObject = this.f2668a;
        if (jSONObject == null) {
            return null;
        }
        try {
            return jSONObject.getString(str);
        } catch (Exception unused) {
            return null;
        }
    }
}
