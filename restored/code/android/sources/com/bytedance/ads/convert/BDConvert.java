package com.bytedance.ads.convert;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Looper;
import android.util.Log;
import com.byazt.hv.TTDownloadField;
import com.bytedance.ads.convert.callback.BDConvertLifecycleCallback;
import com.bytedance.ads.convert.config.BDConvertConfig;
import com.bytedance.ads.convert.flat.f.b;
import com.bytedance.ads.convert.flat.f.c;
import com.bytedance.ads.convert.flat.f.d;
import com.bytedance.ads.convert.flat.i.g;
import java.util.Timer;
import kotlin.Metadata;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@Metadata(bv = {1, 0, 3}, d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\f\n\u0002\u0010\u000e\n\u0002\b\u0005\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b&\u0010'J\u0017\u0010\u0005\u001a\u00020\u00042\u0006\u0010\u0003\u001a\u00020\u0002H\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u001f\u0010\u0005\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\tH\u0002¢\u0006\u0004\b\u0005\u0010\u000bJ\u001d\u0010\u0005\u001a\u00020\u00042\u0006\u0010\u0003\u001a\u00020\u00022\u0006\u0010\n\u001a\u00020\t¢\u0006\u0004\b\u0005\u0010\fJ%\u0010\u0005\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u000e\u001a\u00020\r¢\u0006\u0004\b\u0005\u0010\u000fJ\u001d\u0010\u0005\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\r¢\u0006\u0004\b\u0005\u0010\u0010J\u0015\u0010\u0011\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u0007¢\u0006\u0004\b\u0011\u0010\u0012R\u0016\u0010\u0014\u001a\u00020\u00138\u0002@\u0002X\u0082\u000e¢\u0006\u0006\n\u0004\b\u0014\u0010\u0015R\"\u0010\u0017\u001a\u00020\u00168\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u0017\u0010\u0018\u001a\u0004\b\u0019\u0010\u001a\"\u0004\b\u001b\u0010\u001cR\"\u0010\u001d\u001a\u00020\t8\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u001d\u0010\u001e\u001a\u0004\b\u001f\u0010 \"\u0004\b!\u0010\"R\u0016\u0010$\u001a\u00020#8\u0002@\u0002X\u0082T¢\u0006\u0006\n\u0004\b$\u0010%¨\u0006("}, d2 = {"Lcom/bytedance/ads/convert/BDConvert;", "", "Landroid/app/Application;", "application", "", "init", "(Landroid/app/Application;)V", "Landroid/content/Context;", "context", "Lcom/bytedance/ads/convert/config/BDConvertConfig;", "userConfig", "(Landroid/content/Context;Lcom/bytedance/ads/convert/config/BDConvertConfig;)V", "(Landroid/app/Application;Lcom/bytedance/ads/convert/config/BDConvertConfig;)V", "Landroid/app/Activity;", TTDownloadField.TT_ACTIVITY, "(Landroid/content/Context;Lcom/bytedance/ads/convert/config/BDConvertConfig;Landroid/app/Activity;)V", "(Landroid/content/Context;Landroid/app/Activity;)V", "sendLaunchEvent", "(Landroid/content/Context;)V", "", "hasPost", "Z", "", "initTime", "J", "getInitTime", "()J", "setInitTime", "(J)V", "config", "Lcom/bytedance/ads/convert/config/BDConvertConfig;", "getConfig", "()Lcom/bytedance/ads/convert/config/BDConvertConfig;", "setConfig", "(Lcom/bytedance/ads/convert/config/BDConvertConfig;)V", "", "TAG", "Ljava/lang/String;", "<init>", "()V", "convert_release"}, k = 1, mv = {1, 4, 0})
public final class BDConvert {
    private static final String TAG = "Convert:BDConvert";
    private static boolean hasPost;
    public static final BDConvert INSTANCE = new BDConvert();
    private static BDConvertConfig config = new BDConvertConfig();
    private static long initTime = -1;

    public static final class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final /* synthetic */ Context f1673a;

        public a(Context context) {
            this.f1673a = context;
        }

        @Override // java.lang.Runnable
        public final void run() {
            String string;
            SharedPreferences.Editor editorEdit;
            SharedPreferences.Editor editorClear;
            Intrinsics.checkNotNullParameter(BDConvert.TAG, "tag");
            Intrinsics.checkNotNullParameter("sendLaunchEvent", "msg");
            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                Log.d(BDConvert.TAG, "sendLaunchEvent");
            }
            Context appContext = this.f1673a.getApplicationContext();
            try {
                b.a aVar = b.e;
                Intrinsics.checkNotNullExpressionValue(appContext, "appContext");
                aVar.a(appContext);
                BDConvertLifecycleCallback lifecycleCallback = BDConvert.INSTANCE.getConfig().getLifecycleCallback();
                if (lifecycleCallback != null) {
                    lifecycleCallback.onInitSuccess();
                }
                Intrinsics.checkNotNullParameter("launch_app", "label");
                Intrinsics.checkNotNullParameter("3", "eventVersion");
                b bVar = new b("launch_app");
                bVar.g = "3";
                bVar.h = null;
                bVar.a("Convert:EventReporterV3");
                SharedPreferences sharedPreferences = g.g;
                if (sharedPreferences != null && (string = sharedPreferences.getString("app_switch_event_params", null)) != null) {
                    try {
                        JSONObject params = new JSONObject(string);
                        if (b.f1696a != null) {
                            Intrinsics.checkNotNullParameter("session_sync", "label");
                            Intrinsics.checkNotNullParameter(params, "params");
                            b bVar2 = new b("session_sync");
                            bVar2.g = null;
                            bVar2.h = params;
                            bVar2.a("Convert:PlaySession");
                            g.f++;
                            SharedPreferences sharedPreferences2 = g.g;
                            if (sharedPreferences2 != null && (editorEdit = sharedPreferences2.edit()) != null && (editorClear = editorEdit.clear()) != null) {
                                editorClear.apply();
                            }
                        }
                    } catch (JSONException unused) {
                    }
                }
                d dVar = d.b;
                if (b.b != -1) {
                    dVar.a();
                } else {
                    new Timer().schedule(new c(), 500L);
                }
            } catch (Throwable th) {
                Intrinsics.checkNotNullParameter(BDConvert.TAG, "tag");
                Intrinsics.checkNotNullParameter("初始化失败", "msg");
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.e(BDConvert.TAG, "初始化失败", null);
                }
                BDConvertLifecycleCallback lifecycleCallback2 = BDConvert.INSTANCE.getConfig().getLifecycleCallback();
                if (lifecycleCallback2 != null) {
                    lifecycleCallback2.onInitFailure(-1, th);
                }
            }
        }
    }

    private BDConvert() {
    }

    private final void init(Application application) {
        if (initTime != -1) {
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("BDConvert 重复初始化", "msg");
            if (INSTANCE.getConfig().getEnableLog()) {
                Log.d(TAG, "BDConvert 重复初始化");
            }
            BDConvertLifecycleCallback lifecycleCallback = config.getLifecycleCallback();
            if (lifecycleCallback != null) {
                lifecycleCallback.onInitFailure(1, null);
                return;
            }
            return;
        }
        Looper mainLooper = Looper.getMainLooper();
        Intrinsics.checkNotNullExpressionValue(mainLooper, "Looper.getMainLooper()");
        if (!(!Intrinsics.areEqual(mainLooper.getThread(), Thread.currentThread()))) {
            init(application, config);
            return;
        }
        Intrinsics.checkNotNullParameter(TAG, "tag");
        Intrinsics.checkNotNullParameter("初始化失败, BDConvert 在使用application初始化时,必须在主线程中调用\n若要在子线程中初始化,请在使用Activity作为参数的方法重载", "msg");
        if (INSTANCE.getConfig().getEnableLog()) {
            Log.e(TAG, "初始化失败, BDConvert 在使用application初始化时,必须在主线程中调用\n若要在子线程中初始化,请在使用Activity作为参数的方法重载", null);
        }
        BDConvertLifecycleCallback lifecycleCallback2 = config.getLifecycleCallback();
        if (lifecycleCallback2 != null) {
            lifecycleCallback2.onInitFailure(2, null);
        }
    }

    public final BDConvertConfig getConfig() {
        return config;
    }

    public final long getInitTime() {
        return initTime;
    }

    public final void sendLaunchEvent(Context context) {
        Intrinsics.checkNotNullParameter(context, "context");
        if (!hasPost) {
            hasPost = true;
            new Thread(new a(context)).start();
            return;
        }
        Intrinsics.checkNotNullParameter(TAG, "tag");
        Intrinsics.checkNotNullParameter("already sendLaunchEvent", "msg");
        if (INSTANCE.getConfig().getEnableLog()) {
            Log.d(TAG, "already sendLaunchEvent");
        }
        BDConvertLifecycleCallback lifecycleCallback = config.getLifecycleCallback();
        if (lifecycleCallback != null) {
            lifecycleCallback.onOtherError(3, null);
        }
    }

    public final void setConfig(BDConvertConfig bDConvertConfig) {
        Intrinsics.checkNotNullParameter(bDConvertConfig, "<set-?>");
        config = bDConvertConfig;
    }

    public final void setInitTime(long j) {
        initTime = j;
    }

    public final void init(Application application, BDConvertConfig userConfig) {
        Intrinsics.checkNotNullParameter(application, "application");
        Intrinsics.checkNotNullParameter(userConfig, "userConfig");
        config = userConfig;
        if (initTime != -1) {
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("BDConvert 重复初始化", "msg");
            if (INSTANCE.getConfig().getEnableLog()) {
                Log.d(TAG, "BDConvert 重复初始化");
            }
            BDConvertLifecycleCallback lifecycleCallback = config.getLifecycleCallback();
            if (lifecycleCallback != null) {
                lifecycleCallback.onInitFailure(1, null);
                return;
            }
            return;
        }
        Looper mainLooper = Looper.getMainLooper();
        Intrinsics.checkNotNullExpressionValue(mainLooper, "Looper.getMainLooper()");
        if (!Intrinsics.areEqual(mainLooper.getThread(), Thread.currentThread())) {
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("初始化失败, BDConvert 在使用application初始化时,必须在主线程中调用\n若要在子线程中初始化,请在使用Activity作为参数的方法重载", "msg");
            if (INSTANCE.getConfig().getEnableLog()) {
                Log.e(TAG, "初始化失败, BDConvert 在使用application初始化时,必须在主线程中调用\n若要在子线程中初始化,请在使用Activity作为参数的方法重载", null);
            }
            BDConvertLifecycleCallback lifecycleCallback2 = config.getLifecycleCallback();
            if (lifecycleCallback2 != null) {
                lifecycleCallback2.onInitFailure(2, null);
                return;
            }
            return;
        }
        Context applicationContext = application.getApplicationContext();
        Intrinsics.checkNotNullExpressionValue(applicationContext, "application.applicationContext");
        init(applicationContext, userConfig);
        if (userConfig.getPlaySessionEnable()) {
            g gVar = g.i;
            Intrinsics.checkNotNullParameter(application, "application");
            application.registerActivityLifecycleCallbacks(g.h);
            boolean z = !gVar.a(application);
            g.d = z;
            if (!z) {
                com.bytedance.ads.convert.flat.e.a aVar = com.bytedance.ads.convert.flat.e.a.h;
                gVar.a(com.bytedance.ads.convert.flat.e.a.f);
            }
            g.e = System.currentTimeMillis();
            g.g = application.getSharedPreferences("sp_name_app_switch_event", 0);
        }
    }

    public final void init(Context context, Activity activity) {
        Intrinsics.checkNotNullParameter(context, "context");
        Intrinsics.checkNotNullParameter(activity, "activity");
        if (initTime == -1) {
            init(context, config, activity);
            return;
        }
        Intrinsics.checkNotNullParameter(TAG, "tag");
        Intrinsics.checkNotNullParameter("BDConvert 重复初始化", "msg");
        if (INSTANCE.getConfig().getEnableLog()) {
            Log.d(TAG, "BDConvert 重复初始化");
        }
        BDConvertLifecycleCallback lifecycleCallback = config.getLifecycleCallback();
        if (lifecycleCallback != null) {
            lifecycleCallback.onInitFailure(1, null);
        }
    }

    private final void init(Context context, BDConvertConfig userConfig) {
        Intrinsics.checkNotNullParameter(TAG, "tag");
        Intrinsics.checkNotNullParameter("BDConvert init", "msg");
        if (INSTANCE.getConfig().getEnableLog()) {
            Log.d(TAG, "BDConvert init");
        }
        initTime = System.currentTimeMillis();
        if (config.getAutoSendLaunchEvent()) {
            sendLaunchEvent(context);
        }
    }

    public final void init(Context context, BDConvertConfig userConfig, Activity activity) {
        Intrinsics.checkNotNullParameter(context, "context");
        Intrinsics.checkNotNullParameter(userConfig, "userConfig");
        Intrinsics.checkNotNullParameter(activity, "activity");
        config = userConfig;
        if (initTime != -1) {
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("BDConvert 重复初始化", "msg");
            if (INSTANCE.getConfig().getEnableLog()) {
                Log.d(TAG, "BDConvert 重复初始化");
            }
            BDConvertLifecycleCallback lifecycleCallback = config.getLifecycleCallback();
            if (lifecycleCallback != null) {
                lifecycleCallback.onInitFailure(1, null);
                return;
            }
            return;
        }
        init(context, userConfig);
        if (userConfig.getPlaySessionEnable()) {
            Intrinsics.checkNotNullParameter(activity, "activity");
            Application application = activity.getApplication();
            g.a aVar = g.h;
            application.registerActivityLifecycleCallbacks(aVar);
            aVar.onActivityStarted(activity);
            g.e = System.currentTimeMillis();
            g.g = activity.getSharedPreferences("sp_name_app_switch_event", 0);
        }
    }
}
