package com.kwad.sdk.core.config.item;

import android.content.SharedPreferences;
import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class s extends a<String> {
    public s(String str) {
        this(str, "");
    }

    public s(String str, String str2) {
        super(str, str2);
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final void l(JSONObject jSONObject) {
        String strOptString = jSONObject != null ? jSONObject.optString(getKey(), Ln()) : null;
        if (TextUtils.isEmpty(strOptString)) {
            setValue(Ln());
        } else {
            setValue(strOptString);
        }
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final void b(SharedPreferences.Editor editor) {
        editor.putString(getKey(), eh(getValue()));
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final void a(SharedPreferences sharedPreferences) {
        setValue(getDecodeString(sharedPreferences.getString(getKey(), Ln())));
    }

    @Override // com.kwad.sdk.core.config.item.b
    public final String getValue() {
        return (String) super.getValue();
    }
}
