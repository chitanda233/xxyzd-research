package com.byazt.kj;

import android.content.Context;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import cn.com.chinatelecom.account.api.utils.Constants;
import com.alipay.sdk.m.x.a;
import com.byazt.aas.z;
import com.byazt.gqp.da;
import com.byazt.nr.m;
import com.byazt.nr.rh;
import com.byazt.nys.PluginConstants;
import com.byazt.omf.gt;
import com.byazt.omf.p;
import com.byazt.omf.x;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.sigmob.sdk.base.n;
import java.util.Map;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 159, 20})
public abstract class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public JSONObject f1110a;
    public com.byazt.tjs.c c;
    public String sp;
    public String tt;
    public String ve;
    public AtomicBoolean uj = new AtomicBoolean(false);
    public AtomicBoolean n = new AtomicBoolean(false);

    /* JADX INFO: renamed from: com.byazt.kj.c$c, reason: collision with other inner class name */
    public interface InterfaceC0171c {
        void c(boolean z, Map<String, Object> map);
    }

    public abstract void c();

    public abstract void c(Context context, String str, com.byazt.tjs.tt ttVar, WebResourceResponse webResourceResponse, da daVar, Map<String, Object> map);

    public abstract void c(com.byazt.tjs.tt ttVar, WebResourceResponse webResourceResponse, da daVar, InterfaceC0171c interfaceC0171c);

    public abstract void c(String str);

    public abstract void c(String str, String str2);

    public abstract void c(JSONObject jSONObject, String str, da daVar, String str2, String str3, Map<String, String> map, Map<String, Object> map2);

    public abstract boolean c(WebView webView);

    public abstract boolean c(da daVar);

    public abstract void tt(Context context, String str, com.byazt.tjs.tt ttVar, WebResourceResponse webResourceResponse, da daVar, Map<String, Object> map);

    public abstract void ve();

    public void tt() {
        c();
    }

    public c(com.byazt.tjs.c cVar, String str, String str2, JSONObject jSONObject, String str3, String str4) {
        this.c = cVar;
        this.tt = str;
        this.sp = str4;
        this.ve = str2;
        JSONObject jSONObject2 = new JSONObject();
        this.f1110a = jSONObject2;
        try {
            if (this instanceof tt) {
                jSONObject2.putOpt("log_extra", str3);
                this.f1110a.putOpt("resource_type", "union");
                this.f1110a.putOpt("ts", Long.valueOf(System.currentTimeMillis() / 1000));
            } else if (this instanceof ve) {
                jSONObject2.putOpt(a.k, Long.valueOf(System.currentTimeMillis() / 1000));
                this.f1110a.putOpt(MediationConstant.EXTRA_ADID, jSONObject.optString(MediationConstant.EXTRA_ADID));
                this.f1110a.putOpt("customer_id", jSONObject.optString("customer_id"));
            }
            this.f1110a.putOpt("cid", str);
            this.f1110a.putOpt("ac", Integer.valueOf(rh.ve(gt.getContext())));
            this.f1110a.putOpt("app_name", x.m().qy());
            this.f1110a.putOpt("app_id", x.m().rl());
            this.f1110a.putOpt(n.r, com.byazt.fh.c.n());
            this.f1110a.putOpt(PluginConstants.KEY_SDK_VERSION, p.n);
            this.f1110a.putOpt(PluginConstants.KEY_PLUGIN_VERSION, "7.6.1.1");
            this.f1110a.putOpt("platform", Constants.LOG_OS);
            this.f1110a.putOpt("device_id", z.c());
            this.f1110a.putOpt("web_url", str4);
        } catch (JSONException e) {
            m.c(e);
        }
        c(str, str2);
    }
}
