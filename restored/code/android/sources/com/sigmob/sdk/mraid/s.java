package com.sigmob.sdk.mraid;

import android.app.Activity;
import android.content.Context;
import android.content.res.Configuration;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.WindowInsets;
import android.webkit.ConsoleMessage;
import android.webkit.JsResult;
import android.webkit.ValueCallback;
import android.widget.FrameLayout;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ac;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.PlacementType;
import com.sigmob.sdk.base.views.ar;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import com.sigmob.windad.natives.WindNativeAdData;
import java.net.URI;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class s extends com.sigmob.sdk.videoAd.b implements ac {
    public static final String f = "s";
    protected com.sigmob.sdk.base.common.v g;
    private final Bundle h;
    private int i;
    private final com.sigmob.sdk.videoAd.a j;
    private int k;
    private boolean l;
    private final BaseAdUnit m;
    private h n;
    private x o;
    private ar p;
    private int q;
    private boolean r;
    private boolean s;
    private boolean t;
    private com.sigmob.sdk.base.views.q u;
    private boolean v;
    private com.sigmob.sdk.nativead.b w;
    private com.sigmob.sdk.base.views.w x;
    private JSONObject y;
    private final View.OnClickListener z;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid.s$3, reason: invalid class name */
    class AnonymousClass3 implements h.a {
        AnonymousClass3() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(String str) {
            if (c.a(str) == null || s.this.g == null) {
                return;
            }
            float f = Float.parseFloat(str);
            if (f < 0.999f && !s.this.r) {
                s.this.r = true;
                s.this.b("skip");
            }
            if (s.this.l || s.this.m.getAd_type() == 4 || f <= s.this.m.getFinishedTime()) {
                return;
            }
            s.this.l = true;
            s.this.g.a("reward", s.this.n.f().intValue());
            s.this.a(IntentActions.ACTION_REWARDED_VIDEO_COMPLETE);
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a() {
            s.this.b("show");
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a(float cvtime) {
            s.this.l = true;
            s.this.b("reward");
            s.this.a(IntentActions.ACTION_REWARDED_VIDEO_COMPLETE);
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a(int width, int height, int offsetX, int offsetY, b.a closePosition, boolean allowOffscreen) {
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a(View view) {
            s.this.b("start");
            s.this.a(IntentActions.ACTION_INTERSTITIAL_SHOW);
            SigmobLog.d("onLoaded() called");
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a(WindAdError error) {
            SigmobLog.d("Finishing the activity due to a problem: " + error);
            s.this.b("error");
            if (s.this.b != null) {
                s.this.a(IntentActions.ACTION_INTERSTITIAL_FAIL);
            }
            s.this.d.a();
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a(String ext) {
            boolean z = true;
            if (!TextUtils.isEmpty(ext)) {
                try {
                    JSONObject jSONObject = new JSONObject(ext);
                    int iOptInt = jSONObject.optInt("type");
                    if (jSONObject.has("x") && jSONObject.has("y")) {
                        s.this.n.a(String.valueOf(jSONObject.optInt("x")), String.valueOf(jSONObject.optInt("y")));
                    }
                    if (iOptInt != 1) {
                        s.this.y = jSONObject.optJSONObject("log_data");
                    } else {
                        z = false;
                    }
                } catch (Exception unused) {
                    s.this.n.a("0", "0");
                }
            }
            s.this.j.a(com.sigmob.sdk.base.a.COMPANION, s.this.n.a(), z);
        }

        /* JADX WARN: Code duplicated, block: B:26:0x006c  */
        /* JADX WARN: Code duplicated, block: B:27:0x0086  */
        @Override // com.sigmob.sdk.mraid.h.a
        public void a(URI uri, int InterActionType, String ext) {
            boolean z;
            boolean z2;
            boolean z3;
            JSONObject jSONObject;
            boolean z4 = true;
            boolean z5 = false;
            JSONObject jSONObject2 = null;
            if (!TextUtils.isEmpty(ext)) {
                try {
                    JSONObject jSONObject3 = new JSONObject(ext);
                    try {
                        int iOptInt = jSONObject3.optInt("type");
                        if (jSONObject3.has("x") && jSONObject3.has("y")) {
                            s.this.n.a(String.valueOf(jSONObject3.optInt("x")), String.valueOf(jSONObject3.optInt("y")));
                        }
                        boolean zOptBoolean = jSONObject3.optBoolean("disable_landing");
                        try {
                            z = !jSONObject3.optBoolean("feDisable");
                            if (iOptInt != 1) {
                                try {
                                    s.this.y = jSONObject3.optJSONObject("log_data");
                                } catch (Exception unused) {
                                    z5 = zOptBoolean;
                                    jSONObject2 = jSONObject3;
                                    z2 = z;
                                    z3 = true;
                                    jSONObject = jSONObject2;
                                }
                            } else {
                                z4 = false;
                            }
                            z5 = zOptBoolean;
                            z2 = z;
                            jSONObject = jSONObject3;
                            z3 = z4;
                        } catch (Exception unused2) {
                            z5 = zOptBoolean;
                            jSONObject2 = jSONObject3;
                            z = true;
                            z2 = z;
                            z3 = true;
                            jSONObject = jSONObject2;
                            if (z5) {
                                s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, uri.toString(), s.this.n.a(), z3, z2, jSONObject);
                            } else {
                                s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, (String) null, s.this.n.a(), z3, z2);
                            }
                        }
                    } catch (Exception unused3) {
                    }
                } catch (Exception unused4) {
                }
                if (z5) {
                    s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, uri.toString(), s.this.n.a(), z3, z2, jSONObject);
                } else {
                    s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, (String) null, s.this.n.a(), z3, z2);
                }
            }
            z3 = true;
            z2 = true;
            jSONObject = jSONObject2;
            if (z5) {
                s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, uri.toString(), s.this.n.a(), z3, z2, jSONObject);
            } else {
                s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, (String) null, s.this.n.a(), z3, z2);
            }
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void a(boolean isMute) {
            s sVar;
            String str;
            if (isMute) {
                sVar = s.this;
                str = com.sigmob.sdk.base.common.a.z;
            } else {
                sVar = s.this;
                str = com.sigmob.sdk.base.common.a.A;
            }
            sVar.b(str);
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void b() {
            s.this.b("show_skip");
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void b(float progress) {
            if (s.this.r) {
                return;
            }
            s.this.r = true;
            s.this.b("skip");
            s.this.a(IntentActions.ACTION_REWARDED_VIDEO_SKIP);
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void c() {
            Activity activityN = s.this.n();
            if (activityN == null || s.this.m == null) {
                return;
            }
            s sVar = s.this;
            if (sVar.a(sVar.w)) {
                return;
            }
            s.this.w = new com.sigmob.sdk.nativead.b(activityN, s.this.m);
            s.this.w.a();
            s.this.w.a(new WindNativeAdData.DislikeInteractionCallback() { // from class: com.sigmob.sdk.mraid.s.3.1
                @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                public void onCancel() {
                    s.this.c("feedbackDidDisappear");
                    s.this.s();
                }

                @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                public void onSelected(int position, String value, boolean enforce) {
                    s.this.c("feedbackDidDisappear");
                    s.this.s();
                }

                @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                public void onShow() {
                    s.this.c("feedbackDidAppear");
                }
            });
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void d() {
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void e() {
            SigmobLog.d("MraidActivity failed to load. Finishing the activity");
            if (s.this.b != null) {
                s.this.a(IntentActions.ACTION_INTERSTITIAL_FAIL);
            }
            s.this.d.a();
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void f() {
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void g() {
            if (s.this.u == null) {
                s.this.u = new com.sigmob.sdk.base.views.q(s.this.n(), s.this.m);
                s.this.u.a(new com.sigmob.sdk.base.views.q.b() { // from class: com.sigmob.sdk.mraid.s.3.2
                    @Override // com.sigmob.sdk.base.views.q.b
                    public void a() {
                        s.this.p();
                        if (s.this.g != null) {
                            s.this.g.a(com.sigmob.sdk.base.common.a.g, 0);
                        }
                        s.this.c("fourElementsDidDisappear");
                    }

                    @Override // com.sigmob.sdk.base.views.q.b
                    public void a(Error error) {
                    }

                    @Override // com.sigmob.sdk.base.views.q.b
                    public void a(String url, String clickCoordinate) {
                        if (s.this.j == null) {
                            return;
                        }
                        s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, url, clickCoordinate, true);
                    }

                    @Override // com.sigmob.sdk.base.views.q.b
                    public void b() {
                        if (s.this.g != null) {
                            s.this.g.a(com.sigmob.sdk.base.common.a.f, 0);
                        }
                        s.this.c("fourElementsDidAppear");
                    }
                });
            }
            if (s.this.u == null || !s.this.u.a() || s.this.v) {
                return;
            }
            s.this.u.show();
            s.this.v = true;
        }

        @Override // com.sigmob.sdk.mraid.h.a
        public void h() {
            s.this.n.a(new ValueCallback() { // from class: com.sigmob.sdk.mraid.s$3$$ExternalSyntheticLambda0
                @Override // android.webkit.ValueCallback
                public final void onReceiveValue(Object obj) {
                    this.f$0.b((String) obj);
                }
            });
            s.this.a(IntentActions.ACTION_REWARDED_VIDEO_CLOSE);
            s.this.s = true;
            s.this.d.a();
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid.s$7, reason: invalid class name */
    static /* synthetic */ class AnonymousClass7 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3517a;
        static final /* synthetic */ int[] b;

        static {
            int[] iArr = new int[com.sigmob.sdk.base.a.values().length];
            b = iArr;
            try {
                iArr[com.sigmob.sdk.base.a.COMPANION.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                b[com.sigmob.sdk.base.a.VIDEO_CLICK.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            int[] iArr2 = new int[ConsoleMessage.MessageLevel.values().length];
            f3517a = iArr2;
            try {
                iArr2[ConsoleMessage.MessageLevel.ERROR.ordinal()] = 1;
            } catch (NoSuchFieldError unused3) {
            }
        }
    }

    public s(Activity activity, BaseAdUnit baseAdUnit, Bundle intentExtras, Bundle savedInstanceState, String broadcastIdentifier, com.sigmob.sdk.base.common.k baseAdViewControllerListener) {
        super(activity, broadcastIdentifier, baseAdViewControllerListener);
        this.s = false;
        this.t = false;
        this.v = false;
        this.z = new View.OnClickListener() { // from class: com.sigmob.sdk.mraid.s.5
            @Override // android.view.View.OnClickListener
            public void onClick(View view) {
                Activity activityN = s.this.n();
                if (activityN == null || s.this.m == null) {
                    return;
                }
                s sVar = s.this;
                if (sVar.a(sVar.w)) {
                    return;
                }
                s.this.w = new com.sigmob.sdk.nativead.b(activityN, s.this.m);
                s.this.w.a();
                s.this.w.a(new WindNativeAdData.DislikeInteractionCallback() { // from class: com.sigmob.sdk.mraid.s.5.1
                    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                    public void onCancel() {
                        s.this.s();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                    public void onSelected(int position, String value, boolean enforce) {
                        s.this.s();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                    public void onShow() {
                    }
                });
            }
        };
        this.m = baseAdUnit;
        this.h = intentExtras;
        com.sigmob.sdk.videoAd.a aVar = (com.sigmob.sdk.videoAd.a) baseAdUnit.getAdConfig();
        this.j = aVar;
        aVar.a(n(), baseAdUnit, new com.sigmob.sdk.base.views.q.b() { // from class: com.sigmob.sdk.mraid.s.1
            @Override // com.sigmob.sdk.base.views.q.b
            public void a() {
                s.this.c("fourElementsDidDisappear");
            }

            @Override // com.sigmob.sdk.base.views.q.b
            public void a(Error error) {
            }

            @Override // com.sigmob.sdk.base.views.q.b
            public void a(String url, String clickCoordinate) {
                ClickCommon clickCommon = s.this.m.getClickCommon();
                clickCommon.click_area = ClickCommon.CLICK_AREA_BTN;
                clickCommon.click_scene = "appinfo";
                clickCommon.is_final_click = true;
            }

            @Override // com.sigmob.sdk.base.views.q.b
            public void b() {
                s.this.c("fourElementsDidAppear");
            }
        });
        aVar.a((ac) this);
        this.k = ClientMetadata.getInstance().getInsetBottom();
        m().setBackgroundColor(0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ WindowInsets a(View view, WindowInsets windowInsets) {
        this.n.a(windowInsets);
        return windowInsets;
    }

    private void a(Context context, int initialVisibility) {
        if (this.p != null) {
            return;
        }
        ar arVar = new ar(context);
        this.p = arVar;
        arVar.setVisibility(initialVisibility);
        this.p.setId(ClientMetadata.generateViewId());
        int iDipsToIntPixels = Dips.dipsToIntPixels(10.0f, this.f3184a);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(22.0f, context), Dips.dipsToIntPixels(22.0f, context));
        layoutParams.addRule(10);
        layoutParams.addRule(11);
        layoutParams.setMargins(iDipsToIntPixels, iDipsToIntPixels * 2, iDipsToIntPixels, iDipsToIntPixels);
        m().addView(this.p, layoutParams);
        this.p.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.mraid.s.4
            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View view, MotionEvent motionEvent) {
                if (motionEvent.getAction() == 1) {
                    s.this.s = true;
                    s.this.j.b(s.this.l(), s.this.q, s.this.m);
                    s.this.k().a();
                }
                return true;
            }
        });
        this.p.a(this.m);
        String strF = this.j.f();
        if (strF != null) {
            this.p.a(strF);
        }
    }

    private void a(com.sigmob.sdk.base.a companion, String adCompanionClick) {
        BaseAdUnit baseAdUnit = this.m;
        if (baseAdUnit == null) {
            return;
        }
        ClickCommon clickCommon = baseAdUnit.getClickCommon();
        ad.a(companion, "click", this.m, clickCommon.isDeeplink, clickCommon.clickUrl, clickCommon.clickCoordinate, this.q, this.y);
        b(adCompanionClick);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(v vVar, com.sigmob.sdk.base.common.v vVar2) {
        if (vVar2 != null) {
            this.g = vVar2;
            return;
        }
        com.sigmob.sdk.base.common.v vVar3 = new com.sigmob.sdk.base.common.v();
        this.g = vVar3;
        vVar3.a(this.m);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, Integer num, String str2) {
        if (this.g == null) {
            return;
        }
        try {
            if (c.a(str2) == null) {
                if (str.equals("show_skip")) {
                    this.g.a(false, 0);
                }
                this.g.a(str, 0);
            } else {
                float f2 = Float.parseFloat(str2);
                float fIntValue = (((double) f2) <= 1.0E-7d || num == null || num.intValue() <= 0) ? -1.0f : f2 * num.intValue();
                if (str.equals("show_skip")) {
                    this.g.a(false, (int) fIntValue);
                }
                this.g.a(str, (int) fIntValue);
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    private void b(Context context, int visibility) {
        if (this.x == null) {
            com.sigmob.sdk.base.views.w wVar = new com.sigmob.sdk.base.views.w(context);
            this.x = wVar;
            wVar.setText("反馈");
            this.x.setOnClickListener(this.z);
            this.x.setId(ClientMetadata.generateViewId());
            int iDipsToIntPixels = Dips.dipsToIntPixels(3.0f, this.f3184a);
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(45.0f, context), Dips.dipsToIntPixels(30.0f, context));
            layoutParams.addRule(0, this.p.getId());
            layoutParams.addRule(6, this.p.getId());
            layoutParams.setMargins(0, -iDipsToIntPixels, 0, 0);
            m().addView(this.x, layoutParams);
        }
        com.sigmob.sdk.base.views.w wVar2 = this.x;
        if (wVar2 != null) {
            wVar2.setVisibility(visibility);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(v vVar, com.sigmob.sdk.base.common.v vVar2) {
        if (vVar2 != null) {
            this.g = vVar2;
            return;
        }
        com.sigmob.sdk.base.common.v vVar3 = new com.sigmob.sdk.base.common.v();
        this.g = vVar3;
        vVar3.a(this.m);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(boolean z) {
        if (z) {
            q();
        } else {
            r();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(String event) {
        c cVarE;
        h hVar = this.n;
        if (hVar == null || hVar.g() == null || (cVarE = this.n.e()) == null) {
            return;
        }
        cVarE.a(event, (HashMap<String, Object>) null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void p() {
        com.sigmob.sdk.base.views.q qVar = this.u;
        if (qVar == null) {
            return;
        }
        qVar.dismiss();
        this.u.c();
        this.u = null;
        this.v = false;
    }

    private void q() {
        ar arVar = this.p;
        if (arVar != null) {
            arVar.setVisibility(4);
        }
        com.sigmob.sdk.base.views.w wVar = this.x;
        if (wVar != null) {
            wVar.setVisibility(4);
        }
    }

    private void r() {
        if (this.p == null) {
            a(this.f3184a, 0);
        }
        this.p.setVisibility(0);
        b(l(), 0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void s() {
        com.sigmob.sdk.nativead.b bVar = this.w;
        if (bVar == null) {
            return;
        }
        bVar.dismiss();
        this.w.b();
        this.w = null;
    }

    public View a() {
        String str = this.b;
        z.a aVarA = str != null ? z.a(str) : null;
        this.n = (aVarA == null || aVarA.d() == null) ? new h(this.f3184a, this.m, PlacementType.INTERSTITIAL) : aVarA.d();
        a(new View.OnApplyWindowInsetsListener() { // from class: com.sigmob.sdk.mraid.s$$ExternalSyntheticLambda1
            @Override // android.view.View.OnApplyWindowInsetsListener
            public final WindowInsets onApplyWindowInsets(View view, WindowInsets windowInsets) {
                return this.f$0.a(view, windowInsets);
            }
        });
        this.n.a(this.e);
        this.n.a(new h.f() { // from class: com.sigmob.sdk.mraid.s.2
            private boolean b;

            @Override // com.sigmob.sdk.mraid.h.f
            public void a() {
                SigmobLog.d("adImpression() called");
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void a(Integer duration) {
                s.this.q = duration == null ? -1 : duration.intValue();
                s.this.g.a(s.this.q, s.this.j.l());
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void a(Map<String, String> params) {
                try {
                    params.get("id");
                    String str2 = params.get("url");
                    if (!params.get("playerHandles").equalsIgnoreCase("false")) {
                        if (!TextUtils.isEmpty(str2)) {
                            if (str2.startsWith("http")) {
                                s.this.m.setCustomLandPageUrl(str2);
                            } else {
                                s.this.m.setCustomDeeplink(str2);
                            }
                        }
                        s.this.j.a(com.sigmob.sdk.base.a.ENDCARD, s.this.n.a(), true);
                    }
                    SigmobLog.d("adClickThru() called" + params);
                } catch (Throwable th) {
                    SigmobLog.e("adClickThru", th);
                }
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void b() {
                if (this.b) {
                    return;
                }
                s.this.b(com.sigmob.sdk.base.common.a.j);
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void b(Map<String, String> params) {
                SigmobLog.d("adError() called " + params);
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void c() {
                SigmobLog.d("adPlaying() called");
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void d() {
                this.b = true;
                s.this.b("complete");
                SigmobLog.d("adVideoComplete() called");
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void e() {
                s.this.b(com.sigmob.sdk.base.common.a.k);
                SigmobLog.d("adVideoFirstQuartile() called");
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void f() {
                s.this.b(com.sigmob.sdk.base.common.a.n);
                SigmobLog.d("adVideoThirdQuartile() called");
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void g() {
                s.this.b(com.sigmob.sdk.base.common.a.m);
                SigmobLog.d("adVideoMidpoint() called");
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void h() {
                s.this.b(com.sigmob.sdk.base.common.a.L);
                s.this.a(IntentActions.ACTION_REWARDED_VIDEO_PLAY);
                SigmobLog.d("adVideoStart() called");
            }
        });
        this.n.a(new AnonymousClass3());
        this.n.a(new h.e() { // from class: com.sigmob.sdk.mraid.s$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.mraid.h.e
            public final void useCustomCloseChanged(boolean z) {
                this.f$0.b(z);
            }
        });
        if (aVarA != null) {
            this.g = aVarA.c();
        } else if (!TextUtils.isEmpty(this.m.getHtmlData())) {
            this.n.a(this.m.getHtmlData(), new h.b() { // from class: com.sigmob.sdk.mraid.s$$ExternalSyntheticLambda3
                @Override // com.sigmob.sdk.mraid.h.b
                public final void onReady(v vVar, com.sigmob.sdk.base.common.v vVar2) {
                    this.f$0.b(vVar, vVar2);
                }
            });
        } else if (!TextUtils.isEmpty(this.m.getHtmlUrl())) {
            this.n.b(this.m.getHtmlUrl(), new h.b() { // from class: com.sigmob.sdk.mraid.s$$ExternalSyntheticLambda4
                @Override // com.sigmob.sdk.mraid.h.b
                public final void onReady(v vVar, com.sigmob.sdk.base.common.v vVar2) {
                    this.f$0.a(vVar, vVar2);
                }
            });
        }
        return this.n.q();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Configuration configuration) {
        this.n.a(configuration.orientation);
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Bundle outState) {
    }

    public void a(x debugListener) {
        this.o = debugListener;
        h hVar = this.n;
        if (hVar == null) {
            return;
        }
        hVar.a(debugListener);
    }

    public void b(final String event) {
        final Integer numF = this.n.f();
        this.n.a(new ValueCallback() { // from class: com.sigmob.sdk.mraid.s$$ExternalSyntheticLambda0
            @Override // android.webkit.ValueCallback
            public final void onReceiveValue(Object obj) {
                this.f$0.a(event, numF, (String) obj);
            }
        });
    }

    @Override // com.sigmob.sdk.videoAd.b, com.sigmob.sdk.base.common.j
    public void e() {
        super.e();
        b(n(), this.i, this.h);
        n().getWindow().setFlags(1024, 1024);
        com.sigmob.sdk.base.common.v vVar = this.g;
        if (vVar != null) {
            vVar.a("show", 0);
        }
        m().addView(a(), new FrameLayout.LayoutParams(-1, -1));
        h hVar = this.n;
        if (hVar != null) {
            hVar.a(n());
        }
        a(IntentActions.ACTION_INTERSTITIAL_VOPEN);
        a(new x() { // from class: com.sigmob.sdk.mraid.s.6
            @Override // com.sigmob.sdk.mraid.x
            public boolean a(ConsoleMessage consoleMessage) {
                if (AnonymousClass7.f3517a[consoleMessage.messageLevel().ordinal()] != 1) {
                    return false;
                }
                SigmobLog.e("onConsoleMessage " + consoleMessage.message());
                ad.a("h5_error", "mraid1", 0, consoleMessage.message(), (WindAdRequest) null, (LoadAdRequest) null, s.this.m, (ad.a) null);
                return false;
            }

            @Override // com.sigmob.sdk.mraid.x
            public boolean a(String message, JsResult result) {
                return false;
            }
        });
    }

    @Override // com.sigmob.sdk.base.common.j
    public void f() {
        if (!this.s) {
            this.n.b();
        } else {
            this.t = true;
            a(IntentActions.ACTION_INTERSTITIAL_DISMISS);
        }
    }

    @Override // com.sigmob.sdk.base.common.j
    public void g() {
        this.n.c();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void h() {
        com.sigmob.sdk.base.common.v vVar = this.g;
        if (vVar != null) {
            vVar.a();
            this.g = null;
        }
        h hVar = this.n;
        if (hVar != null) {
            hVar.m();
            this.n = null;
        }
        s();
        p();
        if (!this.s || !this.t) {
            this.t = true;
            a(IntentActions.ACTION_INTERSTITIAL_DISMISS);
        }
        BaseAdUnit baseAdUnit = this.m;
        if (baseAdUnit != null) {
            baseAdUnit.destroy();
        }
        super.h();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void i() {
    }

    @Override // com.sigmob.sdk.base.common.j
    public boolean j() {
        return false;
    }

    @Override // com.sigmob.sdk.base.common.j
    public void o() {
    }

    @Override // com.sigmob.sdk.base.common.ac
    public void onAdClick(boolean isRecord, com.sigmob.sdk.base.a type) {
        com.sigmob.sdk.base.a aVar;
        String str;
        com.sigmob.sdk.base.utils.d.a(f, this.m);
        a(IntentActions.ACTION_INTERSTITIAL_CLICK);
        if (isRecord) {
            int i = AnonymousClass7.b[type.ordinal()];
            if (i == 1) {
                aVar = com.sigmob.sdk.base.a.COMPANION;
                str = com.sigmob.sdk.base.common.a.s;
            } else if (i != 2) {
                aVar = com.sigmob.sdk.base.a.ENDCARD;
                str = "click";
            } else {
                aVar = com.sigmob.sdk.base.a.VIDEO_CLICK;
                str = com.sigmob.sdk.base.common.a.t;
            }
            a(aVar, str);
        }
        this.y = null;
    }
}
