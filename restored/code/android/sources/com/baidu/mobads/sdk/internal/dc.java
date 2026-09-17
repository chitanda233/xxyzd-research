package com.baidu.mobads.sdk.internal;

import android.app.Activity;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import com.kwad.sdk.core.scene.URLPackage;
import java.util.HashMap;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class dc implements w {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ cz f496a;

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(JSONObject jSONObject) {
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void b(JSONObject jSONObject) {
    }

    dc(cz czVar) {
        this.f496a = czVar;
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.f496a.f());
        map.put("interstitial_container", viewGroup);
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        this.f496a.a(cz.u, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup, JSONObject jSONObject) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.f496a.f());
        map.put("interstitial_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.f496a.g()));
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        map.put("novel_info", jSONObject);
        this.f496a.a(cz.v, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void b(ViewGroup viewGroup, JSONObject jSONObject) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.f496a.f());
        map.put("banner_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.f496a.g()));
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        map.put("novel_info", jSONObject);
        this.f496a.a(cz.w, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup, ViewGroup viewGroup2, int i) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.f496a.f());
        map.put("banner_container", viewGroup2);
        map.put("interstitial_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.f496a.g()));
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        map.put("backgroundColor", Integer.valueOf(i));
        this.f496a.a(cz.z, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public JSONObject a() {
        JSONObject jSONObject = new JSONObject();
        String strI = this.f496a.i("get_cuid");
        String strI2 = this.f496a.i("get_oaid");
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
        if (this.f496a.K != null) {
            this.f496a.K.onReadTime(j);
        }
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void b(ViewGroup viewGroup) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", viewGroup.getContext());
        map.put("banner_container", viewGroup);
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        map.put("isnight", Boolean.valueOf(this.f496a.x()));
        this.f496a.a(cz.y, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(ViewGroup viewGroup, int i) {
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", this.f496a.f());
        map.put("interstitial_container", viewGroup);
        map.put("isnight", Boolean.valueOf(this.f496a.g()));
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        map.put("count_down", Integer.valueOf(i));
        this.f496a.a(cz.A, map);
    }

    @Override // com.baidu.mobads.sdk.internal.w
    public void a(boolean z) {
        RelativeLayout relativeLayout;
        if (this.f496a.L == null || (relativeLayout = (RelativeLayout) this.f496a.L.get()) == null) {
            return;
        }
        HashMap<String, Object> map = new HashMap<>();
        map.put("novel_activity", (Activity) this.f496a.i);
        map.put("interstitial_container", null);
        map.put("banner_container", relativeLayout);
        map.put("entry", Integer.valueOf(this.f496a.G));
        map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.f496a.H));
        map.put("novel_id", this.f496a.I);
        map.put("isnight", Boolean.valueOf(this.f496a.x()));
        this.f496a.a(cz.z, map);
    }
}
