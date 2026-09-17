package com.baidu.mobads.sdk.internal;

import android.view.ViewGroup;
import com.kwad.sdk.core.scene.URLPackage;
import java.util.HashMap;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class cy implements w {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ int f491a;
    final /* synthetic */ int b;
    final /* synthetic */ String c;
    final /* synthetic */ cu d;

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(JSONObject jSONObject) {
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(boolean z) {
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void b(JSONObject jSONObject) {
    }

    cy(cu cuVar, int i, int i2, String str) {
        this.d = cuVar;
        this.f491a = i;
        this.b = i2;
        this.c = str;
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.d.e());
        map.put("interstitial_container", viewGroup);
        map.put("entry", Integer.valueOf(this.f491a));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b));
        map.put("novel_id", this.c);
        this.d.a(cz.u, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup, JSONObject jSONObject) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.d.e());
        map.put("interstitial_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.d.f()));
        map.put("entry", Integer.valueOf(this.f491a));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b));
        map.put("novel_id", this.c);
        map.put("novel_info", jSONObject);
        this.d.a(cz.v, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void b(ViewGroup viewGroup, JSONObject jSONObject) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.d.e());
        map.put("banner_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.d.f()));
        map.put("entry", Integer.valueOf(this.f491a));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b));
        map.put("novel_id", this.c);
        map.put("novel_info", jSONObject);
        this.d.a(cz.w, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup, ViewGroup viewGroup2, int i) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.d.e());
        map.put("banner_container", viewGroup2);
        map.put("interstitial_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.d.f()));
        map.put("entry", Integer.valueOf(this.f491a));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b));
        map.put("novel_id", this.c);
        map.put("backgroundColor", Integer.valueOf(i));
        this.d.a(cz.z, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public JSONObject a() {
        JSONObject jSONObject = new JSONObject();
        String strI = this.d.i("get_cuid");
        String strI2 = this.d.i("get_oaid");
        try {
            jSONObject.put("cuid", strI);
            jSONObject.put("imei", "");
            jSONObject.put("oaid", strI2);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(long j) {
        this.d.k.a("单次阅读器打开时长 = " + j);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void b(ViewGroup viewGroup) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", viewGroup.getContext());
        map.put("banner_container", viewGroup);
        map.put("entry", Integer.valueOf(this.f491a));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b));
        map.put("novel_id", this.c);
        this.d.a(cz.y, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup, int i) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.d.e());
        map.put("interstitial_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.d.f()));
        map.put("entry", Integer.valueOf(this.f491a));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b));
        map.put("novel_id", this.c);
        map.put("count_down", Integer.valueOf(i));
        this.d.a(cz.A, map);
    }
}
