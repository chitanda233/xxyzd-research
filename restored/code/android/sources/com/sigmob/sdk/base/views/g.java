package com.sigmob.sdk.base.views;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import android.webkit.CookieManager;
import android.webkit.JsPromptResult;
import android.webkit.JsResult;
import android.webkit.ValueCallback;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.utils.RomUtils;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.StringUtil;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.nativead.APKStatusBroadcastReceiver;
import java.io.File;
import java.io.RandomAccessFile;
import java.lang.ref.WeakReference;
import java.nio.channels.FileChannel;
import java.nio.channels.FileLock;
import java.nio.channels.OverlappingFileLockException;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public class g extends WebView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3322a = "g";
    private static boolean b = false;
    private APKStatusBroadcastReceiver c;
    private WeakReference<com.sigmob.sdk.base.common.b> d;
    private BaseAdUnit e;
    private final Set<String> f;
    private final Map<String, String> g;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.views.g$1, reason: invalid class name */
    class AnonymousClass1 implements af.a {
        AnonymousClass1() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void c() {
            Activity activityC = com.sigmob.sdk.base.utils.w.c(g.this);
            if (activityC == null) {
                return;
            }
            com.sigmob.sdk.videoplayer.c.h((Context) activityC);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void d() {
            Activity activityC = com.sigmob.sdk.base.utils.w.c(g.this);
            if (activityC == null) {
                return;
            }
            com.sigmob.sdk.videoplayer.c.i(activityC);
        }

        @Override // com.sigmob.sdk.base.views.af.a
        public void a() {
            ThreadPoolFactory.MainThreadRun(new Runnable() { // from class: com.sigmob.sdk.base.views.g$1$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.d();
                }
            });
        }

        @Override // com.sigmob.sdk.base.views.af.a
        public void b() {
            ThreadPoolFactory.MainThreadRun(new Runnable() { // from class: com.sigmob.sdk.base.views.g$1$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.c();
                }
            });
        }
    }

    public g(Context context) throws Throwable {
        super(context);
        this.f = new HashSet();
        this.g = new HashMap();
        removeJavascriptInterface("searchBoxJavaBridge_");
        removeJavascriptInterface("accessibility");
        removeJavascriptInterface("accessibilityTraversal");
        a(getSettings());
        if (!b) {
            b(getContext());
            b = true;
        }
        resumeTimers();
        a(context);
    }

    private static void a(Context context) throws Throwable {
        String str;
        if (context == null || Build.VERSION.SDK_INT < 28) {
            return;
        }
        try {
            String absolutePath = context.getDataDir().getAbsolutePath();
            HashSet hashSet = new HashSet();
            String packageName = context.getPackageName();
            String processName = Application.getProcessName();
            if (TextUtils.equals(packageName, processName)) {
                String str2 = "_" + processName;
                hashSet.add(absolutePath + "/app_webview/webview_data.lock");
                hashSet.add(absolutePath + "/app_webview" + str2 + "/webview_data.lock");
                if (RomUtils.isHuawei()) {
                    hashSet.add(absolutePath + "/app_hws_webview/webview_data.lock");
                    str = absolutePath + "/app_hws_webview" + str2 + "/webview_data.lock";
                    hashSet.add(str);
                }
            } else {
                if (!TextUtils.isEmpty(processName)) {
                    packageName = processName;
                }
                WebView.setDataDirectorySuffix(packageName);
                String str3 = "_" + packageName;
                hashSet.add(absolutePath + "/app_webview" + str3 + "/webview_data.lock");
                if (RomUtils.isHuawei()) {
                    str = absolutePath + "/app_hws_webview" + str3 + "/webview_data.lock";
                    hashSet.add(str);
                }
            }
            Iterator it = hashSet.iterator();
            while (it.hasNext()) {
                File file = new File((String) it.next());
                if (file.exists()) {
                    a(file);
                    return;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void a(WebSettings webSettings) {
        com.sigmob.sdk.base.utils.j.a(f3322a, webSettings);
        webSettings.setDomStorageEnabled(true);
        webSettings.setUseWideViewPort(true);
        webSettings.setBuiltInZoomControls(false);
        webSettings.setLoadWithOverviewMode(true);
        webSettings.setSupportZoom(true);
        webSettings.setDefaultTextEncodingName("UTF-8");
        webSettings.setBlockNetworkImage(false);
        webSettings.setBlockNetworkLoads(false);
        webSettings.setCacheMode(-1);
        webSettings.setMediaPlaybackRequiresUserGesture(false);
        webSettings.setLoadsImagesAutomatically(true);
        webSettings.setAllowContentAccess(true);
        try {
            webSettings.setSafeBrowsingEnabled(false);
        } catch (Throwable th) {
            com.sigmob.sdk.base.utils.k.f(f3322a, "setSafeBrowsingEnabled: error = " + th.getMessage(), new Object[0]);
        }
        try {
            webSettings.setMixedContentMode(0);
        } catch (Throwable th2) {
            com.sigmob.sdk.base.utils.k.f(f3322a, "setMixedContentMode: error = " + th2.getMessage(), new Object[0]);
        }
    }

    public static void a(WebView webView) {
        CookieManager.getInstance().setAcceptThirdPartyCookies(webView, com.sigmob.sdk.base.i.a().i());
    }

    /* JADX WARN: Code duplicated, block: B:70:0x011e A[Catch: Exception -> 0x0122, TryCatch #11 {Exception -> 0x0122, blocks: (B:68:0x0118, B:70:0x011e, B:74:0x0126, B:76:0x012b), top: B:89:0x0118 }] */
    /* JADX WARN: Code duplicated, block: B:73:0x0124 A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:74:0x0126 A[Catch: Exception -> 0x0122, TryCatch #11 {Exception -> 0x0122, blocks: (B:68:0x0118, B:70:0x011e, B:74:0x0126, B:76:0x012b), top: B:89:0x0118 }] */
    /* JADX WARN: Code duplicated, block: B:76:0x012b A[Catch: Exception -> 0x0122, TRY_LEAVE, TryCatch #11 {Exception -> 0x0122, blocks: (B:68:0x0118, B:70:0x011e, B:74:0x0126, B:76:0x012b), top: B:89:0x0118 }] */
    /* JADX WARN: Code duplicated, block: B:89:0x0118 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    private static void a(File file) throws Throwable {
        RandomAccessFile randomAccessFile;
        FileChannel channel;
        FileLock fileLock;
        FileLock fileLock2 = null;
        fileLock2 = null;
        fileLock2 = null;
        RandomAccessFile randomAccessFile2 = null;
        try {
            try {
                randomAccessFile = new RandomAccessFile(file, "rw");
                try {
                    channel = randomAccessFile.getChannel();
                    try {
                        FileLock fileLockTryLock = channel.tryLock();
                        if (fileLockTryLock == null) {
                            a(file, file.delete());
                        } else {
                            fileLockTryLock.close();
                        }
                        if (fileLockTryLock != null) {
                            try {
                                if (fileLockTryLock.isValid()) {
                                    fileLockTryLock.close();
                                }
                            } catch (Exception e) {
                                com.sigmob.sdk.base.utils.k.e(f3322a, "Error in finally block: " + e.getMessage(), new Object[0]);
                                return;
                            }
                        }
                        if (channel != null) {
                            channel.close();
                        }
                        randomAccessFile.close();
                    } catch (OverlappingFileLockException e2) {
                        e = e2;
                        fileLock = null;
                        randomAccessFile2 = randomAccessFile;
                        try {
                            a(file, "File already locked by another process or thread: " + file.getAbsolutePath() + ", error is " + e.getMessage());
                            if (fileLock != null) {
                                try {
                                    if (fileLock.isValid()) {
                                        fileLock.close();
                                    }
                                } catch (Exception e3) {
                                    com.sigmob.sdk.base.utils.k.e(f3322a, "Error in finally block: " + e3.getMessage(), new Object[0]);
                                    return;
                                }
                            }
                            if (channel != null) {
                                channel.close();
                            }
                            if (randomAccessFile2 != null) {
                                randomAccessFile2.close();
                            }
                        } catch (Throwable th) {
                            th = th;
                            FileLock fileLock3 = fileLock;
                            randomAccessFile = randomAccessFile2;
                            fileLock2 = fileLock3;
                            if (fileLock2 != null) {
                                try {
                                    if (fileLock2.isValid()) {
                                        fileLock2.close();
                                    }
                                    if (channel != null) {
                                        channel.close();
                                    }
                                    if (randomAccessFile != null) {
                                        randomAccessFile.close();
                                    }
                                } catch (Exception e4) {
                                    com.sigmob.sdk.base.utils.k.e(f3322a, "Error in finally block: " + e4.getMessage(), new Object[0]);
                                    throw th;
                                }
                            } else {
                                if (channel != null) {
                                    channel.close();
                                }
                                if (randomAccessFile != null) {
                                    randomAccessFile.close();
                                }
                            }
                            throw th;
                        }
                    } catch (Exception e5) {
                        e = e5;
                        a(file, "Error in tryLockOrRecreateFile: " + e.getMessage());
                        if (0 != 0) {
                            try {
                                if (fileLock2.isValid()) {
                                    fileLock2.close();
                                }
                            } catch (Exception e6) {
                                com.sigmob.sdk.base.utils.k.e(f3322a, "Error in finally block: " + e6.getMessage(), new Object[0]);
                                return;
                            }
                        }
                        if (channel != null) {
                            channel.close();
                        }
                        if (randomAccessFile != null) {
                            randomAccessFile.close();
                        }
                    }
                } catch (OverlappingFileLockException e7) {
                    e = e7;
                    channel = null;
                    randomAccessFile2 = randomAccessFile;
                    fileLock = null;
                } catch (Exception e8) {
                    e = e8;
                    channel = null;
                } catch (Throwable th2) {
                    th = th2;
                    channel = null;
                    if (fileLock2 != null) {
                        if (fileLock2.isValid()) {
                            fileLock2.close();
                        }
                        if (channel != null) {
                            channel.close();
                        }
                        if (randomAccessFile != null) {
                            randomAccessFile.close();
                        }
                    } else {
                        if (channel != null) {
                            channel.close();
                        }
                        if (randomAccessFile != null) {
                            randomAccessFile.close();
                        }
                    }
                    throw th;
                }
            } catch (Throwable th3) {
                th = th3;
            }
        } catch (OverlappingFileLockException e9) {
            e = e9;
            fileLock = null;
            channel = null;
        } catch (Exception e10) {
            e = e10;
            randomAccessFile = null;
            channel = null;
        } catch (Throwable th4) {
            th = th4;
            randomAccessFile = null;
            channel = null;
        }
    }

    private static void a(File file, String error) {
        com.sigmob.sdk.base.utils.k.e(f3322a, error, new Object[0]);
        a(file, file.exists() ? file.delete() : false);
    }

    private static void a(File file, boolean deleted) {
        if (deleted) {
            try {
                if (file.exists()) {
                    return;
                }
                file.createNewFile();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    private void b(Context context) {
    }

    public static void d() {
        CookieManager cookieManager = CookieManager.getInstance();
        if (com.sigmob.sdk.base.i.a().i()) {
            cookieManager.setAcceptCookie(true);
            CookieManager.setAcceptFileSchemeCookies(true);
            return;
        }
        cookieManager.setAcceptCookie(false);
        CookieManager.setAcceptFileSchemeCookies(false);
        cookieManager.removeSessionCookies(null);
        cookieManager.removeAllCookies(null);
        cookieManager.flush();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.sigmob.sdk.base.common.b getListener() {
        WeakReference<com.sigmob.sdk.base.common.b> weakReference = this.d;
        if (weakReference == null) {
            return null;
        }
        return weakReference.get();
    }

    public void a() {
        if (this.e == null || this.c != null) {
            return;
        }
        APKStatusBroadcastReceiver aPKStatusBroadcastReceiver = new APKStatusBroadcastReceiver(new com.sigmob.sdk.base.common.b() { // from class: com.sigmob.sdk.base.views.g.2
            @Override // com.sigmob.sdk.base.common.b
            public void a(boolean result) {
                com.sigmob.sdk.base.common.b listener = g.this.getListener();
                if (listener != null) {
                    listener.a(result);
                }
            }

            @Override // com.sigmob.sdk.base.common.b
            public void a(boolean result, long downloadId) {
                com.sigmob.sdk.base.common.b listener = g.this.getListener();
                if (listener != null) {
                    listener.b(result, downloadId);
                } else if (result) {
                    g.this.e();
                } else {
                    g.this.f();
                }
            }

            @Override // com.sigmob.sdk.base.common.b
            public void b(boolean result) {
                com.sigmob.sdk.base.common.b listener = g.this.getListener();
                if (listener != null) {
                    listener.b(result);
                } else if (result) {
                    g.this.i();
                } else {
                    g.this.f();
                }
            }

            @Override // com.sigmob.sdk.base.common.b
            public void b(boolean result, long downloadId) {
                com.sigmob.sdk.base.common.b listener = g.this.getListener();
                if (listener != null) {
                    listener.b(result, downloadId);
                } else if (result) {
                    g.this.h();
                } else {
                    g.this.f();
                }
            }

            @Override // com.sigmob.sdk.base.common.b
            public void c(boolean result, long downloadId) {
                com.sigmob.sdk.base.common.b listener = g.this.getListener();
                if (listener != null) {
                    listener.c(result, downloadId);
                }
                g.this.g();
            }
        }, this.e.getUuid());
        this.c = aPKStatusBroadcastReceiver;
        aPKStatusBroadcastReceiver.a(aPKStatusBroadcastReceiver);
    }

    public void a(com.sigmob.sdk.base.common.b listener) {
        this.d = new WeakReference<>(listener);
    }

    void a(String javascript, ValueCallback callback) {
        SigmobLog.d("Injecting Javascript into MRAID WebView:\n\t" + javascript);
        if (javascript.startsWith("bridge")) {
            javascript = javascript.replaceFirst("bridge", StringUtil.decode(StringUtil.s));
        }
        evaluateJavascript(javascript, callback);
    }

    public void a(boolean enabled) {
    }

    @Override // android.webkit.WebView
    public void addJavascriptInterface(Object object, String key) {
        super.addJavascriptInterface(object, key);
        this.f.add(key);
    }

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    public void b() {
        com.sigmob.sdk.base.utils.w.a(this);
        APKStatusBroadcastReceiver aPKStatusBroadcastReceiver = this.c;
        if (aPKStatusBroadcastReceiver != null) {
            aPKStatusBroadcastReceiver.b(aPKStatusBroadcastReceiver);
            this.c = null;
        }
        setWebViewClient(null);
        removeAllViews();
        Iterator<String> it = this.f.iterator();
        while (it.hasNext()) {
            removeJavascriptInterface(it.next());
        }
        this.f.clear();
        setWebChromeClient(null);
        loadUrl("");
        this.e = null;
    }

    public void b(boolean isFinishing) {
        if (isFinishing) {
            stopLoading();
            loadUrl("");
        }
        onPause();
    }

    public void c() {
        setWebChromeClient(new WebChromeClient() { // from class: com.sigmob.sdk.base.views.g.3
            @Override // android.webkit.WebChromeClient
            public boolean onJsAlert(WebView view, String url, String message, JsResult result) {
                SigmobLog.i(message);
                result.confirm();
                return true;
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsBeforeUnload(WebView view, String url, String message, JsResult result) {
                SigmobLog.i(message);
                result.confirm();
                return true;
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsConfirm(WebView view, String url, String message, JsResult result) {
                SigmobLog.i(message);
                result.confirm();
                return true;
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsPrompt(WebView view, String url, String message, String defaultValue, JsPromptResult result) {
                SigmobLog.i(message);
                result.confirm();
                return true;
            }
        });
    }

    @Override // android.webkit.WebView
    public void destroy() {
        b();
        SigmobLog.d(" BaseWebView destroy called ");
        super.destroy();
    }

    void e() {
        a("bridge.notifyApkDownloadStartEvent();", (ValueCallback) null);
    }

    void f() {
        a("bridge.notifyApkDownloadFailEvent();", (ValueCallback) null);
    }

    void g() {
        a("bridge.notifyApkDownloadPauseEvent();", (ValueCallback) null);
    }

    void h() {
        a("bridge.notifyApkDownloadEndEvent();", (ValueCallback) null);
    }

    void i() {
        a("bridge.notifyApkDownloadInstalledEvent();", (ValueCallback) null);
    }

    @Override // android.webkit.WebView
    public void loadUrl(String url) {
        String url2 = StringUtil.getUrl(url);
        this.g.put("Referer", "");
        BaseAdUnit baseAdUnit = this.e;
        if (baseAdUnit != null && baseAdUnit.isDisablexRequestWith()) {
            this.g.put("X-Requested-With", "");
        }
        loadUrl(url2, this.g);
    }

    public void setAdUnit(BaseAdUnit adUnit) {
        this.e = adUnit;
        if (adUnit == null) {
            return;
        }
        addJavascriptInterface(new ae(getContext(), adUnit, new ae.a() { // from class: com.sigmob.sdk.base.views.g$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.views.ae.a
            public final void onApkDownloadProcess() {
                this.f$0.a();
            }
        }), "sigandroidapk");
        addJavascriptInterface(new af(adUnit, new AnonymousClass1()), "sigandroidh5");
    }
}
