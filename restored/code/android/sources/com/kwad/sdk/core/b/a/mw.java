package com.kwad.sdk.core.b.a;

import com.byazt.nys.PluginConstants;
import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class mw implements com.kwad.sdk.core.d<com.kwad.sdk.core.h.a.C0514a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.core.h.a.C0514a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.core.h.a.C0514a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.core.h.a.C0514a c0514a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0514a.aYX = new ArrayList();
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray(PluginConstants.KEY_SDK_VERSION);
        if (jSONArrayOptJSONArray != null) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                c0514a.aYX.add((String) jSONArrayOptJSONArray.opt(i));
            }
        }
        c0514a.aYY = jSONObject.optInt("os_version");
        c0514a.aYZ = new ArrayList();
        JSONArray jSONArrayOptJSONArray2 = jSONObject.optJSONArray("abi");
        if (jSONArrayOptJSONArray2 != null) {
            for (int i2 = 0; i2 < jSONArrayOptJSONArray2.length(); i2++) {
                c0514a.aYZ.add((String) jSONArrayOptJSONArray2.opt(i2));
            }
        }
        c0514a.aZa = new ArrayList();
        JSONArray jSONArrayOptJSONArray3 = jSONObject.optJSONArray(com.baidu.mobads.sdk.internal.bn.j);
        if (jSONArrayOptJSONArray3 != null) {
            for (int i3 = 0; i3 < jSONArrayOptJSONArray3.length(); i3++) {
                c0514a.aZa.add((String) jSONArrayOptJSONArray3.opt(i3));
            }
        }
    }

    private static JSONObject b(com.kwad.sdk.core.h.a.C0514a c0514a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, PluginConstants.KEY_SDK_VERSION, c0514a.aYX);
        if (c0514a.aYY != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "os_version", c0514a.aYY);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "abi", c0514a.aYZ);
        com.kwad.sdk.utils.ac.putValue(jSONObject, com.baidu.mobads.sdk.internal.bn.j, c0514a.aZa);
        return jSONObject;
    }
}
