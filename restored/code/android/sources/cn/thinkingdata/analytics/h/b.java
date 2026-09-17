package cn.thinkingdata.analytics.h;

import android.text.TextUtils;
import cn.thinkingdata.analytics.TDConfig;
import cn.thinkingdata.core.network.Request;
import cn.thinkingdata.core.network.TDNetResponse;
import cn.thinkingdata.core.network.TEHttpCallback;
import cn.thinkingdata.core.network.TEHttpClient;
import com.baidu.mobads.sdk.internal.an;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f113a;
    private List<TDConfig.TDDNSService> b;
    private volatile String c;
    private long d;

    class a extends TEHttpCallback {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f114a;

        a(int i) {
            this.f114a = i;
        }

        @Override // cn.thinkingdata.core.network.TEHttpCallback
        public void onFailure(int i, String str) {
            b.this.a(this.f114a);
        }

        @Override // cn.thinkingdata.core.network.TEHttpCallback
        public void onSuccess(TDNetResponse tDNetResponse) {
            JSONObject jSONObjectOptJSONObject;
            try {
                JSONObject jSONObject = new JSONObject(tDNetResponse.responseData);
                int iOptInt = jSONObject.optInt("Status");
                JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("Answer");
                if (iOptInt == 0 && jSONArrayOptJSONArray != null && jSONArrayOptJSONArray.length() > 0 && (jSONObjectOptJSONObject = jSONArrayOptJSONArray.optJSONObject(jSONArrayOptJSONArray.length() - 1)) != null) {
                    b.this.c = jSONObjectOptJSONObject.optString("data");
                    return;
                }
            } catch (JSONException e) {
                e.printStackTrace();
            }
            b.this.a(this.f114a);
        }
    }

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.h.b$b, reason: collision with other inner class name */
    static /* synthetic */ class C0024b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f115a;

        static {
            int[] iArr = new int[TDConfig.TDDNSService.values().length];
            f115a = iArr;
            try {
                iArr[TDConfig.TDDNSService.CLOUD_FLARE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f115a[TDConfig.TDDNSService.CLOUD_ALI.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f115a[TDConfig.TDDNSService.CLOUD_GOOGLE.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
        }
    }

    public b(String str) {
        try {
            this.f113a = new URL(str).getHost();
        } catch (MalformedURLException e) {
            e.printStackTrace();
        }
    }

    private String a(TDConfig.TDDNSService tDDNSService) {
        int i = C0024b.f115a[tDDNSService.ordinal()];
        if (i != 2) {
            return i != 3 ? "https://cloudflare-dns.com/dns-query?name=" : "https://8.8.8.8/resolve?name=";
        }
        return "https://223.5.5.5/resolve?name=";
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i) {
        if (i >= 0) {
            try {
                if (i >= this.b.size()) {
                    return;
                }
                String strA = a(this.b.get(i));
                if (!TextUtils.isEmpty(strA) && !TextUtils.isEmpty(this.f113a)) {
                    new TEHttpClient.Builder().build().newCall(new Request.Builder().url(strA + this.f113a).get().addHeader("Content-Type", an.d).addHeader("charset", "utf-8").addHeader("accept", "application/dns-json").build()).enqueue(new a(i + 1));
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    public String a() {
        return this.f113a;
    }

    public void a(List<TDConfig.TDDNSService> list) {
        if (System.currentTimeMillis() - this.d < 30000) {
            return;
        }
        this.d = System.currentTimeMillis();
        if (this.b == null) {
            this.b = list;
        }
        List<TDConfig.TDDNSService> list2 = this.b;
        if (list2 == null || list2.size() == 0) {
            return;
        }
        a(0);
    }

    public String b() {
        return this.c;
    }
}
