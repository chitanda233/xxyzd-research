package com.qq.e.comm.managers;

import android.content.Context;
import android.text.TextUtils;
import com.qq.e.ads.dfa.GDTAppDialogClickListener;
import com.qq.e.comm.managers.devtool.DevTools;
import com.qq.e.comm.managers.plugin.PM;
import com.qq.e.comm.managers.plugin.e;
import com.qq.e.comm.pi.POFactory;
import com.qq.e.comm.util.GDTLogger;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

/* JADX INFO: loaded from: classes3.dex */
public class a implements IGDTAdManager {
    public static final ExecutorService g = Executors.newSingleThreadExecutor();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private volatile boolean f2990a;
    private volatile boolean b;
    private volatile Context c;
    private volatile PM d;
    private volatile DevTools e;
    private volatile String f;

    /* JADX INFO: renamed from: com.qq.e.comm.managers.a$a, reason: collision with other inner class name */
    class RunnableC0547a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ GDTAdSdk.OnStartListener f2991a;

        RunnableC0547a(GDTAdSdk.OnStartListener onStartListener) {
            this.f2991a = onStartListener;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                POFactory pOFactory = a.this.d.getPOFactory(false, false);
                if (pOFactory != null) {
                    pOFactory.start(a.this.d.getStartCaller(1));
                    GDTAdSdk.OnStartListener onStartListener = this.f2991a;
                    if (onStartListener != null) {
                        onStartListener.onStartSuccess();
                    }
                } else {
                    GDTAdSdk.OnStartListener onStartListener2 = this.f2991a;
                    if (onStartListener2 != null) {
                        onStartListener2.onStartFailed(new Exception("GDTAdSdk start异常"));
                    }
                }
            } catch (e e) {
                GDTLogger.e(e.getMessage(), e);
                GDTAdSdk.OnStartListener onStartListener3 = this.f2991a;
                if (onStartListener3 != null) {
                    onStartListener3.onStartFailed(e);
                }
            }
        }
    }

    class b implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ boolean f2992a;

        b(boolean z) {
            this.f2992a = z;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                a.this.d.getPOFactory(this.f2992a, true);
                a.this.b = true;
            } catch (e e) {
                GDTLogger.e(e.getMessage(), e);
            }
        }
    }

    private static final class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static a f2993a = new a(null);
    }

    private a() {
        this.f2990a = false;
        this.b = false;
    }

    public static a b() {
        return c.f2993a;
    }

    public PM c() {
        return this.d;
    }

    public boolean d() {
        if (this.f2990a) {
            return true;
        }
        GDTLogger.e("SDK 尚未初始化，请在 Application 中调用 GDTAdSdk.initWithoutStart() 初始化");
        return false;
    }

    @Override // com.qq.e.comm.managers.IGDTAdManager
    public String getBuyerId(Map<String, Object> map) {
        if (!d()) {
            return "";
        }
        try {
            return this.d.getPOFactory().getBuyerId(map);
        } catch (Exception e) {
            GDTLogger.e("SDK 初始化异常", e);
            return "";
        }
    }

    @Override // com.qq.e.comm.managers.IGDTAdManager
    public DevTools getDevTools() {
        if (this.e == null) {
            this.e = new DevTools();
        }
        return this.e;
    }

    @Override // com.qq.e.comm.managers.IGDTAdManager
    public String getSDKInfo(String str) {
        if (!d()) {
            return "";
        }
        try {
            return this.d.getPOFactory().getSDKInfo(str);
        } catch (Exception e) {
            GDTLogger.e("SDK 初始化异常", e);
            return "";
        }
    }

    @Override // com.qq.e.comm.managers.IGDTAdManager
    public int showOpenOrInstallAppDialog(GDTAppDialogClickListener gDTAppDialogClickListener) {
        if (!this.b) {
            return 0;
        }
        try {
            return this.d.getPOFactory().showOpenOrInstallAppDialog(gDTAppDialogClickListener);
        } catch (Exception e) {
            GDTLogger.e("SDK 初始化异常", e);
            return 0;
        }
    }

    /* synthetic */ a(RunnableC0547a runnableC0547a) {
        this();
    }

    synchronized boolean b(Context context, String str, boolean z) {
        if (this.f2990a) {
            return true;
        }
        if (context == null || TextUtils.isEmpty(str)) {
            GDTLogger.e("GDTADManager初始化错误，context和appId不能为空");
            return false;
        }
        try {
            a(context, str, z);
            this.f2990a = true;
            return true;
        } catch (Throwable th) {
            GDTLogger.e("GDTADManager初始化错误", th);
            return false;
        }
    }

    private void a(Context context, String str, boolean z) {
        this.f = str;
        this.c = context.getApplicationContext();
        this.d = new PM(this.c, null);
        g.submit(new b(z));
    }

    public String a() {
        return this.f;
    }

    synchronized void a(GDTAdSdk.OnStartListener onStartListener) {
        if (this.f2990a) {
            g.submit(new RunnableC0547a(onStartListener));
            return;
        }
        GDTLogger.e("在调用start方法前请先调用initWithoutStart方法");
        if (onStartListener != null) {
            onStartListener.onStartFailed(new Exception("在调用start方法前请先调用initWithoutStart方法"));
        }
    }
}
