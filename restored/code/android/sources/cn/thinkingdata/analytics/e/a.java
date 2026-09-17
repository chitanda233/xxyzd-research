package cn.thinkingdata.analytics.e;

import android.content.Context;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.router.TRouter;
import cn.thinkingdata.core.router.TRouterMap;
import cn.thinkingdata.core.router.provider.ISensitiveProvider;
import cn.thinkingdata.core.router.provider.callback.ISensitivePropertiesCallBack;
import java.util.Map;
import java.util.TimeZone;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f86a;
    private final cn.thinkingdata.analytics.h.e c;
    final k d;
    private String e;
    private String f;
    private final JSONObject g;
    private Map<String, String> h;
    boolean j;
    final String k;
    public int b = 0;
    public boolean i = true;

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.e.a$a, reason: collision with other inner class name */
    class C0019a implements ISensitivePropertiesCallBack {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ ISensitivePropertiesCallBack f87a;

        C0019a(ISensitivePropertiesCallBack iSensitivePropertiesCallBack) {
            this.f87a = iSensitivePropertiesCallBack;
        }

        @Override // cn.thinkingdata.core.router.provider.callback.ISensitivePropertiesCallBack
        public void onSuccess(JSONObject jSONObject) {
            try {
                q.a(jSONObject, a.this.g, (TimeZone) null);
            } catch (JSONException e) {
                e.printStackTrace();
            }
            this.f87a.onSuccess(null);
        }
    }

    public a(ThinkingAnalyticsSDK thinkingAnalyticsSDK, k kVar, JSONObject jSONObject, cn.thinkingdata.analytics.h.e eVar, String str, String str2, boolean z) {
        this.j = false;
        this.d = kVar;
        this.g = jSONObject;
        this.c = eVar;
        this.k = thinkingAnalyticsSDK.getToken();
        this.e = str;
        this.f = str2;
        this.j = z;
    }

    public JSONObject a() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("#type", this.d.a());
            jSONObject.put("#time", this.c.b());
            jSONObject.put("#distinct_id", this.e);
            String str = this.f;
            if (str != null) {
                jSONObject.put("#account_id", str);
            }
            Map<String, String> map = this.h;
            if (map != null) {
                for (Map.Entry<String, String> entry : map.entrySet()) {
                    jSONObject.put(entry.getKey(), entry.getValue());
                }
            }
            if (this.d.b()) {
                jSONObject.put("#event_name", this.f86a);
                Double dA = this.c.a();
                if (dA != null) {
                    this.g.put("#zone_offset", dA);
                }
            }
            jSONObject.put("properties", this.g);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }

    public void a(Context context, ISensitivePropertiesCallBack iSensitivePropertiesCallBack) {
        if (iSensitivePropertiesCallBack == null) {
            return;
        }
        ISensitiveProvider iSensitiveProvider = (ISensitiveProvider) TRouter.getInstance().build(TRouterMap.SENSITIVE_PROPERTIES_ROUTE_PATH).navigation();
        if (iSensitiveProvider == null || !this.d.b()) {
            iSensitivePropertiesCallBack.onSuccess(null);
        } else {
            iSensitiveProvider.getSensitiveProperties(context, new C0019a(iSensitivePropertiesCallBack));
        }
    }

    public void a(Map<String, String> map) {
        this.h = map;
    }

    public void b() {
        this.i = false;
    }
}
