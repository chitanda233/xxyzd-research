package com.sigmob.sdk.mraid2;

import android.animation.Animator;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.app.Activity;
import android.content.Context;
import android.net.Uri;
import android.util.Log;
import android.view.View;
import android.webkit.JavascriptInterface;
import android.webkit.RenderProcessGoneDetail;
import android.webkit.ValueCallback;
import android.webkit.WebResourceError;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import androidx.core.app.NotificationCompat;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.exceptions.IntentNotResolvableException;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.Md5Util;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.DownloadItem;
import com.czhj.volley.toolbox.FileDownloadRequest;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.SensorEntity;
import com.sigmob.sdk.base.models.rtb.Ad;
import com.sigmob.sdk.base.models.rtb.AdSetting;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.models.rtb.Template;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c extends x {
    private static final String b = "Mraid2AdContainer";
    private static final HashMap<String, c> r = new LinkedHashMap();
    private final c c;
    private d d;
    private c e;
    private final String f;
    private v g;
    private t h;
    private com.sigmob.sdk.mraid2.a i;
    private boolean j;
    private FrameLayout k;
    private LinearLayout l;
    private boolean m;
    private JSONObject n;
    private BaseAdUnit o;
    private final i p;
    private com.sigmob.sdk.base.common.g q;
    private final HashMap<String, q> s;
    private final k t;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid2.c$1, reason: invalid class name */
    class AnonymousClass1 extends i {
        AnonymousClass1() {
        }

        private void a() {
            if (c.this.d != null) {
                if (c.this.n != null) {
                    c.this.d.a(c.this.n);
                }
                c.this.d.d();
            }
            if (c.this.c != null && c.this.c.getMraidBridge() != null && com.sigmob.sdk.base.utils.s.b(c.this.f)) {
                c.this.c.getMraidBridge().c(c.this.f);
            }
            if (c.this.j) {
                return;
            }
            c.this.j = true;
            if (c.this.i != null) {
                c.this.i.a(c.this.e);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(Object obj) {
            a();
        }

        @Override // android.webkit.WebViewClient
        public void onPageFinished(WebView view, String url) {
            super.onPageFinished(view, url);
            Log.d(c.b, c.this.n + "-----------onPageFinished---------" + url);
            if (c.this.d.b()) {
                a();
            } else {
                c.this.d.a(g.INJECTION_JAVASCRIPT, new ValueCallback() { // from class: com.sigmob.sdk.mraid2.c$1$$ExternalSyntheticLambda0
                    @Override // android.webkit.ValueCallback
                    public final void onReceiveValue(Object obj) {
                        this.f$0.a(obj);
                    }
                });
            }
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedError(WebView view, int errorCode, String description, String failingUrl) {
            d mraidBridge;
            ad.a("h5_error", "mraid2", errorCode, failingUrl + " error:" + description, (WindAdRequest) null, (LoadAdRequest) null, c.this.getAdUnitList().get(0), (ad.a) null);
            if (c.this.c == null || com.sigmob.sdk.base.utils.s.a((CharSequence) c.this.f) || (mraidBridge = c.this.c.getMraidBridge()) == null) {
                return;
            }
            mraidBridge.a(c.this.f, errorCode, description);
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedError(WebView view, WebResourceRequest request, WebResourceError error) {
            d mraidBridge;
            SigmobLog.i("onReceivedError:" + error.toString());
            ad.a("h5_error", "mraid2", 0, request.getUrl() + " error:" + ((Object) error.getDescription()), (WindAdRequest) null, (LoadAdRequest) null, c.this.getAdUnitList().get(0), (ad.a) null);
            if (c.this.c == null || com.sigmob.sdk.base.utils.s.a((CharSequence) c.this.f) || (mraidBridge = c.this.c.getMraidBridge()) == null) {
                return;
            }
            mraidBridge.a(c.this.f, error.getErrorCode(), "" + ((Object) error.getDescription()));
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedHttpError(WebView view, WebResourceRequest request, WebResourceResponse errorResponse) {
            ad.a("h5_error", "mraid2", errorResponse.getStatusCode(), request.getUrl().toString(), (WindAdRequest) null, (LoadAdRequest) null, c.this.getAdUnitList().get(0), (ad.a) null);
        }

        @Override // android.webkit.WebViewClient
        public boolean onRenderProcessGone(WebView view, RenderProcessGoneDetail detail) {
            Log.d(c.b, "-----------onRenderProcessGone---------" + detail);
            WindAdError windAdError = (detail == null || !detail.didCrash()) ? WindAdError.RENDER_PROCESS_GONE_UNSPECIFIED : WindAdError.RENDER_PROCESS_GONE_WITH_CRASH;
            SigmobLog.e("handleRenderProcessGone " + windAdError);
            if (com.sigmob.sdk.base.utils.v.b(c.this.i)) {
                c.this.i.a(windAdError);
            }
            c.this.b();
            return true;
        }

        @Override // android.webkit.WebViewClient
        public boolean shouldOverrideUrlLoading(WebView view, String url) {
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) url)) {
                return false;
            }
            if (url.startsWith("http") || url.startsWith("https")) {
                view.loadUrl(url);
                return true;
            }
            try {
                if (c.this.o != null) {
                    c cVar = c.this;
                    cVar.a(url, cVar.o);
                    return true;
                }
                List<BaseAdUnit> adUnitList = c.this.getAdUnitList();
                if (com.sigmob.sdk.base.utils.f.a(adUnitList)) {
                    return true;
                }
                for (int i = 0; i < adUnitList.size(); i++) {
                    if (c.this.a(url, adUnitList.get(i))) {
                        return true;
                    }
                }
                return true;
            } catch (Exception e) {
                e.printStackTrace();
                return true;
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    class a {
        private a() {
        }

        /* synthetic */ a(c cVar, AnonymousClass1 anonymousClass1) {
            this();
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a() {
            Activity activityC = com.sigmob.sdk.base.utils.w.c(c.this);
            if (activityC == null) {
                return;
            }
            com.sigmob.sdk.videoplayer.c.h((Context) activityC);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            Activity activityC = com.sigmob.sdk.base.utils.w.c(c.this);
            if (activityC == null) {
                return;
            }
            com.sigmob.sdk.videoplayer.c.i(activityC);
        }

        @JavascriptInterface
        public boolean canInstallByVid(String vid, String apkName) {
            BaseAdUnit baseAdUnit;
            List<BaseAdUnit> adUnitList = c.this.getAdUnitList();
            if (com.sigmob.sdk.base.utils.f.a(adUnitList)) {
                return false;
            }
            int i = 0;
            while (true) {
                if (i >= adUnitList.size()) {
                    baseAdUnit = null;
                    break;
                }
                baseAdUnit = adUnitList.get(i);
                if (baseAdUnit.getAd().vid.equals(vid)) {
                    break;
                }
                i++;
            }
            if (baseAdUnit == null) {
                return false;
            }
            if (!com.sigmob.sdk.base.utils.s.b(apkName)) {
                apkName = baseAdUnit.getApkName();
                String apkMd5 = baseAdUnit.getApkMd5();
                if (!com.sigmob.sdk.base.utils.s.b(apkName)) {
                    apkName = com.sigmob.sdk.base.utils.s.a((CharSequence) apkMd5) ? "" : apkMd5 + ".apk";
                }
            }
            return baseAdUnit.canInstall(apkName);
        }

        @JavascriptInterface
        public boolean canOpen(String packageName) {
            return com.sigmob.sdk.base.o.a().b(packageName).booleanValue();
        }

        @JavascriptInterface
        public boolean canOpenByVid(String vid, String packageName) {
            BaseAdUnit baseAdUnit;
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) packageName)) {
                List<BaseAdUnit> adUnitList = c.this.getAdUnitList();
                int i = 0;
                if (com.sigmob.sdk.base.utils.f.a(adUnitList)) {
                    return false;
                }
                while (true) {
                    if (i >= adUnitList.size()) {
                        baseAdUnit = null;
                        break;
                    }
                    baseAdUnit = adUnitList.get(i);
                    if (baseAdUnit.getAd().vid.equals(vid)) {
                        break;
                    }
                    i++;
                }
                if (baseAdUnit != null) {
                    return baseAdUnit.canOpen();
                }
            }
            return com.sigmob.sdk.base.o.a().b(packageName).booleanValue();
        }

        @JavascriptInterface
        public void hideSystemUI() {
            ThreadPoolFactory.MainThreadRun(new Runnable() { // from class: com.sigmob.sdk.mraid2.c$a$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a();
                }
            });
        }

        @JavascriptInterface
        public boolean isOpenListReport() {
            com.sigmob.sdk.base.o oVarA = com.sigmob.sdk.base.o.a();
            return (oVarA.S().isEmpty() || com.sigmob.sdk.base.services.b.a() || !oVarA.L().booleanValue()) ? false : true;
        }

        @JavascriptInterface
        public void onOpenListReport() {
            com.sigmob.sdk.base.services.b.c();
        }

        @JavascriptInterface
        public void showSystemUI() {
            ThreadPoolFactory.MainThreadRun(new Runnable() { // from class: com.sigmob.sdk.mraid2.c$a$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            });
        }
    }

    public c(Context context, List<BaseAdUnit> adUnitList, FrameLayout parentLayout) {
        this(context, adUnitList, parentLayout, null, null);
        a(new a(this, null), "sigandroidh5");
    }

    public c(Context context, List<BaseAdUnit> adUnitList, FrameLayout parentLayout, c container, JSONObject args) {
        super(context);
        this.m = false;
        this.p = new AnonymousClass1();
        this.s = new LinkedHashMap();
        this.t = new k() { // from class: com.sigmob.sdk.mraid2.c.3
            @Override // com.sigmob.sdk.mraid2.k
            public void a() {
                if (c.this.h == null) {
                    return;
                }
                c.this.h.a(c.this.e);
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void a(BaseAdUnit adUnit, JSONObject args2) {
                if (c.this.h == null) {
                    return;
                }
                c.this.h.a(c.this.e, adUnit, args2);
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void a(String vid) {
                List<BaseAdUnit> adUnitList2 = c.this.getAdUnitList();
                if (com.sigmob.sdk.base.utils.s.b(vid) && com.sigmob.sdk.base.utils.f.a(adUnitList2)) {
                    for (int i = 0; i < adUnitList2.size(); i++) {
                        c.this.o = adUnitList2.get(i);
                        if (vid.equals(c.this.o.getVid())) {
                            break;
                        }
                    }
                }
                if (c.this.o == null) {
                    return;
                }
                com.sigmob.sdk.base.common.h.g().j(c.this.o.getCamp_id());
                com.sigmob.sdk.base.common.h.g().i(c.this.o.getCrid());
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void a(String subEvent, JSONObject args2) {
                SigmobLog.d("onVpaidEvent: subEvent = " + subEvent + ", args = " + args2);
                String strOptString = args2.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                }
                com.sigmob.sdk.mraid.n nVar = x.f3556a.get(strOptString);
                com.sigmob.sdk.mraid.t tVar = nVar instanceof com.sigmob.sdk.mraid.t ? (com.sigmob.sdk.mraid.t) nVar : null;
                subEvent.hashCode();
                switch (subEvent) {
                    case "replay":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.c(args2);
                            break;
                        }
                        break;
                    case "assetURL":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.a(args2);
                            break;
                        }
                        break;
                    case "init":
                        c.this.a(strOptString, args2);
                        break;
                    case "play":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.b(args2);
                            break;
                        }
                        break;
                    case "seek":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.g(args2);
                            break;
                        }
                        break;
                    case "stop":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.e(args2);
                            tVar.b();
                            Iterator<Map.Entry<String, com.sigmob.sdk.mraid.n>> it = x.f3556a.entrySet().iterator();
                            while (it.hasNext()) {
                                if (it.next().getValue() == tVar) {
                                    it.remove();
                                    break;
                                }
                            }
                            break;
                        }
                        break;
                    case "frame":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.h(args2);
                            break;
                        }
                        break;
                    case "muted":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.f(args2);
                            break;
                        }
                        break;
                    case "pause":
                        if (com.sigmob.sdk.base.utils.v.b(tVar)) {
                            tVar.d(args2);
                            break;
                        }
                        break;
                }
            }

            /* JADX WARN: Code duplicated, block: B:17:0x0166  */
            @Override // com.sigmob.sdk.mraid2.k
            public void a(JSONObject args2) {
                int iDipsToIntPixels;
                int iDipsToIntPixels2;
                int iDipsToIntPixels3;
                int iDipsToIntPixels4;
                int iDipsToIntPixels5;
                int iDipsToIntPixels6;
                int iDipsToIntPixels7;
                int iDipsToIntPixels8;
                Animator.AnimatorListener animatorListener;
                String str;
                Log.d(c.b, "----------onAnimationEvent-------------" + args2.toString());
                final String strOptString = args2.optString(NotificationCompat.CATEGORY_EVENT);
                String strOptString2 = args2.optString("uniqueId");
                double dOptDouble = args2.optDouble(MediationConstant.EXTRA_DURATION);
                JSONObject jSONObjectOptJSONObject = args2.optJSONObject("from");
                JSONObject jSONObjectOptJSONObject2 = args2.optJSONObject("to");
                if (jSONObjectOptJSONObject != null) {
                    iDipsToIntPixels2 = Dips.dipsToIntPixels(jSONObjectOptJSONObject.optInt("x"), c.this.getContext());
                    iDipsToIntPixels3 = Dips.dipsToIntPixels(jSONObjectOptJSONObject.optInt("y"), c.this.getContext());
                    iDipsToIntPixels4 = Dips.dipsToIntPixels(jSONObjectOptJSONObject.optInt(IAdInterListener.AdReqParam.WIDTH), c.this.getContext());
                    iDipsToIntPixels = Dips.dipsToIntPixels(jSONObjectOptJSONObject.optInt("h"), c.this.getContext());
                } else {
                    iDipsToIntPixels = 0;
                    iDipsToIntPixels2 = 0;
                    iDipsToIntPixels3 = 0;
                    iDipsToIntPixels4 = 0;
                }
                if (jSONObjectOptJSONObject2 != null) {
                    iDipsToIntPixels8 = Dips.dipsToIntPixels(jSONObjectOptJSONObject2.optInt("x"), c.this.getContext());
                    iDipsToIntPixels7 = Dips.dipsToIntPixels(jSONObjectOptJSONObject2.optInt("y"), c.this.getContext());
                    iDipsToIntPixels6 = Dips.dipsToIntPixels(jSONObjectOptJSONObject2.optInt(IAdInterListener.AdReqParam.WIDTH), c.this.getContext());
                    iDipsToIntPixels5 = Dips.dipsToIntPixels(jSONObjectOptJSONObject2.optInt("h"), c.this.getContext());
                } else {
                    iDipsToIntPixels5 = 0;
                    iDipsToIntPixels6 = 0;
                    iDipsToIntPixels7 = 0;
                    iDipsToIntPixels8 = 0;
                }
                Animator.AnimatorListener animatorListener2 = new Animator.AnimatorListener() { // from class: com.sigmob.sdk.mraid2.c.3.1
                    @Override // android.animation.Animator.AnimatorListener
                    public void onAnimationCancel(Animator animation) {
                    }

                    @Override // android.animation.Animator.AnimatorListener
                    public void onAnimationEnd(Animator animation) {
                        c.this.d.g(strOptString);
                    }

                    @Override // android.animation.Animator.AnimatorListener
                    public void onAnimationRepeat(Animator animation) {
                    }

                    @Override // android.animation.Animator.AnimatorListener
                    public void onAnimationStart(Animator animation) {
                    }
                };
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2)) {
                    return;
                }
                com.sigmob.sdk.mraid.n nVar = x.f3556a.get(strOptString2);
                if (nVar != null) {
                    nVar.a(c.this.f);
                    View viewA = nVar.a();
                    if (viewA != null) {
                        AnimatorSet animatorSet = new AnimatorSet();
                        w wVar = new w(viewA);
                        str = MediaFormat.KEY_HEIGHT;
                        animatorSet.playTogether(ObjectAnimator.ofFloat(viewA, "translationX", iDipsToIntPixels2, iDipsToIntPixels8), ObjectAnimator.ofFloat(viewA, "translationY", iDipsToIntPixels3, iDipsToIntPixels7), ObjectAnimator.ofInt(wVar, MediaFormat.KEY_WIDTH, iDipsToIntPixels4, iDipsToIntPixels6), ObjectAnimator.ofInt(wVar, str, iDipsToIntPixels, iDipsToIntPixels5));
                        animatorListener = animatorListener2;
                        animatorSet.addListener(animatorListener);
                        animatorSet.setDuration((long) (dOptDouble * 1000.0d)).start();
                    } else {
                        animatorListener = animatorListener2;
                        str = MediaFormat.KEY_HEIGHT;
                    }
                } else {
                    animatorListener = animatorListener2;
                    str = MediaFormat.KEY_HEIGHT;
                }
                c cVar = (c) c.r.get(strOptString2);
                if (cVar != null) {
                    AnimatorSet animatorSet2 = new AnimatorSet();
                    w wVar2 = new w(cVar);
                    animatorSet2.playTogether(ObjectAnimator.ofFloat(cVar, "translationX", iDipsToIntPixels2, iDipsToIntPixels8), ObjectAnimator.ofFloat(cVar, "translationY", iDipsToIntPixels3, iDipsToIntPixels7), ObjectAnimator.ofInt(wVar2, MediaFormat.KEY_WIDTH, iDipsToIntPixels4, iDipsToIntPixels6), ObjectAnimator.ofInt(wVar2, str, iDipsToIntPixels, iDipsToIntPixels5));
                    animatorSet2.addListener(animatorListener);
                    animatorSet2.setDuration((long) (dOptDouble * 1000.0d)).start();
                }
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void b() {
                for (com.sigmob.sdk.mraid.n nVar : x.f3556a.values()) {
                    if (com.sigmob.sdk.base.utils.s.a((CharSequence) nVar.c(), (CharSequence) c.this.f)) {
                        com.sigmob.sdk.base.utils.w.a(nVar.a());
                        nVar.b();
                    }
                }
                com.sigmob.sdk.base.utils.w.a(c.this.e);
                if (com.sigmob.sdk.base.utils.f.b(c.this.s)) {
                    Iterator it = c.this.s.values().iterator();
                    while (it.hasNext()) {
                        ((q) it.next()).c();
                    }
                    c.this.s.clear();
                }
                if (c.this.e != null) {
                    c.this.e = null;
                }
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void b(String subEvent, JSONObject args2) {
                SigmobLog.d(" onTimerEvent :" + subEvent + ":" + args2);
                String strOptString = args2.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                }
                q qVar = (q) c.this.s.get(strOptString);
                subEvent.hashCode();
                switch (subEvent) {
                    case "invalidate":
                        if (qVar != null) {
                            qVar.c();
                        }
                        c.this.s.remove(strOptString);
                        break;
                    case "fire":
                        if (qVar != null) {
                            qVar.b();
                            break;
                        }
                        break;
                    case "init":
                        c.this.s.put(strOptString, new q(c.this.d, args2));
                        break;
                    case "pause":
                        if (qVar != null) {
                            qVar.a();
                            break;
                        }
                        break;
                }
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void b(JSONObject args2) {
                String strOptString = args2.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                    return;
                }
                com.sigmob.sdk.mraid.n nVar = x.f3556a.get(strOptString);
                if (com.sigmob.sdk.base.utils.v.b(nVar)) {
                    nVar.a(c.this.f);
                    View viewA = nVar.a();
                    if (com.sigmob.sdk.base.utils.v.b(viewA)) {
                        com.sigmob.sdk.base.utils.w.a(viewA);
                        if (!c.this.m || c.this.l == null) {
                            c.this.k.addView(viewA);
                        } else {
                            viewA.setX(0.0f);
                            viewA.setY(0.0f);
                            c.this.l.addView(viewA);
                        }
                    }
                }
                c cVar = (c) c.r.get(strOptString);
                if (cVar == null) {
                    return;
                }
                com.sigmob.sdk.base.utils.w.a(cVar);
                c.this.k.addView(cVar);
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void c() {
                if (c.this.h == null) {
                    return;
                }
                c.this.h.b(c.this.e);
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void c(String subEvent, JSONObject args2) {
                JSONObject jSONObjectOptJSONObject;
                SigmobLog.d(" onWebViewEvent :" + subEvent + ":" + args2);
                String strOptString = args2.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                }
                c cVar = (c) c.r.get(strOptString);
                subEvent.hashCode();
                switch (subEvent) {
                    case "loadHTMLString":
                        String strOptString2 = args2.optString(com.baidu.mobads.sdk.internal.a.f);
                        if (cVar != null && com.sigmob.sdk.base.utils.s.b(strOptString2)) {
                            cVar.a(strOptString2);
                            break;
                        }
                        break;
                    case "loadId":
                        String strOptString3 = args2.optString("id");
                        if (cVar != null && com.sigmob.sdk.base.utils.s.b(strOptString3)) {
                            cVar.f(strOptString3);
                            break;
                        }
                        break;
                    case "stopLoading":
                        if (cVar != null) {
                            cVar.k();
                            break;
                        }
                        break;
                    case "reload":
                        if (cVar != null) {
                            cVar.j();
                            break;
                        }
                        break;
                    case "init":
                        if (c.this.h != null) {
                            c.r.put(strOptString, c.this.h.a(c.this.e, args2));
                            break;
                        }
                        break;
                    case "frame":
                        if (cVar != null && (jSONObjectOptJSONObject = args2.optJSONObject("frame")) != null) {
                            int iOptInt = jSONObjectOptJSONObject.optInt("x", 0);
                            int iOptInt2 = jSONObjectOptJSONObject.optInt("y", 0);
                            int iOptInt3 = jSONObjectOptJSONObject.optInt(IAdInterListener.AdReqParam.WIDTH, -1);
                            int iOptInt4 = jSONObjectOptJSONObject.optInt("h", -1);
                            if (iOptInt3 > 0) {
                                iOptInt3 = Dips.dipsToIntPixels(iOptInt3, com.sigmob.sdk.b.e());
                            }
                            if (iOptInt4 > 0) {
                                iOptInt4 = Dips.dipsToIntPixels(iOptInt4, com.sigmob.sdk.b.e());
                            }
                            cVar.setLayoutParams(new FrameLayout.LayoutParams(iOptInt3, iOptInt4));
                            cVar.setX(Dips.dipsToIntPixels(iOptInt, com.sigmob.sdk.b.e()));
                            cVar.setY(Dips.dipsToIntPixels(iOptInt2, com.sigmob.sdk.b.e()));
                            cVar.requestLayout();
                            break;
                        }
                        break;
                    case "loadURL":
                        String strOptString4 = args2.optString("url");
                        if (cVar != null) {
                            cVar.b(strOptString4);
                            break;
                        }
                        break;
                    case "loadURLByPackage":
                        String strOptString5 = args2.optString("URL");
                        if (cVar != null && com.sigmob.sdk.base.utils.s.b(strOptString5)) {
                            cVar.e(strOptString5);
                            break;
                        }
                        break;
                }
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void c(JSONObject args2) {
                String strOptString = args2.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                    return;
                }
                com.sigmob.sdk.mraid.n nVar = x.f3556a.get(strOptString);
                if (com.sigmob.sdk.base.utils.v.b(nVar)) {
                    nVar.a(c.this.f);
                    View viewA = nVar.a();
                    if (com.sigmob.sdk.base.utils.v.b(viewA)) {
                        com.sigmob.sdk.base.utils.w.a(viewA);
                        if (!c.this.m || c.this.l == null) {
                            c.this.k.addView(viewA);
                            c.this.k.bringChildToFront(c.this.e);
                        } else {
                            viewA.setX(0.0f);
                            viewA.setY(0.0f);
                            c.this.l.addView(viewA);
                        }
                    }
                }
                c cVar = (c) c.r.get(strOptString);
                if (cVar == null) {
                    return;
                }
                com.sigmob.sdk.base.utils.w.a(cVar);
                c.this.k.addView(cVar);
                c.this.k.bringChildToFront(c.this.e);
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void d() {
                if (c.this.h == null) {
                    return;
                }
                c.this.h.a();
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void d(JSONObject args2) {
                c.this.m = true;
                int iOptInt = args2.optInt("flag");
                if (c.this.h != null && c.this.l == null) {
                    c cVar = c.this;
                    cVar.l = cVar.h.a(c.this.e, iOptInt);
                    ArrayList arrayList = new ArrayList();
                    for (int i = 0; i < c.this.k.getChildCount(); i++) {
                        View childAt = c.this.k.getChildAt(i);
                        if (childAt instanceof com.sigmob.sdk.mraid.r) {
                            arrayList.add((com.sigmob.sdk.mraid.r) childAt);
                        }
                    }
                    Log.d(c.b, "-------------onUseScrollView----------" + arrayList.size());
                    for (int i2 = 0; i2 < arrayList.size(); i2++) {
                        com.sigmob.sdk.mraid.r rVar = (com.sigmob.sdk.mraid.r) arrayList.get(i2);
                        rVar.setX(0.0f);
                        rVar.setY(0.0f);
                        com.sigmob.sdk.base.utils.w.a(rVar);
                        c.this.l.addView(rVar);
                    }
                }
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void e(JSONObject args2) {
                if (c.this.h == null) {
                    return;
                }
                c.this.h.b(c.this.e, args2);
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void f(JSONObject json) {
                SigmobLog.d("onMotionEvent: json = " + json);
                JSONObject jSONObjectOptJSONObject = json.optJSONObject("args");
                String strOptString = jSONObjectOptJSONObject == null ? null : jSONObjectOptJSONObject.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                    SigmobLog.e("onMotionViewEvent: uniqueId is null.");
                }
                com.sigmob.sdk.mraid.n nVar = x.f3556a.get(strOptString);
                h hVar = nVar instanceof h ? (h) nVar : null;
                String strOptString2 = json.optString("subEvent");
                strOptString2.hashCode();
                switch (strOptString2) {
                    case "init_sensitivity_raw":
                        String strOptString3 = jSONObjectOptJSONObject.optString("type", "");
                        int iOptInt = jSONObjectOptJSONObject.optInt(com.sigmob.sdk.mraid.g.d, 0);
                        h hVar2 = new h(strOptString, strOptString3);
                        hVar2.a(new j() { // from class: com.sigmob.sdk.mraid2.c.3.3
                            @Override // com.sigmob.sdk.mraid2.j
                            public void a(String uniqueId, String type, String event, HashMap<String, Object> args2) {
                                if (c.this.d == null) {
                                    return;
                                }
                                c.this.d.a(uniqueId, type, event, args2);
                            }
                        });
                        hVar2.b(iOptInt);
                        hVar2.d();
                        x.f3556a.put(strOptString, hVar2);
                        break;
                    case "init":
                        String strOptString4 = jSONObjectOptJSONObject.optString("type", "");
                        int iOptInt2 = jSONObjectOptJSONObject.optInt(com.sigmob.sdk.mraid.g.c, 0);
                        int iOptInt3 = jSONObjectOptJSONObject.optInt(com.sigmob.sdk.mraid.g.f, 0);
                        int iOptInt4 = jSONObjectOptJSONObject.optInt(com.sigmob.sdk.mraid.g.g, 0);
                        int iOptInt5 = jSONObjectOptJSONObject.optInt(com.sigmob.sdk.mraid.g.h, 0);
                        SigmobLog.d("onMotionEvent: type = " + strOptString4 + ", level = " + iOptInt2);
                        h hVar3 = new h(strOptString, strOptString4);
                        hVar3.a(new j() { // from class: com.sigmob.sdk.mraid2.c.3.2
                            @Override // com.sigmob.sdk.mraid2.j
                            public void a(String uniqueId, String type, String event, HashMap<String, Object> args2) {
                                if (c.this.d == null) {
                                    return;
                                }
                                c.this.d.a(uniqueId, type, event, args2);
                            }
                        });
                        hVar3.a(new SensorEntity(iOptInt2, iOptInt3, iOptInt4, iOptInt5));
                        hVar3.d();
                        x.f3556a.put(strOptString, hVar3);
                        break;
                    case "destroy":
                        if (hVar != null) {
                            hVar.b();
                        }
                        x.f3556a.remove(strOptString);
                        break;
                }
            }

            @Override // com.sigmob.sdk.mraid2.k
            public void g(JSONObject json) {
                SigmobLog.d("onMotionViewEvent: json = " + json);
                JSONObject jSONObjectOptJSONObject = json.optJSONObject("args");
                String strOptString = jSONObjectOptJSONObject == null ? null : jSONObjectOptJSONObject.optString("uniqueId");
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
                    SigmobLog.e("onMotionViewEvent: uniqueId is null.");
                }
                com.sigmob.sdk.mraid.n nVar = x.f3556a.get(strOptString);
                com.sigmob.sdk.mraid.l lVar = nVar instanceof com.sigmob.sdk.mraid.l ? (com.sigmob.sdk.mraid.l) nVar : null;
                String strOptString2 = json.optString("subEvent");
                strOptString2.hashCode();
                switch (strOptString2) {
                    case "shakeTimeThreshold":
                        if (lVar != null) {
                            lVar.e(jSONObjectOptJSONObject.optInt(strOptString2));
                            break;
                        }
                        break;
                    case "widgetIntervalTime":
                        if (lVar != null) {
                            lVar.d(jSONObjectOptJSONObject.optInt(strOptString2));
                            break;
                        }
                        break;
                    case "hidden":
                        if (lVar != null) {
                            lVar.a(jSONObjectOptJSONObject.optBoolean("hidden"));
                            break;
                        }
                        break;
                    case "init":
                        com.sigmob.sdk.mraid.l lVar2 = new com.sigmob.sdk.mraid.l(com.sigmob.sdk.b.e(), strOptString, jSONObjectOptJSONObject.optInt("type"), c.this.o);
                        lVar2.a(new j() { // from class: com.sigmob.sdk.mraid2.c.3.4
                            @Override // com.sigmob.sdk.mraid2.j
                            public void a(String uniqueId, String type, String event, HashMap<String, Object> args2) {
                                if (c.this.d == null) {
                                    return;
                                }
                                c.this.d.a(uniqueId, type, event, args2);
                            }
                        });
                        x.f3556a.put(strOptString, lVar2);
                        break;
                    case "frame":
                        if (lVar != null) {
                            lVar.a(jSONObjectOptJSONObject);
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
                            lVar.a(jSONObjectOptJSONObject.optInt(strOptString2));
                            break;
                        }
                        break;
                    case "destroy":
                        if (lVar != null) {
                            lVar.b();
                        }
                        x.f3556a.remove(strOptString);
                        break;
                    case "sensitivity_raw":
                        if (lVar != null) {
                            lVar.b(jSONObjectOptJSONObject.optInt(strOptString2));
                            break;
                        }
                        break;
                    case "shakeTriggerType":
                        if (lVar != null) {
                            lVar.c(jSONObjectOptJSONObject.optInt(strOptString2));
                            break;
                        }
                        break;
                }
            }
        };
        this.e = this;
        this.k = parentLayout;
        this.c = container;
        this.j = false;
        if (args == null) {
            String str = "wv_" + UUID.randomUUID().toString();
            this.f = str;
            r.put(str, this);
        } else {
            try {
                this.n = new JSONObject(args.optString("args"));
            } catch (JSONException e) {
                e.printStackTrace();
            }
            this.f = args.optString("uniqueId");
        }
        a(true);
        setBackgroundColor(0);
        com.sigmob.sdk.base.utils.j.a(b, getSettings());
        this.p.a(com.sigmob.sdk.base.o.a().ad());
        BaseAdUnit baseAdUnit = adUnitList.get(0);
        if (com.sigmob.sdk.base.utils.v.b(baseAdUnit)) {
            this.p.b(baseAdUnit.isDisablexRequestWith());
        }
        setWebViewClient(this.p);
        d dVar = new d(adUnitList);
        this.d = dVar;
        dVar.a(this.t);
        this.d.a(this);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String uniqueId, JSONObject args) {
        com.sigmob.sdk.mraid.t tVar = new com.sigmob.sdk.mraid.t(uniqueId);
        tVar.a(new com.sigmob.sdk.mraid.u() { // from class: com.sigmob.sdk.mraid2.c.4
            @Override // com.sigmob.sdk.mraid.u
            public void a(String uniqueId2, int state) {
                if (c.this.d == null) {
                    return;
                }
                c.this.d.a(uniqueId2, state);
            }

            @Override // com.sigmob.sdk.mraid.u
            public void a(String uniqueId2, int code, String message) {
                ad.a("video", code, message, c.this.o, (ad.a) null);
                if (c.this.d == null) {
                    return;
                }
                c.this.d.a(uniqueId2, "code:" + code + ", msg:" + message);
            }

            @Override // com.sigmob.sdk.mraid.u
            public void a(String uniqueId2, long position) {
                if (c.this.d == null) {
                    return;
                }
                c.this.d.c(uniqueId2, (int) position);
            }

            @Override // com.sigmob.sdk.mraid.u
            public void a(String uniqueId2, long duration, int width, int height) {
                if (c.this.d == null) {
                    return;
                }
                c.this.d.a(uniqueId2, (int) duration, width, height);
            }

            @Override // com.sigmob.sdk.mraid.u
            public void a(String uniqueId2, long position, long duration) {
                if (c.this.d == null) {
                    return;
                }
                c.this.d.a(uniqueId2, (int) position, (int) duration);
            }

            @Override // com.sigmob.sdk.mraid.u
            public void b(String uniqueId2, int state) {
                if (c.this.d == null) {
                    return;
                }
                c.this.d.b(uniqueId2, state);
            }
        });
        tVar.a(getContext(), args);
        View viewA = tVar.a();
        if (com.sigmob.sdk.base.utils.v.b(viewA)) {
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(1, 1);
            layoutParams.topMargin = 0;
            layoutParams.rightMargin = 0;
            viewA.setLayoutParams(layoutParams);
        }
        f3556a.put(uniqueId, tVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean a(String url, BaseAdUnit adUnit) throws IntentNotResolvableException {
        if (!com.sigmob.sdk.base.utils.s.a((CharSequence) url) && adUnit != null) {
            AdSetting adSetting = adUnit.getAdSetting();
            List<String> list = adSetting == null ? null : adSetting.scheme_white_list;
            if (com.sigmob.sdk.base.utils.f.a(list)) {
                return false;
            }
            for (int i = 0; i < list.size(); i++) {
                String str = list.get(i);
                if (url.startsWith(str) || str.equals("*")) {
                    com.sigmob.sdk.base.utils.h.a(getContext(), Uri.parse(url));
                    return true;
                }
            }
        }
        return false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e(String url) {
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) url)) {
            return;
        }
        a(new d.a(this.d), "sigandroid");
        String strMd5 = Md5Util.md5(url);
        File fileF = com.sigmob.sdk.base.utils.n.f(com.sigmob.sdk.base.utils.n.c);
        if (fileF == null) {
            return;
        }
        final File file = new File(fileF.getAbsolutePath() + File.separator + strMd5, "endcard.html");
        Log.d(b, file.exists() + "---------loadURLByPackage----------" + file.getAbsolutePath());
        if (file.exists()) {
            c("file://" + file.getAbsolutePath());
            return;
        }
        File file2 = new File(fileF, strMd5 + ".tgz");
        DownloadItem downloadItem = new DownloadItem();
        downloadItem.url = url;
        downloadItem.filePath = file2.getAbsolutePath();
        downloadItem.type = DownloadItem.FileType.FILE;
        com.sigmob.sdk.base.common.t.a().add(downloadItem, new FileDownloadRequest.FileDownloadListener() { // from class: com.sigmob.sdk.mraid2.c.2
            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void downloadProgress(DownloadItem item, long totalSize, long readSize) {
            }

            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void onCancel(DownloadItem item) {
                Log.d(c.b, "-----------onCancel----------" + item.url);
            }

            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void onErrorResponse(DownloadItem item) {
                Log.d(c.b, "-----------onErrorResponse----------" + item.url);
            }

            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void onSuccess(DownloadItem item) {
                Log.d(c.b, item.url + "-----------onSuccess----------" + item.filePath);
                try {
                    com.sigmob.sdk.base.utils.g.a(new File(item.filePath), new File(item.filePath.replace(".tgz", "/")));
                    if (file.exists()) {
                        c.this.e.c("file://" + file.getAbsolutePath());
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void f(String templateId) {
        String strUtf8;
        MaterialMeta materialMeta;
        Template template;
        Log.d(b, "---------loadContentId----------" + templateId);
        int i = 0;
        while (true) {
            if (i >= getAdUnitList().size()) {
                strUtf8 = null;
                break;
            }
            BaseAdUnit baseAdUnit = getAdUnitList().get(i);
            if (baseAdUnit != null) {
                if (baseAdUnit.scene == null || !templateId.equals(baseAdUnit.scene.templateId)) {
                    Ad ad = baseAdUnit.getAd();
                    if (ad != null && ad.materials != null && (materialMeta = ad.materials.get(0)) != null) {
                        if (materialMeta.main_template != null && templateId.equals(materialMeta.main_template.templateId)) {
                            template = materialMeta.main_template;
                        } else if (materialMeta.sub_template != null && templateId.equals(materialMeta.sub_template.templateId)) {
                            template = materialMeta.sub_template;
                        }
                    }
                } else {
                    template = baseAdUnit.scene;
                }
                strUtf8 = template.context.utf8();
                break;
            }
            i++;
        }
        if (com.sigmob.sdk.base.utils.s.b(strUtf8)) {
            a(strUtf8);
        }
    }

    public static HashMap<String, c> getMraidWebViews() {
        return r;
    }

    private Template getTemplate() {
        BaseAdUnit baseAdUnit;
        List<BaseAdUnit> adUnitList = getAdUnitList();
        if (com.sigmob.sdk.base.utils.f.a(adUnitList) || (baseAdUnit = adUnitList.get(0)) == null) {
            return null;
        }
        Template template = baseAdUnit.scene;
        MaterialMeta material = baseAdUnit.getMaterial();
        if (template == null && material == null) {
            return null;
        }
        if (com.sigmob.sdk.base.utils.v.b(template)) {
            return template;
        }
        return material.main_template == null ? material.sub_template : material.main_template;
    }

    public void a() {
        Template template = getTemplate();
        if (template == null) {
            return;
        }
        String strUtf8 = template.context.utf8();
        int iIntValue = template.type.intValue();
        if (iIntValue == 1) {
            b(strUtf8);
            return;
        }
        if (iIntValue == 2) {
            a(strUtf8);
        } else if (iIntValue != 3) {
            SigmobLog.e("template type error:" + template.type);
        } else {
            e(strUtf8);
        }
    }

    public void a(String htmlData) {
        a(new d.a(this.d), "sigandroid");
        File fileB = com.sigmob.sdk.base.utils.n.b(htmlData, Md5Util.md5(htmlData) + ".html");
        if (com.sigmob.sdk.base.utils.v.b(fileB) && com.sigmob.sdk.base.utils.s.b(fileB.getAbsolutePath())) {
            c("file://" + fileB.getAbsolutePath());
        } else {
            a(Networking.getBaseUrlScheme() + "://localhost/", htmlData, "text/html", "UTF-8", null);
        }
    }

    @Override // com.sigmob.sdk.mraid2.x
    public void b() {
        try {
            setLoadListener(null);
            setNextWebViewListener(null);
            setScrollTouchListener(null);
            if (this.e != null) {
                this.e = null;
            }
            d dVar = this.d;
            if (dVar != null) {
                dVar.g();
                this.d = null;
            }
            super.b();
        } catch (Throwable unused) {
        }
    }

    public void b(String url) {
        Log.d(b, "---------loadContentUrl----------" + url);
        a(new d.a(this.d), "sigandroid");
        c(url);
    }

    public com.sigmob.sdk.base.common.g getAdSize() {
        return this.q;
    }

    @Override // com.sigmob.sdk.mraid2.x
    List<BaseAdUnit> getAdUnitList() {
        d dVar = this.d;
        if (dVar == null) {
            return null;
        }
        return dVar.c();
    }

    public d getMraidBridge() {
        return this.d;
    }

    public v getScrollTouchListener() {
        return this.g;
    }

    public String getUniqueId() {
        return this.f;
    }

    @Override // android.view.View
    protected void onVisibilityChanged(View changedView, int visibility) {
        super.onVisibilityChanged(changedView, visibility);
        d dVar = this.d;
        if (dVar == null) {
            return;
        }
        dVar.a(visibility == 0);
    }

    public void setAdSize(com.sigmob.sdk.base.common.g adSize) {
        this.q = adSize;
    }

    public void setLoadListener(com.sigmob.sdk.mraid2.a loadWebViewListener) {
        this.i = loadWebViewListener;
    }

    public void setNextWebViewListener(t nextWebViewListener) {
        this.h = nextWebViewListener;
    }

    public void setScrollTouchListener(v scrollTouchListener) {
        this.g = scrollTouchListener;
    }
}
