package cn.thinkingdata.analytics.e;

import cn.thinkingdata.analytics.TDConfig;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.l;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.utils.TDLog;
import java.util.Date;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final ThinkingAnalyticsSDK f99a;
    private final TDConfig b;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ JSONObject f100a;
        final /* synthetic */ k b;
        final /* synthetic */ cn.thinkingdata.analytics.h.e c;
        final /* synthetic */ String d;
        final /* synthetic */ String e;
        final /* synthetic */ boolean f;

        a(JSONObject jSONObject, k kVar, cn.thinkingdata.analytics.h.e eVar, String str, String str2, boolean z) {
            this.f100a = jSONObject;
            this.b = kVar;
            this.c = eVar;
            this.d = str;
            this.e = str2;
            this.f = z;
        }

        @Override // java.lang.Runnable
        public void run() {
            if (!cn.thinkingdata.analytics.h.g.a(this.f100a)) {
                TDLog.w("ThinkingAnalytics.UserOperation", "The data contains invalid key or value: " + this.f100a.toString());
                if (g.this.b.shouldThrowException()) {
                    throw new l("Invalid properties. Please refer to SDK debug log for detail reasons.");
                }
            }
            try {
                JSONObject jSONObject = new JSONObject();
                JSONObject jSONObject2 = this.f100a;
                if (jSONObject2 != null) {
                    q.a(jSONObject2, jSONObject, g.this.b.getDefaultTimeZone());
                }
                g.this.f99a.trackInternal(new cn.thinkingdata.analytics.e.a(g.this.f99a, this.b, jSONObject, this.c, this.d, this.e, this.f));
            } catch (Exception e) {
                TDLog.w("ThinkingAnalytics.UserOperation", e.getMessage());
            }
        }
    }

    public g(ThinkingAnalyticsSDK thinkingAnalyticsSDK, TDConfig tDConfig) {
        this.f99a = thinkingAnalyticsSDK;
        this.b = tDConfig;
    }

    public void a(k kVar, JSONObject jSONObject, Date date) {
        if (this.f99a.getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new a(jSONObject, kVar, date == null ? this.f99a.mCalibratedTimeManager.a() : this.f99a.mCalibratedTimeManager.a(date, null), this.f99a.getStatusIdentifyId(), this.f99a.getStatusAccountId(), this.f99a.isStatusTrackSaveOnly()));
    }

    public void a(String str, Number number) {
        try {
            if (number == null) {
                TDLog.d("ThinkingAnalytics.UserOperation", "user_add value must be Number");
                if (this.b.shouldThrowException()) {
                    throw new l("Invalid property values for user add.");
                }
            } else {
                JSONObject jSONObject = new JSONObject();
                jSONObject.put(str, number);
                a(jSONObject, (Date) null);
            }
        } catch (JSONException e) {
            e.printStackTrace();
            if (this.b.shouldThrowException()) {
                throw new l(e);
            }
        }
    }

    public void a(Date date) {
        this.f99a.user_operations(k.USER_DEL, null, date);
    }

    public void a(JSONObject jSONObject, Date date) {
        this.f99a.user_operations(k.USER_ADD, jSONObject, date);
    }

    public void a(String... strArr) {
        if (strArr == null) {
            return;
        }
        JSONObject jSONObject = new JSONObject();
        for (String str : strArr) {
            try {
                jSONObject.put(str, 0);
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
        if (jSONObject.length() > 0) {
            f(jSONObject, null);
        }
    }

    public void b(JSONObject jSONObject, Date date) {
        this.f99a.user_operations(k.USER_APPEND, jSONObject, date);
    }

    public void c(JSONObject jSONObject, Date date) {
        this.f99a.user_operations(k.USER_SET, jSONObject, date);
    }

    public void d(JSONObject jSONObject, Date date) {
        this.f99a.user_operations(k.USER_SET_ONCE, jSONObject, date);
    }

    public void e(JSONObject jSONObject, Date date) {
        this.f99a.user_operations(k.USER_UNIQ_APPEND, jSONObject, date);
    }

    public void f(JSONObject jSONObject, Date date) {
        this.f99a.user_operations(k.USER_UNSET, jSONObject, date);
    }
}
