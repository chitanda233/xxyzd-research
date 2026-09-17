package com.kwad.components.core.webview.tachikoma;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Build;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.FrameLayout;
import android.widget.TextView;
import androidx.core.internal.view.SupportMenu;
import com.alipay.sdk.app.AlipayApi;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.video.m;
import com.kwad.components.core.webview.jshandler.aa;
import com.kwad.components.core.webview.jshandler.ab;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.al;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.ar;
import com.kwad.components.core.webview.jshandler.aw;
import com.kwad.components.core.webview.jshandler.ay;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.bd;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.b.v;
import com.kwad.components.core.webview.tachikoma.b.x;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.z;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.components.offline.api.OfflineHostProvider;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.components.offline.api.tk.ITkOfflineCompo;
import com.kwad.components.offline.api.tk.TKDownloadListener;
import com.kwad.components.offline.api.tk.TkLoggerReporter;
import com.kwad.components.offline.api.tk.model.StyleTemplate;
import com.kwad.components.offline.api.tk.model.report.TKPerformMsg;
import com.kwad.sdk.api.proxy.app.FeedDownloadActivity;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.components.l;
import com.kwad.sdk.components.n;
import com.kwad.sdk.components.o;
import com.kwad.sdk.components.q;
import com.kwad.sdk.components.r;
import com.kwad.sdk.components.s;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.export.proxy.AdHttpBodyBuilder;
import com.kwad.sdk.export.proxy.AdHttpFormDataBuilder;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.io.UnsupportedEncodingException;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import java.util.UUID;
import java.util.concurrent.Future;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class i implements com.kwad.components.core.e.e.f, com.kwad.components.core.innerEc.a.g, q, com.kwad.sdk.core.view.c, com.kwad.sdk.core.webview.d.a.a {
    private static Map<Integer, WeakReference<com.kwad.components.core.webview.tachikoma.d.e>> asS = new HashMap();
    private final z AF;
    protected long Cb;
    private long Kc;
    private StyleTemplate akP;
    private long alM;
    private long alN;
    private aw aoD;
    private com.kwad.sdk.core.download.d aoE;
    protected j asA;
    private com.kwad.sdk.core.webview.c.g asB;
    private com.kwad.components.core.offline.a.f.c asC;
    private Future<?> asD;
    private t asE;
    private p asF;
    private ay asG;
    private bc asH;
    private com.kwad.sdk.core.view.e asI;
    private TextView asJ;
    private boolean asK;
    private boolean asL;
    private boolean asM;
    private boolean asN;
    private boolean asO;
    private int asP;
    private long asQ;
    private Map<String, Object> asR;
    private int asT;
    private int asU;
    private boolean asV;
    private String asW;
    private String asX;
    private boolean asY;
    protected com.kwad.sdk.core.webview.e asZ;
    private WeakReference<Activity> asy;
    private com.kwad.components.core.webview.tachikoma.d.e asz;
    private o ata;
    private int atb;
    private long atc;
    private long atd;
    private long ate;
    private long atf;
    private long atg;
    private com.kwad.components.core.webview.tachikoma.a.e ath;
    private KsAdWebView.b ati;
    private a atj;
    private r atk;
    private com.kwad.sdk.components.k atl;
    private final Runnable atm;
    private final Runnable atn;
    private az ff;
    private final m jX;
    private AdResultData mAdResultData;
    protected final Context mContext;

    interface a {
        void onFailed();

        void onSuccess();
    }

    protected void a(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, t tVar, ViewGroup viewGroup) {
    }

    protected void f(String str, String str2) {
    }

    protected void g(String str, String str2) {
    }

    protected boolean py() {
        return false;
    }

    static /* synthetic */ boolean a(i iVar, boolean z) {
        iVar.asK = true;
        return true;
    }

    static /* synthetic */ boolean b(i iVar, boolean z) {
        iVar.asL = true;
        return true;
    }

    static /* synthetic */ boolean c(i iVar, boolean z) {
        iVar.asO = true;
        return true;
    }

    public i(Context context) {
        this(context, true);
    }

    public i(Context context, boolean z) {
        this.asK = false;
        this.asL = false;
        this.asM = false;
        this.asN = false;
        this.asO = false;
        this.asP = 0;
        this.Cb = -1L;
        this.asT = 1000;
        this.asU = 0;
        this.asV = true;
        this.asZ = new com.kwad.sdk.core.webview.e();
        this.ati = new KsAdWebView.b() { // from class: com.kwad.components.core.webview.tachikoma.i.1
            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onSuccess() {
                if (i.this.aoD != null) {
                    i.this.aoD.onSuccess();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onFailed() {
                if (i.this.aoD != null) {
                    i.this.aoD.onFailed();
                }
            }
        };
        this.atj = new a() { // from class: com.kwad.components.core.webview.tachikoma.i.47
            @Override // com.kwad.components.core.webview.tachikoma.i.a
            public final void onSuccess() {
                com.kwad.sdk.core.d.c.d("TKLoadController", "JS执行成功");
            }

            @Override // com.kwad.components.core.webview.tachikoma.i.a
            public final void onFailed() {
                i.this.c(TKRenderFailReason.RENDER_ERROR);
                com.kwad.sdk.core.d.c.d("TKLoadController", "JS执行失败");
            }
        };
        this.atk = new r() { // from class: com.kwad.components.core.webview.tachikoma.i.4
            @Override // com.kwad.sdk.components.r
            public final void a(l lVar) {
                StyleTemplate styleTemplate;
                Activity activityYZ = i.this.yZ();
                if (activityYZ == null) {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null || activityYZ.isFinishing()) {
                    lVar.callbackPageStatus(false, "no host activity");
                    return;
                }
                final String viewKey = lVar.getViewKey();
                if (viewKey == null) {
                    styleTemplate = new StyleTemplate();
                    try {
                        styleTemplate.parseJson(styleTemplate, new JSONObject(lVar.getStyleTemplate()));
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTrace(th);
                        lVar.callbackPageStatus(false, "template parse failed");
                        return;
                    }
                } else {
                    styleTemplate = null;
                }
                com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
                bVar.a(i.this.mAdResultData);
                bVar.c(lVar);
                if (styleTemplate != null) {
                    bVar.a(styleTemplate);
                }
                if (viewKey != null) {
                    bVar.a(new k() { // from class: com.kwad.components.core.webview.tachikoma.i.4.1
                        @Override // com.kwad.components.core.webview.tachikoma.k
                        public final o a(Object... objArr) {
                            if (i.this.asE != null) {
                                return i.this.asE.a(viewKey, objArr);
                            }
                            return null;
                        }
                    });
                }
                com.kwad.components.core.webview.tachikoma.d.e eVarB = com.kwad.components.core.webview.tachikoma.d.e.b(bVar);
                eVarB.show(activityYZ.getFragmentManager(), "");
                i.asS.put(Integer.valueOf(lVar.getDialogId()), new WeakReference(eVarB));
            }

            @Override // com.kwad.sdk.components.r
            public final void b(l lVar) {
                WeakReference weakReference = (WeakReference) i.asS.get(Integer.valueOf(lVar.getDialogId()));
                if (weakReference == null || weakReference.get() == null) {
                    return;
                }
                ((com.kwad.components.core.webview.tachikoma.d.e) weakReference.get()).dismiss();
            }

            /* JADX WARN: Code duplicated, block: B:6:0x0011  */
            @Override // com.kwad.sdk.components.r
            public final void a(n nVar) {
                Activity activityYZ = i.this.yZ();
                if (activityYZ != null) {
                    com.kwad.sdk.core.c.b.Mh();
                    if (activityYZ != com.kwad.sdk.core.c.b.getCurrentActivity()) {
                        com.kwad.sdk.core.c.b.Mh();
                        activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                    }
                } else {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null) {
                    nVar.callbackPageStatus(false, "no host activity");
                    return;
                }
                Intent intent = nVar.getIntent();
                if (!TextUtils.isEmpty(nVar.getTemplateString()) || !TextUtils.isEmpty(nVar.getViewKey())) {
                    com.kwad.sdk.service.c.putComponentProxy(FeedDownloadActivity.class, com.kwad.components.core.s.a.a.class);
                    int iWI = com.kwad.components.core.s.a.a.wI();
                    com.kwad.components.core.s.a.a.a(iWI, "native_intent", nVar);
                    if (i.this.mAdResultData != null) {
                        intent.putExtra("ad_result_cache_idx", com.kwad.components.core.c.f.oR().l(i.this.mAdResultData));
                    }
                    if (!TextUtils.isEmpty(nVar.getTemplateString())) {
                        intent.putExtra("tk_style_template", nVar.getTemplateString());
                    } else {
                        final String viewKey = nVar.getViewKey();
                        com.kwad.components.core.s.a.a.a(iWI, "tk_view_holder", new k() { // from class: com.kwad.components.core.webview.tachikoma.i.4.2
                            @Override // com.kwad.components.core.webview.tachikoma.k
                            public final o a(Object... objArr) {
                                if (i.this.asE != null) {
                                    return i.this.asE.a(viewKey, objArr);
                                }
                                return null;
                            }
                        });
                    }
                    intent.putExtra("tk_id", iWI);
                    intent.setClass(i.this.mContext, FeedDownloadActivity.class);
                } else if (!TextUtils.isEmpty(nVar.getClassName())) {
                    try {
                        com.kwad.sdk.service.c.putComponentProxy(FeedDownloadActivity.class, Class.forName(nVar.getClassName()));
                        intent.setClass(i.this.mContext, FeedDownloadActivity.class);
                    } catch (ClassNotFoundException e) {
                        nVar.callbackPageStatus(false, e.getMessage());
                        return;
                    }
                }
                if (!TextUtils.isEmpty(nVar.getUrl())) {
                    intent.setData(Uri.parse(nVar.getUrl()));
                    int intExtra = intent.getIntExtra("adCacheId", 0);
                    if (intExtra > 0) {
                        com.kwad.components.core.proxy.launchdialog.e.vV().aW(com.kwad.sdk.core.response.helper.c.r(com.kwad.components.core.offline.a.f.a.a.bf(intExtra)));
                    }
                }
                try {
                    activityYZ.startActivity(intent);
                    nVar.callbackPageStatus(true, null);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    nVar.callbackPageStatus(false, th.getMessage());
                }
            }
        };
        this.atl = new com.kwad.sdk.components.k() { // from class: com.kwad.components.core.webview.tachikoma.i.5
            @Override // com.kwad.sdk.components.k
            public final com.kwad.sdk.components.j bX(int i) {
                return i.this.bf(com.kwad.sdk.core.response.helper.c.r(com.kwad.components.core.offline.a.f.a.a.bf(i)));
            }

            @Override // com.kwad.sdk.components.k
            public final com.kwad.sdk.components.j bM(String str) {
                if (TextUtils.isEmpty(str)) {
                    return null;
                }
                try {
                    JSONObject jSONObject = new JSONObject(str);
                    AdTemplate adTemplate = new AdTemplate();
                    adTemplate.parseJson(jSONObject);
                    return i.this.bf(adTemplate);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                    return null;
                }
            }
        };
        this.atm = new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.7
            @Override // java.lang.Runnable
            public final void run() {
                com.kwad.sdk.core.d.c.d("TKLoadController", "mDownloadTimeoutRunnable 已经超时" + i.this.asA.getTkTemplateId());
                i.this.zu();
                i.a(i.this, true);
                i.this.c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            }
        };
        this.atn = new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.8
            @Override // java.lang.Runnable
            public final void run() {
                i.b(i.this, true);
                com.kwad.sdk.core.d.c.d("TKLoadController", "mTKLoadTotalTimeoutRunnable run: " + i.this.asA.getTkTemplateId());
                i.this.c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            }
        };
        this.jX = new m() { // from class: com.kwad.components.core.webview.tachikoma.i.39
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPreparing() {
                e(0.0d);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j, long j2) {
                e(j2);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                e(0.0d);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                i.this.AF.aji = true;
                i.this.AF.auD = false;
                i.this.AF.ri = com.kwad.sdk.core.response.helper.a.N(com.kwad.sdk.core.response.helper.e.eM(i.this.zn()));
                ko();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                i.this.AF.auD = true;
                i.this.AF.aji = false;
                ko();
            }

            private void e(double d) {
                i.this.AF.auD = false;
                i.this.AF.aji = false;
                i.this.AF.ri = (int) ((d / 1000.0d) + 0.5d);
                ko();
            }

            private void ko() {
                if (i.this.asF == null || i.this.AF == null) {
                    return;
                }
                i.this.asF.a(i.this.AF);
            }
        };
        this.mContext = context;
        this.Cb = -1L;
        this.asT = 1000;
        this.asV = z;
        this.AF = new z();
    }

    public i(long j, Context context) {
        this.asK = false;
        this.asL = false;
        this.asM = false;
        this.asN = false;
        this.asO = false;
        this.asP = 0;
        this.Cb = -1L;
        this.asT = 1000;
        this.asU = 0;
        this.asV = true;
        this.asZ = new com.kwad.sdk.core.webview.e();
        this.ati = new KsAdWebView.b() { // from class: com.kwad.components.core.webview.tachikoma.i.1
            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onSuccess() {
                if (i.this.aoD != null) {
                    i.this.aoD.onSuccess();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onFailed() {
                if (i.this.aoD != null) {
                    i.this.aoD.onFailed();
                }
            }
        };
        this.atj = new a() { // from class: com.kwad.components.core.webview.tachikoma.i.47
            @Override // com.kwad.components.core.webview.tachikoma.i.a
            public final void onSuccess() {
                com.kwad.sdk.core.d.c.d("TKLoadController", "JS执行成功");
            }

            @Override // com.kwad.components.core.webview.tachikoma.i.a
            public final void onFailed() {
                i.this.c(TKRenderFailReason.RENDER_ERROR);
                com.kwad.sdk.core.d.c.d("TKLoadController", "JS执行失败");
            }
        };
        this.atk = new r() { // from class: com.kwad.components.core.webview.tachikoma.i.4
            @Override // com.kwad.sdk.components.r
            public final void a(l lVar) {
                StyleTemplate styleTemplate;
                Activity activityYZ = i.this.yZ();
                if (activityYZ == null) {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null || activityYZ.isFinishing()) {
                    lVar.callbackPageStatus(false, "no host activity");
                    return;
                }
                final String viewKey = lVar.getViewKey();
                if (viewKey == null) {
                    styleTemplate = new StyleTemplate();
                    try {
                        styleTemplate.parseJson(styleTemplate, new JSONObject(lVar.getStyleTemplate()));
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTrace(th);
                        lVar.callbackPageStatus(false, "template parse failed");
                        return;
                    }
                } else {
                    styleTemplate = null;
                }
                com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
                bVar.a(i.this.mAdResultData);
                bVar.c(lVar);
                if (styleTemplate != null) {
                    bVar.a(styleTemplate);
                }
                if (viewKey != null) {
                    bVar.a(new k() { // from class: com.kwad.components.core.webview.tachikoma.i.4.1
                        @Override // com.kwad.components.core.webview.tachikoma.k
                        public final o a(Object... objArr) {
                            if (i.this.asE != null) {
                                return i.this.asE.a(viewKey, objArr);
                            }
                            return null;
                        }
                    });
                }
                com.kwad.components.core.webview.tachikoma.d.e eVarB = com.kwad.components.core.webview.tachikoma.d.e.b(bVar);
                eVarB.show(activityYZ.getFragmentManager(), "");
                i.asS.put(Integer.valueOf(lVar.getDialogId()), new WeakReference(eVarB));
            }

            @Override // com.kwad.sdk.components.r
            public final void b(l lVar) {
                WeakReference weakReference = (WeakReference) i.asS.get(Integer.valueOf(lVar.getDialogId()));
                if (weakReference == null || weakReference.get() == null) {
                    return;
                }
                ((com.kwad.components.core.webview.tachikoma.d.e) weakReference.get()).dismiss();
            }

            /* JADX WARN: Code duplicated, block: B:6:0x0011  */
            @Override // com.kwad.sdk.components.r
            public final void a(n nVar) {
                Activity activityYZ = i.this.yZ();
                if (activityYZ != null) {
                    com.kwad.sdk.core.c.b.Mh();
                    if (activityYZ != com.kwad.sdk.core.c.b.getCurrentActivity()) {
                        com.kwad.sdk.core.c.b.Mh();
                        activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                    }
                } else {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null) {
                    nVar.callbackPageStatus(false, "no host activity");
                    return;
                }
                Intent intent = nVar.getIntent();
                if (!TextUtils.isEmpty(nVar.getTemplateString()) || !TextUtils.isEmpty(nVar.getViewKey())) {
                    com.kwad.sdk.service.c.putComponentProxy(FeedDownloadActivity.class, com.kwad.components.core.s.a.a.class);
                    int iWI = com.kwad.components.core.s.a.a.wI();
                    com.kwad.components.core.s.a.a.a(iWI, "native_intent", nVar);
                    if (i.this.mAdResultData != null) {
                        intent.putExtra("ad_result_cache_idx", com.kwad.components.core.c.f.oR().l(i.this.mAdResultData));
                    }
                    if (!TextUtils.isEmpty(nVar.getTemplateString())) {
                        intent.putExtra("tk_style_template", nVar.getTemplateString());
                    } else {
                        final String viewKey = nVar.getViewKey();
                        com.kwad.components.core.s.a.a.a(iWI, "tk_view_holder", new k() { // from class: com.kwad.components.core.webview.tachikoma.i.4.2
                            @Override // com.kwad.components.core.webview.tachikoma.k
                            public final o a(Object... objArr) {
                                if (i.this.asE != null) {
                                    return i.this.asE.a(viewKey, objArr);
                                }
                                return null;
                            }
                        });
                    }
                    intent.putExtra("tk_id", iWI);
                    intent.setClass(i.this.mContext, FeedDownloadActivity.class);
                } else if (!TextUtils.isEmpty(nVar.getClassName())) {
                    try {
                        com.kwad.sdk.service.c.putComponentProxy(FeedDownloadActivity.class, Class.forName(nVar.getClassName()));
                        intent.setClass(i.this.mContext, FeedDownloadActivity.class);
                    } catch (ClassNotFoundException e) {
                        nVar.callbackPageStatus(false, e.getMessage());
                        return;
                    }
                }
                if (!TextUtils.isEmpty(nVar.getUrl())) {
                    intent.setData(Uri.parse(nVar.getUrl()));
                    int intExtra = intent.getIntExtra("adCacheId", 0);
                    if (intExtra > 0) {
                        com.kwad.components.core.proxy.launchdialog.e.vV().aW(com.kwad.sdk.core.response.helper.c.r(com.kwad.components.core.offline.a.f.a.a.bf(intExtra)));
                    }
                }
                try {
                    activityYZ.startActivity(intent);
                    nVar.callbackPageStatus(true, null);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    nVar.callbackPageStatus(false, th.getMessage());
                }
            }
        };
        this.atl = new com.kwad.sdk.components.k() { // from class: com.kwad.components.core.webview.tachikoma.i.5
            @Override // com.kwad.sdk.components.k
            public final com.kwad.sdk.components.j bX(int i) {
                return i.this.bf(com.kwad.sdk.core.response.helper.c.r(com.kwad.components.core.offline.a.f.a.a.bf(i)));
            }

            @Override // com.kwad.sdk.components.k
            public final com.kwad.sdk.components.j bM(String str) {
                if (TextUtils.isEmpty(str)) {
                    return null;
                }
                try {
                    JSONObject jSONObject = new JSONObject(str);
                    AdTemplate adTemplate = new AdTemplate();
                    adTemplate.parseJson(jSONObject);
                    return i.this.bf(adTemplate);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                    return null;
                }
            }
        };
        this.atm = new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.7
            @Override // java.lang.Runnable
            public final void run() {
                com.kwad.sdk.core.d.c.d("TKLoadController", "mDownloadTimeoutRunnable 已经超时" + i.this.asA.getTkTemplateId());
                i.this.zu();
                i.a(i.this, true);
                i.this.c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            }
        };
        this.atn = new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.8
            @Override // java.lang.Runnable
            public final void run() {
                i.b(i.this, true);
                com.kwad.sdk.core.d.c.d("TKLoadController", "mTKLoadTotalTimeoutRunnable run: " + i.this.asA.getTkTemplateId());
                i.this.c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            }
        };
        this.jX = new m() { // from class: com.kwad.components.core.webview.tachikoma.i.39
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPreparing() {
                e(0.0d);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j2, long j3) {
                e(j3);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                e(0.0d);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                i.this.AF.aji = true;
                i.this.AF.auD = false;
                i.this.AF.ri = com.kwad.sdk.core.response.helper.a.N(com.kwad.sdk.core.response.helper.e.eM(i.this.zn()));
                ko();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                i.this.AF.auD = true;
                i.this.AF.aji = false;
                ko();
            }

            private void e(double d) {
                i.this.AF.auD = false;
                i.this.AF.aji = false;
                i.this.AF.ri = (int) ((d / 1000.0d) + 0.5d);
                ko();
            }

            private void ko() {
                if (i.this.asF == null || i.this.AF == null) {
                    return;
                }
                i.this.asF.a(i.this.AF);
            }
        };
        this.mContext = context;
        this.Cb = j;
        this.AF = new z();
    }

    public i(Context context, int i, int i2) {
        this.asK = false;
        this.asL = false;
        this.asM = false;
        this.asN = false;
        this.asO = false;
        this.asP = 0;
        this.Cb = -1L;
        this.asT = 1000;
        this.asU = 0;
        this.asV = true;
        this.asZ = new com.kwad.sdk.core.webview.e();
        this.ati = new KsAdWebView.b() { // from class: com.kwad.components.core.webview.tachikoma.i.1
            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onSuccess() {
                if (i.this.aoD != null) {
                    i.this.aoD.onSuccess();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onFailed() {
                if (i.this.aoD != null) {
                    i.this.aoD.onFailed();
                }
            }
        };
        this.atj = new a() { // from class: com.kwad.components.core.webview.tachikoma.i.47
            @Override // com.kwad.components.core.webview.tachikoma.i.a
            public final void onSuccess() {
                com.kwad.sdk.core.d.c.d("TKLoadController", "JS执行成功");
            }

            @Override // com.kwad.components.core.webview.tachikoma.i.a
            public final void onFailed() {
                i.this.c(TKRenderFailReason.RENDER_ERROR);
                com.kwad.sdk.core.d.c.d("TKLoadController", "JS执行失败");
            }
        };
        this.atk = new r() { // from class: com.kwad.components.core.webview.tachikoma.i.4
            @Override // com.kwad.sdk.components.r
            public final void a(l lVar) {
                StyleTemplate styleTemplate;
                Activity activityYZ = i.this.yZ();
                if (activityYZ == null) {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null || activityYZ.isFinishing()) {
                    lVar.callbackPageStatus(false, "no host activity");
                    return;
                }
                final String viewKey = lVar.getViewKey();
                if (viewKey == null) {
                    styleTemplate = new StyleTemplate();
                    try {
                        styleTemplate.parseJson(styleTemplate, new JSONObject(lVar.getStyleTemplate()));
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTrace(th);
                        lVar.callbackPageStatus(false, "template parse failed");
                        return;
                    }
                } else {
                    styleTemplate = null;
                }
                com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
                bVar.a(i.this.mAdResultData);
                bVar.c(lVar);
                if (styleTemplate != null) {
                    bVar.a(styleTemplate);
                }
                if (viewKey != null) {
                    bVar.a(new k() { // from class: com.kwad.components.core.webview.tachikoma.i.4.1
                        @Override // com.kwad.components.core.webview.tachikoma.k
                        public final o a(Object... objArr) {
                            if (i.this.asE != null) {
                                return i.this.asE.a(viewKey, objArr);
                            }
                            return null;
                        }
                    });
                }
                com.kwad.components.core.webview.tachikoma.d.e eVarB = com.kwad.components.core.webview.tachikoma.d.e.b(bVar);
                eVarB.show(activityYZ.getFragmentManager(), "");
                i.asS.put(Integer.valueOf(lVar.getDialogId()), new WeakReference(eVarB));
            }

            @Override // com.kwad.sdk.components.r
            public final void b(l lVar) {
                WeakReference weakReference = (WeakReference) i.asS.get(Integer.valueOf(lVar.getDialogId()));
                if (weakReference == null || weakReference.get() == null) {
                    return;
                }
                ((com.kwad.components.core.webview.tachikoma.d.e) weakReference.get()).dismiss();
            }

            /* JADX WARN: Code duplicated, block: B:6:0x0011  */
            @Override // com.kwad.sdk.components.r
            public final void a(n nVar) {
                Activity activityYZ = i.this.yZ();
                if (activityYZ != null) {
                    com.kwad.sdk.core.c.b.Mh();
                    if (activityYZ != com.kwad.sdk.core.c.b.getCurrentActivity()) {
                        com.kwad.sdk.core.c.b.Mh();
                        activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                    }
                } else {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null) {
                    nVar.callbackPageStatus(false, "no host activity");
                    return;
                }
                Intent intent = nVar.getIntent();
                if (!TextUtils.isEmpty(nVar.getTemplateString()) || !TextUtils.isEmpty(nVar.getViewKey())) {
                    com.kwad.sdk.service.c.putComponentProxy(FeedDownloadActivity.class, com.kwad.components.core.s.a.a.class);
                    int iWI = com.kwad.components.core.s.a.a.wI();
                    com.kwad.components.core.s.a.a.a(iWI, "native_intent", nVar);
                    if (i.this.mAdResultData != null) {
                        intent.putExtra("ad_result_cache_idx", com.kwad.components.core.c.f.oR().l(i.this.mAdResultData));
                    }
                    if (!TextUtils.isEmpty(nVar.getTemplateString())) {
                        intent.putExtra("tk_style_template", nVar.getTemplateString());
                    } else {
                        final String viewKey = nVar.getViewKey();
                        com.kwad.components.core.s.a.a.a(iWI, "tk_view_holder", new k() { // from class: com.kwad.components.core.webview.tachikoma.i.4.2
                            @Override // com.kwad.components.core.webview.tachikoma.k
                            public final o a(Object... objArr) {
                                if (i.this.asE != null) {
                                    return i.this.asE.a(viewKey, objArr);
                                }
                                return null;
                            }
                        });
                    }
                    intent.putExtra("tk_id", iWI);
                    intent.setClass(i.this.mContext, FeedDownloadActivity.class);
                } else if (!TextUtils.isEmpty(nVar.getClassName())) {
                    try {
                        com.kwad.sdk.service.c.putComponentProxy(FeedDownloadActivity.class, Class.forName(nVar.getClassName()));
                        intent.setClass(i.this.mContext, FeedDownloadActivity.class);
                    } catch (ClassNotFoundException e) {
                        nVar.callbackPageStatus(false, e.getMessage());
                        return;
                    }
                }
                if (!TextUtils.isEmpty(nVar.getUrl())) {
                    intent.setData(Uri.parse(nVar.getUrl()));
                    int intExtra = intent.getIntExtra("adCacheId", 0);
                    if (intExtra > 0) {
                        com.kwad.components.core.proxy.launchdialog.e.vV().aW(com.kwad.sdk.core.response.helper.c.r(com.kwad.components.core.offline.a.f.a.a.bf(intExtra)));
                    }
                }
                try {
                    activityYZ.startActivity(intent);
                    nVar.callbackPageStatus(true, null);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    nVar.callbackPageStatus(false, th.getMessage());
                }
            }
        };
        this.atl = new com.kwad.sdk.components.k() { // from class: com.kwad.components.core.webview.tachikoma.i.5
            @Override // com.kwad.sdk.components.k
            public final com.kwad.sdk.components.j bX(int i3) {
                return i.this.bf(com.kwad.sdk.core.response.helper.c.r(com.kwad.components.core.offline.a.f.a.a.bf(i3)));
            }

            @Override // com.kwad.sdk.components.k
            public final com.kwad.sdk.components.j bM(String str) {
                if (TextUtils.isEmpty(str)) {
                    return null;
                }
                try {
                    JSONObject jSONObject = new JSONObject(str);
                    AdTemplate adTemplate = new AdTemplate();
                    adTemplate.parseJson(jSONObject);
                    return i.this.bf(adTemplate);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                    return null;
                }
            }
        };
        this.atm = new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.7
            @Override // java.lang.Runnable
            public final void run() {
                com.kwad.sdk.core.d.c.d("TKLoadController", "mDownloadTimeoutRunnable 已经超时" + i.this.asA.getTkTemplateId());
                i.this.zu();
                i.a(i.this, true);
                i.this.c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            }
        };
        this.atn = new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.8
            @Override // java.lang.Runnable
            public final void run() {
                i.b(i.this, true);
                com.kwad.sdk.core.d.c.d("TKLoadController", "mTKLoadTotalTimeoutRunnable run: " + i.this.asA.getTkTemplateId());
                i.this.c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            }
        };
        this.jX = new m() { // from class: com.kwad.components.core.webview.tachikoma.i.39
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPreparing() {
                e(0.0d);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j2, long j3) {
                e(j3);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                e(0.0d);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                i.this.AF.aji = true;
                i.this.AF.auD = false;
                i.this.AF.ri = com.kwad.sdk.core.response.helper.a.N(com.kwad.sdk.core.response.helper.e.eM(i.this.zn()));
                ko();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i3, int i4) {
                i.this.AF.auD = true;
                i.this.AF.aji = false;
                ko();
            }

            private void e(double d) {
                i.this.AF.auD = false;
                i.this.AF.aji = false;
                i.this.AF.ri = (int) ((d / 1000.0d) + 0.5d);
                ko();
            }

            private void ko() {
                if (i.this.asF == null || i.this.AF == null) {
                    return;
                }
                i.this.asF.a(i.this.AF);
            }
        };
        this.mContext = context;
        this.asT = i;
        this.AF = new z();
        this.asU = i2;
    }

    public final void a(StyleTemplate styleTemplate) {
        this.akP = styleTemplate;
    }

    public final com.kwad.sdk.core.webview.b yY() {
        return this.asZ;
    }

    public void a(Activity activity, AdResultData adResultData, j jVar) {
        this.asy = new WeakReference<>(activity);
        this.mAdResultData = adResultData;
        this.asZ.a(adResultData);
        this.asA = jVar;
        this.asW = jVar.getTkTemplateId();
        this.asX = this.asA.getTKReaderScene();
        zi();
        FrameLayout tKContainer = this.asA.getTKContainer();
        if (tKContainer != null) {
            tKContainer.removeAllViews();
        }
        if (!com.kwad.sdk.core.config.e.JX()) {
            c(TKRenderFailReason.SWITCH_CLOSE);
            return;
        }
        this.asC = (com.kwad.components.core.offline.a.f.c) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.f.c.class);
        zp();
        com.kwad.sdk.core.d.c.d("TKLoadController", "bind mTKPlugin: " + this.asC);
        if (TextUtils.isEmpty(this.asW)) {
            com.kwad.sdk.commercial.d.a.n(zn(), this.asX);
        }
        if (this.asC != null) {
            if (zg()) {
                za();
                return;
            } else {
                zj();
                return;
            }
        }
        c(TKRenderFailReason.PLUGIN_NOT_READY);
        f(this.asW, TKPerformMsg.ERROR_REASON.KSAD_TK_OFFLINE_FAILED);
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.ERROR_LOG, new TKPerformMsg(this.asP).setRenderState(4).setErrorReason(TKPerformMsg.ERROR_REASON.KSAD_TK_OFFLINE_FAILED).setTemplateId(this.asW).toJson());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Activity yZ() {
        WeakReference<Activity> weakReference = this.asy;
        if (weakReference == null || weakReference.get() == null) {
            return null;
        }
        return this.asy.get();
    }

    private void za() {
        StyleTemplate styleTemplateZl = zl();
        if (styleTemplateZl == null) {
            bI("no template");
            return;
        }
        int iB = b(styleTemplateZl);
        this.atb = iB;
        try {
            t tVarA = com.kwad.components.core.t.k.a(Integer.valueOf(iB));
            if (tVarA != null) {
                long jElapsedRealtime = SystemClock.elapsedRealtime();
                this.asQ = jElapsedRealtime;
                this.atf = jElapsedRealtime;
                a(tVarA);
                return;
            }
            if (com.kwad.components.core.webview.tachikoma.e.b.zQ().cc(this.atb)) {
                zj();
            } else {
                this.atc = SystemClock.elapsedRealtime();
                com.kwad.components.core.webview.tachikoma.e.b.zQ().a(this.atb, new com.kwad.components.core.webview.tachikoma.f.f() { // from class: com.kwad.components.core.webview.tachikoma.i.12
                    @Override // com.kwad.components.core.webview.tachikoma.f.f
                    public final void zA() {
                        i.this.d(TKRenderFailReason.RENDER_ERROR);
                        i.this.bL(TKPerformMsg.ERROR_REASON.KSAD_TK_RENDER_FAIL);
                    }

                    @Override // com.kwad.components.core.webview.tachikoma.f.f
                    public final void zB() {
                        com.kwad.components.core.t.k.a aVarB = com.kwad.components.core.t.k.b(Integer.valueOf(i.this.atb));
                        t tVarXd = aVarB.xd();
                        i.this.alM = aVarB.wZ();
                        i.this.alN = aVarB.xb();
                        i.this.Kc = aVarB.xa();
                        i.this.atd = aVarB.xc();
                        i.this.asQ = SystemClock.elapsedRealtime();
                        i iVar = i.this;
                        iVar.atf = iVar.asQ;
                        i.this.zb();
                        i.this.a(tVarXd);
                    }
                });
            }
        } catch (Exception e) {
            c(TKRenderFailReason.RENDER_ERROR);
            bL(e.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void zb() {
        long j = this.atc;
        long j2 = this.atd;
        if (j >= j2) {
            this.alM = 0L;
            this.alN = 0L;
            this.Kc = 0L;
            this.ate = 0L;
            return;
        }
        long j3 = this.alN;
        long j4 = this.alM;
        if (j >= j3 + j4) {
            this.alM = 0L;
            this.alN = 0L;
            this.Kc = 0L;
            this.ate = j2 - j;
            this.asQ = j2;
            return;
        }
        if (j3 >= j && j >= this.Kc) {
            this.Kc = j;
        } else if (j3 + j4 > j) {
            this.alM = (j3 + j4) - this.Kc;
            this.alN = 0L;
            this.Kc = 0L;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Multi-variable type inference failed */
    public void a(t tVar) {
        try {
            com.kwad.sdk.core.d.c.d("TKLoadController", "renderTKTemplate start tachikomaContext: " + tVar);
            if (this.akP == null) {
                this.akP = zl();
            }
            if (tVar == null) {
                return;
            }
            this.asE = tVar;
            zq();
            int iHashCode = this.mAdResultData.hashCode();
            com.kwad.components.core.offline.a.f.a.a.a(iHashCode, this.mAdResultData);
            this.mAdResultData.mAdCacheId = iHashCode;
            com.kwad.sdk.core.d.c.d("TKLoadController", "renderTKTemplate tachikomaContext is not null");
            o oVarA = tVar.a(this.asA.getRegisterViewKey(), new af.a(this.mAdResultData).toJson().toString(), zd(), zc());
            com.kwad.sdk.core.d.c.d("TKLoadController", "renderTKTemplate itkView: " + oVarA);
            this.ata = oVarA;
            ze();
            View view = oVarA.getView();
            com.kwad.sdk.core.d.c.d("TKLoadController", "renderTKTemplate itkView getView: " + view);
            if (view != null) {
                FrameLayout tKContainer = this.asA.getTKContainer();
                if (tKContainer != 0 && this.asV) {
                    if (tKContainer instanceof com.kwad.sdk.core.view.e) {
                        com.kwad.sdk.core.view.e eVar = (com.kwad.sdk.core.view.e) tKContainer;
                        this.asI = eVar;
                        eVar.getWindowFocusChangeHelper().a(this);
                    }
                    view.setLayoutParams(new FrameLayout.LayoutParams(-1, -1));
                    tKContainer.addView(view);
                }
                d(zl());
                zy();
                return;
            }
            com.kwad.components.core.t.k.c(Integer.valueOf(this.atb));
            c(TKRenderFailReason.RENDER_ERROR);
            bL(TKPerformMsg.ERROR_REASON.KSAD_TK_RENDER_FAIL);
            com.kwad.sdk.core.d.c.d("TKLoadController", "renderTKTemplate start end: ");
        } catch (Exception e) {
            com.kwad.components.core.t.k.c(Integer.valueOf(this.atb));
            c(TKRenderFailReason.RENDER_ERROR);
            bL(e.getMessage());
            ServiceProvider.reportSdkCaughtException(e);
        }
    }

    private static String zc() {
        ai.a aVar = new ai.a();
        aVar.screenOrientation = !as.isOrientationPortrait() ? 1 : 0;
        return aVar.toJson().toString();
    }

    private String zd() {
        ae.a aVar = new ae.a();
        j jVar = this.asA;
        if (jVar != null) {
            jVar.a(aVar);
        } else {
            aVar.width = this.asZ.adZ.getWidth();
            aVar.height = this.asZ.adZ.getHeight();
        }
        return aVar.toJson().toString();
    }

    private void ze() {
        zm();
        this.asA.aD();
        zf();
        a("setCloseAction", (String) null, new com.kwad.components.core.webview.tachikoma.a.b() { // from class: com.kwad.components.core.webview.tachikoma.i.23
            @Override // com.kwad.components.core.webview.tachikoma.a.b
            public final void c(WebCloseStatus webCloseStatus) {
                if (i.this.asA != null) {
                    i.this.asA.a(webCloseStatus);
                }
            }
        });
        a("setAdOutClickCallback", (String) null, new com.kwad.components.core.webview.tachikoma.a.c() { // from class: com.kwad.components.core.webview.tachikoma.i.34
            @Override // com.kwad.components.core.webview.tachikoma.a.c
            public final void b(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
                if (i.this.asA != null) {
                    i.this.asA.a(c0464a);
                }
            }
        });
        a("setUpdatePositionCallback", (String) null, new com.kwad.components.core.webview.tachikoma.a.f() { // from class: com.kwad.components.core.webview.tachikoma.i.43
            @Override // com.kwad.components.core.webview.tachikoma.a.f
            public final void a(al.a aVar) {
                i.this.b(aVar);
            }
        });
        a("setCancelDownloadCallback", (String) null, new com.kwad.components.core.webview.tachikoma.a.d() { // from class: com.kwad.components.core.webview.tachikoma.i.44
            @Override // com.kwad.components.core.webview.tachikoma.a.d
            public final AdTemplate zC() {
                return i.this.zn();
            }
        });
    }

    private void zf() {
        com.kwad.components.core.e.d.d dVar = zn() != null ? new com.kwad.components.core.e.d.d(zn()) : null;
        this.ath = new com.kwad.components.core.webview.tachikoma.a.e(dVar, this.asZ, this.ata);
        a("setClickAction", (String) null, new com.kwad.components.core.webview.tachikoma.a.a(yY(), dVar, this, true));
    }

    private static int b(StyleTemplate styleTemplate) {
        if (styleTemplate == null) {
            return 0;
        }
        return (styleTemplate.templateId + " " + styleTemplate.templateVersionCode).hashCode();
    }

    public final Object a(String str, String str2, com.kwad.sdk.components.m mVar) {
        o oVar = this.ata;
        if (oVar != null) {
            return oVar.b(str, str2, mVar);
        }
        return null;
    }

    private boolean zg() {
        try {
            boolean z = (this.asX.equals("tk_feed_tk_card") && com.kwad.sdk.core.config.e.KT()) || this.asX.equals("tk_draw_card");
            this.asY = z;
            return z;
        } catch (Exception unused) {
            return false;
        }
    }

    public final boolean zh() {
        return this.asY;
    }

    public final void a(com.kwad.sdk.core.webview.c.g gVar) {
        this.asB = gVar;
    }

    private void zi() {
        this.asM = false;
        this.asN = false;
        this.asK = false;
        this.asL = false;
        this.asO = false;
        this.Kc = 0L;
        this.alN = 0L;
        this.alM = 0L;
        this.asQ = 0L;
    }

    private void zj() {
        if (isLocalDebugEnable()) {
            this.asT = 2000;
            this.asU = 3000;
        }
        by.runOnUiThreadDelay(this.atm, this.asT);
        int i = this.asU;
        if (i > 0) {
            by.runOnUiThreadDelay(this.atn, i);
        }
        this.asD = GlobalThreadPools.Om().submit(new bi() { // from class: com.kwad.components.core.webview.tachikoma.i.45
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                i.this.Kc = SystemClock.elapsedRealtime();
                com.kwad.sdk.core.d.c.d("TKLoadController", "开始读取模板 id: " + i.this.asA.getTkTemplateId());
                i.this.a(new TKDownloadListener() { // from class: com.kwad.components.core.webview.tachikoma.i.45.1
                    @Override // com.kwad.components.offline.api.tk.TKDownloadListener
                    public final void onSuccess(StyleTemplate styleTemplate) {
                        i.this.c(styleTemplate);
                    }

                    @Override // com.kwad.components.offline.api.tk.TKDownloadListener
                    public final void onFailed(String str) {
                        i.this.bI(str);
                    }
                });
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(final StyleTemplate styleTemplate) {
        com.kwad.sdk.utils.l.b("", "renderType_tk", styleTemplate.templateId, styleTemplate.templateUrl);
        com.kwad.sdk.core.d.c.d("TKLoadController", "读取完毕，总耗时" + (SystemClock.elapsedRealtime() - this.Kc) + ", 读取成功" + styleTemplate.templateId);
        if (this.asK) {
            return;
        }
        com.kwad.sdk.core.d.c.d("TKLoadController", "没有超时");
        by.b(this.atm);
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.i.46
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                i iVar = i.this;
                iVar.a(styleTemplate, iVar.atj);
            }
        });
        ViewParent tKContainer = this.asA.getTKContainer();
        if (tKContainer instanceof com.kwad.sdk.core.view.e) {
            com.kwad.sdk.core.view.e eVar = (com.kwad.sdk.core.view.e) tKContainer;
            this.asI = eVar;
            eVar.getWindowFocusChangeHelper().a(this);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bI(String str) {
        c(TKRenderFailReason.TK_FILE_LOAD_ERROR);
        bK(str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(TKDownloadListener tKDownloadListener) {
        StyleTemplate styleTemplateZl = zl();
        if (styleTemplateZl == null) {
            tKDownloadListener.onFailed("no template");
            return;
        }
        if (!isLocalDebugEnable()) {
            String strO = h.yW().o(styleTemplateZl.templateId, styleTemplateZl.templateVersionCode);
            if (!TextUtils.isEmpty(strO) && !isLocalDebugEnable()) {
                styleTemplateZl.jsStr = strO;
                styleTemplateZl.tkSouce = 4;
                com.kwad.sdk.core.d.c.d("TKLoadController", "使用TK模板缓存");
                tKDownloadListener.onSuccess(styleTemplateZl);
                return;
            }
        }
        this.asC.loadTkFileByTemplateId(this.mContext, styleTemplateZl.templateId, styleTemplateZl.templateMd5, styleTemplateZl.templateUrl, styleTemplateZl.templateVersionCode, tKDownloadListener);
    }

    private static boolean isLocalDebugEnable() {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return false;
    }

    private static boolean zk() {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return false;
    }

    private static StyleTemplate bJ(String str) {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return null;
    }

    private StyleTemplate zl() {
        AdMatrixInfo.MatrixTemplate matrixTemplateT;
        String tkTemplateId = this.asA.getTkTemplateId();
        StyleTemplate styleTemplate = this.akP;
        if (styleTemplate != null) {
            tkTemplateId = styleTemplate.templateId;
        }
        StyleTemplate styleTemplateBJ = bJ(tkTemplateId);
        if (styleTemplateBJ != null) {
            return styleTemplateBJ;
        }
        if (isLocalDebugEnable()) {
            StyleTemplate styleTemplate2 = new StyleTemplate();
            styleTemplate2.templateId = tkTemplateId;
            styleTemplate2.templateVersion = "1.0.4";
            styleTemplate2.templateVersionCode = 104;
            if (zk()) {
                styleTemplate2.templateUrl = "http://" + OfflineHostProvider.getApi().env().localIpAddress() + ":24680/" + tkTemplateId + ".104.coverage.zip";
            } else {
                styleTemplate2.templateUrl = "http://" + OfflineHostProvider.getApi().env().localIpAddress() + ":24680/" + tkTemplateId + ".104.zip";
            }
            return styleTemplate2;
        }
        StyleTemplate styleTemplate3 = this.akP;
        if (styleTemplate3 != null) {
            return styleTemplate3;
        }
        AdTemplate adTemplateZn = zn();
        if (adTemplateZn == null || (matrixTemplateT = com.kwad.sdk.core.response.helper.b.t(adTemplateZn, this.asA.getTkTemplateId())) == null) {
            return null;
        }
        com.kwad.components.core.offline.a.f.c cVar = this.asC;
        if (cVar == null) {
            StyleTemplate styleTemplate4 = new StyleTemplate();
            styleTemplate4.templateId = matrixTemplateT.templateId;
            styleTemplate4.templateMd5 = matrixTemplateT.templateMd5;
            styleTemplate4.templateUrl = matrixTemplateT.templateUrl;
            styleTemplate4.templateVersionCode = (int) matrixTemplateT.templateVersionCode;
            styleTemplate4.tkSouce = 0;
            return styleTemplate4;
        }
        return cVar.checkStyleTemplateById(this.mContext, matrixTemplateT.templateId, matrixTemplateT.templateMd5, matrixTemplateT.templateUrl, (int) matrixTemplateT.templateVersionCode);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(StyleTemplate styleTemplate, a aVar) {
        this.akP = styleTemplate;
        com.kwad.sdk.core.d.c.w("TKLoadController", "addTKView mTKPlugin.getState(): " + this.asC.getState());
        if (this.asC.getState() == ITkOfflineCompo.TKState.SO_FAIL) {
            bK(TKPerformMsg.ERROR_REASON.KSAD_TK_SO_FAIL);
            if (aVar != null) {
                aVar.onFailed();
                return;
            }
            return;
        }
        com.kwad.sdk.core.d.c.w("TKLoadController", "addTKView TextUtils.isEmpty(styleTemplate.jsStr) " + TextUtils.isEmpty(styleTemplate.jsStr));
        if (TextUtils.isEmpty(styleTemplate.jsStr)) {
            bL(TKPerformMsg.ERROR_REASON.KSAD_TK_NO_TEMPLATE);
            if (aVar != null) {
                aVar.onFailed();
                return;
            }
            return;
        }
        try {
            com.kwad.sdk.core.d.c.w("TKLoadController", "addTKView isReuseTKContext: " + this.asY);
            if (this.asY) {
                b(styleTemplate, aVar);
            } else {
                c(styleTemplate, aVar);
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
            m(th);
            if (aVar != null) {
                aVar.onFailed();
            }
        }
    }

    private void b(StyleTemplate styleTemplate, final a aVar) {
        com.kwad.sdk.core.d.c.w("TKLoadController", "registerTKViewNew start center1: ");
        zq();
        this.alN = SystemClock.elapsedRealtime();
        t tVarA = this.asC.a(this.mContext, styleTemplate.templateId, styleTemplate.templateVersionCode, styleTemplate.tkSouce, this.asV);
        com.kwad.components.core.offline.a.f.a.a.a(this.mAdResultData.hashCode(), this.mAdResultData);
        tVarA.a(this.atk);
        tVarA.a(this.atl);
        if (this.akP != null) {
            zv().put("styleTemplate", this.akP.toJson().toString());
        }
        zv().put(AlipayApi.c, ServiceProvider.getAppId());
        zv().put("isDebug", com.kwad.components.core.a.oV);
        zv().put("newRenderType", Boolean.valueOf(this.asY));
        tVarA.setCustomEnv(zv());
        this.asE = tVarA;
        com.kwad.sdk.core.d.c.w("TKLoadController", "registerTKViewNew center1: ");
        com.kwad.sdk.core.c.b.Mh();
        Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
        if (currentActivity != null) {
            ViewGroup viewGroup = (ViewGroup) currentActivity.getWindow().getDecorView();
            zv().put("isImmersiveMode", Boolean.valueOf(com.kwad.sdk.c.a.a.J(viewGroup) && com.kwad.sdk.c.a.a.bz(currentActivity) == viewGroup.getHeight()));
        }
        tVarA.setCustomEnv(zv());
        com.kwad.sdk.core.webview.c.g gVar = this.asB;
        if (gVar != null) {
            tVarA.b(gVar);
        }
        this.alM = SystemClock.elapsedRealtime() - this.alN;
        this.asQ = SystemClock.elapsedRealtime();
        c(tVarA);
        tVarA.a(styleTemplate.jsStr, new File(this.asC.getJsBaseDir(this.mContext, this.asA.getTkTemplateId())).getAbsolutePath() + "/", new s() { // from class: com.kwad.components.core.webview.tachikoma.i.2
            @Override // com.kwad.sdk.components.s
            public final void onSuccess() {
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.onSuccess();
                }
            }

            @Override // com.kwad.sdk.components.s
            public final void onFailed(Throwable th) {
                com.kwad.sdk.core.d.c.w("TKLoadController", "registerTKViewNew onFailed: " + th.getMessage());
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.onFailed();
                }
                i.this.m(th);
            }
        });
        com.kwad.sdk.core.d.c.w("TKLoadController", "registerTKViewNew end: ");
    }

    private void c(StyleTemplate styleTemplate, final a aVar) {
        com.kwad.sdk.core.d.c.w("TKLoadController", "renderTKView start: ");
        zq();
        this.alN = SystemClock.elapsedRealtime();
        t tVarA = this.asC.a(this.mContext, styleTemplate.templateId, styleTemplate.templateVersionCode, styleTemplate.tkSouce, this.asV);
        com.kwad.components.core.offline.a.f.a.a.a(tVarA.getUniqId(), this.mAdResultData);
        tVarA.a(this.atk);
        tVarA.a(this.atl);
        AdResultData adResultData = this.mAdResultData;
        if (adResultData != null && com.kwad.sdk.core.response.helper.c.r(adResultData).mAdScene != null) {
            zv().put("adStyle", Integer.valueOf(com.kwad.sdk.core.response.helper.c.r(this.mAdResultData).mAdScene.getAdStyle()));
            zv().put("adScene", com.kwad.sdk.core.response.helper.c.r(this.mAdResultData).mAdScene.toJson().toString());
        }
        if (this.akP != null) {
            zv().put("styleTemplate", this.akP.toJson().toString());
        }
        zv().put("adCacheId", Integer.valueOf(tVarA.getUniqId()));
        zv().put(AlipayApi.c, ServiceProvider.getAppId());
        zv().put("isDebug", com.kwad.components.core.a.oV);
        zv().put("newRenderType", Boolean.valueOf(this.asY));
        tVarA.setCustomEnv(zv());
        this.asE = tVarA;
        com.kwad.sdk.core.c.b.Mh();
        Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
        if (currentActivity != null) {
            ViewGroup viewGroup = (ViewGroup) currentActivity.getWindow().getDecorView();
            zv().put("isImmersiveMode", Boolean.valueOf(com.kwad.sdk.c.a.a.J(viewGroup) && com.kwad.sdk.c.a.a.bz(currentActivity) == viewGroup.getHeight()));
        }
        tVarA.setCustomEnv(zv());
        com.kwad.sdk.core.webview.c.g gVar = this.asB;
        if (gVar != null) {
            tVarA.b(gVar);
        }
        this.alM = SystemClock.elapsedRealtime() - this.alN;
        this.asQ = SystemClock.elapsedRealtime();
        zm();
        com.kwad.sdk.core.d.c.w("TKLoadController", "renderTKView center1: ");
        b(tVarA);
        tVarA.a(styleTemplate.jsStr, new File(this.asC.getJsBaseDir(this.mContext, this.asA.getTkTemplateId())).getAbsolutePath() + "/", new s() { // from class: com.kwad.components.core.webview.tachikoma.i.3
            @Override // com.kwad.sdk.components.s
            public final void onSuccess() {
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.onSuccess();
                }
            }

            @Override // com.kwad.sdk.components.s
            public final void onFailed(Throwable th) {
                com.kwad.sdk.core.d.c.w("TKLoadController", "renderTKView onFailed: " + th.getMessage());
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.onFailed();
                }
                i.this.m(th);
            }
        });
        FrameLayout tKContainer = this.asA.getTKContainer();
        if (tKContainer != null && this.asV) {
            View view = tVarA.getView();
            view.setLayoutParams(new FrameLayout.LayoutParams(-1, -1));
            tKContainer.addView(view);
            d(styleTemplate);
        }
        com.kwad.sdk.core.d.c.w("TKLoadController", "renderTKView end: ");
    }

    private void d(StyleTemplate styleTemplate) {
        if (com.kwad.components.core.a.oV.booleanValue() && this.asA.getTKContainer() != null) {
            if (this.asJ == null) {
                TextView textView = new TextView(this.mContext);
                this.asJ = textView;
                textView.setTextSize(12.0f);
                this.asJ.setTextColor(SupportMenu.CATEGORY_MASK);
                this.asA.getTKContainer().addView(this.asJ);
            }
            this.asJ.setText(styleTemplate.templateId + " " + styleTemplate.templateVersionCode);
            this.asJ.setVisibility(0);
        }
    }

    private void zm() {
        this.asZ.a(!as.VV() ? 1 : 0, this.asA.getTouchCoordsView(), this.asA.getTKContainer(), this.asA.getTkTemplateId());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.sdk.components.j bf(final AdTemplate adTemplate) {
        final com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(adTemplate);
        dVar.qr();
        return new com.kwad.sdk.components.j() { // from class: com.kwad.components.core.webview.tachikoma.i.6
            @Override // com.kwad.sdk.components.j
            public final void setCustomReportParam(String str) {
                try {
                    dVar.e(new JSONObject(str));
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }

            @Override // com.kwad.sdk.components.j
            public final void a(final com.kwad.sdk.components.i iVar) {
                dVar.b(new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.webview.tachikoma.i.6.1
                    @Override // com.kwad.sdk.api.KsAppDownloadListener
                    public final void onIdle() {
                        iVar.onIdle();
                    }

                    @Override // com.kwad.sdk.core.download.a.a, com.kwad.sdk.api.KsAppDownloadListener
                    public final void onDownloadStarted() {
                        iVar.onDownloadStarted();
                    }

                    @Override // com.kwad.sdk.api.KsAppDownloadListener
                    public final void onProgressUpdate(int i) {
                        long j;
                        long j2;
                        AdTemplate adTemplate2 = i.this.asZ.getAdTemplate();
                        if (adTemplate2 != null) {
                            j = com.kwad.sdk.core.response.helper.e.eM(adTemplate2).totalBytes;
                            j2 = com.kwad.sdk.core.response.helper.e.eM(adTemplate2).soFarBytes;
                        } else {
                            j = 0;
                            j2 = 0;
                        }
                        iVar.onProgressUpdate(i, j, j2);
                    }

                    @Override // com.kwad.sdk.api.KsAppDownloadListener
                    public final void onDownloadFinished() {
                        iVar.onDownloadFinished();
                    }

                    @Override // com.kwad.sdk.api.KsAppDownloadListener
                    public final void onInstalled() {
                        iVar.onInstalled();
                    }

                    @Override // com.kwad.sdk.api.KsAppDownloadListener
                    public final void onDownloadFailed() {
                        iVar.onDownloadFailed();
                    }

                    @Override // com.kwad.sdk.core.download.a.a
                    public final void onPaused(int i) {
                        long j;
                        long j2;
                        AdTemplate adTemplate2 = i.this.asZ.getAdTemplate();
                        if (adTemplate2 != null) {
                            j = com.kwad.sdk.core.response.helper.e.eM(adTemplate2).totalBytes;
                            j2 = com.kwad.sdk.core.response.helper.e.eM(adTemplate2).soFarBytes;
                        } else {
                            j = 0;
                            j2 = 0;
                        }
                        iVar.onPaused(i, j, j2);
                    }
                });
            }

            @Override // com.kwad.sdk.components.j
            public final void startDownload() {
                dVar.qx();
            }

            @Override // com.kwad.sdk.components.j
            public final void pauseDownload() {
                dVar.qy();
            }

            @Override // com.kwad.sdk.components.j
            public final void resumeDownload() {
                dVar.qz();
            }

            @Override // com.kwad.sdk.components.j
            public final void stopDownload() {
                dVar.qy();
            }

            @Override // com.kwad.sdk.components.j
            public final void cancelDownload() {
                com.kwad.sdk.core.download.a.eu(com.kwad.sdk.core.response.helper.e.eP(adTemplate));
            }

            @Override // com.kwad.sdk.components.j
            public final void installApp() {
                dVar.qw();
            }

            @Override // com.kwad.sdk.components.j
            public final void openApp() {
                dVar.qu();
            }
        };
    }

    protected final AdTemplate zn() {
        return this.asZ.getAdTemplate();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(final TKRenderFailReason tKRenderFailReason) {
        by.postOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.i.9
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (i.this.asO) {
                    return;
                }
                i.c(i.this, true);
                i.this.asA.a(tKRenderFailReason);
                com.kwad.components.core.e.e.g.qJ().b(i.this);
                com.kwad.components.core.innerEc.a.h.rw().b(i.this);
                com.kwad.components.core.webview.tachikoma.e.c.zS().u(i.this.asW, i.this.asX);
                com.kwad.components.core.webview.tachikoma.e.b.zQ().b(i.this.atb, i.this.asW, i.this.asX);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void d(final TKRenderFailReason tKRenderFailReason) {
        by.postOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.i.10
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (i.this.asO) {
                    return;
                }
                i.c(i.this, true);
                i.this.asA.a(tKRenderFailReason);
                com.kwad.components.core.e.e.g.qJ().b(i.this);
                com.kwad.components.core.innerEc.a.h.rw().b(i.this);
                com.kwad.components.core.webview.tachikoma.e.c.zS().u(i.this.asW, i.this.asX);
            }
        });
    }

    private void b(t tVar) {
        com.kwad.components.core.e.d.d dVar = zn() != null ? new com.kwad.components.core.e.d.d(zn()) : null;
        this.asA.a(tVar, this.asZ);
        a(tVar, new com.kwad.components.core.webview.jshandler.q());
        a(tVar, new com.kwad.components.core.webview.jshandler.r());
        com.kwad.components.core.webview.tachikoma.b.s sVar = new com.kwad.components.core.webview.tachikoma.b.s();
        sVar.a(new com.kwad.components.core.webview.tachikoma.b.s.a() { // from class: com.kwad.components.core.webview.tachikoma.i.11
            @Override // com.kwad.components.core.webview.tachikoma.b.s.a
            public final void a(com.kwad.components.core.webview.tachikoma.c.t tVar2) {
                if (TextUtils.isEmpty(tVar2.message)) {
                    return;
                }
                com.kwad.sdk.utils.ae.d(i.this.mContext, tVar2.message, 0L);
            }
        });
        a(tVar, sVar);
        a(tVar, c(this.asZ));
        a(tVar, new com.kwad.components.core.webview.jshandler.n(this.asZ));
        a(tVar, new com.kwad.components.core.webview.jshandler.o(this.asZ));
        a(tVar, new com.kwad.sdk.core.webview.d.a());
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.f());
        a(tVar, new x());
        if (py()) {
            com.kwad.components.core.webview.jshandler.z zVar = new com.kwad.components.core.webview.jshandler.z(this.asZ, dVar, this);
            if (!this.asW.equals(com.kwad.sdk.core.response.helper.b.dB(this.asZ.getAdTemplate()))) {
                com.kwad.components.core.e.e.g.qJ().a(this);
            }
            a(tVar, zVar);
        } else {
            a(tVar, new ac(this.asZ, dVar, this, (byte) 0));
        }
        com.kwad.components.core.innerEc.a.h.rw().a(this);
        a(tVar, new ab(this.asZ));
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.k());
        a(tVar, new af(this.asZ));
        a(tVar, new ai(this.asZ));
        a(tVar, new ar(this.mContext, zn()));
        ae aeVar = new ae(this.asZ);
        aeVar.a(new ae.c() { // from class: com.kwad.components.core.webview.tachikoma.i.13
            @Override // com.kwad.components.core.webview.jshandler.ae.c
            public final void c(ae.a aVar) {
                i.this.asA.a(aVar);
            }
        });
        a(tVar, aeVar);
        a(tVar, new bd(this.asZ, new bd.a() { // from class: com.kwad.components.core.webview.tachikoma.i.14
            @Override // com.kwad.components.core.webview.jshandler.bd.a
            public final void f(AdTemplate adTemplate) {
                try {
                    i.this.asZ.PD().remove(0);
                    i.this.asZ.PD().add(adTemplate);
                    ArrayList arrayList = new ArrayList();
                    arrayList.add(adTemplate);
                    AdResultData adResultData = new AdResultData();
                    adResultData.setAdTemplateList(arrayList);
                    adResultData.llsid = adTemplate.llsid;
                    i.this.mAdResultData = adResultData;
                    i.this.asA.f(com.kwad.sdk.core.response.helper.c.r(i.this.mAdResultData));
                    if (i.this.asE != null) {
                        com.kwad.components.core.offline.a.f.a.a.a(i.this.asE.getUniqId(), i.this.mAdResultData);
                    }
                    i.this.asH.setApkDownloadHelper(new com.kwad.components.core.e.d.d(adTemplate));
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        }));
        a(tVar, new al(this.asZ, new al.b() { // from class: com.kwad.components.core.webview.tachikoma.i.15
            @Override // com.kwad.components.core.webview.jshandler.al.b
            public final void a(al.a aVar) {
                i.this.b(aVar);
            }
        }));
        a(tVar, new com.kwad.components.core.webview.jshandler.as(new com.kwad.components.core.webview.jshandler.as.b() { // from class: com.kwad.components.core.webview.tachikoma.i.16
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(com.kwad.components.core.webview.jshandler.as.a aVar) {
                if (aVar.status != 1) {
                    i.this.c(TKRenderFailReason.RENDER_ERROR);
                    i.this.bL(aVar.errorMsg);
                } else {
                    i.this.zy();
                }
            }
        }));
        az azVar = new az();
        this.ff = azVar;
        a(tVar, azVar);
        this.asA.a(this.ff);
        ay ayVar = new ay();
        this.asG = ayVar;
        a(tVar, ayVar);
        bc bcVar = new bc(this.asZ, dVar);
        this.asH = bcVar;
        a(tVar, bcVar);
        p pVar = new p();
        this.asF = pVar;
        a(tVar, pVar);
        this.asA.a(this.asF);
        a(tVar, new com.kwad.components.core.webview.jshandler.a(new com.kwad.components.core.webview.jshandler.a.b() { // from class: com.kwad.components.core.webview.tachikoma.i.17
            @Override // com.kwad.components.core.webview.jshandler.a.b
            public final void c(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
                i.this.asA.a(c0464a);
            }
        }));
        if (zn() != null && com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(zn()))) {
            final com.kwad.components.core.webview.tachikoma.b.l lVar = new com.kwad.components.core.webview.tachikoma.b.l();
            a(tVar, lVar);
            this.aoE = new com.kwad.sdk.core.download.d(zn()) { // from class: com.kwad.components.core.webview.tachikoma.i.18
                @Override // com.kwad.sdk.core.download.d, com.kwad.sdk.core.download.c
                public final void b(String str, String str2, com.kwad.sdk.core.download.e eVar) {
                    super.b(str, str2, eVar);
                    com.kwad.components.core.webview.tachikoma.c.b bVar = new com.kwad.components.core.webview.tachikoma.c.b();
                    bVar.auk = 1;
                    lVar.a(bVar);
                }
            };
            com.kwad.sdk.core.download.b.LK().a(this.aoE, zn());
        }
        com.kwad.components.core.webview.tachikoma.b.t tVar2 = new com.kwad.components.core.webview.tachikoma.b.t();
        tVar2.a(new com.kwad.components.core.webview.tachikoma.b.t.a() { // from class: com.kwad.components.core.webview.tachikoma.i.19
            @Override // com.kwad.components.core.webview.tachikoma.b.t.a
            public final void b(u uVar) {
                i.this.asA.a(uVar);
            }
        });
        a(tVar, tVar2);
        v vVar = new v();
        vVar.a(new v.a() { // from class: com.kwad.components.core.webview.tachikoma.i.20
            @Override // com.kwad.components.core.webview.tachikoma.b.v.a
            public final void b(com.kwad.components.core.webview.tachikoma.c.n nVar) {
                i.this.asA.a(nVar);
            }
        });
        a(tVar, vVar);
        com.kwad.components.core.webview.tachikoma.b.o oVar = new com.kwad.components.core.webview.tachikoma.b.o();
        a(tVar, oVar);
        this.asA.a(oVar);
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.r() { // from class: com.kwad.components.core.webview.tachikoma.i.21
            @Override // com.kwad.components.core.webview.tachikoma.b.r
            public final void a(com.kwad.components.core.webview.tachikoma.c.s sVar2) {
                super.a(sVar2);
                Activity activityYZ = i.this.yZ();
                if (activityYZ == null) {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null || activityYZ.isFinishing()) {
                    return;
                }
                if (i.this.asz != null) {
                    i.this.asz.dismiss();
                }
                com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
                bVar.a(i.this.mAdResultData);
                bVar.bN(sVar2.templateId);
                i.this.asz = com.kwad.components.core.webview.tachikoma.d.e.b(bVar);
                i.this.asz.show(activityYZ.getFragmentManager(), "");
            }
        });
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.c() { // from class: com.kwad.components.core.webview.tachikoma.i.22
            @Override // com.kwad.components.core.webview.tachikoma.b.c
            public final void kr() {
                super.kr();
                if (i.this.asz != null) {
                    i.this.asz.dismiss();
                }
                if (i.this.asA != null) {
                    i.this.asA.aC();
                }
            }
        });
        a(tVar, new aa(new com.kwad.sdk.core.webview.d.a.b() { // from class: com.kwad.components.core.webview.tachikoma.i.24
            @Override // com.kwad.sdk.core.webview.d.a.b
            public final void b(WebCloseStatus webCloseStatus) {
                i.this.asA.a(webCloseStatus);
            }
        }));
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.d() { // from class: com.kwad.components.core.webview.tachikoma.i.25
            @Override // com.kwad.components.core.webview.tachikoma.b.d
            public final void a(com.kwad.components.core.webview.tachikoma.c.g gVar) {
                AdTemplate adTemplateA = gVar.apq >= 0 ? com.kwad.sdk.core.response.helper.c.a(com.kwad.components.core.offline.a.f.a.a.bf(gVar.apq), gVar.Pu) : null;
                if (adTemplateA == null) {
                    adTemplateA = i.this.zn();
                }
                com.kwad.components.core.p.a.vX().a(gVar.actionType, adTemplateA, gVar.QQ);
            }
        });
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.j() { // from class: com.kwad.components.core.webview.tachikoma.i.26
            @Override // com.kwad.components.core.webview.tachikoma.b.j
            public final void a(com.kwad.components.core.webview.tachikoma.c.o oVar2) {
                super.a(oVar2);
                AdWebViewActivityProxy.launch(i.this.mContext, new AdWebViewActivityProxy.a.C0449a().aW(oVar2.title).aX(oVar2.url).aS(!oVar2.auw).q(i.this.mAdResultData).um());
            }
        });
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.a(zn()));
        a(tVar, new com.kwad.components.core.webview.tachikoma.a(zn()));
        a(this.asZ, dVar, tVar, this.asA.getTKContainer());
        a(tVar, new com.kwad.components.core.webview.jshandler.a.f(this.mContext));
        a(tVar, new com.kwad.components.core.webview.jshandler.a.d(this.mContext));
        a(tVar, new com.kwad.components.core.webview.jshandler.a.a());
        a(tVar, new com.kwad.components.core.webview.jshandler.a.e(this.mContext));
        aw awVar = new aw();
        this.aoD = awVar;
        a(tVar, awVar);
        a(tVar, new com.kwad.components.core.webview.jshandler.c(this.asZ));
    }

    private void c(final t tVar) {
        com.kwad.components.core.e.d.d dVar = zn() != null ? new com.kwad.components.core.e.d.d(zn()) : null;
        this.asA.a(tVar, this.asZ);
        a(tVar, new com.kwad.components.core.webview.jshandler.q());
        a(tVar, new com.kwad.components.core.webview.jshandler.r());
        com.kwad.components.core.webview.tachikoma.b.s sVar = new com.kwad.components.core.webview.tachikoma.b.s();
        sVar.a(new com.kwad.components.core.webview.tachikoma.b.s.a() { // from class: com.kwad.components.core.webview.tachikoma.i.27
            @Override // com.kwad.components.core.webview.tachikoma.b.s.a
            public final void a(com.kwad.components.core.webview.tachikoma.c.t tVar2) {
                if (TextUtils.isEmpty(tVar2.message)) {
                    return;
                }
                com.kwad.sdk.utils.ae.d(i.this.mContext, tVar2.message, 0L);
            }
        });
        a(tVar, sVar);
        a(tVar, c(this.asZ));
        a(tVar, new com.kwad.sdk.core.webview.d.a());
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.f());
        a(tVar, new x());
        if (py()) {
            com.kwad.components.core.webview.jshandler.z zVar = new com.kwad.components.core.webview.jshandler.z(this.asZ, dVar, this);
            if (!this.asW.equals(com.kwad.sdk.core.response.helper.b.dB(this.asZ.getAdTemplate()))) {
                com.kwad.components.core.e.e.g.qJ().a(this);
            }
            a(tVar, zVar);
        } else {
            a(tVar, new ac(this.asZ, dVar, this, (byte) 0));
        }
        a(tVar, new ab(this.asZ));
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.k());
        a(tVar, new ar(this.mContext, zn()));
        a(tVar, new bd(this.asZ, new bd.a() { // from class: com.kwad.components.core.webview.tachikoma.i.28
            @Override // com.kwad.components.core.webview.jshandler.bd.a
            public final void f(AdTemplate adTemplate) {
                try {
                    i.this.asZ.PD().remove(0);
                    i.this.asZ.PD().add(adTemplate);
                    ArrayList arrayList = new ArrayList();
                    arrayList.add(adTemplate);
                    AdResultData adResultData = new AdResultData();
                    adResultData.setAdTemplateList(arrayList);
                    adResultData.llsid = adTemplate.llsid;
                    i.this.mAdResultData = adResultData;
                    i.this.asA.f(com.kwad.sdk.core.response.helper.c.r(i.this.mAdResultData));
                    if (i.this.asE != null) {
                        com.kwad.components.core.offline.a.f.a.a.a(i.this.asE.getUniqId(), i.this.mAdResultData);
                    }
                    i.this.asH.setApkDownloadHelper(new com.kwad.components.core.e.d.d(adTemplate));
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        }));
        a(tVar, new com.kwad.components.core.webview.jshandler.as(new com.kwad.components.core.webview.jshandler.as.b() { // from class: com.kwad.components.core.webview.tachikoma.i.29
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(com.kwad.components.core.webview.jshandler.as.a aVar) {
                if (aVar.status == 2 && i.this.asY) {
                    try {
                        i.this.atd = SystemClock.elapsedRealtime();
                        i iVar = i.this;
                        iVar.atf = iVar.atd;
                        i iVar2 = i.this;
                        iVar2.ate = iVar2.atd - i.this.asQ;
                        com.kwad.sdk.core.d.c.d("WebCardPageStatusHandler", "registerTKContext");
                        com.kwad.components.core.t.k.a(Integer.valueOf(i.this.atb), tVar, i.this.alM, i.this.Kc, i.this.alN, i.this.atd);
                        i.this.a(tVar);
                        com.kwad.components.core.webview.tachikoma.e.b.zQ().ce(i.this.atb);
                        return;
                    } catch (Exception e) {
                        com.kwad.components.core.t.k.c(Integer.valueOf(i.this.atb));
                        i.this.c(TKRenderFailReason.RENDER_ERROR);
                        i.this.bL(e.getMessage());
                        return;
                    }
                }
                if (aVar.status == 0) {
                    i.this.c(TKRenderFailReason.RENDER_ERROR);
                    i.this.bL(aVar.errorMsg);
                }
            }
        }));
        ay ayVar = new ay();
        this.asG = ayVar;
        a(tVar, ayVar);
        p pVar = new p();
        this.asF = pVar;
        a(tVar, pVar);
        this.asA.a(this.asF);
        if (zn() != null && com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(zn()))) {
            final com.kwad.components.core.webview.tachikoma.b.l lVar = new com.kwad.components.core.webview.tachikoma.b.l();
            a(tVar, lVar);
            this.aoE = new com.kwad.sdk.core.download.d(zn()) { // from class: com.kwad.components.core.webview.tachikoma.i.30
                @Override // com.kwad.sdk.core.download.d, com.kwad.sdk.core.download.c
                public final void b(String str, String str2, com.kwad.sdk.core.download.e eVar) {
                    super.b(str, str2, eVar);
                    com.kwad.components.core.webview.tachikoma.c.b bVar = new com.kwad.components.core.webview.tachikoma.c.b();
                    bVar.auk = 1;
                    lVar.a(bVar);
                }
            };
            com.kwad.sdk.core.download.b.LK().a(this.aoE, zn());
        }
        com.kwad.components.core.webview.tachikoma.b.t tVar2 = new com.kwad.components.core.webview.tachikoma.b.t();
        tVar2.a(new com.kwad.components.core.webview.tachikoma.b.t.a() { // from class: com.kwad.components.core.webview.tachikoma.i.31
            @Override // com.kwad.components.core.webview.tachikoma.b.t.a
            public final void b(u uVar) {
                i.this.asA.a(uVar);
            }
        });
        a(tVar, tVar2);
        v vVar = new v();
        vVar.a(new v.a() { // from class: com.kwad.components.core.webview.tachikoma.i.32
            @Override // com.kwad.components.core.webview.tachikoma.b.v.a
            public final void b(com.kwad.components.core.webview.tachikoma.c.n nVar) {
                i.this.asA.a(nVar);
            }
        });
        a(tVar, vVar);
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.r() { // from class: com.kwad.components.core.webview.tachikoma.i.33
            @Override // com.kwad.components.core.webview.tachikoma.b.r
            public final void a(com.kwad.components.core.webview.tachikoma.c.s sVar2) {
                super.a(sVar2);
                Activity activityYZ = i.this.yZ();
                if (activityYZ == null) {
                    com.kwad.sdk.core.c.b.Mh();
                    activityYZ = com.kwad.sdk.core.c.b.getCurrentActivity();
                }
                if (activityYZ == null || activityYZ.isFinishing()) {
                    return;
                }
                if (i.this.asz != null) {
                    i.this.asz.dismiss();
                }
                com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
                bVar.a(i.this.mAdResultData);
                bVar.bN(sVar2.templateId);
                i.this.asz = com.kwad.components.core.webview.tachikoma.d.e.b(bVar);
                i.this.asz.show(activityYZ.getFragmentManager(), "");
            }
        });
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.c() { // from class: com.kwad.components.core.webview.tachikoma.i.35
            @Override // com.kwad.components.core.webview.tachikoma.b.c
            public final void kr() {
                super.kr();
                if (i.this.asz != null) {
                    i.this.asz.dismiss();
                }
                if (i.this.asA != null) {
                    i.this.asA.aC();
                }
            }
        });
        a(tVar, new aa(new com.kwad.sdk.core.webview.d.a.b() { // from class: com.kwad.components.core.webview.tachikoma.i.36
            @Override // com.kwad.sdk.core.webview.d.a.b
            public final void b(WebCloseStatus webCloseStatus) {
                i.this.asA.a(webCloseStatus);
            }
        }));
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.d() { // from class: com.kwad.components.core.webview.tachikoma.i.37
            @Override // com.kwad.components.core.webview.tachikoma.b.d
            public final void a(com.kwad.components.core.webview.tachikoma.c.g gVar) {
                AdTemplate adTemplateA = gVar.apq >= 0 ? com.kwad.sdk.core.response.helper.c.a(com.kwad.components.core.offline.a.f.a.a.bf(gVar.apq), gVar.Pu) : null;
                if (adTemplateA == null) {
                    adTemplateA = i.this.zn();
                }
                com.kwad.components.core.p.a.vX().a(gVar.actionType, adTemplateA, gVar.QQ);
            }
        });
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.j() { // from class: com.kwad.components.core.webview.tachikoma.i.38
            @Override // com.kwad.components.core.webview.tachikoma.b.j
            public final void a(com.kwad.components.core.webview.tachikoma.c.o oVar) {
                super.a(oVar);
                AdWebViewActivityProxy.launch(i.this.mContext, new AdWebViewActivityProxy.a.C0449a().aW(oVar.title).aX(oVar.url).aS(!oVar.auw).q(i.this.mAdResultData).um());
            }
        });
        a(tVar, new com.kwad.components.core.webview.tachikoma.b.a(zn()));
        a(tVar, new com.kwad.components.core.webview.tachikoma.a(zn()));
        a(this.asZ, dVar, tVar, this.asA.getTKContainer());
        a(tVar, new com.kwad.components.core.webview.jshandler.a.f(this.mContext));
        a(tVar, new com.kwad.components.core.webview.jshandler.a.d(this.mContext));
        a(tVar, new com.kwad.components.core.webview.jshandler.a.a());
        a(tVar, new com.kwad.components.core.webview.jshandler.a.e(this.mContext));
        aw awVar = new aw();
        this.aoD = awVar;
        a(tVar, awVar);
    }

    private static void a(t tVar, com.kwad.sdk.core.webview.c.a aVar) {
        tVar.c(aVar);
    }

    protected am c(com.kwad.sdk.core.webview.b bVar) {
        return new am(bVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(al.a aVar) {
        FrameLayout tKContainer = this.asA.getTKContainer();
        if (tKContainer != null) {
            FrameLayout.LayoutParams layoutParams = (FrameLayout.LayoutParams) tKContainer.getLayoutParams();
            layoutParams.height = com.kwad.sdk.c.a.a.a(this.mContext, aVar.height);
            layoutParams.leftMargin = com.kwad.sdk.c.a.a.a(this.mContext, aVar.leftMargin);
            layoutParams.rightMargin = com.kwad.sdk.c.a.a.a(this.mContext, aVar.rightMargin);
            layoutParams.bottomMargin = com.kwad.sdk.c.a.a.a(this.mContext, aVar.bottomMargin);
            layoutParams.width = -1;
            tKContainer.setLayoutParams(layoutParams);
        }
    }

    private int zo() {
        return com.kwad.sdk.core.config.e.cP(new StringBuffer().append(this.asA.getTkTemplateId()).append("#").append(zl() != null ? zl().templateVersionCode : 0).toString());
    }

    private void zp() {
        StyleTemplate styleTemplateZl = zl();
        if (styleTemplateZl == null) {
            return;
        }
        this.asP = styleTemplateZl.tkSouce;
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.APM_LOG, new TKPerformMsg(this.asP).setRenderState(-1).setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(styleTemplateZl.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    private void bK(String str) {
        f(this.asA.getTkTemplateId(), str);
        StyleTemplate styleTemplateZl = zl();
        if (styleTemplateZl == null) {
            return;
        }
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.ERROR_LOG, new TKPerformMsg(this.asP).setRenderState(4).setErrorReason(str).setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(styleTemplateZl.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    private void zq() {
        if (this.asM) {
            return;
        }
        this.asM = true;
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.APM_LOG, new TKPerformMsg(this.asP).setRenderState(0).setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(this.akP.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    private void zr() {
        StringBuilder sbAppend = new StringBuilder("logTkRenderSuccess, templateId = ").append(this.asA.getTkTemplateId()).append(":");
        StyleTemplate styleTemplate = this.akP;
        com.kwad.sdk.core.d.c.d("TKLoadController", sbAppend.append(styleTemplate != null ? styleTemplate.templateVersionCode : 0).toString());
        if (!this.asM || this.asN) {
            return;
        }
        this.asN = true;
        long jElapsedRealtime = this.asQ > 0 ? SystemClock.elapsedRealtime() - this.asQ : 0L;
        com.kwad.sdk.core.d.c.d("TKLoadController", "render time, templateId = " + this.asA.getTkTemplateId() + " init:" + this.alM + " load:" + (this.alN - this.Kc) + " render:" + jElapsedRealtime);
        if (this.asY) {
            this.atg = SystemClock.elapsedRealtime() - this.atf;
        }
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.APM_LOG, new TKPerformMsg(this.asP).setRenderState(1).setRenderTime(jElapsedRealtime).setTemplateId(this.asA.getTkTemplateId()).setLoadTime(this.alN - this.Kc).setInitTime(this.alM).setRegisterEndTime(this.ate).setGetViewEndTime(this.atg).setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(this.akP.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    private int zs() {
        return this.asY ? 1 : 0;
    }

    private long zt() {
        if (zs() == 1) {
            return com.kwad.sdk.core.config.e.KU().longValue();
        }
        return 0L;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bL(String str) {
        com.kwad.sdk.core.d.c.d("TKLoadController", "logTkRenderFail : " + str + ", templateId = " + this.asA.getTkTemplateId());
        g(this.asA.getTkTemplateId(), str);
        if (!this.asM || this.asN) {
            return;
        }
        this.asN = true;
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.ERROR_LOG, new TKPerformMsg(this.asP).setRenderState(2).setErrorReason(str).setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(this.akP.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void zu() {
        com.kwad.sdk.core.d.c.d("TKLoadController", "logTkRenderFail : timeout, templateId = " + this.asA.getTkTemplateId());
        StyleTemplate styleTemplateZl = zl();
        if (styleTemplateZl == null) {
            return;
        }
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.ERROR_LOG, new TKPerformMsg(this.asP).setRenderState(3).setErrorReason("timeout").setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(styleTemplateZl.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void m(Throwable th) {
        com.kwad.sdk.core.d.c.d("TKLoadController", "logTkRenderFail : " + th + ", templateId = " + this.asA.getTkTemplateId());
        g(this.asA.getTkTemplateId(), "error:" + th.toString());
        TkLoggerReporter.get().reportTKPerform(ILoggerReporter.Category.ERROR_LOG, new TKPerformMsg(this.asP).setRenderState(3).setErrorReason(th.toString()).setTemplateId(this.asA.getTkTemplateId()).setVersionCode(String.valueOf(this.akP.templateVersionCode)).setTKPublishType(zo()).setRenderType(zs()).setRenderIdleTime(zt()).toJson());
    }

    @Override // com.kwad.sdk.components.q
    public final void callJS(String str) {
        t tVar = this.asE;
        if (tVar != null) {
            tVar.a(str, null, null);
        }
    }

    private Map<String, Object> zv() {
        if (this.asR == null) {
            HashMap map = new HashMap();
            this.asR = map;
            map.put("TKVersion", "6.2.2");
            this.asR.put("SDKVersion", BuildConfig.VERSION_NAME);
            this.asR.put("sdkType", 1);
        }
        return this.asR;
    }

    public final void a(String str, Object obj) {
        zv().put(str, obj);
    }

    @Override // com.kwad.sdk.core.webview.d.a.a
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        j jVar = this.asA;
        if (jVar != null) {
            jVar.a(aVar);
        }
    }

    @Override // com.kwad.sdk.core.view.c
    public final void i(View view, boolean z) {
        ay ayVar;
        FrameLayout tKContainer = this.asA.getTKContainer();
        if (tKContainer == null || !tKContainer.equals(view) || (ayVar = this.asG) == null) {
            return;
        }
        ayVar.bl(z);
    }

    @Override // com.kwad.components.core.e.e.f
    public void show() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yO();
        }
    }

    @Override // com.kwad.components.core.e.e.f
    public void dismiss() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yN();
        }
    }

    public void dl() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yO();
        }
    }

    public void dm() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yN();
        }
    }

    public void kT() {
        if (this.asy != null) {
            this.asy = null;
        }
        com.kwad.sdk.core.view.e eVar = this.asI;
        if (eVar != null) {
            eVar.getWindowFocusChangeHelper().b(this);
            this.asI = null;
        }
        Future<?> future = this.asD;
        if (future != null) {
            future.cancel(true);
        }
        by.b(this.atm);
        by.b(this.atn);
        com.kwad.components.core.e.e.g.qJ().b(this);
        com.kwad.components.core.innerEc.a.h.rw().b(this);
        if (this.aoE != null) {
            com.kwad.sdk.core.download.b.LK().a(this.aoE);
        }
        com.kwad.components.core.webview.tachikoma.d.e eVar2 = this.asz;
        if (eVar2 != null) {
            eVar2.dismiss();
        }
        if (com.kwad.components.core.a.oV.booleanValue()) {
            zw();
        }
        com.kwad.components.core.offline.a.f.c cVar = this.asC;
        if (cVar != null) {
            cVar.onDestroy();
        }
        final t tVar = this.asE;
        if (tVar != null) {
            this.asE = null;
            if (this.asY) {
                com.kwad.components.core.t.k.c(Integer.valueOf(this.atb));
            } else {
                by.postOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.40
                    @Override // java.lang.Runnable
                    public final void run() {
                        t tVar2 = tVar;
                        if (tVar2 != null) {
                            tVar2.onDestroy();
                        }
                    }
                });
            }
        }
    }

    private void zw() {
        if (this.asC == null || this.asE == null) {
            return;
        }
        File file = new File(new File(this.asC.getJsBaseDir(this.mContext, this.asA.getTkTemplateId())), "kcov.json");
        if (file.exists()) {
            try {
                String strY = y.Y(file);
                if (TextUtils.isEmpty(strY)) {
                    return;
                }
                com.kwad.sdk.core.d.c.d("TKLoadController", "kcov.json:" + strY);
                JSONObject jSONObject = new JSONObject(strY);
                final String string = jSONObject.getString("gitHeadCommit");
                final String string2 = jSONObject.getString("coverageApi");
                final String string3 = jSONObject.getString("coverageTaskId");
                final String string4 = jSONObject.getString("currentBranch");
                if (!TextUtils.isEmpty(string) && !TextUtils.isEmpty(string2) && !TextUtils.isEmpty(string3) && !TextUtils.isEmpty(string4)) {
                    com.kwad.sdk.core.d.c.d("TKLoadController", new StringBuilder("尝试获取覆盖率统计... ").append(this.akP).toString() != null ? this.akP.templateId : "");
                    Object objExecute = this.asE.execute("JSON.stringify(this.__coverage__)");
                    if (objExecute instanceof String) {
                        final String str = (String) objExecute;
                        com.kwad.sdk.utils.i.execute(new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.41
                            @Override // java.lang.Runnable
                            public final void run() {
                                JSONObject jSONObject2 = new JSONObject();
                                try {
                                    jSONObject2.put("coverage_task_id", Integer.valueOf(string3));
                                    jSONObject2.put("user", "");
                                    jSONObject2.put(com.alipay.sdk.m.x.a.k, System.currentTimeMillis() / 1000);
                                    jSONObject2.put("branch_name", string4);
                                    jSONObject2.put("version", BuildConfig.VERSION_NAME);
                                    jSONObject2.put("tk_version", String.valueOf(i.this.akP.templateVersionCode));
                                    jSONObject2.put("tk_template_ids", i.this.akP.templateId);
                                } catch (JSONException e) {
                                    com.kwad.sdk.core.d.c.printStackTrace(e);
                                }
                                com.kwad.sdk.core.network.c cVarDoPost = com.kwad.sdk.h.ES().doPost(string2 + "/analysis/add/pkg/info", (Map<String, String>) null, jSONObject2);
                                if (cVarDoPost.Mq()) {
                                    com.kwad.sdk.core.d.c.d("TKLoadController", "上传TK覆盖率pkg完成:" + cVarDoPost.aSY);
                                } else {
                                    com.kwad.sdk.core.d.c.d("TKLoadController", "上传覆盖率pkg失败");
                                }
                                com.kwad.sdk.core.network.c cVarDoPost2 = com.kwad.sdk.h.ES().doPost(string2 + "/attachment/ec", (Map<String, String>) null, new AdHttpBodyBuilder() { // from class: com.kwad.components.core.webview.tachikoma.i.41.1
                                    @Override // com.kwad.sdk.export.proxy.AdHttpBodyBuilder
                                    public final void buildFormData(AdHttpFormDataBuilder adHttpFormDataBuilder) {
                                        adHttpFormDataBuilder.addFormDataPart("task_id", string3);
                                        adHttpFormDataBuilder.addFormDataPart("os_build_model", Build.MODEL);
                                        adHttpFormDataBuilder.addFormDataPart("os_build_serial", "unknown");
                                        adHttpFormDataBuilder.addFormDataPart("os_build_brand", Build.BRAND);
                                        adHttpFormDataBuilder.addFormDataPart(com.sigmob.sdk.base.n.r, BuildConfig.VERSION_NAME);
                                        adHttpFormDataBuilder.addFormDataPart("git_head_commit", string);
                                        adHttpFormDataBuilder.addFormDataPart("execute_type", "manual_qa");
                                        adHttpFormDataBuilder.addFormDataPart("uid", "");
                                        adHttpFormDataBuilder.addFormDataPart("did", bf.getDeviceId());
                                        adHttpFormDataBuilder.addFormDataPart("execute_user", "");
                                        adHttpFormDataBuilder.addFormDataPart("url_type", "transform");
                                        try {
                                            adHttpFormDataBuilder.addFormDataPart(com.sigmob.sdk.base.n.z, UUID.randomUUID().toString() + ".json", "application/octet-stream", str.getBytes("UTF-8"));
                                        } catch (UnsupportedEncodingException e2) {
                                            com.kwad.sdk.core.d.c.printStackTrace(e2);
                                        }
                                    }
                                });
                                if (cVarDoPost2.Mq()) {
                                    com.kwad.sdk.core.d.c.d("TKLoadController", "上传TK覆盖率完成:" + cVarDoPost2.aSY);
                                } else {
                                    com.kwad.sdk.core.d.c.d("TKLoadController", "上传TK覆盖率失败");
                                }
                            }
                        });
                        return;
                    }
                    return;
                }
                com.kwad.sdk.core.d.c.d("TKLoadController", "kcov.json数据不合法，缺少关键字段gitHeadCommit | coverageApi | coverageTaskId | currentBranch");
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
    }

    public final String getTkTemplateId() {
        j jVar = this.asA;
        if (jVar == null) {
            return null;
        }
        return jVar.getTkTemplateId();
    }

    public final o zx() {
        return this.ata;
    }

    public final void zy() {
        com.kwad.sdk.core.d.c.d("TKLoadController", "judgeTKRenderResult tkHasTimeout： " + this.asL);
        if (this.asL) {
            com.kwad.sdk.core.d.c.d("TKLoadController", "judgeTKRenderResult: " + this.asA.getTkTemplateId());
            c(TKRenderFailReason.TK_FILE_LOAD_TIMEOUT);
            return;
        }
        by.b(this.atn);
        zr();
        if (this.asA != null) {
            by.runOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.i.42
                @Override // java.lang.Runnable
                public final void run() {
                    i.this.asA.aB();
                }
            });
            com.kwad.components.core.webview.tachikoma.e.c.zS().c(this.asA.getTkTemplateId(), this.alN - this.Kc, this.alM, this.asQ > 0 ? SystemClock.elapsedRealtime() - this.asQ : 0L);
        }
    }
}
