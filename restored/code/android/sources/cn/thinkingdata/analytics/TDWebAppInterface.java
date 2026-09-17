package cn.thinkingdata.analytics;

import android.text.TextUtils;
import android.webkit.JavascriptInterface;
import cn.thinkingdata.analytics.h.e;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.p;
import cn.thinkingdata.core.utils.TDLog;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDWebAppInterface {
    private static final String TAG = "ThinkingAnalytics.TDWebAppInterface";
    private final ThinkingAnalyticsSDK defaultInstance;
    private Map<String, Object> deviceInfoMap;

    class a implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f44a;
        final /* synthetic */ c b;
        final /* synthetic */ String c;

        a(String str, c cVar, String str2) {
            this.f44a = str;
            this.b = cVar;
            this.c = str2;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            if (thinkingAnalyticsSDK.getToken().equals(this.f44a)) {
                this.b.b();
                TDWebAppInterface.this.trackFromH5(this.c, thinkingAnalyticsSDK);
            }
        }
    }

    class b implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ ThinkingAnalyticsSDK f45a;
        final /* synthetic */ k b;
        final /* synthetic */ JSONObject c;
        final /* synthetic */ e d;
        final /* synthetic */ String e;
        final /* synthetic */ String f;
        final /* synthetic */ boolean g;

        b(TDWebAppInterface tDWebAppInterface, ThinkingAnalyticsSDK thinkingAnalyticsSDK, k kVar, JSONObject jSONObject, e eVar, String str, String str2, boolean z) {
            this.f45a = thinkingAnalyticsSDK;
            this.b = kVar;
            this.c = jSONObject;
            this.d = eVar;
            this.e = str;
            this.f = str2;
            this.g = z;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.f45a.trackInternal(new cn.thinkingdata.analytics.e.a(this.f45a, this.b, this.c, this.d, this.e, this.f, this.g));
        }
    }

    private class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private boolean f46a;

        private c(TDWebAppInterface tDWebAppInterface) {
        }

        /* synthetic */ c(TDWebAppInterface tDWebAppInterface, a aVar) {
            this(tDWebAppInterface);
        }

        boolean a() {
            return !this.f46a;
        }

        void b() {
            this.f46a = true;
        }
    }

    TDWebAppInterface(ThinkingAnalyticsSDK thinkingAnalyticsSDK, Map<String, Object> map) {
        this.defaultInstance = thinkingAnalyticsSDK;
        this.deviceInfoMap = map;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void trackFromH5(String str, ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        try {
            JSONArray jSONArray = new JSONObject(str).getJSONArray("data");
            for (int i = 0; i < jSONArray.length(); i++) {
                JSONObject jSONObject = jSONArray.getJSONObject(i);
                p pVar = new p(jSONObject.getString("#time"), jSONObject.has("#zone_offset") ? Double.valueOf(jSONObject.getDouble("#zone_offset")) : null);
                k kVarA = k.a(jSONObject.getString("#type"));
                if (kVarA == null) {
                    TDLog.w(TAG, "Unknown data type from H5. ignoring...");
                    return;
                }
                JSONObject jSONObject2 = jSONObject.getJSONObject("properties");
                Iterator<String> itKeys = jSONObject2.keys();
                while (itKeys.hasNext()) {
                    try {
                        String next = itKeys.next();
                        if (next.equals("#account_id") || next.equals("#distinct_id")) {
                            itKeys.remove();
                        } else if (this.deviceInfoMap.containsKey(next)) {
                            itKeys.remove();
                        }
                    } catch (Exception e) {
                        e = e;
                    }
                }
                if (kVarA.b()) {
                    String string = jSONObject.getString("#event_name");
                    HashMap map = new HashMap();
                    if (jSONObject.has("#first_check_id")) {
                        map.put("#first_check_id", jSONObject.getString("#first_check_id"));
                    }
                    if (jSONObject.has("#event_id")) {
                        map.put("#event_id", jSONObject.getString("#event_id"));
                    }
                    thinkingAnalyticsSDK.track(string, jSONObject2, pVar, false, map, kVarA, 0);
                } else {
                    cn.thinkingdata.analytics.g.a.a().a(new b(this, thinkingAnalyticsSDK, kVarA, jSONObject2, pVar, thinkingAnalyticsSDK.getStatusIdentifyId(), thinkingAnalyticsSDK.getStatusAccountId(), thinkingAnalyticsSDK.isStatusTrackSaveOnly()));
                }
                TDLog.w(TAG, "Exception occurred when track data from H5.");
                e.printStackTrace();
                return;
            }
        } catch (Exception e2) {
            e = e2;
        }
    }

    @JavascriptInterface
    public void thinkingdata_track(String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        TDLog.d(TAG, str);
        try {
            String string = new JSONObject(str).getString("#app_id");
            c cVar = new c(this, null);
            ThinkingAnalyticsSDK.allInstances(new a(string, cVar, str));
            if (cVar.a()) {
                trackFromH5(str, this.defaultInstance);
            }
        } catch (JSONException e) {
            TDLog.w(TAG, "Unexpected exception occurred: " + e.toString());
        }
    }
}
