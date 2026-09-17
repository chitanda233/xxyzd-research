package com.bytedance.ads.convert.flat.i;

import android.app.Activity;
import android.app.ActivityManager;
import android.app.Application;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Process;
import android.util.Log;
import com.byazt.hv.TTDownloadField;
import com.bytedance.ads.convert.BDConvert;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;
import java.util.UUID;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static int f1707a = 1;
    public static String b = "";
    public static Timer c = null;
    public static boolean d = true;
    public static long e;
    public static int f;
    public static SharedPreferences g;
    public static final g i = new g();
    public static final a h = new a();

    public static final class a implements Application.ActivityLifecycleCallbacks {
        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityCreated(Activity activity, Bundle bundle) {
            Intrinsics.checkNotNullParameter(activity, "activity");
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityDestroyed(Activity activity) {
            Intrinsics.checkNotNullParameter(activity, "activity");
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityPaused(Activity activity) {
            Intrinsics.checkNotNullParameter(activity, "activity");
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityResumed(Activity activity) {
            Intrinsics.checkNotNullParameter(activity, "activity");
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivitySaveInstanceState(Activity activity, Bundle outState) {
            Intrinsics.checkNotNullParameter(activity, "activity");
            Intrinsics.checkNotNullParameter(outState, "outState");
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityStarted(Activity activity) {
            Intrinsics.checkNotNullParameter(activity, "activity");
            g gVar = g.i;
            boolean z = g.d;
            g.d = false;
            if (z) {
                com.bytedance.ads.convert.flat.e.a aVar = com.bytedance.ads.convert.flat.e.a.h;
                gVar.a(com.bytedance.ads.convert.flat.e.a.f);
                Intrinsics.checkNotNullParameter("Convert:PlaySession", "tag");
                Intrinsics.checkNotNullParameter("App came to foreground", "msg");
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d("Convert:PlaySession", "App came to foreground");
                }
            }
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityStopped(Activity activity) {
            Intrinsics.checkNotNullParameter(activity, "activity");
            g gVar = g.i;
            Context applicationContext = activity.getApplicationContext();
            Intrinsics.checkNotNullExpressionValue(applicationContext, "activity.applicationContext");
            if (!(!gVar.a(applicationContext)) || g.d) {
                return;
            }
            g.d = true;
            gVar.a();
            gVar.a(g.a(gVar, 1));
            String string = UUID.randomUUID().toString();
            Intrinsics.checkNotNullExpressionValue(string, "UUID.randomUUID().toString()");
            Intrinsics.checkNotNullParameter(string, "<set-?>");
            g.b = string;
            Intrinsics.checkNotNullParameter("Convert:PlaySession", "tag");
            Intrinsics.checkNotNullParameter("App went to background", "msg");
            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                Log.d("Convert:PlaySession", "App went to background");
            }
        }
    }

    public static final class b extends TimerTask {
        @Override // java.util.TimerTask, java.lang.Runnable
        public void run() throws JSONException {
            g gVar = g.i;
            if (g.d) {
                return;
            }
            SharedPreferences sharedPreferences = g.g;
            if (sharedPreferences != null) {
                sharedPreferences.edit().putString("app_switch_event_params", g.a(gVar, 1).toString()).apply();
            }
            if (com.bytedance.ads.convert.flat.f.b.f1696a == null) {
                return;
            }
            JSONObject params = new JSONObject();
            try {
                int i = g.f1707a;
                g.f1707a = i + 1;
                params.put("play_session_num", i);
            } catch (JSONException unused) {
            }
            Intrinsics.checkNotNullParameter("play_session", "label");
            Intrinsics.checkNotNullParameter(params, "params");
            com.bytedance.ads.convert.flat.f.b bVar = new com.bytedance.ads.convert.flat.f.b("play_session");
            bVar.g = null;
            bVar.h = params;
            bVar.a("Convert:PlaySession");
        }
    }

    public static final JSONObject a(g gVar, int i2) throws JSONException {
        JSONObject jSONObject = new JSONObject();
        jSONObject.put(MediationConstant.EXTRA_DURATION, (System.currentTimeMillis() - e) / ((long) 1000));
        jSONObject.put("switch_type", i2);
        jSONObject.put(PointCategory.SESSION_START, e);
        return jSONObject;
    }

    public final boolean a(Context context) {
        int i2;
        try {
            Object systemService = context.getSystemService(TTDownloadField.TT_ACTIVITY);
            if (!(systemService instanceof ActivityManager)) {
                systemService = null;
            }
            ActivityManager activityManager = (ActivityManager) systemService;
            if (activityManager == null) {
                return false;
            }
            int iMyPid = Process.myPid();
            List<ActivityManager.RunningAppProcessInfo> runningAppProcesses = activityManager.getRunningAppProcesses();
            if (runningAppProcesses != null && !runningAppProcesses.isEmpty()) {
                for (ActivityManager.RunningAppProcessInfo runningAppProcessInfo : runningAppProcesses) {
                    if (runningAppProcessInfo.pid == iMyPid && ((i2 = runningAppProcessInfo.importance) == 100 || i2 == 200)) {
                        return true;
                    }
                }
                return false;
            }
            return false;
        } catch (Throwable unused) {
            return false;
        }
    }

    public final void a() {
        try {
            Timer timer = c;
            if (timer != null) {
                timer.cancel();
            }
        } catch (Throwable unused) {
        }
        c = null;
        Intrinsics.checkNotNullParameter("Convert:PlaySession", "tag");
        Intrinsics.checkNotNullParameter("cancelPlaySessionEvent", "msg");
        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
            Log.d("Convert:PlaySession", "cancelPlaySessionEvent");
        }
    }

    public final void a(JSONObject params) {
        SharedPreferences.Editor editorEdit;
        SharedPreferences.Editor editorClear;
        if (com.bytedance.ads.convert.flat.f.b.f1696a == null) {
            return;
        }
        Intrinsics.checkNotNullParameter("session_sync", "label");
        Intrinsics.checkNotNullParameter(params, "params");
        com.bytedance.ads.convert.flat.f.b bVar = new com.bytedance.ads.convert.flat.f.b("session_sync");
        bVar.g = null;
        bVar.h = params;
        bVar.a("Convert:PlaySession");
        f++;
        SharedPreferences sharedPreferences = g;
        if (sharedPreferences == null || (editorEdit = sharedPreferences.edit()) == null || (editorClear = editorEdit.clear()) == null) {
            return;
        }
        editorClear.apply();
    }

    public final synchronized void a(long j) {
        a();
        c = new Timer();
        b bVar = new b();
        com.bytedance.ads.convert.flat.e.a aVar = com.bytedance.ads.convert.flat.e.a.h;
        long j2 = com.bytedance.ads.convert.flat.e.a.f;
        if (j2 <= 0) {
            j2 = 60000;
        }
        long j3 = j2;
        long j4 = j > 0 ? j : j3;
        try {
            Timer timer = c;
            if (timer != null) {
                timer.schedule(bVar, j4, j3);
            }
        } catch (Throwable unused) {
            a();
        }
        Intrinsics.checkNotNullParameter("Convert:PlaySession", "tag");
        Intrinsics.checkNotNullParameter("startPlaySessionEvent", "msg");
        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
            Log.d("Convert:PlaySession", "startPlaySessionEvent");
        }
    }
}
