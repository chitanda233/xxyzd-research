package cn.thinkingdata.analytics;

import android.content.Context;
import android.content.Intent;
import android.os.SystemClock;
import cn.thinkingdata.analytics.e.d;
import cn.thinkingdata.analytics.h.g;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.l;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.preset.TDPresetUtils;
import java.util.Date;
import java.util.List;
import java.util.TimeZone;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class c extends ThinkingAnalyticsSDK {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    Context f75a;
    String b;
    private final JSONObject c;

    static /* synthetic */ class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f76a;

        static {
            int[] iArr = new int[k.values().length];
            f76a = iArr;
            try {
                iArr[k.TRACK_OVERWRITE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f76a[k.TRACK_UPDATE.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f76a[k.TRACK.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
        }
    }

    public c(TDConfig tDConfig) {
        super(tDConfig, new boolean[0]);
        this.f75a = tDConfig.mContext;
        this.c = new JSONObject();
        this.b = q.b(this.f75a);
    }

    double a(String str, long j) {
        d dVar;
        synchronized (this.mTrackTimer) {
            dVar = this.mTrackTimer.get(str);
            this.mTrackTimer.remove(str);
        }
        if (dVar != null) {
            return Double.parseDouble(dVar.a(j));
        }
        return 0.0d;
    }

    public Intent a() {
        Intent intent = new Intent();
        String strD = q.d(this.f75a);
        intent.setAction(strD.length() == 0 ? "cn.thinkingdata.receiver" : strD + ".cn.thinkingdata.receiver");
        intent.putExtra("#app_id", this.mConfig.getName());
        return intent;
    }

    public JSONObject a(String str, JSONObject jSONObject) {
        JSONObject dynamicSuperProperties;
        JSONObject jSONObject2 = new JSONObject();
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        try {
            jSONObject2.put("TA_KEY_SUBPROCESS_TAG__TA__", true);
            if (!TDPresetProperties.disableList.contains(TDPresetUtils.KEY_BUNDLE_ID)) {
                jSONObject2.put(TDPresetUtils.KEY_BUNDLE_ID, this.b);
            }
            double dA = a(str, jElapsedRealtime);
            if (dA > 0.0d && !TDPresetProperties.disableList.contains("#duration")) {
                jSONObject2.put("#duration", dA);
            }
        } catch (JSONException unused) {
        }
        if (getDynamicSuperPropertiesTracker() != null && (dynamicSuperProperties = getDynamicSuperPropertiesTracker().getDynamicSuperProperties()) != null) {
            try {
                q.a(dynamicSuperProperties, jSONObject2, this.mConfig.getDefaultTimeZone());
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
        try {
            q.a(jSONObject, jSONObject2, this.mConfig.getDefaultTimeZone());
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        return jSONObject2;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void autoTrack(String str, JSONObject jSONObject) {
        Intent intentA = a();
        intentA.putExtra("#event_name", str);
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        JSONObject jSONObjectA = a(str, jSONObject);
        try {
            JSONObject jSONObjectOptJSONObject = getAutoTrackProperties().optJSONObject(str);
            if (jSONObjectOptJSONObject != null) {
                q.a(jSONObjectOptJSONObject, jSONObjectA, this.mConfig.getDefaultTimeZone());
            }
            intentA.putExtra("properties", jSONObjectA.toString());
            intentA.putExtra("TD_ACTION", 1048582);
            Context context = this.f75a;
            if (context != null) {
                context.sendBroadcast(intentA);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void clearSuperProperties() {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097159);
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void enableAutoTrack(List<ThinkingAnalyticsSDK.AutoTrackEventType> list, ThinkingAnalyticsSDK.AutoTrackEventListener autoTrackEventListener) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void enableTracking(boolean z) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void flush() {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097157);
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public JSONObject getAutoTrackProperties() {
        return this.c;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public boolean hasOptOut() {
        return false;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void identify(String str) {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097156);
        if (str == null || str.length() <= 0) {
            str = "";
        }
        intentA.putExtra("#distinct_id", str);
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void login(String str) {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097154);
        if (str == null || str.length() <= 0) {
            str = "";
        }
        intentA.putExtra("#account_id", str);
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void logout() {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097155);
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void optInTracking() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void optOutTracking() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void optOutTrackingAndDeleteUser() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setAutoTrackProperties(List<ThinkingAnalyticsSDK.AutoTrackEventType> list, JSONObject jSONObject) {
        if (hasDisabled()) {
            return;
        }
        if (jSONObject != null) {
            try {
                if (g.a(jSONObject)) {
                    JSONObject jSONObject2 = new JSONObject();
                    for (ThinkingAnalyticsSDK.AutoTrackEventType autoTrackEventType : list) {
                        JSONObject jSONObject3 = new JSONObject();
                        q.a(jSONObject, jSONObject3, this.mConfig.getDefaultTimeZone());
                        jSONObject2.put(autoTrackEventType.getEventName(), jSONObject3);
                    }
                    synchronized (this.c) {
                        q.b(jSONObject2, this.c, this.mConfig.getDefaultTimeZone());
                    }
                    return;
                }
            } catch (Exception e) {
                e.printStackTrace();
                return;
            }
        }
        if (this.mConfig.shouldThrowException()) {
            throw new l("Set autoTrackEvent properties failed. Please refer to the SDK debug log for details.");
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setNetworkType(ThinkingAnalyticsSDK.ThinkingdataNetworkType thinkingdataNetworkType) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setSuperProperties(JSONObject jSONObject) {
        JSONObject jSONObject2 = new JSONObject();
        try {
            q.a(jSONObject, jSONObject2, this.mConfig.getDefaultTimeZone());
            Intent intentA = a();
            intentA.putExtra("TD_ACTION", 2097153);
            if (jSONObject != null) {
                intentA.putExtra("properties", jSONObject2.toString());
            }
            Context context = this.f75a;
            if (context != null) {
                context.sendBroadcast(intentA);
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setTrackStatus(ThinkingAnalyticsSDK.TATrackStatus tATrackStatus) {
    }

    /* JADX WARN: Code duplicated, block: B:15:0x0039  */
    /* JADX WARN: Code duplicated, block: B:16:0x003f  */
    /* JADX WARN: Code duplicated, block: B:19:0x005a  */
    /* JADX WARN: Code duplicated, block: B:22:0x006d  */
    /* JADX WARN: Code duplicated, block: B:25:0x0087  */
    /* JADX WARN: Code duplicated, block: B:27:? A[RETURN, SYNTHETIC] */
    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void track(ThinkingAnalyticsEvent thinkingAnalyticsEvent) {
        int i;
        JSONObject properties;
        Context context;
        Intent intentA = a();
        int i2 = a.f76a[thinkingAnalyticsEvent.getDataType().ordinal()];
        if (i2 == 1) {
            i = 1048581;
        } else {
            if (i2 != 2) {
                if (i2 == 3) {
                    i = 1048579;
                }
                intentA.putExtra("#event_name", thinkingAnalyticsEvent.getEventName());
                if (thinkingAnalyticsEvent.getProperties() == null) {
                    properties = new JSONObject();
                } else {
                    properties = thinkingAnalyticsEvent.getProperties();
                }
                intentA.putExtra("properties", a(thinkingAnalyticsEvent.getEventName(), properties).toString());
                if (thinkingAnalyticsEvent.getEventTime() != null) {
                    intentA.putExtra("TD_DATE", thinkingAnalyticsEvent.getEventTime().getTime());
                }
                if (thinkingAnalyticsEvent.getTimeZone() != null) {
                    intentA.putExtra("TD_KEY_TIMEZONE", thinkingAnalyticsEvent.getTimeZone().getID());
                }
                intentA.putExtra("TD_KEY_EXTRA_FIELD", thinkingAnalyticsEvent.getExtraValue());
                context = this.f75a;
                if (context != null) {
                    context.sendBroadcast(intentA);
                }
            }
            i = 1048580;
        }
        intentA.putExtra("TD_ACTION", i);
        intentA.putExtra("#event_name", thinkingAnalyticsEvent.getEventName());
        if (thinkingAnalyticsEvent.getProperties() == null) {
            properties = new JSONObject();
        } else {
            properties = thinkingAnalyticsEvent.getProperties();
        }
        intentA.putExtra("properties", a(thinkingAnalyticsEvent.getEventName(), properties).toString());
        if (thinkingAnalyticsEvent.getEventTime() != null) {
            intentA.putExtra("TD_DATE", thinkingAnalyticsEvent.getEventTime().getTime());
        }
        if (thinkingAnalyticsEvent.getTimeZone() != null) {
            intentA.putExtra("TD_KEY_TIMEZONE", thinkingAnalyticsEvent.getTimeZone().getID());
        }
        intentA.putExtra("TD_KEY_EXTRA_FIELD", thinkingAnalyticsEvent.getExtraValue());
        context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void track(String str) {
        track(str, (JSONObject) null, (Date) null, (TimeZone) null);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void track(String str, JSONObject jSONObject) {
        track(str, jSONObject, (Date) null, (TimeZone) null);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void track(String str, JSONObject jSONObject, Date date) {
        track(str, jSONObject, date, (TimeZone) null);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void track(String str, JSONObject jSONObject, Date date, TimeZone timeZone) {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 1048578);
        intentA.putExtra("#event_name", str);
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        intentA.putExtra("properties", a(str, jSONObject).toString());
        if (date != null) {
            intentA.putExtra("TD_DATE", date.getTime());
        }
        if (timeZone != null) {
            intentA.putExtra("TD_KEY_TIMEZONE", timeZone.getID());
        }
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void unsetSuperProperty(String str) {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097158);
        if (str != null) {
            intentA.putExtra("properties", str);
        }
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void user_operations(k kVar, JSONObject jSONObject, Date date) {
        Intent intentA = a();
        intentA.putExtra("TD_ACTION", 2097152);
        intentA.putExtra("TD_KEY_USER_PROPERTY_SET_TYPE", kVar.a());
        if (jSONObject != null) {
            JSONObject jSONObject2 = new JSONObject();
            try {
                q.a(jSONObject, jSONObject2, this.mConfig.getDefaultTimeZone());
            } catch (JSONException e) {
                e.printStackTrace();
            }
            intentA.putExtra("properties", jSONObject2.toString());
        }
        if (date != null) {
            intentA.putExtra("TD_DATE", date.getTime());
        }
        Context context = this.f75a;
        if (context != null) {
            context.sendBroadcast(intentA);
        }
    }
}
