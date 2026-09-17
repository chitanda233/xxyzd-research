package com.sigmob.sdk.splash;

import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewTreeObserver;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.byazt.bv.BaseConstants;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.wire.Wire;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.ah;
import com.sigmob.sdk.base.common.am;
import com.sigmob.sdk.base.common.an;
import com.sigmob.sdk.base.common.ao;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.SensorEntity;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.utils.n;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.w;
import com.sigmob.sdk.base.views.aa;
import com.sigmob.sdk.base.views.ac;
import com.sigmob.sdk.base.views.ag;
import com.sigmob.sdk.base.views.ai;
import com.sigmob.sdk.base.views.ak;
import com.sigmob.sdk.base.views.ap;
import com.sigmob.sdk.base.views.aq;
import com.sigmob.sdk.base.views.aw;
import com.sigmob.sdk.base.views.q;
import com.sigmob.sdk.base.views.v;
import com.sigmob.windad.WindAdError;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public final class i extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3619a = "i";
    private static float b = 25.0f;
    private final RelativeLayout c;
    private b d;
    private final Context e;
    private BaseAdUnit f;
    private com.sigmob.sdk.splash.a g;
    private RelativeLayout h;
    private View.OnTouchListener i;
    private volatile boolean j;
    private volatile boolean k;
    private boolean l;
    private boolean m;
    private ag n;
    private am.a o;
    private v p;
    private boolean q;
    private float r;
    private a s;

    /* JADX INFO: renamed from: com.sigmob.sdk.splash.i$2, reason: invalid class name */
    class AnonymousClass2 implements am.c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ aw f3623a;

        AnonymousClass2(final aw val$actionView) {
            this.f3623a = val$actionView;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            i.this.g();
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a() {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || i.this.f == null || i.this.j) {
                return;
            }
            i.this.j = true;
            Number number = info.get("turn_x");
            Number number2 = info.get("turn_y");
            Number number3 = info.get("turn_z");
            Number number4 = info.get("turn_time");
            ClickCommon clickCommon = i.this.f.getClickCommon();
            if (number != null) {
                clickCommon.turn_x = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.turn_y = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.turn_z = String.valueOf(number3.intValue());
            }
            clickCommon.turn_time = String.valueOf(number4);
            clickCommon.sld = "5";
            clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
            clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
            this.f3623a.postDelayed(new Runnable() { // from class: com.sigmob.sdk.splash.i$2$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.splash.i$3, reason: invalid class name */
    static /* synthetic */ class AnonymousClass3 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3624a;

        static {
            int[] iArr = new int[an.values().length];
            f3624a = iArr;
            try {
                iArr[an.FOLLOW_PACKAGE_NAME.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3624a[an.IGNORE_ABOUT_SCHEME.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3624a[an.MINI_PROGRAM.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f3624a[an.FOLLOW_DEEP_LINK.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f3624a[an.MARKET_SCHEME.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                f3624a[an.DOWNLOAD_APK.ordinal()] = 6;
            } catch (NoSuchFieldError unused6) {
            }
            try {
                f3624a[an.OPEN_WITH_BROWSER.ordinal()] = 7;
            } catch (NoSuchFieldError unused7) {
            }
            try {
                f3624a[an.NOOP.ordinal()] = 8;
            } catch (NoSuchFieldError unused8) {
            }
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.splash.i$5, reason: invalid class name */
    class AnonymousClass5 implements ao.b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ BaseAdUnit f3626a;

        AnonymousClass5(final BaseAdUnit val$adUnit) {
            this.f3626a = val$adUnit;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
                pointEntitySigmob.setFinal_url(str);
                Map<String, String> options = pointEntitySigmob.getOptions();
                options.put("app_package_name", i.this.f.getAndroidMarket().app_package_name);
                options.put("store_package_name", i.this.f.getAndroidMarket().appstore_package_name);
                pointEntitySigmob.setOptions(options);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
                pointEntitySigmob.setFinal_url(str);
                Map<String, String> options = pointEntitySigmob.getOptions();
                options.put("app_package_name", i.this.f.getAndroidMarket().app_package_name);
                options.put("store_package_name", i.this.f.getAndroidMarket().appstore_package_name);
                pointEntitySigmob.setOptions(options);
            }
        }

        @Override // com.sigmob.sdk.base.common.ao.b
        public void a(final String url, an urlAction) {
            SigmobLog.i("urlHandlingSucceeded: " + urlAction.name() + " url: " + url);
            if (i.this.f == null) {
                SigmobLog.e("adUnit is null");
                return;
            }
            ClickCommon clickCommon = i.this.f.getClickCommon();
            clickCommon.is_final_click = true;
            if (!this.f3626a.getAd().forbiden_parse_landingpage.booleanValue()) {
                ad.a(this.f3626a, urlAction.name(), url);
            }
            i.this.h();
            int i = AnonymousClass3.f3624a[urlAction.ordinal()];
            if (i == 3) {
                Log.d(i.f3619a, "打开小程序成功：" + urlAction);
                com.sigmob.sdk.manager.b.b(this.f3626a, com.sigmob.sdk.base.common.a.G, url);
            } else if (i == 5) {
                AndroidMarket androidMarket = i.this.f.getAndroidMarket();
                if (androidMarket != null) {
                    ad.a(PointCategory.APK_CLICK, ((Integer) Wire.get(androidMarket.type, 0)).intValue() == 0 ? BaseConstants.SCHEME_MARKET : "mimarket", i.this.f, (ad.a) null);
                    if (s.b(androidMarket.app_package_name)) {
                        try {
                            FileUtil.writeToCache(i.this.f, n.a((Object) androidMarket.app_package_name).getAbsolutePath());
                        } catch (Throwable th) {
                            SigmobLog.e("write ad info with package error " + th.getMessage());
                        }
                    }
                }
                ad.a(PointCategory.OPEN_MARKET, (String) null, i.this.f, new ad.a() { // from class: com.sigmob.sdk.splash.i$5$$ExternalSyntheticLambda0
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        this.f$0.b(url, obj);
                    }
                });
            } else if (i == 6) {
                if (i.this.g.j()) {
                    clickCommon.is_final_click = false;
                } else {
                    i.this.a(true);
                    i.this.g.f(url);
                    i.this.k = true;
                }
            }
            ah sessionManager = this.f3626a.getSessionManager();
            if (sessionManager == null) {
                return;
            }
            sessionManager.a("click", 0);
        }

        @Override // com.sigmob.sdk.base.common.ao.b
        public void b(final String url, an urlAction) {
            SigmobLog.i("urlHandlingFailed: " + urlAction.name() + " url: " + url);
            if (i.this.f == null) {
                return;
            }
            ClickCommon clickCommon = i.this.f.getClickCommon();
            clickCommon.is_final_click = true;
            int i = AnonymousClass3.f3624a[urlAction.ordinal()];
            if (i == 3 || i == 4) {
                Log.d(i.f3619a, "打开小程序失败：" + urlAction);
                com.sigmob.sdk.manager.b.b(this.f3626a, com.sigmob.sdk.base.common.a.H, url);
                return;
            }
            if (i == 5) {
                ad.a(PointCategory.OPEN_MARKET_FAILED, (String) null, i.this.f, new ad.a() { // from class: com.sigmob.sdk.splash.i$5$$ExternalSyntheticLambda1
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        this.f$0.a(url, obj);
                    }
                });
                return;
            }
            if (i != 8) {
                return;
            }
            if (!this.f3626a.getAd().forbiden_parse_landingpage.booleanValue()) {
                ad.a(this.f3626a, urlAction.name(), url);
            }
            clickCommon.is_final_click = true;
            ah sessionManager = this.f3626a.getSessionManager();
            if (sessionManager != null) {
                sessionManager.a("click", 0);
            }
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.splash.i$6, reason: invalid class name */
    class AnonymousClass6 implements am.c {
        AnonymousClass6() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            i.this.g();
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a() {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || i.this.f == null || i.this.j) {
                return;
            }
            i.this.j = true;
            Number number = info.get("x_max_acc");
            Number number2 = info.get("y_max_acc");
            Number number3 = info.get("z_max_acc");
            ClickCommon clickCommon = i.this.f.getClickCommon();
            clickCommon.sld = "2";
            clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
            clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
            if (number != null) {
                clickCommon.x_max_acc = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.y_max_acc = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.z_max_acc = String.valueOf(number3.intValue());
            }
            i.this.p.postDelayed(new Runnable() { // from class: com.sigmob.sdk.splash.i$6$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.splash.i$7, reason: invalid class name */
    class AnonymousClass7 implements am.c {
        AnonymousClass7() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            i.this.g();
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a() {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
            if (i.this.p instanceof com.sigmob.sdk.base.views.am) {
                ((com.sigmob.sdk.base.views.am) i.this.p).a(progress);
            }
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || i.this.f == null || i.this.j) {
                return;
            }
            i.this.j = true;
            Number number = info.get("turn_x");
            Number number2 = info.get("turn_y");
            Number number3 = info.get("turn_z");
            Number number4 = info.get("turn_time");
            ClickCommon clickCommon = i.this.f.getClickCommon();
            if (number != null) {
                clickCommon.turn_x = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.turn_y = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.turn_z = String.valueOf(number3.intValue());
            }
            clickCommon.turn_time = String.valueOf(number4);
            clickCommon.sld = "5";
            clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
            clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
            i.this.p.postDelayed(new Runnable() { // from class: com.sigmob.sdk.splash.i$7$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.splash.i$9, reason: invalid class name */
    class AnonymousClass9 implements am.c {
        AnonymousClass9() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            if (i.this.p instanceof ap) {
                ((ap) i.this.p).a(0.0f);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void c() {
            i.this.g();
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a() {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
            if (i.this.p instanceof ap) {
                ((ap) i.this.p).a(progress);
            }
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || i.this.f == null || i.this.j) {
                return;
            }
            i.this.j = true;
            Number number = info.get("x_max_acc");
            Number number2 = info.get("y_max_acc");
            Number number3 = info.get("z_max_acc");
            ClickCommon clickCommon = i.this.f.getClickCommon();
            if (number != null) {
                clickCommon.x_max_acc = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.y_max_acc = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.z_max_acc = String.valueOf(number3.intValue());
            }
            clickCommon.sld = "2";
            clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
            clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
            i.this.p.postDelayed(new Runnable() { // from class: com.sigmob.sdk.splash.i$9$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.c();
                }
            }, 400L);
            i.this.p.postDelayed(new Runnable() { // from class: com.sigmob.sdk.splash.i$9$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 800L);
        }
    }

    public interface a {
        void onWindowVisibilityChanged(int visibility);
    }

    public i(Context context) {
        super(context);
        Context applicationContext = context.getApplicationContext();
        this.e = applicationContext;
        RelativeLayout relativeLayout = new RelativeLayout(applicationContext);
        this.c = relativeLayout;
        addView(relativeLayout, new RelativeLayout.LayoutParams(-1, -1));
    }

    private void a(Activity activity) {
        Context context = getContext();
        com.sigmob.sdk.videoplayer.c.c(activity);
        com.sigmob.sdk.videoplayer.c.f(activity);
        int iDipsToIntPixels = Dips.dipsToIntPixels(12.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(68.0f, context);
        int iDipsToIntPixels3 = Dips.dipsToIntPixels(25.0f, context);
        ag agVar = new ag(context);
        this.n = agVar;
        agVar.setId(View.generateViewId());
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels2, iDipsToIntPixels3);
        layoutParams.addRule(11);
        this.n.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.splash.i$$ExternalSyntheticLambda1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.a(view);
            }
        });
        layoutParams.setMargins(0, iDipsToIntPixels * 3, iDipsToIntPixels, 0);
        addView(this.n, layoutParams);
    }

    private void a(Context context) {
        b bVarA = b.a(context, this.f);
        this.d = bVarA;
        if (bVarA == null) {
            return;
        }
        bVarA.setAspectRatio(this.r);
        this.c.addView(this.d, new RelativeLayout.LayoutParams(-1, -1));
        this.h = new RelativeLayout(context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
        int iDipsToIntPixels = Dips.dipsToIntPixels(b, this.e);
        layoutParams.setMargins(iDipsToIntPixels, (int) (((double) iDipsToIntPixels) * 2.5d), iDipsToIntPixels, iDipsToIntPixels);
        this.h.setClickable(true);
        this.h.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.splash.i$$ExternalSyntheticLambda0
            @Override // android.view.View.OnTouchListener
            public final boolean onTouch(View view, MotionEvent motionEvent) {
                return i.a(view, motionEvent);
            }
        });
        this.c.addView(this.h, layoutParams);
        this.i = new View.OnTouchListener() { // from class: com.sigmob.sdk.splash.i.4
            private MotionEvent b;

            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View v, MotionEvent event) {
                if (i.this.f == null) {
                    SigmobLog.e("adUnit is null");
                    return false;
                }
                if (event.getAction() == 0) {
                    this.b = MotionEvent.obtain(event);
                } else if (event.getAction() == 1) {
                    if (this.b == null) {
                        this.b = event;
                    }
                    try {
                        ClickCommon clickCommon = i.this.f.getClickCommon();
                        clickCommon.sld = "0";
                        clickCommon.click_area = ClickCommon.CLICK_AREA_COMPANION;
                        clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                        i.this.f.getMacroCommon().updateClickMarco(this.b, event, false);
                    } catch (Throwable th) {
                        SigmobLog.e("splash click macro set " + th.getMessage());
                    }
                    i.this.g();
                }
                return true;
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(View view) {
        this.q = true;
        BaseAdUnit baseAdUnit = this.f;
        if (baseAdUnit == null) {
            return;
        }
        ah sessionManager = baseAdUnit.getSessionManager();
        if (sessionManager != null) {
            sessionManager.a("skip", 0);
        }
        BaseBroadcastReceiver.a(this.e, this.f.getUuid(), IntentActions.ACTION_SPLAH_SKIP);
    }

    private void a(BaseAdUnit adUnit) {
        SigmobLog.d("handleUrlAction");
        if (adUnit == null) {
            SigmobLog.e("adUnit is null");
        } else {
            new ao.a().a(an.IGNORE_ABOUT_SCHEME, an.DOWNLOAD_APK, an.MARKET_SCHEME, an.OPEN_WITH_BROWSER, an.FOLLOW_PACKAGE_NAME, an.FOLLOW_DEEP_LINK, an.MINI_PROGRAM).a(new AnonymousClass5(adUnit)).a(adUnit.isSkipSigmobBrowser()).a(adUnit).b(adUnit.getAd().forbiden_parse_landingpage.booleanValue()).a().a(com.sigmob.sdk.b.e(), null);
        }
    }

    private void a(String title, String desc) {
        Context context = getContext();
        aq aqVar = new aq(context);
        aqVar.setTitle(title);
        aqVar.setDescription(desc);
        int iDipsToIntPixels = Dips.dipsToIntPixels(82.0f, context);
        if (this.f.getClickType() == 1) {
            aqVar.setOnTouchListener(this.i);
        }
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -2);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels);
        addView(aqVar, layoutParams);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ boolean a(View view, MotionEvent motionEvent) {
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void g() {
        SigmobLog.d("handleClick");
        if (this.f == null) {
            SigmobLog.e("adUnit is null");
            return;
        }
        this.j = true;
        if (com.sigmob.sdk.b.i() == null) {
            com.sigmob.sdk.b.a(w.c(this));
        }
        a(this.f);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void h() {
        BaseAdUnit baseAdUnit = this.f;
        if (baseAdUnit == null) {
            return;
        }
        com.sigmob.sdk.base.utils.d.a(f3619a, baseAdUnit);
        BaseBroadcastReceiver.a(this.e, this.f.getUuid(), IntentActions.ACTION_INTERSTITIAL_CLICK);
    }

    private void i() {
        Context context = getContext();
        int iDipsToIntPixels = Dips.dipsToIntPixels(10.0f, context);
        Dips.dipsToIntPixels(75.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(25.0f, context);
        TextView textView = new TextView(context);
        textView.setText("互动广告");
        textView.setTextSize(2, 12.0f);
        textView.setTextColor(Color.parseColor("#ccffffff"));
        textView.setGravity(17);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, iDipsToIntPixels2);
        layoutParams.addRule(0, this.n.getId());
        layoutParams.addRule(6, this.n.getId());
        layoutParams.setMargins(0, 0, iDipsToIntPixels, 0);
        addView(textView, layoutParams);
    }

    private void j() {
        Context context = getContext();
        this.p = new ac(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(145.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels2);
        if (this.f.getClickType() == 1) {
            this.p.setOnTouchListener(this.i);
        }
        am.a aVar = new am.a(context, new AnonymousClass6(), am.d.SHAKE);
        this.o = aVar;
        aVar.a(SensorEntity.format(this.f));
        this.o.a();
        addView(this.p, layoutParams);
    }

    private void k() {
        Context context = getContext();
        this.p = new com.sigmob.sdk.base.views.am(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(92.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(145.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels2);
        if (this.f.getClickType() == 1) {
            this.p.setOnTouchListener(this.i);
        }
        am.a aVar = new am.a(context, new AnonymousClass7(), am.d.SLOPE);
        this.o = aVar;
        aVar.a(SensorEntity.format(this.f));
        this.o.a();
        addView(this.p, layoutParams);
    }

    private void l() {
        getViewTreeObserver().addOnGlobalLayoutListener(new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.sigmob.sdk.splash.i.8
            @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
            public void onGlobalLayout() {
                Context context;
                i.this.getViewTreeObserver().removeOnGlobalLayoutListener(this);
                if (i.this.f == null || (context = i.this.getContext()) == null) {
                    return;
                }
                int[] iArr = new int[2];
                i.this.getLocationOnScreen(iArr);
                ClickCommon clickCommon = i.this.f.getClickCommon();
                clickCommon.adarea_x = String.valueOf(Dips.pixelsToIntDips(iArr[0], context));
                clickCommon.adarea_y = String.valueOf(Dips.pixelsToIntDips(iArr[1], context));
                clickCommon.adarea_w = String.valueOf(Dips.pixelsToIntDips(i.this.getWidth(), context));
                clickCommon.adarea_h = String.valueOf(Dips.pixelsToIntDips(i.this.getHeight(), context));
            }
        });
    }

    private void m() {
        Context context = getContext();
        this.p = new ap(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(145.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels2);
        if (this.f.getClickType() == 1) {
            this.p.setOnTouchListener(this.i);
        }
        am.a aVar = new am.a(context, new AnonymousClass9(), am.d.SWING);
        this.o = aVar;
        aVar.a(SensorEntity.format(this.f));
        this.o.a();
        addView(this.p, layoutParams);
    }

    private void n() {
        int i;
        Context context = getContext();
        ak akVar = new ak(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, context);
        if (this.f.getClickType() == 1) {
            akVar.setOnTouchListener(this.i);
        }
        int sensitivity = this.f.getSensitivity();
        if (sensitivity == 10) {
            i = 0;
        } else {
            i = (sensitivity <= 0 || sensitivity >= 10) ? 50 : ((10 - sensitivity) + 1) * 10;
        }
        final int iDipsToIntPixels2 = Dips.dipsToIntPixels(i, com.sigmob.sdk.b.e());
        this.h.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.splash.i.10
            private MotionEvent c;

            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View view, MotionEvent event) {
                if (i.this.f == null) {
                    return false;
                }
                if (event.getAction() == 0) {
                    this.c = MotionEvent.obtain(event);
                    i.this.j = false;
                } else {
                    if ((event.getAction() != 2 && event.getAction() != 1) || i.this.j) {
                        return true;
                    }
                    if (((float) Math.sqrt(Math.pow(Math.abs(event.getX() - this.c.getX()), 2.0d) + Math.pow(Math.abs(event.getY() - this.c.getY()), 2.0d))) >= iDipsToIntPixels2) {
                        i.this.j = true;
                        SigMacroCommon macroCommon = i.this.f.getMacroCommon();
                        if (macroCommon != null) {
                            macroCommon.updateClickMarco(this.c, event, false);
                        }
                        i.this.g();
                    }
                }
                return true;
            }
        });
        int iDipsToIntPixels3 = Dips.dipsToIntPixels(145.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels3);
        addView(akVar, layoutParams);
    }

    private void o() {
        Context context = getContext();
        aa aaVar = new aa(context);
        aaVar.setButtonColor(this.f.getButtonColor());
        aaVar.a(this.f.getDesc(), null);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, context);
        aaVar.setOnTouchListener(this.i);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(100.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels2);
        addView(aaVar, layoutParams);
    }

    private void p() {
        Context context = getContext();
        ai aiVar = new ai(context);
        String title = this.f.getTitle();
        if (s.a((CharSequence) title)) {
            title = "点击查看详情";
        }
        aiVar.a(title, this.f.getDesc());
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(40.0f, context);
        aiVar.setOnTouchListener(this.i);
        int iDipsToIntPixels3 = Dips.dipsToIntPixels(100.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(iDipsToIntPixels2, 0, iDipsToIntPixels2, iDipsToIntPixels3);
        addView(aiVar, layoutParams);
    }

    private void q() {
        Context context = getContext();
        com.sigmob.sdk.base.views.i iVar = new com.sigmob.sdk.base.views.i(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(183.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(40.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        addView(iVar, layoutParams);
        iVar.setOnTouchListener(this.i);
        String title = this.f.getTitle();
        if (s.a((CharSequence) title)) {
            title = "点击前往";
        }
        aq aqVar = new aq(context);
        aqVar.setTitle(title);
        aqVar.setDescription(this.f.getDesc());
        aqVar.setOnTouchListener(this.i);
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-1, -2);
        layoutParams2.addRule(14);
        layoutParams2.addRule(12);
        layoutParams2.setMargins(0, 0, 0, iDipsToIntPixels2);
        addView(aqVar, layoutParams2);
    }

    private void r() {
        Context context = getContext();
        g gVar = new g(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(20.0f, context);
        boolean z = this.f.getadPrivacy() != null;
        if (z) {
            gVar.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.splash.i.11
                private MotionEvent b;

                @Override // android.view.View.OnTouchListener
                public boolean onTouch(View view, MotionEvent event) {
                    if (i.this.f == null) {
                        return false;
                    }
                    if (event.getAction() == 0) {
                        this.b = MotionEvent.obtain(event);
                    } else if (event.getAction() == 1) {
                        ClickCommon clickCommon = i.this.f.getClickCommon();
                        clickCommon.click_area = "appinfo";
                        clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                        com.sigmob.sdk.base.utils.d.a(i.f3619a, i.this.f);
                        if (this.b == null) {
                            this.b = event;
                        }
                        try {
                            i.this.f.getMacroCommon().updateClickMarco(this.b, event, false);
                        } catch (Throwable th) {
                            SigmobLog.e("splash click macro set " + th.getMessage());
                        }
                        i.this.g.i();
                    }
                    return true;
                }
            });
        }
        gVar.a(this.f.getAd_source_logo(), z);
        gVar.setAlpha(0.5f);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(5.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(iDipsToIntPixels2, 0, iDipsToIntPixels2, iDipsToIntPixels2);
        addView(gVar, layoutParams);
    }

    private void s() {
        Context context = getContext();
        aw awVar = new aw(context);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, context);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(145.0f, context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels2);
        if (this.f.getClickType() == 1) {
            awVar.setOnTouchListener(this.i);
        }
        am.a aVar = new am.a(context, new AnonymousClass2(awVar), am.d.WRING);
        this.o = aVar;
        aVar.a(SensorEntity.format(this.f));
        this.o.a();
        addView(awVar, layoutParams);
    }

    void a() {
        super.setVisibility(8);
        b bVar = this.d;
        if (bVar != null) {
            bVar.setVisibility(8);
        }
    }

    void a(boolean hasClose) {
        if (hasClose && com.sigmob.sdk.base.utils.v.b(this.f)) {
            BaseBroadcastReceiver.a(this.e, this.f.getUuid(), IntentActions.ACTION_INTERSTITIAL_DISMISS);
            this.n.setOnClickListener(null);
            com.sigmob.sdk.base.common.h.b(this.f);
            this.f = null;
        }
        am.a aVar = this.o;
        if (aVar != null) {
            aVar.c();
            this.o = null;
        }
        v vVar = this.p;
        if (vVar != null) {
            vVar.b();
        }
        this.d.setOnTouchListener(null);
    }

    /* JADX WARN: Code duplicated, block: B:38:0x00e1 A[Catch: all -> 0x00f8, TryCatch #0 {all -> 0x00f8, blocks: (B:3:0x0003, B:6:0x0033, B:41:0x00e9, B:7:0x0037, B:36:0x00dd, B:38:0x00e1, B:39:0x00e4, B:8:0x0042, B:9:0x004d, B:10:0x0058, B:14:0x0075, B:15:0x0079, B:16:0x007d, B:20:0x0090, B:21:0x0095, B:25:0x00a8, B:26:0x00ad, B:30:0x00c0, B:31:0x00c5, B:35:0x00d8), top: B:46:0x0003 }] */
    public boolean a(BaseAdUnit adUnit, Activity activity) {
        String title;
        String desc;
        v vVar;
        try {
            this.f = adUnit;
            this.g = (com.sigmob.sdk.splash.a) adUnit.getAdConfig();
            a(this.e);
            a(activity);
            int templateId = this.f.getTemplateId();
            ClickCommon clickCommon = this.f.getClickCommon();
            clickCommon.template_id = String.valueOf(templateId);
            l();
            switch (templateId) {
                case 2101:
                    i();
                    j();
                    title = adUnit.getTitle();
                    if (!s.b(title)) {
                        title = "摇动手机";
                    }
                    desc = adUnit.getDesc();
                    a(title, desc);
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2102:
                    i();
                    k();
                    title = adUnit.getTitle();
                    if (!s.b(title)) {
                        title = "前倾手机";
                    }
                    desc = adUnit.getDesc();
                    a(title, desc);
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2103:
                    i();
                    m();
                    title = adUnit.getTitle();
                    if (!s.b(title)) {
                        title = "晃动手机";
                    }
                    desc = adUnit.getDesc();
                    a(title, desc);
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2104:
                    i();
                    s();
                    title = adUnit.getTitle();
                    if (!s.b(title)) {
                        title = "转动手机";
                    }
                    desc = adUnit.getDesc();
                    a(title, desc);
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2105:
                    i();
                    n();
                    title = adUnit.getTitle();
                    clickCommon.sld = "1";
                    clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
                    clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                    if (!s.b(title)) {
                        title = "向上滑动";
                    }
                    desc = adUnit.getDesc();
                    a(title, desc);
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2106:
                    clickCommon.sld = "0";
                    clickCommon.click_area = ClickCommon.CLICK_AREA_COMPANION;
                    clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                    o();
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2107:
                    clickCommon.sld = "0";
                    clickCommon.click_area = ClickCommon.CLICK_AREA_COMPANION;
                    clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                    p();
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                case 2108:
                    clickCommon.sld = "0";
                    clickCommon.click_area = ClickCommon.CLICK_AREA_COMPANION;
                    clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                    q();
                    vVar = this.p;
                    if (vVar != null) {
                        vVar.a();
                    }
                    r();
                    return true;
                default:
                    SigmobLog.e("loadUI: templateId = " + templateId);
                    return false;
            }
        } catch (Throwable th) {
            SigmobLog.e("setupAd error", th);
            return false;
        }
    }

    void b() {
        super.setVisibility(4);
    }

    public boolean c() {
        BaseAdUnit baseAdUnit = this.f;
        if (baseAdUnit != null && baseAdUnit.getSplashFilePath() != null) {
            return this.d.a(this.f);
        }
        SigmobLog.e("adUnit or splashFilePath is null");
        return false;
    }

    public void d() {
        this.j = false;
        am.a aVar = this.o;
        if (aVar != null) {
            aVar.b();
        }
        this.d.b();
    }

    public void e() {
        am.a aVar = this.o;
        if (aVar != null) {
            aVar.a();
        }
        v vVar = this.p;
        if (vVar != null) {
            vVar.a();
        }
        this.d.c();
    }

    public boolean f() {
        return this.k;
    }

    public int getDuration() {
        return this.d.getDuration();
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
        if (this.f == null) {
            SigmobLog.e("adUnit is null");
        } else {
            if (this.g == null) {
                return;
            }
            this.g.a(w.c(this), this.f, new q.b() { // from class: com.sigmob.sdk.splash.i.1
                @Override // com.sigmob.sdk.base.views.q.b
                public void a() {
                    SigmobLog.d(i.f3619a + "#onCloseClick");
                    i.this.l = false;
                    i.this.j = false;
                    if (i.this.m) {
                        i.this.a(true);
                    } else if (i.this.o != null) {
                        i.this.o.a();
                    }
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void a(Error error) {
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void a(String url, String clickCoordinate) {
                    SigmobLog.d(i.f3619a + "#onCloseClick");
                    if (i.this.f == null) {
                        return;
                    }
                    ClickCommon clickCommon = i.this.f.getClickCommon();
                    clickCommon.click_scene = "appinfo";
                    clickCommon.click_area = ClickCommon.CLICK_AREA_BTN;
                    clickCommon.is_final_click = true;
                    i.this.h();
                    i.this.k = true;
                    ah sessionManager = i.this.f.getSessionManager();
                    if (sessionManager == null) {
                        return;
                    }
                    sessionManager.a("click", 0);
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void b() {
                    SigmobLog.d(i.f3619a + "#onShowSuccess");
                    if (i.this.o != null) {
                        i.this.o.b();
                    }
                    i.this.l = true;
                }
            });
        }
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        am.a aVar = this.o;
        if (aVar != null) {
            aVar.c();
        }
        v vVar = this.p;
        if (vVar != null) {
            vVar.b();
        }
        removeAllViews();
    }

    @Override // android.view.View
    public void onWindowFocusChanged(boolean hasWindowFocus) {
        super.onWindowFocusChanged(hasWindowFocus);
        com.sigmob.sdk.base.utils.k.c(f3619a, "onWindowFocusChanged: hasWindowFocus = " + hasWindowFocus, new Object[0]);
    }

    @Override // android.view.View
    protected void onWindowVisibilityChanged(int visibility) {
        super.onWindowVisibilityChanged(visibility);
        com.sigmob.sdk.base.utils.k.c(f3619a, "onWindowVisibilityChanged: visibility = " + visibility, new Object[0]);
        if (com.sigmob.sdk.base.utils.v.b(this.s)) {
            this.s.onWindowVisibilityChanged(visibility);
        }
    }

    public void setAspectRatio(float v) {
        this.r = v;
    }

    public void setDuration(int duration) {
        if (this.f == null) {
            return;
        }
        if (duration > 0 && com.sigmob.sdk.base.utils.v.b(this.n)) {
            this.n.a(duration);
            return;
        }
        this.m = true;
        ad.a("complete", (String) null, this.f, (ad.a) null);
        if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(this.l)) || this.q) {
            a(true);
        }
    }

    @Override // android.view.View
    public void setOnTouchListener(View.OnTouchListener l) {
        b bVar = this.d;
        if (bVar == null) {
            return;
        }
        bVar.setOnTouchListener(l);
    }

    public void setViewStatusListener(a statusListener) {
        this.s = statusListener;
    }

    @Override // android.view.View
    public void setVisibility(int visibility) {
        if (visibility != 0) {
            try {
                ad.a(PointCategory.SPLASHADBLOCK, WindAdError.ERROR_SPLASH_ADBLOCK.getErrorCode(), Preconditions.NoThrow.getLineInfo(), this.f, (ad.a) null);
                SigmobLog.e("debug " + Preconditions.NoThrow.getLineInfo());
                return;
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
                return;
            }
        }
        this.n.setVisibility(0);
        this.d.a();
        if (com.sigmob.sdk.base.utils.v.b(this.f)) {
            ah sessionManager = this.f.getSessionManager();
            if (com.sigmob.sdk.base.utils.v.b(sessionManager)) {
                sessionManager.a("start", 0);
            }
        }
        super.setVisibility(visibility);
    }
}
