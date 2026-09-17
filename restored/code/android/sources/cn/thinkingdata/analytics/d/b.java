package cn.thinkingdata.analytics.d;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.os.Bundle;
import android.os.SystemClock;
import android.text.TextUtils;
import cn.thinkingdata.analytics.ScreenAutoTracker;
import cn.thinkingdata.analytics.TDPresetProperties;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.ThinkingDataAutoTrackAppViewScreenUrl;
import cn.thinkingdata.analytics.e.d;
import cn.thinkingdata.analytics.h.e;
import cn.thinkingdata.analytics.h.g;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.utils.TDLog;
import java.lang.ref.WeakReference;
import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Timer;
import java.util.TimerTask;
import java.util.concurrent.TimeUnit;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class b implements Application.ActivityLifecycleCallbacks {
    private final ThinkingAnalyticsSDK c;
    private d e;
    private WeakReference<Activity> f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private boolean f83a = false;
    private final Object b = new Object();
    private volatile Boolean d = true;
    private final List<WeakReference<Activity>> g = new ArrayList();
    private boolean h = false;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ JSONObject f84a;
        final /* synthetic */ e b;
        final /* synthetic */ String c;
        final /* synthetic */ String d;
        final /* synthetic */ boolean e;

        a(JSONObject jSONObject, e eVar, String str, String str2, boolean z) {
            this.f84a = jSONObject;
            this.b = eVar;
            this.c = str;
            this.d = str2;
            this.e = z;
        }

        @Override // java.lang.Runnable
        public void run() {
            JSONObject autoTrackStartProperties = b.this.c.getAutoTrackStartProperties();
            try {
                q.a(this.f84a, autoTrackStartProperties, b.this.c.mConfig.getDefaultTimeZone());
            } catch (JSONException e) {
                TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", e);
            }
            cn.thinkingdata.analytics.e.a aVar = new cn.thinkingdata.analytics.e.a(b.this.c, k.TRACK, autoTrackStartProperties, this.b, this.c, this.d, this.e);
            aVar.f86a = "ta_app_start";
            b.this.c.trackInternal(aVar);
        }
    }

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.d.b$b, reason: collision with other inner class name */
    class C0018b extends TimerTask {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ e f85a;

        C0018b(e eVar) {
            this.f85a = eVar;
        }

        @Override // java.util.TimerTask, java.lang.Runnable
        public void run() {
            if (b.this.d.booleanValue()) {
                b.this.d = false;
                JSONObject jSONObject = new JSONObject();
                try {
                    if (!TDPresetProperties.disableList.contains("#resume_from_background")) {
                        jSONObject.put("#resume_from_background", b.this.f83a);
                    }
                    if (!TDPresetProperties.disableList.contains("#start_reason")) {
                        String strA = b.this.a();
                        if (!strA.equals(new JSONObject().toString())) {
                            jSONObject.put("#start_reason", strA);
                        }
                    }
                } catch (Exception unused) {
                } finally {
                    b.this.c.autoTrack("ta_app_start", jSONObject, this.f85a);
                    b.this.c.flush();
                    b.this.h = true;
                }
            }
        }
    }

    public b(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        this.c = thinkingAnalyticsSDK;
    }

    public static JSONArray a(Object obj) throws JSONException {
        JSONArray jSONArray = new JSONArray();
        if (!obj.getClass().isArray()) {
            throw new JSONException("Not a primitive array: " + obj.getClass());
        }
        int length = Array.getLength(obj);
        for (int i = 0; i < length; i++) {
            jSONArray.put(b(Array.get(obj, i)));
        }
        return jSONArray;
    }

    private void a(Activity activity, e eVar) {
        if (this.d.booleanValue() || this.f83a) {
            if (this.c.isAutoTrackEnabled()) {
                try {
                    if (!this.c.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_START)) {
                        this.d = false;
                        JSONObject jSONObject = new JSONObject();
                        if (!TDPresetProperties.disableList.contains("#resume_from_background")) {
                            jSONObject.put("#resume_from_background", this.f83a);
                        }
                        if (!TDPresetProperties.disableList.contains("#start_reason")) {
                            String strA = a();
                            if (!strA.equals(new JSONObject().toString())) {
                                jSONObject.put("#start_reason", strA);
                            }
                        }
                        q.a(jSONObject, activity);
                        if (this.e != null) {
                            double d = Double.parseDouble(this.e.a(SystemClock.elapsedRealtime()));
                            if (d > 0.0d && !TDPresetProperties.disableList.contains("#background_duration")) {
                                jSONObject.put("#background_duration", d);
                            }
                        }
                        if (eVar == null) {
                            this.c.autoTrack("ta_app_start", jSONObject);
                        } else {
                            if (this.c.getStatusHasDisabled()) {
                                return;
                            }
                            String statusAccountId = this.c.getStatusAccountId();
                            String statusIdentifyId = this.c.getStatusIdentifyId();
                            boolean zIsStatusTrackSaveOnly = this.c.isStatusTrackSaveOnly();
                            if (this.c.mAutoTrackDynamicProperties != null) {
                                try {
                                    JSONObject autoTrackDynamicProperties = this.c.mAutoTrackDynamicProperties.getAutoTrackDynamicProperties();
                                    if (autoTrackDynamicProperties != null) {
                                        q.a(autoTrackDynamicProperties, jSONObject, this.c.mConfig.getDefaultTimeZone());
                                    }
                                } catch (Exception e) {
                                    e.printStackTrace();
                                }
                            }
                            cn.thinkingdata.analytics.g.a.a().a(new a(jSONObject, eVar, statusIdentifyId, statusAccountId, zIsStatusTrackSaveOnly));
                            this.h = true;
                        }
                        if (eVar == null && !this.c.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_END)) {
                            this.c.timeEvent("ta_app_end");
                            this.h = true;
                        }
                    } else if (eVar == null) {
                        this.c.timeEvent("ta_app_end");
                        this.h = true;
                    }
                } catch (Exception e2) {
                    TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", e2);
                }
            }
            try {
                this.c.appBecomeActive();
                this.e = null;
            } catch (Exception e3) {
                e3.printStackTrace();
            }
        }
    }

    private boolean a(Activity activity, boolean z) {
        synchronized (this.b) {
            Iterator<WeakReference<Activity>> it = this.g.iterator();
            while (it.hasNext()) {
                if (it.next().get() == activity) {
                    if (z) {
                        it.remove();
                    }
                    return false;
                }
            }
            return true;
        }
    }

    public static Object b(Object obj) {
        if (obj == null) {
            return JSONObject.NULL;
        }
        if ((obj instanceof JSONArray) || (obj instanceof JSONObject) || obj.equals(JSONObject.NULL)) {
            return obj;
        }
        try {
            if (obj instanceof Collection) {
                return new JSONArray((Collection) obj);
            }
            if (obj.getClass().isArray()) {
                return a(obj);
            }
            if (obj instanceof Map) {
                return new JSONObject((Map) obj);
            }
            if (!(obj instanceof Boolean) && !(obj instanceof Byte) && !(obj instanceof Character) && !(obj instanceof Double) && !(obj instanceof Float) && !(obj instanceof Integer) && !(obj instanceof Long) && !(obj instanceof Short) && !(obj instanceof String)) {
                if (obj.getClass().getPackage().getName().startsWith("java.")) {
                    return obj.toString();
                }
                return null;
            }
            return obj;
        } catch (Exception unused) {
        }
    }

    String a() {
        JSONObject jSONObject = new JSONObject();
        JSONObject jSONObject2 = new JSONObject();
        WeakReference<Activity> weakReference = this.f;
        if (weakReference != null) {
            try {
                Intent intent = weakReference.get().getIntent();
                if (intent != null) {
                    String dataString = intent.getDataString();
                    if (!TextUtils.isEmpty(dataString)) {
                        jSONObject.put("url", dataString);
                    }
                    Bundle extras = intent.getExtras();
                    if (extras != null) {
                        for (String str : extras.keySet()) {
                            Object obj = extras.get(str);
                            Object objB = b(obj);
                            if (objB != null && objB != JSONObject.NULL) {
                                jSONObject2.put(str, b(obj));
                            }
                        }
                        jSONObject.put("data", jSONObject2);
                    }
                }
            } catch (Exception unused) {
                return jSONObject.toString();
            }
        }
        return jSONObject.toString();
    }

    public void a(JSONObject jSONObject) {
        this.c.autoTrack("ta_app_crash", jSONObject);
        this.c.autoTrack("ta_app_end", new JSONObject());
        this.h = false;
        this.c.flush();
    }

    public void a(boolean z) {
        this.h = z;
    }

    boolean a(Context context) {
        try {
            Resources resources = context.getResources();
            return resources.getBoolean(resources.getIdentifier("TAEnableBackgroundStartEvent", "bool", context.getPackageName()));
        } catch (Exception unused) {
            return false;
        }
    }

    public void b() {
        synchronized (this.b) {
            if (this.d.booleanValue() && this.c.isAutoTrackEnabled()) {
                try {
                    if (!this.c.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_START) && (q.e(this.c.mConfig.mContext) || a(this.c.mConfig.mContext))) {
                        new Timer().schedule(new C0018b(this.c.mCalibratedTimeManager.a()), 100L);
                    }
                } catch (Exception e) {
                    TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", e);
                }
            }
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityCreated(Activity activity, Bundle bundle) {
        TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "onActivityCreated");
        this.f = new WeakReference<>(activity);
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityDestroyed(Activity activity) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityPaused(Activity activity) {
        synchronized (this.b) {
            if (a(activity, false)) {
                TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "onActivityPaused: the SDK was initialized after the onActivityStart of " + activity);
                this.g.add(new WeakReference<>(activity));
                if (this.g.size() == 1) {
                    a(activity, this.c.getAutoTrackStartTime());
                    this.c.flush();
                }
            }
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityResumed(Activity activity) {
        synchronized (this.b) {
            if (a(activity, false)) {
                TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "onActivityResumed: the SDK was initialized after the onActivityStart of " + activity);
                this.g.add(new WeakReference<>(activity));
                if (this.g.size() == 1) {
                    a(activity, this.c.getAutoTrackStartTime());
                    this.c.flush();
                }
            }
        }
        try {
            boolean z = !this.c.isActivityAutoTrackAppViewScreenIgnored(activity.getClass());
            if (this.c.isAutoTrackEnabled() && z && !this.c.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_VIEW_SCREEN)) {
                try {
                    JSONObject jSONObject = new JSONObject();
                    if (!TDPresetProperties.disableList.contains("#screen_name")) {
                        jSONObject.put("#screen_name", activity.getClass().getCanonicalName());
                    }
                    q.a(jSONObject, activity);
                    if (activity instanceof ScreenAutoTracker) {
                        ScreenAutoTracker screenAutoTracker = (ScreenAutoTracker) activity;
                        String screenUrl = screenAutoTracker.getScreenUrl();
                        JSONObject trackProperties = screenAutoTracker.getTrackProperties();
                        if (trackProperties == null || !g.a(trackProperties)) {
                            TDLog.d("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "invalid properties: " + trackProperties);
                        } else {
                            q.a(trackProperties, jSONObject, this.c.mConfig.getDefaultTimeZone());
                        }
                        this.c.trackViewScreenInternal(screenUrl, jSONObject);
                        return;
                    }
                    ThinkingDataAutoTrackAppViewScreenUrl thinkingDataAutoTrackAppViewScreenUrl = (ThinkingDataAutoTrackAppViewScreenUrl) activity.getClass().getAnnotation(ThinkingDataAutoTrackAppViewScreenUrl.class);
                    if (thinkingDataAutoTrackAppViewScreenUrl == null || !(TextUtils.isEmpty(thinkingDataAutoTrackAppViewScreenUrl.appId()) || this.c.getToken().equals(thinkingDataAutoTrackAppViewScreenUrl.appId()))) {
                        if (this.c.isIgnoreAppViewInExtPackage()) {
                            return;
                        }
                        this.c.autoTrack("ta_app_view", jSONObject);
                    } else {
                        String strUrl = thinkingDataAutoTrackAppViewScreenUrl.url();
                        if (TextUtils.isEmpty(strUrl)) {
                            strUrl = activity.getClass().getCanonicalName();
                        }
                        this.c.trackViewScreenInternal(strUrl, jSONObject);
                    }
                } catch (Exception e) {
                    TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", e);
                }
            }
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStarted(Activity activity) {
        TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "onActivityStarted");
        this.f = new WeakReference<>(activity);
        try {
            synchronized (this.b) {
                try {
                    if (this.g.size() == 0) {
                        a(activity, (e) null);
                    }
                    if (a(activity, false)) {
                        this.g.add(new WeakReference<>(activity));
                    } else {
                        TDLog.w("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "Unexpected state. The activity might not be stopped correctly: " + activity);
                    }
                } catch (Throwable th) {
                    throw th;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /* JADX WARN: Code duplicated, block: B:52:0x007f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStopped(Activity activity) {
        ThinkingAnalyticsSDK thinkingAnalyticsSDK;
        String str;
        TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "onActivityStopped");
        try {
            synchronized (this.b) {
                if (a(activity, true)) {
                    TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", "onActivityStopped: the SDK might be initialized after the onActivityStart of " + activity);
                    return;
                }
                if (this.g.size() == 0) {
                    this.f = null;
                    if (this.h) {
                        try {
                            this.c.appEnterBackground();
                            this.f83a = true;
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                        if (this.c.isAutoTrackEnabled()) {
                            JSONObject jSONObject = new JSONObject();
                            if (this.c.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_END)) {
                                this.e = new d(TimeUnit.SECONDS, SystemClock.elapsedRealtime());
                            } else {
                                try {
                                    try {
                                        q.a(jSONObject, activity);
                                        thinkingAnalyticsSDK = this.c;
                                        str = "ta_app_end";
                                    } catch (Throwable th) {
                                        this.c.autoTrack("ta_app_end", jSONObject);
                                        this.h = false;
                                        throw th;
                                    }
                                } catch (Exception e2) {
                                    TDLog.i("ThinkingAnalytics.ThinkingDataActivityLifecycleCallbacks", e2);
                                    thinkingAnalyticsSDK = this.c;
                                    str = "ta_app_end";
                                }
                                thinkingAnalyticsSDK.autoTrack(str, jSONObject);
                                this.h = false;
                                try {
                                    this.e = new d(TimeUnit.SECONDS, SystemClock.elapsedRealtime());
                                } catch (Exception e3) {
                                    e3.printStackTrace();
                                }
                            }
                        } else {
                            this.e = new d(TimeUnit.SECONDS, SystemClock.elapsedRealtime());
                        }
                    }
                    this.c.flush();
                }
            }
        } catch (Exception e4) {
            e4.printStackTrace();
        }
    }
}
