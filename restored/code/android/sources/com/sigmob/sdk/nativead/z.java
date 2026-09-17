package com.sigmob.sdk.nativead;

import android.app.Activity;
import android.content.Context;
import android.content.res.Configuration;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewTreeObserver;
import android.view.animation.AlphaAnimation;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ah;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.PlacementType;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.natives.WindNativeAdData;
import java.net.URI;
import kotlinx.coroutines.scheduling.WorkQueueKt;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public class z extends com.sigmob.sdk.base.common.j {
    private static r g;
    public final long f;
    private ae h;
    private ae i;
    private RelativeLayout j;
    private FrameLayout k;
    private BaseAdUnit l;
    private e m;
    private com.sigmob.sdk.mraid.h n;
    private View o;
    private WindNativeAdData p;
    private APKStatusBroadcastReceiver q;
    private ImageView r;
    private com.sigmob.sdk.base.views.q s;
    private boolean t;
    private boolean u;

    public z(Activity activity, BaseAdUnit baseAdUnit, Bundle intentExtras, Bundle savedInstanceState, String broadcastIdentifier, com.sigmob.sdk.base.common.k baseAdViewControllerListener) {
        super(activity, broadcastIdentifier, baseAdViewControllerListener);
        this.f = 300L;
        this.t = false;
        this.l = baseAdUnit;
        e eVar = (e) baseAdUnit.getAdConfig();
        this.m = eVar;
        eVar.a(n(), this.l, (com.sigmob.sdk.base.views.q.b) null);
        this.h = (ae) intentExtras.getParcelable("attr");
        k().a(1);
        int iA = com.sigmob.sdk.base.k.a();
        if (iA == 0) {
            return;
        }
        n().getTheme().applyStyle(iA, true);
    }

    private void a(Context context) {
        if (this.r != null) {
            return;
        }
        ImageView imageView = new ImageView(context);
        this.r = imageView;
        imageView.setImageBitmap(com.sigmob.sdk.base.views.s.CLOSE.a());
        this.r.setScaleType(ImageView.ScaleType.CENTER_CROP);
        this.r.setImageAlpha(WorkQueueKt.MASK);
        this.r.setClickable(true);
        this.r.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.nativead.z$$ExternalSyntheticLambda5
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.a(view);
            }
        });
        int iDipsToIntPixels = Dips.dipsToIntPixels(20.0f, this.f3184a);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(10);
        layoutParams.addRule(9);
        int i = iDipsToIntPixels / 2;
        layoutParams.setMargins(i, i, 0, 0);
        RelativeLayout relativeLayout = this.j;
        if (relativeLayout != null) {
            relativeLayout.addView(this.r, layoutParams);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(View view) {
        k().onBackPressed();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(com.sigmob.sdk.mraid.v vVar, com.sigmob.sdk.base.common.v vVar2) {
    }

    public static void a(m sigAdView) {
        if (sigAdView instanceof r) {
            g = (r) sigAdView;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(boolean z) {
        if (z) {
            s();
        } else if (g == null) {
            t();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(View view) {
        k().onBackPressed();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void b(com.sigmob.sdk.mraid.v vVar, com.sigmob.sdk.base.common.v vVar2) {
    }

    private int r() {
        DisplayMetrics displayMetrics = ClientMetadata.getInstance().getDisplayMetrics();
        return Math.min((int) (((double) Math.min(displayMetrics.widthPixels, displayMetrics.heightPixels)) / this.l.getAdPercent()), Math.max(displayMetrics.heightPixels, displayMetrics.widthPixels) / 2);
    }

    private void s() {
        ImageView imageView = this.r;
        if (imageView == null) {
            return;
        }
        imageView.setVisibility(4);
    }

    private void t() {
        if (this.r == null) {
            a(n());
        }
        this.r.setVisibility(0);
    }

    private void u() {
        this.u = true;
        if (g == null) {
            k().a();
            return;
        }
        new af(this.k, this.i, this.h, 300L).a();
        this.j.setVisibility(8);
        this.k.postDelayed(new Runnable() { // from class: com.sigmob.sdk.nativead.z$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.v();
            }
        }, 300L);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void v() {
        r rVar = g;
        if (rVar != null) {
            rVar.setUIStyle(j.PREVIEW);
        }
        k().a();
    }

    public ah a() {
        ah sessionManager = this.l.getSessionManager();
        if (sessionManager != null) {
            return sessionManager;
        }
        i iVar = new i();
        iVar.a(this.l);
        return iVar;
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Configuration configuration) {
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Bundle outState) {
    }

    @Override // com.sigmob.sdk.base.common.j
    public void e() {
        m().removeAllViews();
        k().onSetContentView(m());
        this.l.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_TEMPLATE;
        RelativeLayout relativeLayout = new RelativeLayout(l());
        this.j = relativeLayout;
        relativeLayout.setBackgroundColor(-1);
        this.o = p();
        com.sigmob.sdk.mraid.h hVar = this.n;
        if (hVar != null) {
            hVar.a(n());
        }
        this.j.addView(this.o, new RelativeLayout.LayoutParams(-1, -1));
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
        r rVar = g;
        if (rVar != null) {
            WindNativeAdData nativeAdUnit = rVar.getNativeAdUnit();
            this.p = nativeAdUnit;
            if (nativeAdUnit != null) {
                layoutParams.setMargins(0, r(), 0, 0);
            }
        }
        m().addView(this.j, layoutParams);
        if (g != null) {
            this.k = new FrameLayout(n());
            g.setBackClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.nativead.z$$ExternalSyntheticLambda0
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    this.f$0.b(view);
                }
            });
            m().addView(this.k, new RelativeLayout.LayoutParams(-1, r()));
            g.getSigVideoAdController().c();
            this.k.getViewTreeObserver().addOnPreDrawListener(new ViewTreeObserver.OnPreDrawListener() { // from class: com.sigmob.sdk.nativead.z.1
                @Override // android.view.ViewTreeObserver.OnPreDrawListener
                public boolean onPreDraw() {
                    if (z.g == null || z.this.k == null) {
                        return false;
                    }
                    z.this.k.getViewTreeObserver().removeOnPreDrawListener(this);
                    z.g.setUIStyle(j.DETAIL_PAGE);
                    ViewGroup videoContainer = z.g.getVideoContainer();
                    if (videoContainer != null) {
                        com.sigmob.sdk.base.utils.w.a(videoContainer);
                        z.this.k.addView(videoContainer, new FrameLayout.LayoutParams(-1, -1));
                    }
                    z.this.i = new ae();
                    int[] iArr = new int[2];
                    z.this.k.getLocationOnScreen(iArr);
                    z.this.i.a(iArr[0]);
                    z.this.i.b(0);
                    z.this.i.c(z.this.k.getMeasuredWidth());
                    z.this.i.d(z.this.k.getMeasuredHeight());
                    new af(z.this.k, z.this.h, z.this.i, 300L).a();
                    z.this.h.b(z.this.h.b() - iArr[1]);
                    if (z.this.j != null) {
                        AlphaAnimation alphaAnimation = new AlphaAnimation(0.0f, 1.0f);
                        alphaAnimation.setDuration(300L);
                        z.this.j.setAnimation(alphaAnimation);
                        alphaAnimation.start();
                    }
                    return true;
                }
            });
        }
        a(IntentActions.ACTION_NATIVE_TEMPLIE_SHOW, 100);
    }

    @Override // com.sigmob.sdk.base.common.j
    public void f() {
        t sigVideoAdController;
        r rVar = g;
        if (rVar == null || this.u || (sigVideoAdController = rVar.getSigVideoAdController()) == null) {
            return;
        }
        sigVideoAdController.a();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void g() {
        t sigVideoAdController;
        r rVar = g;
        if (rVar != null && (sigVideoAdController = rVar.getSigVideoAdController()) != null) {
            sigVideoAdController.c();
        }
        com.sigmob.sdk.mraid.h hVar = this.n;
        if (hVar != null) {
            hVar.c();
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
    @Override // com.sigmob.sdk.base.common.j
    public void h() {
        APKStatusBroadcastReceiver aPKStatusBroadcastReceiver = this.q;
        if (aPKStatusBroadcastReceiver != null) {
            aPKStatusBroadcastReceiver.b(aPKStatusBroadcastReceiver);
            this.q = null;
        }
        com.sigmob.sdk.base.views.q qVar = this.s;
        if (qVar != null) {
            qVar.dismiss();
            this.s.c();
            this.s = null;
        }
        com.sigmob.sdk.mraid.h hVar = this.n;
        if (hVar != null) {
            hVar.m();
            this.n = null;
        }
        r rVar = g;
        if (rVar != null) {
            rVar.setBackClickListener(null);
            g = null;
        }
        a(IntentActions.ACTION_NATIVE_TEMPLE_DISMISS);
        super.h();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void i() {
    }

    @Override // com.sigmob.sdk.base.common.j
    public boolean j() {
        r rVar = g;
        if (rVar != null && rVar.b()) {
            return false;
        }
        u();
        return false;
    }

    @Override // com.sigmob.sdk.base.common.j
    public void o() {
    }

    public View p() {
        if (this.n == null) {
            this.n = new com.sigmob.sdk.mraid.h(this.f3184a, this.l, PlacementType.INTERSTITIAL);
        }
        this.n.a(new com.sigmob.sdk.mraid.h.a() { // from class: com.sigmob.sdk.nativead.z.2
            @Override // com.sigmob.sdk.mraid.h.a
            public void a() {
                SigmobLog.d("SigNativeAdLandViewController onEndCardShow()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(float cvTime) {
                SigmobLog.d("SigNativeAdLandViewController onReward()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(int width, int height, int offsetX, int offsetY, com.sigmob.sdk.mraid.b.a closePosition, boolean allowOffscreen) {
                SigmobLog.i("SigNativeAdLandViewController onResize()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(View view) {
                SigmobLog.d("SigNativeAdLandViewController onLoaded()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(WindAdError error) {
                SigmobLog.i("SigNativeAdLandViewController onRenderProcessGone:" + error.toString());
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(String ext) {
                SigmobLog.i("SigNativeAdLandViewController onCompanionClick:" + ext);
                boolean z = true;
                if (!TextUtils.isEmpty(ext)) {
                    try {
                        z.this.l.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
                        z.this.l.getClickCommon().is_final_click = true;
                        JSONObject jSONObject = new JSONObject(ext);
                        int iOptInt = jSONObject.optInt("type");
                        z.this.n.a(String.valueOf(jSONObject.optInt("x")), String.valueOf(jSONObject.optInt("y")));
                        if (iOptInt != 1) {
                            z.this.a().a("click", 0);
                        } else {
                            z = false;
                        }
                    } catch (Exception unused) {
                        z.this.n.a("0", "0");
                        z.this.a().a("click", 0);
                    }
                }
                z.this.m.a(com.sigmob.sdk.base.a.COMPANION, z.this.n.a(), z);
                z.this.a(IntentActions.ACTION_NATIVE_TEMPLE_CLICK);
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(URI uri, int type, String ext) {
                boolean z;
                boolean z2;
                boolean z3;
                e eVar;
                com.sigmob.sdk.base.a aVar;
                String string;
                SigmobLog.i("SigNativeAdLandViewController  onOpen:" + uri + "======" + type + "=====" + ext);
                boolean z4 = false;
                if (TextUtils.isEmpty(ext)) {
                    z3 = true;
                    z2 = true;
                } else {
                    try {
                        z.this.l.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
                        z.this.l.getClickCommon().is_final_click = true;
                        JSONObject jSONObject = new JSONObject(ext);
                        int iOptInt = jSONObject.optInt("type");
                        int iOptInt2 = jSONObject.optInt("x");
                        int iOptInt3 = jSONObject.optInt("y");
                        boolean zOptBoolean = jSONObject.optBoolean("disable_landing");
                        try {
                            z = !jSONObject.optBoolean("feDisable");
                            try {
                                z.this.n.a(String.valueOf(iOptInt2), String.valueOf(iOptInt3));
                                z2 = z;
                                z3 = iOptInt != 1;
                                z4 = zOptBoolean;
                            } catch (Exception unused) {
                                z4 = zOptBoolean;
                                z2 = z;
                                z3 = true;
                            }
                        } catch (Exception unused2) {
                            z = true;
                        }
                    } catch (Exception unused3) {
                        z = true;
                    }
                }
                if (z4 || TextUtils.isEmpty(z.this.l.getLanding_page())) {
                    eVar = z.this.m;
                    aVar = com.sigmob.sdk.base.a.ENDCARD;
                    string = uri.toString();
                } else {
                    eVar = z.this.m;
                    aVar = com.sigmob.sdk.base.a.ENDCARD;
                    string = null;
                }
                eVar.a(aVar, string, z.this.n.a(), z3, z2);
                z.this.a(IntentActions.ACTION_NATIVE_TEMPLE_CLICK);
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(boolean isMute) {
                SigmobLog.d("SigNativeAdLandViewController onMute()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void b() {
                SigmobLog.d("SigNativeAdLandViewController onShowSkipTime()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void b(float progress) {
                SigmobLog.d("SigNativeAdLandViewController onSkip()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void c() {
                SigmobLog.d("SigNativeAdLandViewController onFeedBack()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void d() {
                SigmobLog.d("SigNativeAdLandViewController onExpand()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void e() {
                SigmobLog.i("SigNativeAdLandViewController onFailedToLoad()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void f() {
                SigmobLog.i("SigNativeAdLandViewController onUnload()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void g() {
                SigmobLog.i("SigNativeAdLandViewController onOpenFourElements()");
                if (z.this.s == null) {
                    z.this.s = new com.sigmob.sdk.base.views.q(z.this.n(), z.this.l);
                    z.this.s.a(new com.sigmob.sdk.base.views.q.b() { // from class: com.sigmob.sdk.nativead.z.2.1
                        @Override // com.sigmob.sdk.base.views.q.b
                        public void a() {
                            if (z.this.s != null) {
                                z.this.s.dismiss();
                                z.this.s.c();
                                z.this.s = null;
                                z.this.t = false;
                            }
                            z.this.l.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_TEMPLATE;
                            z.this.a().a(com.sigmob.sdk.base.common.a.g, 0);
                        }

                        @Override // com.sigmob.sdk.base.views.q.b
                        public void a(Error error) {
                        }

                        @Override // com.sigmob.sdk.base.views.q.b
                        public void a(String url, String clickCoordinate) {
                            z.this.l.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
                            z.this.l.getClickCommon().click_scene = "appinfo";
                            z.this.l.getClickCommon().is_final_click = true;
                            if (z.this.m != null) {
                                z.this.m.a(com.sigmob.sdk.base.a.COMPANION, url, clickCoordinate, true);
                                z.this.a(IntentActions.ACTION_NATIVE_TEMPLE_CLICK);
                            }
                        }

                        @Override // com.sigmob.sdk.base.views.q.b
                        public void b() {
                            z.this.a().a(com.sigmob.sdk.base.common.a.f, 0);
                        }
                    });
                }
                if (z.this.s == null || !z.this.s.a() || z.this.t) {
                    return;
                }
                z.this.l.getClickCommon().click_area = "appinfo";
                z.this.l.getClickCommon().is_final_click = false;
                z.this.a().a("click", 0);
                z.this.s.show();
                z.this.t = true;
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void h() {
                SigmobLog.i("SigNativeAdLandViewController onClose()");
                z.this.k().onBackPressed();
            }
        });
        if (!TextUtils.isEmpty(this.l.getHtmlUrl())) {
            this.n.b(this.l.getHtmlUrl(), new com.sigmob.sdk.mraid.h.b() { // from class: com.sigmob.sdk.nativead.z$$ExternalSyntheticLambda2
                @Override // com.sigmob.sdk.mraid.h.b
                public final void onReady(com.sigmob.sdk.mraid.v vVar, com.sigmob.sdk.base.common.v vVar2) {
                    z.b(vVar, vVar2);
                }
            });
        } else if (!TextUtils.isEmpty(this.l.getHtmlData())) {
            this.n.a(this.l.getHtmlData(), new com.sigmob.sdk.mraid.h.b() { // from class: com.sigmob.sdk.nativead.z$$ExternalSyntheticLambda3
                @Override // com.sigmob.sdk.mraid.h.b
                public final void onReady(com.sigmob.sdk.mraid.v vVar, com.sigmob.sdk.base.common.v vVar2) {
                    z.a(vVar, vVar2);
                }
            });
        }
        this.n.a(new com.sigmob.sdk.mraid.h.e() { // from class: com.sigmob.sdk.nativead.z$$ExternalSyntheticLambda4
            @Override // com.sigmob.sdk.mraid.h.e
            public final void useCustomCloseChanged(boolean z) {
                this.f$0.a(z);
            }
        });
        return this.n.q();
    }
}
