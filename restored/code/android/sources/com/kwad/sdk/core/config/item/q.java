package com.kwad.sdk.core.config.item;

import android.content.SharedPreferences;
import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class q extends b<String> {
    private static volatile String[] aRf;

    public q(String str, String str2) {
        super(str, str2);
        aRf = null;
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final void l(JSONObject jSONObject) {
        if (jSONObject != null) {
            String strOptString = jSONObject.optString(getKey(), Ln());
            setValue(strOptString);
            ej(strOptString);
            return;
        }
        setValue(Ln());
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final void b(SharedPreferences.Editor editor) {
        editor.putString(getKey(), getValue());
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final void a(SharedPreferences sharedPreferences) {
        String string = sharedPreferences.getString(getKey(), Ln());
        setValue(string);
        ej(string);
    }

    public static boolean ak(long j) {
        if (aRf == null) {
            return false;
        }
        for (String str : aRf) {
            if (str != null && String.valueOf(j).equals(str.trim())) {
                return true;
            }
        }
        return false;
    }

    private static void ej(String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        aRf = str.split(",");
    }
}
