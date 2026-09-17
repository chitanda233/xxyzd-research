package com.sigmob.sdk.mraid;

import android.app.Activity;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageManager;
import android.graphics.Rect;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewTreeObserver;
import android.view.WindowInsets;
import android.webkit.ConsoleMessage;
import android.webkit.JsResult;
import android.webkit.ValueCallback;
import android.widget.FrameLayout;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.mta.DeviceContext;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.CurrentAppOrientation;
import com.sigmob.sdk.base.models.ExposureChange;
import com.sigmob.sdk.base.models.ExtensionEvent;
import com.sigmob.sdk.base.models.MraidEnv;
import com.sigmob.sdk.base.models.PlacementType;
import com.sigmob.sdk.base.models.SensorEntity;
import com.sigmob.sdk.base.models.VideoItem;
import com.sigmob.sdk.base.models.ViewState;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.nativead.APKStatusBroadcastReceiver;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAds;
import java.net.URI;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3486a = "MraidController";
    private APKStatusBroadcastReceiver A;
    private boolean B;
    private com.sigmob.sdk.base.common.g C;
    private WindowInsets D;
    private final PlacementType b;
    private final BaseAdUnit c;
    private final FrameLayout d;
    private final d e;
    private final q f;
    private final com.sigmob.sdk.mraid.c g;
    private final m h;
    private boolean i;
    private Integer j;
    private String k;
    private ViewGroup l;
    private ViewState m;
    private a n;
    private e o;
    private x p;
    private f q;
    private v r;
    private c s;
    private Integer t;
    private boolean u;
    private p v;
    private boolean w;
    private final HashMap<String, n> x;
    private final com.sigmob.sdk.mraid.e y;
    private final com.sigmob.sdk.mraid.d z;

    public interface a {
        void a();

        void a(float progress);

        void a(int width, int height, int offsetX, int offsetY, com.sigmob.sdk.mraid.b.a closePosition, boolean allowOffscreen);

        void a(View view);

        void a(WindAdError error);

        void a(String ext);

        void a(URI uri, int type, String ext);

        void a(boolean isMute);

        void b();

        void b(float progress);

        void c();

        void d();

        void e();

        void f();

        void g();

        void h();
    }

    public interface b {
        void onReady(v webView, com.sigmob.sdk.base.common.v viewabilityManager);
    }

    class c extends BroadcastReceiver {
        private Context b;
        private int c = -1;

        c() {
        }

        public void a() {
            Context context = this.b;
            if (context == null) {
                return;
            }
            context.unregisterReceiver(this);
            this.b = null;
        }

        public void a(Context context) {
            Preconditions.checkNotNull(context);
            Context applicationContext = context.getApplicationContext();
            this.b = applicationContext;
            if (applicationContext == null) {
                return;
            }
            com.sigmob.sdk.base.utils.h.a(applicationContext, this, new IntentFilter("android.intent.action.CONFIGURATION_CHANGED"));
        }

        @Override // android.content.BroadcastReceiver
        public void onReceive(Context context, Intent intent) {
            int iX;
            if (this.b == null || h.this.w || !"android.intent.action.CONFIGURATION_CHANGED".equals(intent.getAction()) || (iX = h.this.x()) == this.c) {
                return;
            }
            this.c = iX;
            h.this.a(iX);
        }
    }

    static class d {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final Handler f3494a = new Handler();
        private a b;

        static class a {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            int f3495a;
            private final View[] b;
            private final Handler c;
            private Runnable d;
            private final Runnable e;

            private a(Handler handler, View[] views) {
                this.e = new Runnable() { // from class: com.sigmob.sdk.mraid.h.d.a.1
                    @Override // java.lang.Runnable
                    public void run() {
                        for (final View view : a.this.b) {
                            if (view.getHeight() > 0 || view.getWidth() > 0) {
                                a.this.b();
                            } else {
                                view.getViewTreeObserver().addOnPreDrawListener(new ViewTreeObserver.OnPreDrawListener() { // from class: com.sigmob.sdk.mraid.h.d.a.1.1
                                    @Override // android.view.ViewTreeObserver.OnPreDrawListener
                                    public boolean onPreDraw() {
                                        view.getViewTreeObserver().removeOnPreDrawListener(this);
                                        a.this.b();
                                        return true;
                                    }
                                });
                            }
                        }
                    }
                };
                this.c = handler;
                this.b = views;
            }

            /* JADX INFO: Access modifiers changed from: private */
            public void b() {
                Runnable runnable;
                int i = this.f3495a - 1;
                this.f3495a = i;
                if (i != 0 || (runnable = this.d) == null) {
                    return;
                }
                runnable.run();
                this.d = null;
            }

            void a() {
                this.c.removeCallbacks(this.e);
                this.d = null;
            }

            void a(Runnable successRunnable) {
                this.d = successRunnable;
                this.f3495a = this.b.length;
                this.c.post(this.e);
            }
        }

        d() {
        }

        a a(View... views) {
            a aVar = new a(this.f3494a, views);
            this.b = aVar;
            return aVar;
        }

        void a() {
            a aVar = this.b;
            if (aVar == null) {
                return;
            }
            aVar.a();
            this.b = null;
        }
    }

    public interface e {
        void useCustomCloseChanged(boolean useCustomClose);
    }

    public interface f {
        void a();

        void a(Integer duration);

        void a(Map<String, String> params);

        void b();

        void b(Map<String, String> params);

        void c();

        void d();

        void e();

        void f();

        void g();

        void h();
    }

    public h(Context context, BaseAdUnit adUnit, PlacementType placementType) {
        this(context, adUnit, placementType, new com.sigmob.sdk.mraid.c(adUnit, placementType), null, new d());
    }

    h(Context context, BaseAdUnit adUnit, PlacementType placementType, com.sigmob.sdk.mraid.c bridge, com.sigmob.sdk.mraid.c twoPartBridge, d screenMetricsWaiter) {
        this.i = false;
        this.m = ViewState.LOADING;
        this.s = new c();
        this.u = true;
        this.v = p.NONE;
        this.w = false;
        this.x = new HashMap<>();
        com.sigmob.sdk.mraid.e eVar = new com.sigmob.sdk.mraid.e() { // from class: com.sigmob.sdk.mraid.h.1
            @Override // com.sigmob.sdk.mraid.e
            public void a(String event, JSONObject args) {
                SigmobLog.d("handleVpaidEvent event:" + event);
                SigmobLog.d("postMessage args:" + args);
                String strOptString = args.optString("uniqueId");
                if (TextUtils.isEmpty(strOptString) || h.this.r == null) {
                    SigmobLog.e("handleVpaidEvent uniqueId is null:" + args);
                    return;
                }
                n nVar = (n) h.this.x.get(strOptString);
                t tVar = (com.sigmob.sdk.base.utils.v.b(nVar) && (nVar instanceof t)) ? (t) nVar : null;
                event.hashCode();
                switch (event) {
                    case "replay":
                        if (tVar != null) {
                            tVar.c(args);
                            break;
                        }
                        break;
                    case "assetURL":
                        if (tVar != null) {
                            tVar.a(args);
                            break;
                        }
                        break;
                    case "init":
                        t tVar2 = new t(strOptString);
                        tVar2.a(new u() { // from class: com.sigmob.sdk.mraid.h.1.1
                            @Override // com.sigmob.sdk.mraid.u
                            public void a(String uniqueId, int state) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.c(uniqueId, state);
                            }

                            @Override // com.sigmob.sdk.mraid.u
                            public void a(String uniqueId, int code, String message) {
                                ad.a("video", code, message, h.this.c, (ad.a) null);
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.b(uniqueId, "code:" + code + ", msg:" + message);
                            }

                            @Override // com.sigmob.sdk.mraid.u
                            public void a(String uniqueId, long position) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.a(uniqueId, (int) position);
                            }

                            @Override // com.sigmob.sdk.mraid.u
                            public void a(String uniqueId, long duration, int width, int height) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.a(uniqueId, (int) duration, width, height);
                            }

                            @Override // com.sigmob.sdk.mraid.u
                            public void a(String uniqueId, long position, long duration) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.a(uniqueId, (int) position, (int) duration);
                            }

                            @Override // com.sigmob.sdk.mraid.u
                            public void b(String uniqueId, int state) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.b(uniqueId, state);
                            }
                        });
                        h.this.x.put(strOptString, tVar2);
                        tVar2.a(h.this.r.getContext(), args);
                        View viewA = tVar2.a();
                        if (viewA != null) {
                            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(1, 1);
                            layoutParams.topMargin = -1;
                            layoutParams.rightMargin = -1;
                            h.this.d.addView(viewA, layoutParams);
                            break;
                        }
                        break;
                    case "play":
                        if (tVar != null) {
                            tVar.b(args);
                            break;
                        }
                        break;
                    case "seek":
                        if (tVar != null) {
                            tVar.g(args);
                            break;
                        }
                        break;
                    case "stop":
                        if (tVar != null) {
                            tVar.e(args);
                            tVar.b();
                            h.this.x.remove(strOptString);
                            break;
                        }
                        break;
                    case "frame":
                        if (tVar != null) {
                            tVar.h(args);
                            break;
                        }
                        break;
                    case "muted":
                        if (tVar != null) {
                            tVar.f(args);
                            break;
                        }
                        break;
                    case "pause":
                        if (tVar != null) {
                            tVar.d(args);
                            break;
                        }
                        break;
                }
            }

            @Override // com.sigmob.sdk.mraid.e
            public void b(String subEvent, JSONObject args) {
                n nVar;
                String strOptString = args.optString("uniqueId");
                if (TextUtils.isEmpty(strOptString) || (nVar = (n) h.this.x.get(strOptString)) == null || nVar.a() == null) {
                    return;
                }
                h.this.d.bringChildToFront(h.this.r);
            }

            @Override // com.sigmob.sdk.mraid.e
            public void c(String subEvent, JSONObject args) {
                n nVar;
                View viewA;
                String strOptString = args.optString("uniqueId");
                if (TextUtils.isEmpty(strOptString) || (nVar = (n) h.this.x.get(strOptString)) == null || (viewA = nVar.a()) == null) {
                    return;
                }
                com.sigmob.sdk.base.utils.w.a(viewA);
                h.this.d.addView(viewA);
            }

            @Override // com.sigmob.sdk.mraid.e
            public void d(String subEvent, JSONObject args) {
                SigmobLog.d("postMessage subEvent data:" + args);
                String strOptString = args.optString("uniqueId");
                if (TextUtils.isEmpty(strOptString)) {
                    SigmobLog.e("onMotionViewEvent uniqueId is null:" + args);
                }
                n nVar = (n) h.this.x.get(strOptString);
                com.sigmob.sdk.mraid2.h hVar = nVar instanceof com.sigmob.sdk.mraid2.h ? (com.sigmob.sdk.mraid2.h) nVar : null;
                subEvent.hashCode();
                switch (subEvent) {
                    case "init_sensitivity_raw":
                        String strOptString2 = args.optString("type", "");
                        int iOptInt = args.optInt(g.d, 0);
                        com.sigmob.sdk.mraid2.h hVar2 = new com.sigmob.sdk.mraid2.h(strOptString, strOptString2);
                        hVar2.a(new com.sigmob.sdk.mraid2.j() { // from class: com.sigmob.sdk.mraid.h.1.3
                            @Override // com.sigmob.sdk.mraid2.j
                            public void a(String uniqueId, String type, String event, HashMap<String, Object> args2) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.a(uniqueId, type, event, args2);
                            }
                        });
                        hVar2.b(iOptInt);
                        hVar2.d();
                        h.this.x.put(strOptString, hVar2);
                        break;
                    case "init":
                        String strOptString3 = args.optString("type", "");
                        int iOptInt2 = args.optInt(g.c, 0);
                        int iOptInt3 = args.optInt(g.f, 0);
                        int iOptInt4 = args.optInt(g.g, 0);
                        int iOptInt5 = args.optInt(g.h, 0);
                        com.sigmob.sdk.mraid2.h hVar3 = new com.sigmob.sdk.mraid2.h(strOptString, strOptString3);
                        hVar3.a(new com.sigmob.sdk.mraid2.j() { // from class: com.sigmob.sdk.mraid.h.1.2
                            @Override // com.sigmob.sdk.mraid2.j
                            public void a(String uniqueId, String type, String event, HashMap<String, Object> args2) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.a(uniqueId, type, event, args2);
                            }
                        });
                        hVar3.a(new SensorEntity(iOptInt2, iOptInt3, iOptInt4, iOptInt5));
                        hVar3.d();
                        h.this.x.put(strOptString, hVar3);
                        break;
                    case "destroy":
                        if (hVar != null) {
                            hVar.b();
                        }
                        h.this.x.remove(strOptString);
                        break;
                }
            }

            @Override // com.sigmob.sdk.mraid.e
            public void e(String subEvent, JSONObject args) {
                SigmobLog.d("onMotionViewEvent event:" + subEvent);
                SigmobLog.d("postMessage args:" + args);
                String strOptString = args.optString("uniqueId");
                if (TextUtils.isEmpty(strOptString)) {
                    SigmobLog.e("onMotionViewEvent uniqueId is null:" + args);
                }
                n nVar = (n) h.this.x.get(strOptString);
                l lVar = (com.sigmob.sdk.base.utils.v.b(nVar) && (nVar instanceof l)) ? (l) nVar : null;
                subEvent.hashCode();
                switch (subEvent) {
                    case "shakeTimeThreshold":
                        if (lVar != null) {
                            lVar.e(args.optInt(subEvent));
                            break;
                        }
                        break;
                    case "widgetIntervalTime":
                        if (lVar != null) {
                            lVar.d(args.optInt(subEvent));
                            break;
                        }
                        break;
                    case "hidden":
                        if (lVar != null) {
                            lVar.a(args.optBoolean("hidden"));
                            break;
                        }
                        break;
                    case "init":
                        l lVar2 = new l(com.sigmob.sdk.b.e(), strOptString, args.optInt("type"), h.this.c);
                        lVar2.a(new com.sigmob.sdk.mraid2.j() { // from class: com.sigmob.sdk.mraid.h.1.4
                            @Override // com.sigmob.sdk.mraid2.j
                            public void a(String uniqueId, String type, String event, HashMap<String, Object> args2) {
                                if (h.this.g == null) {
                                    return;
                                }
                                h.this.g.a(uniqueId, type, event, args2);
                            }
                        });
                        h.this.x.put(strOptString, lVar2);
                        break;
                    case "frame":
                        if (lVar != null) {
                            lVar.a(args);
                            break;
                        }
                        break;
                    case "start":
                        if (lVar != null) {
                            lVar.d();
                            break;
                        }
                        break;
                    case "sensitivity":
                        if (lVar != null) {
                            lVar.a(args.optInt(subEvent));
                            break;
                        }
                        break;
                    case "destroy":
                        if (lVar != null) {
                            lVar.b();
                        }
                        h.this.x.remove(strOptString);
                        break;
                    case "sensitivity_raw":
                        if (lVar != null) {
                            lVar.b(args.optInt(subEvent));
                            break;
                        }
                        break;
                    case "shakeTriggerType":
                        if (lVar != null) {
                            lVar.c(args.optInt(subEvent));
                            break;
                        }
                        break;
                }
            }
        };
        this.y = eVar;
        com.sigmob.sdk.mraid.d dVar = new com.sigmob.sdk.mraid.d() { // from class: com.sigmob.sdk.mraid.h.2
            @Override // com.sigmob.sdk.mraid.d
            public void a() {
                h.this.k();
                if (h.this.n != null) {
                    h.this.n.a(h.this.d);
                }
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(int width, int height, int offsetX, int offsetY, com.sigmob.sdk.mraid.b.a closePosition, boolean allowOffscreen) {
                if (h.this.n != null) {
                    h.this.n.a(width, height, offsetX, offsetY, closePosition, allowOffscreen);
                }
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(WindAdError errorCode) {
                h.this.a(errorCode);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(String event, Map<String, String> params) {
                h.this.b(event, params);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(URI uri) {
                h.this.a(uri.toString());
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(URI uri, int type, String ext) {
                h.this.a(uri, type, ext);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(URI uri, boolean shouldUseCustomClose) throws com.sigmob.sdk.mraid.f {
                h.this.a(uri, shouldUseCustomClose);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(boolean isVisible) {
                h.this.g.a(isVisible);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void a(boolean allowOrientationChange, p forceOrientation) throws com.sigmob.sdk.mraid.f {
                h.this.a(allowOrientationChange, forceOrientation);
            }

            @Override // com.sigmob.sdk.mraid.d
            public boolean a(ConsoleMessage consoleMessage) {
                return h.this.a(consoleMessage);
            }

            @Override // com.sigmob.sdk.mraid.d
            public boolean a(String message, JsResult result) {
                return h.this.a(message, result);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void b() {
                h.this.j();
            }

            @Override // com.sigmob.sdk.mraid.d
            public void b(String event, Map<String, String> params) {
                h.this.a(event, params);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void b(boolean shouldUseCustomClose) {
                h.this.e(shouldUseCustomClose);
            }

            @Override // com.sigmob.sdk.mraid.d
            public void c() {
                if (h.this.n != null) {
                    h.this.n.e();
                }
            }

            @Override // com.sigmob.sdk.mraid.d
            public void d() {
                h.this.n();
                h.this.n.h();
            }

            @Override // com.sigmob.sdk.mraid.d
            public void e() {
                if (h.this.n != null) {
                    h.this.n.f();
                }
            }

            @Override // com.sigmob.sdk.mraid.d
            public void f() {
                if (h.this.n != null) {
                    h.this.n.g();
                }
            }

            @Override // com.sigmob.sdk.mraid.d
            public void g() {
                if (h.this.n != null) {
                    h.this.n.c();
                }
            }
        };
        this.z = dVar;
        Preconditions.checkNotNull(context);
        FrameLayout frameLayout = new FrameLayout(context);
        this.d = frameLayout;
        this.c = adUnit;
        this.b = placementType;
        this.g = bridge;
        this.e = screenMetricsWaiter;
        this.m = ViewState.LOADING;
        this.f = new q(context, context.getResources().getDisplayMetrics().density);
        frameLayout.setBackgroundColor(0);
        new View(context).setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.mraid.h$$ExternalSyntheticLambda0
            @Override // android.view.View.OnTouchListener
            public final boolean onTouch(View view, MotionEvent motionEvent) {
                return h.a(view, motionEvent);
            }
        });
        this.s.a(context);
        bridge.a(dVar);
        bridge.a(eVar);
        this.h = new m();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void A() {
        e eVar = this.o;
        if (eVar == null) {
            return;
        }
        eVar.useCustomCloseChanged(this.i);
    }

    private float a(String value, float defaultValue) {
        if (TextUtils.isEmpty(value)) {
            return defaultValue;
        }
        try {
            return Float.parseFloat(value);
        } catch (Throwable unused) {
            return defaultValue;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(Context context) {
        try {
            this.g.a(new MraidEnv());
            this.g.a(this.h.b(context), this.h.a(context), m.d(context), m.c(context), h(), true, true);
            this.g.a(this.b);
            this.g.a(this.c.getRvAdSetting());
            WindowInsets windowInsets = this.D;
            if (windowInsets != null) {
                com.sigmob.sdk.base.utils.l lVarA = com.sigmob.sdk.videoplayer.c.a(windowInsets);
                this.g.a(lVarA.a(), lVarA.b(), lVarA.c(), lVarA.d());
            }
            if (!TextUtils.isEmpty(this.c.getVideo_url())) {
                String proxyVideoUrl = this.c.getProxyVideoUrl();
                this.g.a(this.c.getMaterial().video_size != null ? new VideoItem(proxyVideoUrl, this.c.getMaterial().video_size.width.intValue(), this.c.getMaterial().video_size.height.intValue()) : new VideoItem(proxyVideoUrl, 0, 0));
                f();
            }
            MaterialMeta.Builder builderNewBuilder = this.c.getMaterial().newBuilder();
            if (!this.c.getMaterial().has_companion_endcard.booleanValue()) {
                builderNewBuilder.companion(null);
            }
            this.g.a(builderNewBuilder.html_snippet(null).html_url(null).deeplink_url(null).landing_page(null).web_event_handle(null).endcard_url(null).build());
            this.g.a(this.c.getAd().newBuilder().materials(new LinkedList()).ad_tracking(new LinkedList()).build(), this.c.getSlotAdSetting());
        } catch (Throwable th) {
            SigmobLog.e("handleMraidLoad", th);
        }
        if (this.B) {
            k();
        }
    }

    static void a(a mraidListener, ViewState previousViewState, ViewState currentViewState) {
        Preconditions.checkNotNull(mraidListener);
        Preconditions.checkNotNull(previousViewState);
        Preconditions.checkNotNull(currentViewState);
    }

    private void a(Runnable successRunnable) {
        this.e.a();
        Context contextW = w();
        v vVarG = g();
        if (contextW == null || vVarG == null || this.w) {
            return;
        }
        DisplayMetrics displayMetrics = contextW.getResources().getDisplayMetrics();
        com.sigmob.sdk.base.common.g gVar = this.C;
        if (gVar == null) {
            this.f.a(displayMetrics.widthPixels, displayMetrics.heightPixels);
        } else {
            this.f.a(gVar.a(), this.C.b());
        }
        int[] iArr = new int[2];
        ViewGroup viewGroupZ = z();
        viewGroupZ.getLocationOnScreen(iArr);
        this.f.a(iArr[0], iArr[1], viewGroupZ.getWidth(), viewGroupZ.getHeight());
        this.f.c(iArr[0], iArr[1], viewGroupZ.getWidth(), viewGroupZ.getHeight());
        vVarG.getLocationOnScreen(iArr);
        this.f.b(iArr[0], iArr[1], vVarG.getWidth(), vVarG.getHeight());
        this.g.a(new CurrentAppOrientation(ClientMetadata.getInstance().getOrientationInt().intValue() == 1 ? "portrait" : "landscape", true));
        this.g.a(this.f);
        if (successRunnable != null) {
            successRunnable.run();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:26:0x0073  */
    /* JADX WARN: Failed to restore switch over string. Please report as a decompilation issue */
    public void a(String event, Map<String, String> params) {
        byte b2;
        if (this.n == null) {
            return;
        }
        try {
            String strA = com.sigmob.sdk.mraid.c.a(params.get(com.sigmob.sdk.base.n.m));
            String strA2 = com.sigmob.sdk.mraid.c.a(params.get("ctime"));
            String strA3 = com.sigmob.sdk.mraid.c.a(params.get("state"));
            switch (event.hashCode()) {
                case -1610203128:
                    if (!event.equals(ExtensionEvent.AD_ENDCARD_SHOW)) {
                        b2 = -1;
                    } else {
                        b2 = 3;
                    }
                    break;
                case -1102513700:
                    if (!event.equals(ExtensionEvent.AD_COMPANION_CLICK)) {
                        b2 = -1;
                    } else {
                        b2 = 4;
                    }
                    break;
                case -934326481:
                    if (!event.equals("reward")) {
                        b2 = -1;
                    } else {
                        b2 = 1;
                    }
                    break;
                case -900560382:
                    if (!event.equals(ExtensionEvent.AD_SKIP)) {
                        b2 = -1;
                    } else {
                        b2 = 0;
                    }
                    break;
                case 112386354:
                    if (!event.equals(ExtensionEvent.AD_MUTE)) {
                        b2 = -1;
                    } else {
                        b2 = 2;
                    }
                    break;
                case 1293469449:
                    if (!event.equals(ExtensionEvent.AD_SHOE_SKIP_TIME)) {
                        b2 = -1;
                    } else {
                        b2 = 5;
                    }
                    break;
                default:
                    b2 = -1;
                    break;
            }
            if (b2 == 0) {
                this.n.b(a(strA2, 0.0f));
                return;
            }
            if (b2 == 1) {
                this.n.a(a(strA2, 0.0f));
                return;
            }
            if (b2 == 2) {
                if (com.sigmob.sdk.base.utils.v.b(strA3)) {
                    this.n.a(strA3.equalsIgnoreCase("true") || strA3.equalsIgnoreCase("1"));
                }
            } else if (b2 == 3) {
                this.n.a();
            } else if (b2 == 4) {
                this.n.a(strA);
            } else {
                if (b2 != 5) {
                    return;
                }
                this.n.b();
            }
        } catch (Throwable unused) {
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ boolean a(View view, MotionEvent motionEvent) {
        return true;
    }

    private void b(ViewState viewState) {
        SigmobLog.d("MRAID state set to " + viewState);
        ViewState viewState2 = this.m;
        this.m = viewState;
        this.g.a(viewState);
        a aVar = this.n;
        if (aVar != null) {
            a(aVar, viewState2, viewState);
        }
        SigmobLog.d("setViewState state set to " + viewState);
        a((Runnable) null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(String event, Map<String, String> params) {
        if (this.q == null) {
        }
        event.hashCode();
        switch (event) {
            case "AdPaused":
                this.q.b();
                break;
            case "AdImpression":
                this.q.a();
                break;
            case "AdVideoThirdQuartile":
                this.q.f();
                break;
            case "AdVideoMidpoint":
                this.q.g();
                break;
            case "AdVideoComplete":
                this.q.d();
                break;
            case "AdVideoFirstQuartile":
                this.q.e();
                break;
            case "AdError":
                this.q.b(params);
                break;
            case "AdVideoStart":
                this.q.h();
                break;
            case "AdClickThru":
                this.q.a(params);
                break;
            case "AdPlaying":
                this.q.c();
                break;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(String str) {
        Float fValueOf;
        try {
            if (str.equalsIgnoreCase("null") || str.equalsIgnoreCase("undefined") || (fValueOf = Float.valueOf(str)) == null || fValueOf.floatValue() <= 1.0E-5d) {
                return;
            }
            Integer numValueOf = Integer.valueOf((int) (fValueOf.floatValue() * 1000.0f));
            this.j = numValueOf;
            f fVar = this.q;
            if (fVar != null) {
                fVar.a(numValueOf);
            }
        } catch (Throwable unused) {
        }
    }

    private Context w() {
        FrameLayout frameLayout = this.d;
        if (frameLayout == null) {
            return null;
        }
        return frameLayout.getContext();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public int x() {
        return ClientMetadata.getInstance().getScreenOrientation(w());
    }

    private void y() {
        com.sigmob.sdk.mraid.c cVar = this.g;
        if (cVar == null || this.r == null) {
            return;
        }
        cVar.b();
        try {
            this.r.stopLoading();
            this.r.removeAllViews();
            this.r.destroy();
            com.sigmob.sdk.base.utils.w.a(this.r);
        } catch (Exception e2) {
            com.sigmob.sdk.base.utils.k.f(f3486a, "detachMraidWebView: error = " + e2.getMessage(), new Object[0]);
        }
        this.r = null;
    }

    private ViewGroup z() {
        ViewGroup viewGroup = this.l;
        if (viewGroup != null) {
            return viewGroup;
        }
        View viewA = com.sigmob.sdk.base.utils.w.a(w(), this.d);
        ViewGroup viewGroup2 = viewA instanceof ViewGroup ? (ViewGroup) viewA : this.d;
        this.l = viewGroup2;
        return viewGroup2;
    }

    int a(int min, int target, int max) {
        return Math.max(min, Math.min(target, max));
    }

    public String a() {
        return this.g.a();
    }

    public void a(int currentRotation) {
        SigmobLog.i("handleOrientationChange " + currentRotation);
        a((Runnable) null);
    }

    @Deprecated
    void a(int width, int height) {
        this.f.a(0, 0, width, height);
    }

    void a(int widthDips, int heightDips, int offsetXDips, int offsetYDips, com.sigmob.sdk.mraid.b.a closePosition, boolean allowOffscreen) throws com.sigmob.sdk.mraid.f {
    }

    public void a(Activity activity) {
        new Handler(Looper.getMainLooper()).postDelayed(new Runnable() { // from class: com.sigmob.sdk.mraid.h$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.A();
            }
        }, 5000);
    }

    public void a(WindowInsets windowInsets) {
        this.D = windowInsets;
        SigmobLog.d("updateWindowInsets " + windowInsets);
        if (this.B) {
            com.sigmob.sdk.base.utils.l lVarA = com.sigmob.sdk.videoplayer.c.a(windowInsets);
            com.sigmob.sdk.mraid.c cVar = this.g;
            if (cVar == null) {
                return;
            }
            cVar.a(lVarA.a(), lVarA.b(), lVarA.c(), lVarA.d());
        }
    }

    public void a(ValueCallback callback) {
        this.g.a(callback);
    }

    public void a(com.sigmob.sdk.base.common.g adSize) {
        this.C = adSize;
    }

    @Deprecated
    void a(ViewState viewState) {
        this.m = viewState;
    }

    public void a(a mraidListener) {
        this.n = mraidListener;
    }

    @Deprecated
    void a(c receiver) {
        this.s = receiver;
    }

    public void a(e listener) {
        this.o = listener;
    }

    public void a(f vpaidEventListener) {
        this.q = vpaidEventListener;
    }

    public void a(x debugListener) {
        this.p = debugListener;
    }

    void a(WindAdError error) {
        a aVar = this.n;
        if (aVar == null) {
            return;
        }
        aVar.a(error);
    }

    void a(String videoUrl) {
    }

    public void a(String htmlData, b listener) {
        v vVar = new v(w());
        this.r = vVar;
        vVar.a(true);
        this.r.setBackgroundColor(0);
        if (listener != null) {
            listener.onReady(this.r, (com.sigmob.sdk.base.common.v) this.c.getSessionManager());
        }
        this.g.a(this.r);
        this.d.addView(this.r, new FrameLayout.LayoutParams(-1, -1));
        this.g.a(w(), htmlData);
    }

    public void a(String x, String y) {
        this.g.a(x, y);
    }

    public void a(String uniqueId, String type, String began, HashMap<String, Object> args) {
        this.g.a(uniqueId, type, began, args);
    }

    void a(URI uri, int interActionType, String ext) {
        a aVar = this.n;
        if (aVar == null) {
            return;
        }
        aVar.a(uri, interActionType, ext);
    }

    void a(URI uri, boolean shouldUseCustomClose) throws com.sigmob.sdk.mraid.f {
    }

    public void a(boolean result) {
        if (result) {
            this.g.f();
        } else {
            this.g.g();
        }
    }

    void a(boolean allowOrientationChange, p forceOrientation) throws com.sigmob.sdk.mraid.f {
        if (!a(forceOrientation)) {
            throw new com.sigmob.sdk.mraid.f("Unable to force orientation to " + forceOrientation);
        }
        this.u = allowOrientationChange;
        this.v = forceOrientation;
        if (this.m == ViewState.EXPANDED || (this.b == PlacementType.INTERSTITIAL && !this.w)) {
            o();
        }
    }

    boolean a(ConsoleMessage consoleMessage) {
        x xVar = this.p;
        if (xVar == null) {
            return true;
        }
        return xVar.a(consoleMessage);
    }

    boolean a(p newOrientation) {
        if (newOrientation == p.NONE) {
            return true;
        }
        Activity activityC = com.sigmob.sdk.base.utils.w.c(this.d);
        if (activityC == null) {
            return false;
        }
        try {
            int i = activityC.getPackageManager().getActivityInfo(new ComponentName(activityC, activityC.getClass()), 0).screenOrientation;
            return i == -1 || i == newOrientation.a();
        } catch (PackageManager.NameNotFoundException unused) {
            return false;
        }
    }

    boolean a(String message, JsResult result) {
        x xVar = this.p;
        if (xVar != null) {
            return xVar.a(message, result);
        }
        result.confirm();
        return true;
    }

    public void b() {
        this.w = true;
        this.g.a(false);
    }

    void b(int screenOrientation) throws com.sigmob.sdk.mraid.f {
        Activity activityC = com.sigmob.sdk.base.utils.w.c(this.d);
        if (activityC == null || !a(this.v)) {
            throw new com.sigmob.sdk.mraid.f("Attempted to lock orientation to unsupported value: " + this.v.name());
        }
        if (this.t == null) {
            this.t = Integer.valueOf(activityC.getRequestedOrientation());
        }
        try {
            activityC.setRequestedOrientation(screenOrientation);
        } catch (Exception e2) {
            SigmobLog.e("lockOrientation: " + e2.getMessage());
        }
    }

    public void b(String javascript) {
        this.g.c(javascript);
    }

    public void b(String url, b listener) {
        v vVar = new v(w());
        this.r = vVar;
        vVar.a(true);
        this.r.setBackgroundColor(0);
        if (listener != null) {
            listener.onReady(this.r, (com.sigmob.sdk.base.common.v) this.c.getSessionManager());
        }
        this.g.a(this.r);
        this.d.addView(this.r, new FrameLayout.LayoutParams(-1, -1));
        this.g.b(url);
    }

    public void b(boolean result) {
        if (result) {
            this.g.h();
        } else {
            this.g.g();
        }
    }

    public void c() {
        v vVar = this.r;
        if (vVar != null) {
            vVar.resumeTimers();
        }
        if (this.w) {
            this.g.a(true);
        }
        this.w = false;
    }

    public void c(boolean result) {
        if (result) {
            this.g.i();
        }
    }

    public void d() {
        this.g.a(new ExposureChange(100.0f, new Rect(0, 0, z().getWidth(), z().getHeight()), null));
    }

    public void d(boolean isFinishing) {
        this.w = true;
        v vVar = this.r;
        if (vVar != null) {
            vVar.b(isFinishing);
        }
    }

    public com.sigmob.sdk.mraid.c e() {
        return this.g;
    }

    protected void e(boolean useCustomClose) {
        this.i = useCustomClose;
        e eVar = this.o;
        if (eVar == null) {
            return;
        }
        eVar.useCustomCloseChanged(useCustomClose);
    }

    public Integer f() {
        Integer num = this.j;
        if (num != null) {
            return num;
        }
        this.g.b(new ValueCallback() { // from class: com.sigmob.sdk.mraid.h$$ExternalSyntheticLambda3
            @Override // android.webkit.ValueCallback
            public final void onReceiveValue(Object obj) {
                this.f$0.c((String) obj);
            }
        });
        return 0;
    }

    public v g() {
        return this.r;
    }

    boolean h() {
        Activity activityC = com.sigmob.sdk.base.utils.w.c(this.d);
        if (activityC == null || g() == null) {
            return false;
        }
        if (this.b != PlacementType.INLINE) {
            return true;
        }
        return this.h.a(activityC, g());
    }

    void i() {
        Context contextW = w();
        if (contextW == null) {
            return;
        }
        String str = ClientMetadata.getInstance().getOrientationInt().intValue() == 1 ? "portrait" : "landscape";
        DisplayMetrics displayMetrics = contextW.getResources().getDisplayMetrics();
        com.sigmob.sdk.base.common.g gVar = this.C;
        if (gVar == null) {
            this.f.a(displayMetrics.widthPixels, displayMetrics.heightPixels);
        } else {
            this.f.a(gVar.a(), this.C.b());
        }
        ViewGroup viewGroupZ = z();
        int measuredWidth = viewGroupZ.getMeasuredWidth();
        int measuredHeight = viewGroupZ.getMeasuredHeight();
        this.f.a(0, 0, measuredWidth, measuredHeight);
        this.f.c(0, 0, measuredWidth, measuredHeight);
        this.f.b(0, 0, measuredWidth, measuredHeight);
        this.g.a(new CurrentAppOrientation(str, true));
        this.g.a(this.f);
    }

    void j() {
        final Context contextW = w();
        if (contextW == null) {
            return;
        }
        WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.mraid.h$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(contextW);
            }
        });
    }

    void k() {
        try {
            this.B = true;
            i();
            b(ViewState.DEFAULT);
            d();
            this.g.e();
            this.g.a(true);
            try {
                this.g.j();
                o();
                DeviceContext deviceContextB = com.sigmob.sdk.b.b();
                this.g.a(deviceContextB == null ? ClientMetadata.getInstance().getLocation() : deviceContextB.getLocation());
            } catch (Throwable unused) {
                SigmobLog.e("Failed to apply orientation.");
            }
        } catch (Throwable th) {
            SigmobLog.e("handlePageLoad error", th);
        }
    }

    public void l() {
        this.w = false;
        v vVar = this.r;
        if (vVar != null) {
            vVar.onResume();
        }
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
    public void m() {
        this.e.a();
        this.o = null;
        this.n = null;
        Iterator<n> it = this.x.values().iterator();
        while (it.hasNext()) {
            it.next().b();
        }
        try {
            if (com.sigmob.sdk.base.utils.v.b(this.s)) {
                this.s.a();
                this.s = null;
            }
        } catch (Throwable th) {
            com.sigmob.sdk.base.utils.k.f(f3486a, "destroy: error = " + th.getMessage(), new Object[0]);
        }
        try {
            if (com.sigmob.sdk.base.utils.v.b(this.A)) {
                APKStatusBroadcastReceiver aPKStatusBroadcastReceiver = this.A;
                aPKStatusBroadcastReceiver.b(aPKStatusBroadcastReceiver);
                this.A = null;
            }
        } catch (Throwable th2) {
            com.sigmob.sdk.base.utils.k.f(f3486a, "destroy: error = " + th2.getMessage(), new Object[0]);
        }
        if (!this.w) {
            d(true);
        }
        y();
        p();
        this.n = null;
        this.q = null;
        this.o = null;
        this.p = null;
        this.e.a();
        this.x.clear();
        com.sigmob.sdk.base.utils.w.a(this.l);
        this.l = null;
    }

    protected void n() {
        ViewState viewState;
        if (this.r == null || this.m == ViewState.LOADING || this.m == ViewState.HIDDEN) {
            return;
        }
        if (this.m == ViewState.EXPANDED || this.b == PlacementType.INTERSTITIAL) {
            p();
        }
        if (this.m == ViewState.RESIZED || this.m == ViewState.EXPANDED) {
            this.d.addView(this.r, new FrameLayout.LayoutParams(-1, -1));
            this.d.setVisibility(0);
            viewState = ViewState.DEFAULT;
        } else {
            if (this.m != ViewState.DEFAULT) {
                return;
            }
            this.d.setVisibility(4);
            viewState = ViewState.HIDDEN;
        }
        b(viewState);
    }

    void o() throws com.sigmob.sdk.mraid.f {
        int iA;
        if (this.v != p.NONE) {
            iA = this.v.a();
        } else {
            if (this.u) {
                p();
                return;
            }
            Activity activityC = com.sigmob.sdk.base.utils.w.c(this.d);
            if (activityC == null) {
                throw new com.sigmob.sdk.mraid.f("Unable to set MRAID expand orientation to 'none'; expected passed in Activity Context.");
            }
            iA = ClientMetadata.getInstance().getScreenOrientation(activityC);
        }
        b(iA);
    }

    void p() {
        Integer num;
        try {
            Activity activityC = com.sigmob.sdk.base.utils.w.c(this.d);
            if (activityC != null && (num = this.t) != null) {
                activityC.setRequestedOrientation(num.intValue());
            }
            this.t = null;
        } catch (Exception e2) {
            SigmobLog.e("unApplyOrientation: " + e2.getMessage());
        }
    }

    public FrameLayout q() {
        return this.d;
    }

    @Deprecated
    ViewState r() {
        return this.m;
    }

    @Deprecated
    Integer s() {
        return this.t;
    }

    @Deprecated
    boolean t() {
        return this.u;
    }

    @Deprecated
    p u() {
        return this.v;
    }

    @Deprecated
    v v() {
        return this.r;
    }
}
