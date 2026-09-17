package com.kwad.sdk.contentalliance.a.a;

import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.o;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public long adStyle;
    public long clickTime;
    public int contentType;
    public long photoId;

    public a() {
        this.clickTime = -1L;
    }

    public a(AdTemplate adTemplate, long j) {
        this.clickTime = -1L;
        this.photoId = e.eS(adTemplate);
        this.clickTime = j;
        this.adStyle = e.eH(adTemplate);
        this.contentType = e.eI(adTemplate);
    }

    public static a ci(AdTemplate adTemplate) {
        return new a(adTemplate, o.fq(adTemplate));
    }

    public final String IR() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("contentType", this.contentType);
            jSONObject.put("adStyle", this.adStyle);
        } catch (JSONException e) {
            c.printStackTrace(e);
        }
        return jSONObject.toString();
    }
}
